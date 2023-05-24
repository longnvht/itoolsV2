using itools_source;
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

namespace VinamiToolUser.Views
{
    public partial class GetToolViewNew : Form, IGetToolViewNew
    {
        private string portName = "COM1";
        private ToolModel _curentTool;
        private TrayModel _currentTray;
        private MainViewNew _mainView;
        private int _actionTime=0;
        private string _textReceive;
        private static GetToolViewNew _instance;
        public GetToolViewNew()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }


        public static GetToolViewNew GetInstance(Form parentContainer)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                //instance = new ToolView();
                _instance = UnityDI.container.Resolve<IGetToolViewNew>() as GetToolViewNew;
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
            lstTool.ItemClick += delegate { SelectToolEvent?.Invoke(this, EventArgs.Empty); };
            btnSearch.Click += delegate { SearchToolEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
            {
                if(e.KeyCode == Keys.Enter) { SearchToolEvent?.Invoke(this, EventArgs.Empty); }
            };
            this.Load += FormGetToolLoad;
            tvStock.TrayNodeSelect += SelectTray;
            btnGetTool.Click += GetTool;
            tmGetTool.Tick += (s, e) => 
            { 
                _actionTime++;
                //AppendText(rtbStatus, _actionTime.ToString(), Color.Blue, true);
            };
            serialPortGetTool.DataReceived += GetDataReceive;
        }

        private void GetDataReceive(object sender, SerialDataReceivedEventArgs e)
        {
            _textReceive = serialPortGetTool.ReadLine();
        }

        private void AppendText(RichTextBox box, string text, Color color, bool AddNewLine = false)
        {
            if (AddNewLine)
            {
                text += Environment.NewLine;
            }

            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }

        private async void GetTool(object sender, EventArgs e)
        {
            AppendText(rtbStatus, "Start Get Tool ...", Color.Blue, true);
            bool comportStatus =  await OpenComPort();
            if (comportStatus)
            {
                await CheckConnecttion();
            }
            
        }
        private async Task<bool> CheckConnecttion()
        {
            rtbStatus.BeginInvoke(new Action ( () => {AppendText(rtbStatus, "Checking Connection ...", Color.Blue, true); }));
            string message = "Không thể thiết lập kết nối tới bo mạch điều khiển";
            bool result = false;
            _actionTime = 0;
            _textReceive = "";
            tmGetTool.Start();
            //await Task.Run(() =>
            //{
            //    serialPortGetTool.WriteLine("100\n");
            //    while (_actionTime <= 5)
            //    {
            //        if (_textReceive.Contains("120"))
            //        {
            //            result = true;
            //            message = "Kết nối tới bo mạch thành công";
            //            break;
            //        }
            //    }
            //    tmGetTool.Stop();
            //});
            Task<bool> t1 = new Task<bool>
            (
                () =>
                {
                    serialPortGetTool.WriteLine("100\n");
                    while (_actionTime < 5)
                    {
                        if (_textReceive.Contains("100"))
                        {
                            result = true;
                            message = "Kết nối tới bo mạch thành công";
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

        private async Task<bool> OpenComPort()
        {
            bool result = false; // Biến trung gian để lưu giá trị trả về

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
                        rtbStatus.Invoke(new MethodInvoker(delegate { AppendText(rtbStatus, ex.Message, Color.Red); }));
                        result = false; // Gán giá trị cho biến trung gian
                    }

                    return result; // Trả về giá trị biến trung gian
                }
            );
            t1.Start();
            await t1;
            return result; // Trả về giá trị biến trung gian
        }

        private void SelectTray(object sender, StockInfoTreeView.TrayNodeClickEventArgs e)
        {
            TrayModel tray = e.Tray;
            if(tray != null)
            {
                TrayName = tray.TrayName;
                Quantity = tray.QtyStock.ToString();
            }
            else
            {
                TrayName = "";
                Quantity = "";
            }
        }

        private void FormGetToolLoad(object sender, EventArgs e)
        {
            serialPortGetTool.PortName = portName;
            _mainView = MainViewNew.GetInstance();
            IGetToolRepositoryNew repository = UnityDI.container.Resolve<IGetToolRepositoryNew>();
            Presenter = new GetToolPresenterNew(this, repository);
        }

        public ToolModel SelectedTool 
        { 
            get => _curentTool;
            set
            { 
                _curentTool = value; 
                _mainView.CurrentTool = value;
            }
        }
        public TrayModel SelectedTray
        {
            get => _currentTray;
            set
            {
                _currentTray = value;
                _mainView.CurrentTray = value;
            } 
        }
        public string SearchToolValue { get => txtSearch.Text; set => txtSearch.Text = value; }
        //public string SearchTrayValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public GetToolPresenterNew Presenter { private get; set; }
        public string ToolCode { get => txtToolCode.Text; set => txtToolCode.Text = value; }
        public string ToolName { get => txtToolName.Text; set => txtToolName.Text = value; }
        public string TrayName { get => txtTrayNumber.Text; set => txtTrayNumber.Text = value; }
        public string Quantity 
        { 
            get => txtQty.Text; 
            set 
            { 
                txtQty.Text = value;
                Int32.TryParse(value, out var quantity);
                if (quantity<=0 & String.IsNullOrEmpty(TrayName)) btnGetTool.Enabled = false;
                else btnGetTool.Enabled = true;
            } 
        }

        public event EventHandler SelectToolEvent;
        public event EventHandler SelectTrayEvent;
        public event EventHandler SearchToolEvent;
        public event EventHandler UpdateToolStock;

        public void SetToolListBindingSource(BindingSource toolList)
        {
            lstTool.DataSource = toolList;
        }

        public void SetTrayListBindingSource(BindingSource trayList)
        {
            tvStock.DataSource = trayList;
        }
    }
}
