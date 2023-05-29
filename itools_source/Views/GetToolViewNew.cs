﻿using itools_source;
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
        private string portName = "COM3";
        private ToolModel _curentTool;
        private TrayModel _currentTray;
        private IMainViewNew _mainView;
        private bool _resultGetTool;
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
            btnSearch.Click += delegate 
            {
                KeyBoard.CloseKeyboard();
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
            tvStock.TrayNodeSelect += SelectTray;
            btnGetTool.Click += async (s, e) => 
            { 
                _resultGetTool = await GetTool();
                UpdateToolStock?.Invoke(this, new EventArgs());
            };
            tmGetTool.Tick += (s, e) => 
            { 
                _actionTime++;
                AppendText(rtbStatus, "* - - - *", Color.Blue, true);
            };
            serialPortGetTool.DataReceived += GetDataReceive;
        }

        private void FormGetToolLoad(object sender, EventArgs e)
        {
            serialPortGetTool.PortName = portName;
            _mainView = MainViewNew.GetInstance();
            _mainView.PrevView = "Select Op";
            IGetToolRepositoryNew repository = UnityDI.container.Resolve<IGetToolRepositoryNew>();
            Presenter = new GetToolPresenterNew(this, repository);
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

        private async Task<bool> GetTool()
        {
            AppendText(rtbStatus, "/*******************************/", Color.Green, true);
            AppendText(rtbStatus, "/*******************************/", Color.Green, true);
            AppendText(rtbStatus, "Start Get Tool ...", Color.Blue, true);
            bool comportStatus =  await OpenComPort();
            if (!comportStatus) return false;
            //if (comportStatus)
            //{
            //    bool connectStatus = await CheckConnecttion();
            //    if (comportStatus)
            //    {
            //        await SendGetToolComman();
            //    }
            //}
            bool connectStatus = await CheckConnecttion();
            if (!connectStatus) return false;

            bool getToolStatus = await SendGetToolComman();
            if (!getToolStatus) return false;
            return true;
        }

        private async Task<bool> SendGetToolComman()
        {
            rtbStatus.BeginInvoke(new Action(() => { AppendText(rtbStatus, "Send Get Tool Command ...", Color.Blue, true); }));
            string message = "Lấy dụng cụ thất bại";
            bool result = false;
            string lastTextReceive = "";
            _textReceive = "";
            _actionTime = 0;
            serialPortGetTool.WriteLine("101,1\n");
            tmGetTool.Start();
            Task<bool> t1 = new Task<bool>
            (
                () =>
                {
                    while (_actionTime < 10)
                    {
                        if (_textReceive.Contains("121") & lastTextReceive != _textReceive) //Ghi nhận sự kiện Motor Start
                        {
                            lastTextReceive = _textReceive;
                            rtbStatus.BeginInvoke(new Action(() => { AppendText(rtbStatus, "Motor Start ...", Color.Blue, true); }));
                        }

                        if (_textReceive.Contains("122") & lastTextReceive != _textReceive) //Ghi nhận sự kiện Motor Stop
                        {
                            lastTextReceive = _textReceive;
                            rtbStatus.BeginInvoke(new Action(() => { AppendText(rtbStatus, "Motor Stop ...", Color.Blue, true); }));
                        }

                        if (_textReceive.Contains("123") & lastTextReceive != _textReceive) //Ghi nhận sự kiện Lấy Tool Thành công
                        {
                            lastTextReceive = _textReceive;
                            result = true;
                            message = "Lấy dụng cụ thành công";
                            break;
                        }

                        if (_textReceive.Contains("124") & lastTextReceive != _textReceive) //Ghi nhận sự kiện Lấy Tool Thất bại
                        {
                            lastTextReceive = _textReceive;
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

        private async Task<bool> CheckConnecttion()
        {
            rtbStatus.BeginInvoke(new Action ( () => {AppendText(rtbStatus, "Checking Connection ...", Color.Blue, true); }));
            string message = "Không thể thiết lập kết nối tới bo mạch điều khiển";
            bool result = false;
            _actionTime = 0;
            _textReceive = "";
            serialPortGetTool.WriteLine("100\n");
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
                    while (_actionTime < 5)
                    {
                        if (_textReceive.Contains("120"))
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
                SelectedTray = tray;
                TrayName = tray.TrayName;
                Quantity = tray.QtyStock.ToString();
            }
            else
            {
                TrayName = "";
                Quantity = "";
            }
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

        public bool GetToolResult { get => _resultGetTool; set => _resultGetTool = value; }

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