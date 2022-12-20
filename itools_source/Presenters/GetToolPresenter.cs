using Guna.UI2.WinForms;
using itools_source.Models;
using itools_source.Models.Interface;
using itools_source.Repository;
using itools_source.Views;
using itools_source.Views.Interface;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

namespace itools_source.Presenters
{
    public class GetToolPresenter
    {
        public GetToolPresenter(IGetToolView getToolView, IGetToolRepository getToolRepository)
        {
            //_getToolView = (getToolView == null) ? new GetToolView : getToolView;
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

            _getToolView.Show();
        }

        #region Properties - Fields
        private readonly IGetToolView _getToolView;
        private readonly IGetToolRepository _getToolRepository;

        private readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(GetToolPresenter).Name);
        private bool bToggle = false; // On/Off => Show all machine and tray quantity.
        #endregion

        #region Evens
        private async void _getToolView_toggleShowAll_Click(object sender, EventArgs e)
        {
            GetToolView frm = (GetToolView)sender;
            if (!bToggle)
            {
                _getToolView.lstMachineTrayQuantity = await _getToolRepository.GetMachineTrayQuantityByToolId(_getToolView.iToolId);
                if (_getToolView.lstMachineTrayQuantity != null)
                {
                    frm.flpTrayMachineList.Controls.Clear();
                    _getToolView.CreateListButton(false);
                    bToggle = true;
                }
            }
            else
            {
                if (_getToolView.lstTrayQuantity != null)
                {
                    bToggle = false;
                    _getToolView.CreateListButton(true);
                }
            }
        }

        private void _getToolView_btnflpTrayMachineList_DoubleClick(object sender, EventArgs e)
        {
            _getToolView.SetCheckedButton("");
            _getToolView.cStatusForm = '4';
            _getToolView.SetStatusForm();
            Guna2GradientButton btn = (Guna2GradientButton)sender;
            if (string.IsNullOrEmpty(btn.Text))
            {
                MessageBox.Show("Nút Không Có Dữ Liệu!");
                return;
            }

            _getToolView.strTrayIndex = btn.Text.Split('\n').GetValue(0).ToString();

            string strSendSerialCom = "125," + _getToolView.strTrayIndex.Split('_').GetValue(1).ToString() + "|";
            //MessageBox.Show(strSendSerialCom);
            if (SerialPort.GetPortNames().Length == 0)
            {
                MessageBox.Show("Không có cổng COM!");
                _log.Info("Not connect COM!");
                return;
            }
            if (!_getToolView.serialPortGetTool.IsOpen && !string.IsNullOrEmpty(Properties.Settings.Default.SerialPort) && !string.IsNullOrWhiteSpace(Properties.Settings.Default.SerialPort))
            {
                foreach (var item in SerialPort.GetPortNames())
                {
                    _getToolView.serialPortGetTool.PortName = item;
                    if (_getToolView.serialPortGetTool.PortName == Properties.Settings.Default.SerialPort)
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
            if (btn.Checked == true)
            {
                btn.Checked = false;
            }
            else
            {
                btn.Checked = true;
            }
            _getToolView.SetCheckedButton(btn.Text);
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

            // 1. Show view select TrayIndex.
            _getToolView.cStatusForm = '1';
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
                if (Properties.Settings.Default.MachineId != 0)
                {
                    _getToolView.lstTrayQuantity = await _getToolRepository.GetMachineTrayByToolId(_getToolView.iToolId, Properties.Settings.Default.MachineId);
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

        private void _getToolView_btnGetTool_Click(object sender, EventArgs e)
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

                string strSendSerialCom = "125," + _getToolView.strTrayIndex.Split('_').GetValue(1).ToString() + "|";
                frm.btnGetTool.Enabled = false;
                if (SerialPort.GetPortNames().Length == 0)
                {
                    MessageBox.Show("Không có cổng COM!");
                    _log.Info("Not connect COM!");
                    return;
                }
                if (!_getToolView.serialPortGetTool.IsOpen)
                {
                    foreach (var item in SerialPort.GetPortNames())
                    {
                        _getToolView.serialPortGetTool.PortName = item;
                        if (_getToolView.serialPortGetTool.PortName != "COM1")
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
        }

        private void _getToolView_serialPort_GetTool_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (_getToolView.serialPortGetTool.IsOpen)
            {
                string strReadLine = _getToolView.serialPortGetTool.ReadLine().Substring(0, 3);
                if (strReadLine == "123")
                {
                    // Get information workingtransaction.
                    //WorkingTransaction workingTransaction = new WorkingTransaction();
                    //workingTransaction.dtTransactionDate = _toolManagerView.toolTrayCurrent.dtUpdateDate;
                    //workingTransaction.iMachineId = _toolManagerView.iMachineId;
                    //if (Properties.Settings.Default.CompanyId != 0)
                    //{
                    //    workingTransaction.iCompanyId = Properties.Settings.Default.CompanyId;
                    //}
                    //if (Program.sessionLogin["UserName"] != null)
                    //{
                    //    workingTransaction.strUserLogin = Program.sessionLogin["UserName"].ToString();
                    //}
                    //workingTransaction.strJobNumber = null;
                    //workingTransaction.strOPNumber = null;
                    //workingTransaction.iTrayId = _toolManagerView.iTrayID;
                    //workingTransaction.iQuantity = _toolManagerView.iOperateQuantity.Value;
                    //workingTransaction.strTransactionStatus = "Complete";

                    // Add workingtransaction.
                    IWorkingTransactionRepository workingTransactionRepository = new WorkingTransactionRepository();

                    MessageBox.Show("Get tool success.");
                    _log.Info("Get tool success.");
                    _getToolView.serialPortGetTool.Close();
                    return;
                }
            }
        }

        private async void _getToolView_GetToolView_Load(object sender, EventArgs e)
        {
            MessageDialog.Show("JobNumber: " + _getToolView.strJobNumber +
                                "\nOPId: " + _getToolView.iOPId.ToString());
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
        #endregion
    }
}
