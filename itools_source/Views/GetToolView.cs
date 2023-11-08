using itools_source;
using itools_source.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using VinamiToolUser.Models;
using VinamiToolUser.Models.Interface;
using VinamiToolUser.Presenters;
using VinamiToolUser.Views.Components;
using VinamiToolUser.Views.Interface;
using CustomMessageBox;
using MySqlX.XDevAPI.Common;
using VinamiToolUser.Utils;

namespace VinamiToolUser.Views
{
    public partial class GetToolView : Form, IGetToolView
    {
        private static log4net.ILog _log = log4net.LogManager.GetLogger(typeof(GetToolView).Name);
        private ToolModel _curentTool;
        private TrayModel _currentTray;
        private IMainView _mainView;
        private bool _resultGetTool;
        private int _actionTime=0;
        private string _textReceive;
        private string _lastTextReceive;
        private static GetToolView _instance;
        public GetToolView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        public static GetToolView GetInstance(Form parentContainer)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                //instance = new ToolView();
                _instance = UnityDI.container.Resolve<IGetToolView>() as GetToolView;
                _instance.MdiParent = parentContainer;
                _instance.FormBorderStyle = FormBorderStyle.None;
                _instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (_instance.WindowState == FormWindowState.Minimized)
                    _instance.WindowState = FormWindowState.Normal;
                _instance.BringToFront();
            }
            return _instance;
        }

        private void AssociateAndRaiseViewEvents()
        {
            lstTool.ItemClick += (s,e) => 
            {
                CurrentTray = null;
                SelectToolEvent?.Invoke(this, EventArgs.Empty); 
            };
            btnSearch.Click += delegate 
            {
                KeyBoard.CloseKeyboard();
                CurrentTray = null;
                SearchToolEvent?.Invoke(this, EventArgs.Empty); 
            };
            txtSearch.MouseClick += (s, e) => { ShowKeyboard(); };
            txtSearch.KeyDown += (s, e) =>
            {
                if(e.KeyCode == Keys.Enter) 
                {
                    SearchToolEvent?.Invoke(this, EventArgs.Empty);
                    KeyBoard.CloseKeyboard();
                }
            };
            this.Load += FormGetToolLoad;
            tvStock.TrayNodeSelect += (s,e) => CurrentTray = e.Tray;
            btnGetTool.MouseClick += async (s, e) => 
            {
                IsRunning = true;
                btnGetTool.Enabled = false;
                _resultGetTool = await GetTool();
                UpdateToolStock?.Invoke(this, new EventArgs());
                CurrentTray = null;

                //if(_resultGetTool)
                //{
                //    var result = RJMessageBox.Show("Lấy dụng cụ thành công!", "Thông Báo!", MessageBoxButtons.OK);
                //    if (result == DialogResult.OK) _mainView.CurrentView = "WorkInfo";
                //}
                //else
                //{
                //    var result = RJMessageBox.Show("Lấy dụng cụ thất bại!", "Thông Báo!", MessageBoxButtons.OK);
                //    if (result == DialogResult.OK) _mainView.CurrentView = "WorkInfo";
                //}
            };
            tmGetTool.Tick += (s, e) => 
            { 
                _actionTime++;
                AppendText(rtbStatus, "* - - - *", Color.Blue, true);
            };
            tclStock.SelectedIndexChanged += (s, e) => { CurrentTray = null; };
            serialPortGetTool.DataReceived += GetDataReceive;
        }

        private void FormGetToolLoad(object sender, EventArgs e)
        {
            _mainView = MainView.GetInstance();
            serialPortGetTool.PortName = _mainView.MachineConfig.ComPort;
            _mainView.PrevView = "WorkInfo";
            CurrentTray = null;
            IGetToolRepository repository = UnityDI.container.Resolve<IGetToolRepository>();
            Presenter = new GetToolPresenter(this, repository);
        }

        private void ShowKeyboard()
        {
            var Keyboard = KeyBoard.GetInstance();
            int x = (Screen.PrimaryScreen.Bounds.Right - Keyboard.Width) / 2;
            int y = Screen.PrimaryScreen.Bounds.Bottom - Keyboard.Height;
            Keyboard.Show();
            Keyboard.Location = new Point(x, y);
        }

        private void GetDataReceive(object sender, SerialDataReceivedEventArgs e)
        {
            _textReceive = serialPortGetTool.ReadLine();
        }

        private void AppendText(RichTextBox box, string text, Color color, bool AddNewLine = false)
        {
            _log.Info(text);
            if (AddNewLine)
            {
                text += Environment.NewLine;
            }

            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
            box.ScrollToCaret();
        }

        private async Task<bool> GetTool()
        {
            AppendText(rtbStatus, "/*******************************/", Color.Green, true);
            AppendText(rtbStatus, "/*******************************/", Color.Green, true);
            AppendText(rtbStatus, "Start Get Tool ...", Color.Blue, true);
            bool comportStatus =  await OpenComPort();
            if (!comportStatus)
            {
                CloseComport();
                return false;
            }
            bool connectStatus = await CheckConnecttion();
            if (!connectStatus)
            {
                CloseComport();
                return false;
            }
            bool getToolStatus = await SendGetToolComman();
            if (!getToolStatus)
            {
                CloseComport();
                return false;
            }
            CloseComport();
            return true;
        }

        private async Task<bool> SendGetToolComman()
        {
            string message = "Get Tool Fail!";
            string comman = "";
            bool result = false;
            string trayName = CurrentTray.TrayName;
            string trayNumber = new string(trayName.Where(char.IsDigit).ToArray());
            if (!string.IsNullOrEmpty(trayNumber)) 
            {
                comman = String.Format("101,{0}\n", trayNumber);
            } 
            else { return false; }
            rtbStatus.BeginInvoke(new Action(() => { AppendText(rtbStatus, "Send Get Tool Command ...", Color.Blue, true); }));
            rtbStatus.BeginInvoke(new Action(() => { AppendText(rtbStatus, "ToolCode: " + CurrentTool.ToolCode , Color.Blue, true); }));
            rtbStatus.BeginInvoke(new Action(() => { AppendText(rtbStatus, "Tray Number: Tray_" + trayNumber, Color.Blue, true); }));
            _actionTime = 0;
            serialPortGetTool.WriteLine(comman);
            tmGetTool.Start();
            Task<bool> t1 = new Task<bool>
            (
                () =>
                {
                    while (_actionTime < 20)
                    {
                        if (_lastTextReceive != _textReceive)
                        {
                            _lastTextReceive = _textReceive;
                            if (_textReceive.Contains("121"))
                            {
                                rtbStatus.BeginInvoke(new Action(() => { AppendText(rtbStatus, "Motor Start ...", Color.Blue, true); }));
                            }
                            if (_textReceive.Contains("122"))
                            {
                                rtbStatus.BeginInvoke(new Action(() => { AppendText(rtbStatus, "Motor Stop ...", Color.Blue, true); }));
                            }
                            if (_textReceive.Contains("123"))
                            {
                                result = true;
                                message = "Get Tool Success!";
                                break;
                            }
                            if (_textReceive.Contains("124")) //Ghi nhận sự kiện Lấy Tool Thất bại
                            {
                                break;
                            }
                        }
                    }
                    return result;
                }
            );
            t1.Start();
            await t1;
            tmGetTool.Stop();
            rtbStatus.BeginInvoke(new Action(() => { AppendText(rtbStatus, message, Color.Orange, true); }));
            return result;
        }

        private async Task<bool> CheckConnecttion()
        {
            rtbStatus.BeginInvoke(new Action ( () => {AppendText(rtbStatus, "Checking Connection ...", Color.Blue, true); }));
            string message = "Can Not Connect To Controler Board!";
            bool result = false;
            _actionTime = 0;
            _textReceive = "";
            serialPortGetTool.WriteLine("100\n");
            tmGetTool.Start();
            Task<bool> t1 = new Task<bool>
            (
                () =>
                {
                    while (_actionTime < 5)
                    {
                        if (_textReceive.Contains("120"))
                        {
                            result = true;
                            message = "Connected To Control Board Success!";
                            break;
                        }
                    }
                    return result;
                }
            );
            t1.Start();
            await t1;
            tmGetTool.Stop();
            rtbStatus.BeginInvoke(new Action(() => { AppendText(rtbStatus, message, Color.Orange, true); }));
            return result;
        }

        private void CloseComport()
        {
            if (serialPortGetTool.IsOpen == true)
            {
                serialPortGetTool.Close();
                rtbStatus.BeginInvoke(new Action(() => { AppendText(rtbStatus, "Comport is Close!", Color.Blue, true); }));
            }
        }

        private async Task<bool> OpenComPort()
        {
            bool result = false; // Biến trung gian để lưu giá trị trả về
            string portName = _mainView.MachineConfig.ComPort;
            Task<bool> t1 = new Task<bool>
            (
                () =>
                {
                    try
                    {
                        if (String.IsNullOrEmpty(portName))
                        {
                            rtbStatus.Invoke(new MethodInvoker(delegate { AppendText(rtbStatus, "Please select the serial port first!", Color.Red, true); }));
                            result = false; // Gán giá trị cho biến trung gian
                        }
                        else
                        {
                            if (serialPortGetTool.IsOpen == true)
                            {
                                serialPortGetTool.Close();
                            }
                            serialPortGetTool.Open();
                            rtbStatus.Invoke(new MethodInvoker(delegate { AppendText(rtbStatus, "Serial port opened successfully!", Color.Green, true); }));
                            result = true; // Gán giá trị cho biến trung gian
                        }
                    }
                    catch (Exception ex)
                    {
                        rtbStatus.Invoke(new MethodInvoker(delegate { AppendText(rtbStatus, ex.Message, Color.Red, true); }));
                        result = false; // Gán giá trị cho biến trung gian
                    }
                    return result; // Trả về giá trị biến trung gian
                }
            );
            t1.Start();
            await t1;
            return result; // Trả về giá trị biến trung gian
        }


        public ToolModel CurrentTool 
        { 
            get => _curentTool;
            set
            { 
                _curentTool = value; 
                _mainView.CurrentTool = value;
                txtToolCode.Text = _curentTool.ToolCode;
                txtToolName.Text = _curentTool.ToolName;
                txtTrayNumber.Text = "";
                txtQty.Text = "";
            }
        }
        public TrayModel CurrentTray
        {
            get => _currentTray;
            set
            {
                _currentTray = value;
                _mainView.CurrentTray = value;
                int qty = 0;
                if(_currentTray != null)
                {
                    txtTrayNumber.Text = _currentTray.TrayName;
                    qty = _currentTray.QtyStock;
                    txtQty.Text = qty.ToString();
                }
                else
                {
                    txtTrayNumber.Text = "";
                    txtQty.Text = "";
                }
                if (qty <= 0) btnGetTool.Enabled = false;
                else btnGetTool.Enabled = true;
            } 
        }
        public string SearchToolValue { get => txtSearch.Text; set => txtSearch.Text = value; }
        //public string SearchTrayValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public GetToolPresenter Presenter { private get; set; }

        public bool GetToolResult { get => _resultGetTool; set => _resultGetTool = value; }
        public string LogMessage { set => AppendText(rtbStatus, value, Color.Orange, true); }

        public UserAccount UserLogin => _mainView.UserLogin;

        public string OpNumber => _mainView.CurrentOP.OpNumber;

        public string JobNumber => _mainView.CurrentJob.JobNumber;

        public MachineConfigModel CurrentConfig =>  _mainView.MachineConfig;

        public MachineModel CurrentMachine => _mainView.CurrentMachine;

        public bool IsRunning { get => _mainView.IsRunning; set => _mainView.IsRunning = value; }

        public event EventHandler SearchToolEvent;
        public event EventHandler UpdateToolStock;
        public event EventHandler SelectToolEvent;

        public void SetToolListBindingSource(BindingSource toolList)
        {
            lstTool.DataSource = toolList;
        }

        public void SetCurrentTrayListBindingSource(BindingSource trayList)
        {
            tvStock.DataSource = trayList;
        }
        public void SetOtherTrayListBindingSource(BindingSource trayList)
        {
            tvOtherStock.DataSource = trayList;
        }
    }
}
