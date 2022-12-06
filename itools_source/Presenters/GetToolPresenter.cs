using Guna.UI2.WinForms;
using itools_source.Models.Interface;
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
            _getToolView = getToolView;
            _getToolRepository = getToolRepository;

            _getToolView.GetToolView_Load += _getToolView_GetToolView_Load;
            _getToolView.serialPort_GetTool_DataReceived += _getToolView_serialPort_GetTool_DataReceived;
            _getToolView.btnGetTool_Click += _getToolView_btnGetTool_Click;
            _getToolView.btnCancelSelectTray_Click += _getToolView_btnCancelSelectTray;
            _getToolView.btnflpToolList_Click += _getToolView_btnflpToolList_Click;
            _getToolView.btnflpTrayMachineList_Click += _getToolView_btnflpTrayMachineList_Click;
            _getToolView.btnflpTrayMachineList_DoubleClick += _getToolView_btnflpTrayMachineList_DoubleClick;
            _getToolView.btnShowAll_DoubleClick += _getToolView_btnShowAll_DoubleClick;

            _getToolView.Show();
        }



        #region Properties - Fields
        private IGetToolView _getToolView;
        private IGetToolRepository _getToolRepository;

        private log4net.ILog _log = log4net.LogManager.GetLogger(typeof(OPPresenter).Name);
        private bool bToggle = false; // On/Off => Show all machine and tray quantity.
        #endregion

        #region Evens
        private async void _getToolView_btnShowAll_DoubleClick(object sender, EventArgs e)
        {
            GetToolView frm = (GetToolView)sender;
            if (!bToggle)
            {
                _getToolView.lstMachineTrayQuantity = await _getToolRepository.GetMachineTrayQuantityByToolCode(_getToolView.strToolCode);
                if (_getToolView.lstMachineTrayQuantity != null)
                {
                    frm.flpTrayMachineList.Controls.Clear();
                    _getToolView.CreateListButton(false);
                    bToggle = true;
                }
            }
            else
            {
                if (_getToolView.lstMachineTray != null)
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

            _getToolView.strTrayIndex = btn.Text;
            //_getToolView.strMachineCode = btn.Tag.ToString();

            string strSendSerialCom = "125," + _getToolView.strTrayIndex.Split('_').GetValue(1).ToString() + "|";
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
            if (string.IsNullOrEmpty(btn.Text) || btn.Tag == null)
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
            Dictionary<string, string> lstModelDes = await _getToolRepository.GetModelDescriptionByToolId(_getToolView.iToolId);

            if (lstModelDes != null)
            {
                _getToolView.strToolModel = lstModelDes.Keys.ElementAt(0);
                _getToolView.strToolDescription = lstModelDes.Values.ElementAt(0);
                _log.Info("Get ToolModel: " + _getToolView.strToolModel + ", ToolDescription: " + _getToolView.strToolDescription);

                // 3. Get tool tray data.
                _getToolView.lstMachineTray = await _getToolRepository.GetMachineTrayByToolCode(_getToolView.strToolCode, "VM-1");
                if (_getToolView.lstMachineTray != null)
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
            GetToolView frm = (GetToolView)sender;
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
                    break;
                }
            }

            // 2. Send to serial.
        }

        private void _getToolView_serialPort_GetTool_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (_getToolView.serialPortGetTool.IsOpen)
            {
                string strReadLine = _getToolView.serialPortGetTool.ReadLine().Substring(0, 3);
                //MessageBox.Show(strReadLine + ", length: " + strReadLine.Length.ToString());
                if (strReadLine == "123")
                {
                    MessageBox.Show("Get tool success.");
                    _log.Info("Get tool success.");
                    _getToolView.serialPortGetTool.Close();
                    return;
                }
            }
        }

        private async void _getToolView_GetToolView_Load(object sender, EventArgs e)
        {
            GetToolView frm = (GetToolView)sender;

            _getToolView.cStatusForm = '0';
            _getToolView.SetStatusForm();

            _getToolView.lstToolForOPList = await _getToolRepository.GetByToolForOP(_getToolView.iOPId);

            if (_getToolView.lstToolForOPList != null)
            {
                // 1. Create list button.
                if (_getToolView.lstToolButton == null)
                {
                    _getToolView.lstToolButton = new List<Guna2GradientButton>();
                }

                foreach (var item in _getToolView.lstToolForOPList)
                {
                    _getToolView.lstToolButton.Add(_getToolView.CreateButton(item.Value, null, "Tool", item.Key));
                }

                // 2. Add to flowlayoutpanel.
                frm.flpToolList.Controls.AddRange(_getToolView.lstToolButton.ToArray());
                _log.Info("Create button list and add button to flowlayoutpanel.");
            }
        }
        #endregion

        #region Methods
        #endregion
    }
}
