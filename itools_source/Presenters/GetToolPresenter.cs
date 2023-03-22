using Guna.UI2.WinForms;
using itools_source.Models;
using itools_source.Models.Interface;
using itools_source.Repository;
using itools_source.Views;
using itools_source.Views.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

namespace itools_source.Presenters
{
    public class GetToolPresenter
    {
        #region Properties - Fields
        private IGetToolView _getToolView;
        private IGetToolRepository _getToolRepository;

        private readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(GetToolPresenter).Name);
        private bool bToggle = false; // On/Off => Show all machine and tray quantity.
        private bool sendCheck = false;
        private bool sendGetToolCheck = false;
        VirtualKeyBoard frmKeyBoard;
        Point clientPoint;
        #endregion

        #region Events
        private void _getToolView_btnToolSelect_Click(object sender, EventArgs e)
        {
            // Show view select TrayIndex.
            if (_getToolView.iToolId != null)
            {
                _getToolView.cStatusForm = '1';
                _getToolView.SetStatusForm();
            }
        }

        private void _getToolView_GetToolView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.OfType<VirtualKeyBoard>().Any())
            {
                frmKeyBoard.Close();
            }
        }

        private void _getToolView_txtToolSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (!Application.OpenForms.OfType<VirtualKeyBoard>().Any() && !Application.OpenForms.OfType<VirtualNumericKeyBoard>().Any())
            {
                frmKeyBoard = new VirtualKeyBoard();
                frmKeyBoard.Show();

                GetToolView frm = (GetToolView)sender;
                frm.txtToolSearch.Focus();

                int iTempX = ((frm.Width - frmKeyBoard.Width) / 2) + (frm.MdiParent as MainView).Location.X;
                int iTempY = ((frm.Height - frmKeyBoard.Height) + 69) + (frm.MdiParent as MainView).Location.Y;

                clientPoint = new Point(iTempX, iTempY);
                frmKeyBoard.Location = clientPoint;
            }
        }

        private void _getToolView_txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (!Application.OpenForms.OfType<VirtualKeyBoard>().Any() && !Application.OpenForms.OfType<VirtualNumericKeyBoard>().Any())
            {
                frmKeyBoard = new VirtualKeyBoard();
                frmKeyBoard.Show();

                GetToolView frm = (GetToolView)sender;
                frm.txtSearch.Focus();

                int iTempX = ((frm.Width - frmKeyBoard.Width) / 2) + (frm.MdiParent as MainView).Location.X;
                int iTempY = ((frm.Height - frmKeyBoard.Height) + 69) + (frm.MdiParent as MainView).Location.Y;

                clientPoint = new Point(iTempX, iTempY);
                frmKeyBoard.Location = clientPoint;
            }
        }

        private async void _getToolView_toggleShowAll_Click(object sender, EventArgs e)
        {
            GetToolView frm = (GetToolView)sender;
            if (!bToggle)
            {
                frm.btnGetTool.Hide();
                _getToolView.lstMachineTrayQuantity = await _getToolRepository.GetMachineTrayQuantityByToolId(_getToolView.iToolId);
                if (_getToolView.lstMachineTrayQuantity != null)
                {
                    frm.flpTrayMachineList.Controls.Clear();
                    _getToolView.CreateListButton(false); // MachineCode, ToolCode, Quantity
                    bToggle = true;
                    frm.flpTrayMachineList.Enabled = true;
                }
            }
            else
            {
                frm.btnGetTool.Show();
                if (_getToolView.lstTrayQuantity != null)
                {
                    bToggle = false;
                    _getToolView.CreateListButton(true);
                }
            }
        }

        private void _getToolView_btnflpTrayMachineList_DoubleClick(object sender, EventArgs e)
        {
            if (_getToolView == null)
            {
                _log.Error("_getToolView is null.");
                return;
            }
            _getToolView.SetCheckedButton("");
            _getToolView.cStatusForm = '4';
            _getToolView.SetStatusForm();

            Guna2GradientButton btn = (Guna2GradientButton)sender;
            if (btn == null)
            {
                _log.Error("button is null.");
                return;
            }

            if (string.IsNullOrEmpty(btn.Text))
            {
                MessageBox.Show("Nút Không Có Dữ Liệu!");
                return;
            }

            if (btn.Tag != null)
            {
                _getToolView.iTrayId = Convert.ToInt32(_getToolView.iTrayId);
            }

            _getToolView.strTrayIndex = btn.Text.Split('\n').GetValue(0).ToString();

            string strSendSerialCom = "101," + _getToolView.strTrayIndex.Split('_').GetValue(1).ToString() + "\n";

            if (SerialPort.GetPortNames().Length == 0)
            {
                MessageBox.Show("Không có cổng COM!");
                _log.Info("Not connect COM!");
                return;
            }

            if (!_getToolView.serialPortGetTool.IsOpen)
            {
                if (string.IsNullOrEmpty(VinamiToolUser.Properties.Settings.Default.SerialPort) && string.IsNullOrWhiteSpace(VinamiToolUser.Properties.Settings.Default.SerialPort))
                {
                    MessageDialog.Show("Máy Chưa Cấu Hình Cổng Port.",
                                        "Thông Báo",
                                        MessageDialogButtons.OK,
                                        MessageDialogIcon.Information,
                                        MessageDialogStyle.Default);
                    _log.Error("Properties.Settings.Default.SerialPort is empty.");
                }
                else
                {
                    _getToolView.serialPortGetTool.PortName = VinamiToolUser.Properties.Settings.Default.SerialPort;
                }

                foreach (var item in SerialPort.GetPortNames())
                {
                    if (_getToolView.serialPortGetTool.PortName == item)
                    {
                        _getToolView.serialPortGetTool.Open();
                        break;
                    }
                }
            }

            if (_getToolView.serialPortGetTool.IsOpen)
            {
                _getToolView.serialPortGetTool.Write(strSendSerialCom);
            }
        }

        private void _getToolView_btnflpTrayMachineList_Click(object sender, EventArgs e)
        {
            Guna2GradientButton btn = (Guna2GradientButton)sender;
            if (btn != null)
            {
                if (btn.Checked == true)
                {
                    btn.Checked = false;
                }
                else
                {
                    btn.Checked = true;
                }
                _getToolView.SetCheckedButton(btn.Text);

                if (btn.Tag != null)
                {
                    _getToolView.iTrayId = Convert.ToInt32(btn.Tag);
                }
            }
        }

        private async void _getToolView_btnflpToolList_Click(object sender, EventArgs e)
        {
            Guna2GradientButton btn = (Guna2GradientButton)sender;
            if (string.IsNullOrEmpty(btn.Text) || string.IsNullOrWhiteSpace(btn.Text) || btn.Tag == null)
            {
                _getToolView.cStatusForm = '2';
                _getToolView.SetStatusForm();
                MessageBox.Show("Nút Không Có Dữ Liệu!");
                return;
            }

            // 1. Open button tool select.
            _getToolView.cStatusForm = '5';
            _getToolView.SetStatusForm();

            /*
             * 2. Get data tool:
             *  a. Id
             *  b. Code
             *  c. Model
             *  d. Description
             */
            _getToolView.iToolId = Convert.ToInt32(btn.Tag);
            _getToolView.strToolCode = btn.Text;
            Dictionary<int, Dictionary<string, string>> lstToolIDModelDes = await _getToolRepository.GetModelDescriptionByToolId(_getToolView.iToolId);

            if (lstToolIDModelDes != null)
            {
                _getToolView.strToolModel = lstToolIDModelDes.Values.ElementAt(0).Keys.ElementAt(0);
                _getToolView.strToolDescription = lstToolIDModelDes.Values.ElementAt(0).Values.ElementAt(0);
                _log.Info("Get ToolModel: " + _getToolView.strToolModel + ", ToolDescription: " + _getToolView.strToolDescription);

                // 3. Get tool tray data.
                if (VinamiToolUser.Properties.Settings.Default.MachineId != 0)
                {
                    _getToolView.lstTrayQuantity = await _getToolRepository.GetMachineTrayByToolId(_getToolView.iToolId, VinamiToolUser.Properties.Settings.Default.MachineId);
                }

                if (_getToolView.lstTrayQuantity != null)
                {
                    // 4. Create list button.
                    _getToolView.CreateListButton(true);
                }
            }
            else
            {
                _log.Error("Get data ToolModel and ToolDescription fail!");
            }
        }

        private void _getToolView_btnCancelSelectTray(object sender, EventArgs e)
        {
            _getToolView.cStatusForm = '3';
            _getToolView.SetStatusForm();
        }

        private void _getToolView_tmGetTool_Tick(object sender, EventArgs e)
        {
            GetToolView frm = (GetToolView)sender;
            frm.countTimer += 1;
            frm.txtCheckTime.Text = frm.countTimer.ToString();
            if (frm.countTimer > 5)
            {
                frm.tmGetTool.Stop();
                MessageBox.Show("Hết thời gian xử lý!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _getToolView_btnGetTool_Click(object sender, EventArgs e)
        {
            if (!_getToolView.serialPortGetTool.IsOpen)
            {
                if (string.IsNullOrEmpty(VinamiToolUser.Properties.Settings.Default.SerialPort) && string.IsNullOrWhiteSpace(VinamiToolUser.Properties.Settings.Default.SerialPort))
                {
                    MessageDialog.Show("Máy Chưa Cấu Hình Cổng Port.",
                                        "Thông Báo",
                                        MessageDialogButtons.OK,
                                        MessageDialogIcon.Information,
                                        MessageDialogStyle.Default);
                    _log.Error("Properties.Settings.Default.SerialPort is empty.");
                }
                else
                {
                    _getToolView.serialPortGetTool.PortName = VinamiToolUser.Properties.Settings.Default.SerialPort;
                }

                foreach (var item in SerialPort.GetPortNames())
                {
                    if (_getToolView.serialPortGetTool.PortName == item)
                    {
                        _getToolView.serialPortGetTool.Open();
                        break;
                    }
                }
            }

            if (_getToolView.serialPortGetTool.IsOpen)
            {
                _getToolView.serialPortGetTool.Write("100\n");
                GetToolView frm = (GetToolView)sender;
                frm.countTimer = 0;
                _getToolView.OnOffTimer(true);
            }

            while (!sendGetToolCheck)
            {
                while (sendCheck)
                {
                    // 1. Checked button.
                    bool bCheck = false;
                    GetToolView frm = (GetToolView)sender;
                    string strBtnText = null;
                    foreach (var item in frm.flpTrayMachineList.Controls)
                    {
                        if (item.GetType() != typeof(Guna2GradientButton))
                        {
                            continue;
                        }
                        Guna2GradientButton btn = (Guna2GradientButton)item;
                        if (btn.Checked)
                        {
                            btn.Checked = false;
                            bCheck = true;
                            strBtnText = btn.Text;
                            break;
                        }
                    }

                    // 2. Send to serial.
                    if (bCheck)
                    {
                        _getToolView.strTrayIndex = strBtnText.Split('\n').GetValue(0).ToString();

                        string strSendSerialCom = "101," + _getToolView.strTrayIndex.Split('_').GetValue(1).ToString() + "\n";
                        frm.btnGetTool.Enabled = false;
                        if (SerialPort.GetPortNames().Length == 0)
                        {
                            MessageBox.Show("Không có cổng COM!");
                            _log.Info("Not connect COM!");
                            return;
                        }
                        if (!_getToolView.serialPortGetTool.IsOpen)
                        {
                            if (string.IsNullOrEmpty(VinamiToolUser.Properties.Settings.Default.SerialPort) && string.IsNullOrWhiteSpace(VinamiToolUser.Properties.Settings.Default.SerialPort))
                            {
                                MessageDialog.Show("Máy Chưa Cấu Hình Cổng Port.",
                                                    "Thông Báo",
                                                    MessageDialogButtons.OK,
                                                    MessageDialogIcon.Information,
                                                    MessageDialogStyle.Default);
                                _log.Error("Properties.Settings.Default.SerialPort is empty.");
                            }
                            else
                            {
                                _getToolView.serialPortGetTool.PortName = VinamiToolUser.Properties.Settings.Default.SerialPort;
                            }

                            foreach (var item in SerialPort.GetPortNames())
                            {
                                if (_getToolView.serialPortGetTool.PortName == item)
                                {
                                    _getToolView.serialPortGetTool.Open();
                                    break;
                                }
                            }
                        }

                        if (_getToolView.serialPortGetTool.IsOpen)
                        {
                            _getToolView.serialPortGetTool.Write(strSendSerialCom);
                            //frm.countTimer = 0;
                            //_getToolView.OnOffTimer(true);
                            sendGetToolCheck = true;
                            sendCheck = false;
                            _getToolView.cStatusForm = '3';
                            _getToolView.SetStatusForm();
                        }
                    }
                }
            }
        }

        private async void _getToolView_serialPort_GetTool_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            GetToolView frm = new GetToolView();
            if (_getToolView.serialPortGetTool.IsOpen && frm.countTimer <= 5)
            {
                _getToolView.OnOffTimer(false);
                string strReadLine = _getToolView.serialPortGetTool.ReadLine().Substring(0, 3);

                if (strReadLine == "rea")
                {
                    sendCheck = true;
                }
                else if (strReadLine == "sus")
                {
                    // Get information workingtransaction.
                    WorkingTransaction workingTransaction = new WorkingTransaction();
                    workingTransaction.dtTransactionDate = Utils.ServerTime.GetServerTime().ToLocalTime();
                    if (VinamiToolUser.Properties.Settings.Default.MachineId != 0)
                    {
                        workingTransaction.iMachineId = VinamiToolUser.Properties.Settings.Default.MachineId;
                    }
                    else
                    {
                        _log.Error("Properties.Settings.Default.MachineId is null");
                    }

                    if (VinamiToolUser.Properties.Settings.Default.CompanyId != 0)
                    {
                        workingTransaction.iCompanyId = VinamiToolUser.Properties.Settings.Default.CompanyId;
                    }
                    else
                    {
                        _log.Error("Properties.Settings.Default.CompanyId is null.");
                    }

                    if (Program.sessionLogin["UserName"] != null)
                    {
                        workingTransaction.strUserLogin = Program.sessionLogin["UserName"].ToString();
                    }
                    else
                    {
                        _log.Error("Program.sessionLogin[\"UserName\"] is null.");
                    }

                    if (_getToolView.strJobNumber != null)
                    {
                        workingTransaction.strJobNumber = _getToolView.strJobNumber;
                    }
                    else
                    {
                        _log.Error("_getToolView.strJobNumber is null.");
                    }

                    if (!string.IsNullOrEmpty(_getToolView.strOPNumber) && !string.IsNullOrWhiteSpace(_getToolView.strOPNumber))
                    {
                        workingTransaction.strOPNumber = _getToolView.strOPNumber;
                    }
                    else
                    {
                        _log.Error("_getToolView.strOPNumber is null.");
                    }

                    if (_getToolView.iToolId != null)
                    {
                        workingTransaction.toolID = _getToolView.iToolId;
                    }
                    else
                    {
                        _log.Error("_getToolView.iTrayId is null.");
                    }
                    if (!string.IsNullOrEmpty(_getToolView.strTrayIndex) && !string.IsNullOrWhiteSpace(_getToolView.strTrayIndex))
                    {
                        workingTransaction.trayIndex = _getToolView.strTrayIndex;
                    }
                    else
                    {
                        _log.Error("_getToolView.strTrayIndex is null.");
                    }

                    workingTransaction.iQuantity = 1;
                    workingTransaction.strTransactionStatus = "Complete";
                    workingTransaction.strTransactiomType = "Get Tool";

                    // Update quantity to table ToolsMachineTray
                    IToolMachineTrayRepository toolMachineTrayRepository = new ToolMachineTrayRepository();
                    if (_getToolView.iTrayId == null)
                    {
                        _log.Error("TrayId is null.");
                        return;
                    }
                    ToolMachineTray toolMachineTray = new ToolMachineTray();
                    toolMachineTray.iToolsMachineTrayId = _getToolView.iTrayId;
                    toolMachineTray.dtUpdateDate = workingTransaction.dtTransactionDate;
                    int? iQuantityTray = await toolMachineTrayRepository.GetQuantityInTray(iTrayID: _getToolView.iTrayId);
                    toolMachineTray.iQuantity = iQuantityTray - 1; // Quantity(ToolsMachineTray) - 1

                    bool bResultToolsMachineTray = await toolMachineTrayRepository.UpdateQuantityToolTray(toolMachineTray: toolMachineTray);

                    // Add workingtransaction.
                    IWorkingTransactionRepository workingTransactionRepository = new WorkingTransactionRepository();
                    bool bResultTransaction = await workingTransactionRepository.AddWorkingTransaction(workingTransaction: workingTransaction);

                    if (bResultToolsMachineTray && bResultTransaction)
                    {
                        sendGetToolCheck = false;
                        DialogResult dlr = MessageDialog.Show("Lấy Tool Thành Công.",
                                        "Thông Báo",
                                        MessageDialogButtons.OK,
                                        MessageDialogIcon.Information,
                                        MessageDialogStyle.Default);
                        _log.Info("Get tool success.");
                        _getToolView.serialPortGetTool.Close();
                    }
                    else
                    {
                        _log.Error("add workingtransaction failed.");
                    }
                    return;
                }
                else if (strReadLine != "sus" || strReadLine != "rea")
                {
                    MessageDialog.Show("Lấy Tool Thất Bại.",
                                        "Thông Báo",
                                        MessageDialogButtons.OK,
                                        MessageDialogIcon.Error,
                                        MessageDialogStyle.Default);
                    _log.Error("Get tool fail.");
                    _getToolView.serialPortGetTool.Close();
                }
                else 
                { 
                    MessageDialog.Show("Máy Không Sẵn Sàng Hoạt Động.", "Thông Báo", 
                                        MessageDialogButtons.OK, MessageDialogIcon.Error, 
                                        MessageDialogStyle.Default); 
                    _log.Error("Machine not readly."); 
                }
            }
        }
        private void _getToolView_txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetToolView frm = (GetToolView)sender;
            frm.flpToolList.Controls.Clear();
            frm.ToolSearch();
        }
        private void _getToolView_txtToolSearch_TextChanged(object sender, EventArgs e)
        {
            GetToolView frm = (GetToolView)sender;
            frm.flpTrayMachineList.Controls.Clear();
            frm.TraySearch();
        }
        private async void _getToolView_GetToolView_Load(object sender, EventArgs e)
        {
            GetToolView frm = (GetToolView)sender;

            if (_getToolView == null || _getToolRepository == null)
            {
                MessageBox.Show("Lỗi Dữ Liệu!");
                _log.Info("_getToolView or _getToolRepository is null!");
                return;
            }

            // Set status form.
            _getToolView.cStatusForm = '0';
            _getToolView.SetStatusForm();

            if (_getToolView.iOPId == null)
            {
                _log.Info("OPId is Null.");
                return;
            }

            _getToolView.lstToolForOPList = await _getToolRepository.GetByToolForOP(_getToolView.iOPId); // Get list table tool for op

            if (_getToolView.lstToolForOPList != null)
            {
                // 1. Create list button.
                if (_getToolView.lstToolButton == null)
                {
                    _getToolView.lstToolButton = new List<Guna2GradientButton>();
                }

                foreach (var item in _getToolView.lstToolForOPList)
                {
                    _getToolView.lstToolButton.Add(frm.CreateButton(item.Value, null, "Tool", item.Key));
                }

                // 2. Add to flowlayoutpanel.
                frm.flpToolList.Controls.AddRange(_getToolView.lstToolButton.ToArray());
                _log.Info("Create button list and add button to flowlayoutpanel.");
            }

            // Not enabled click next in form main
            _getToolView.EnabledButton(false);
        }
        #endregion

        #region Methods
        public void Run(IGetToolView getToolView, IGetToolRepository getToolRepository)
        {
            _getToolView = getToolView;
            _getToolRepository = getToolRepository;

            _getToolView.GetToolView_Load += _getToolView_GetToolView_Load;
            _getToolView.serialPort_GetTool_DataReceived += _getToolView_serialPort_GetTool_DataReceived;
            _getToolView.btnGetTool_Click += _getToolView_btnGetTool_Click;
            _getToolView.btnCancelSelectTray_Click += _getToolView_btnCancelSelectTray;
            _getToolView.btnflpToolList_Click += _getToolView_btnflpToolList_Click;
            _getToolView.btnflpTrayMachineList_Click += _getToolView_btnflpTrayMachineList_Click;
            _getToolView.btnflpTrayMachineList_DoubleClick += _getToolView_btnflpTrayMachineList_DoubleClick;
            _getToolView.toggleShowAll_Click += _getToolView_toggleShowAll_Click;
            _getToolView.txtSearch_MouseClick += _getToolView_txtSearch_MouseClick;
            _getToolView.txtToolSearch_MouseClick += _getToolView_txtToolSearch_MouseClick;
            _getToolView.GetToolView_FormClosing += _getToolView_GetToolView_FormClosing;
            _getToolView.btnToolSelect_Click += _getToolView_btnToolSelect_Click;
            _getToolView.tmGetTool_Tick += _getToolView_tmGetTool_Tick;
            _getToolView.txtSearch_TextChanged += _getToolView_txtSearch_TextChanged;
            _getToolView.txtToolSearch_TextChanged += _getToolView_txtToolSearch_TextChanged;

            _getToolView.Show();
        }
        #endregion
    }
}
