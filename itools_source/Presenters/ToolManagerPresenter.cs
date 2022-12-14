using Guna.UI2.WinForms;
using itools_source.Models;
using itools_source.Models.Interface;
using itools_source.Utils;
using itools_source.Views;
using itools_source.Views.Interface;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace itools_source.Presenters
{
    public class ToolManagerPresenter
    {
        public ToolManagerPresenter(IToolManagerView pushToolView, IToolMachineTrayRepository toolMachineTrayRepository)
        {
            _toolManagerView = pushToolView;
            _toolMachineTrayRepository = toolMachineTrayRepository;

            _toolManagerView.ToolManagerView_Load += _toolManagerView_ToolManagerView_Load;
            _toolManagerView.txtTraySearch_TextChanged += _toolManagerView_txtTraySearch_TextChanged;
            _toolManagerView.btnTraySearch_Click += _toolManagerView_btnTraySearch_Click;
            _toolManagerView.btnflpTrayList_Click += _toolManagerView_btnflpTrayList_Click;
            _toolManagerView.txtOperateQuantity_KeyPress += _toolManagerView_txtOperateQuantity_KeyPress;
            _toolManagerView.txtOperateQuantity_TextChanged += _toolManagerView_txtOperateQuantity_TextChanged;
            _toolManagerView.txtToolCode_MouseClick += _toolManagerView_txtToolCode_MouseClick;
            _toolManagerView.txtToolSearch_TextChanged += _toolManagerView_txtToolSearch_TextChanged;
            _toolManagerView.btnflpToolList_Click += _toolManagerView_btnflpToolList_Click;
            _toolManagerView.btnflpToolList_DoubleClick += _toolManagerView_btnflpToolList_DoubleClick;
            _toolManagerView.btnToolSelect_Click += _toolManagerView_btnToolSelect_Click;
            _toolManagerView.btnToolCancel_Click += _toolManagerView_btnToolCancel_Click;
            _toolManagerView.btnTakeOut_Click += _toolManagerView_btnTakeOut_Click;
            _toolManagerView.btnAddPlugin_Click += _toolManagerView_btnAddPlugin_Click;
            _toolManagerView.btnAddNew_Click += _toolManagerView_btnAddNew_Click;
            _toolManagerView.btnSave_Click += _toolManagerView_btnSave_Click;

            _toolManagerView.Show();
        }

        #region Properties - Fields
        private readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(ToolManagerPresenter).Name);

        private readonly IToolManagerView _toolManagerView;
        private readonly IToolMachineTrayRepository _toolMachineTrayRepository;
        private int? _iMachineId = null;
        private readonly string _strMachineCode = null; // 
        private string _strTrayIndexCurrent = null;
        private string _strToolCodeCurrent = "";
        private int _iCurrentQuantity = 0;
        #endregion

        #region Events
        private async void _toolManagerView_ToolManagerView_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.MachineId != 0)
            {
                _iMachineId = Properties.Settings.Default.MachineId;
                _toolManagerView.iMachineId = Properties.Settings.Default.MachineId;

                // Get data TrayId, TrayIndex and ToolCode
                _toolManagerView.lstTrayIndexToolCode = await _toolMachineTrayRepository.GetTrayIndexAndToolCode(_toolManagerView.iMachineId);

                if (_toolManagerView.lstTrayIndexToolCode != null)
                {
                    var form = (ToolManagerView)sender;
                    form.CreateButtonTray(); // *
                    form.cStatusForm = '3';
                    form.SetStatusForm();
                }
            }
        }

        private async void _toolManagerView_btnSave_Click(object sender, EventArgs e)
        {
            if (_toolManagerView.iCurrentQuantity == null || _toolManagerView.iOperateQuantity == null)
            {
                _log.Info("CurrentQuantity or OperateQuantity is null!!");
                return;
            }

            if (_toolManagerView.iOperateQuantity == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Số Lượng!");
                _toolManagerView.txtOperateQuantity_Focus();
            }
            else
            {
                bool bResult = false;

                // Get detailed information
                MessageBox.Show("ID: " + _toolManagerView.toolTrayCurrent.iToolsMachineTrayId.ToString() +
                    "\nMachineID: " + _toolManagerView.toolTrayCurrent.iMachineId.ToString() +
                    "\nToolID: " + _toolManagerView.toolTrayCurrent.iToolId.ToString() +
                    "\nTrayIndex: " + _toolManagerView.toolTrayCurrent.strTrayIndex +
                    "\nQuantity: " + _toolManagerView.toolTrayCurrent.iQuantity.ToString() +
                    "\nCreateDate: " + _toolManagerView.toolTrayCurrent.dtCreateDate.ToString() +
                    "\nUpdateDate: " + _toolManagerView.toolTrayCurrent.dtUpdateDate.ToString() +
                    "\nActive: " + _toolManagerView.toolTrayCurrent.isActive.ToString());

                //_toolManagerView.toolTrayCurrent.iMachineId = _iMachineId;
                //_toolManagerView.toolTrayCurrent.iToolId = _toolManagerView.iToolID;
                //_toolManagerView.toolTrayCurrent.strTrayIndex = _strTrayIndexCurrent;
                //_toolManagerView.toolTrayCurrent.iQuantity = _toolManagerView.iTotalQuantity.Value;
                //_toolManagerView.toolTrayCurrent.dtCreateDate = null;

                //_toolManagerView.toolTrayCurrent.dtUpdateDate = ServerTime.GetServerTime().ToLocalTime();
                //_toolManagerView.toolTrayCurrent.isActive = 1;

                if (_toolManagerView.iOperateQuantity > 10)
                {
                    MessageBox.Show("Chỉ Thêm Tối Đa 10 Tool!");
                    return;
                }

                // Check tool is Machine and Tray.
                if (!await _toolMachineTrayRepository.IsToolInMachineTray(strTrayIndex: _toolManagerView.toolTrayCurrent.strTrayIndex, iMachineId: _iMachineId, _toolManagerView.iToolID))
                {
                    MessageBox.Show("TrayIndex: " + _toolManagerView.toolTrayCurrent.strTrayIndex + "\nMachineID: " + _iMachineId.ToString() + "\nToolID: " + _toolManagerView.iToolID.ToString());
                    MessageBox.Show("Tool Không Có Trong Tray Của Máy!");
                    _log.Info("Tool is not Machine and Tray!");
                    return;
                }

                MessageBox.Show(_toolManagerView.cStatusButton.ToString());
                switch (_toolManagerView.cStatusButton)
                {
                    case '0': // AddNew
                        bResult = await _toolMachineTrayRepository.UpdateTrayQuantityToolCode(toolMachineTray: _toolManagerView.toolTrayCurrent);
                        //string strTextButton;

                        //foreach (var item in _toolManagerView.lstTrayButton)
                        //{
                        //    strTextButton = item.Text.Split('\r').GetValue(0).ToString().Replace(' ', '_');
                        //    if (_strTrayIndexCurrent == strTextButton)
                        //    {
                        //        StringBuilder strBuiderTray = new StringBuilder(_strTrayIndexCurrent.Replace('_', ' '));
                        //        strBuiderTray.Append("\r\n");
                        //        strBuiderTray.Append(_toolManagerView.strToolCode);
                        //        item.Text = strBuiderTray.ToString();
                        //    }
                        //}
                        break;
                    case '1': // AddPlugin
                    case '2': // TakeOut
                        MessageBox.Show("Ahihi");
                        bResult = await _toolMachineTrayRepository.UpdateQuantityToolTray(toolMachineTray: _toolManagerView.toolTrayCurrent);
                        break;
                }

                if (bResult == true)
                {
                    bool bResultTransaction = false;
                    bool bResultStock = false;
                    if (_toolManagerView.toolTrayCurrent != null)
                    {
                        WorkingTransaction workingTransaction = new WorkingTransaction();
                        workingTransaction.dtTransactionDate = _toolManagerView.toolTrayCurrent.dtUpdateDate;
                        workingTransaction.iMachineId = _toolManagerView.toolTrayCurrent.iMachineId;
                        workingTransaction.iCompanyId = Properties.Settings.Default.CompanyId;
                        workingTransaction.strUserLogin = Program.sessionLogin["UserName"].ToString();
                        workingTransaction.strJobNumber = null;
                        workingTransaction.strOPNumber = null;
                        workingTransaction.iToolId = _toolManagerView.toolTrayCurrent.iToolId;
                        workingTransaction.strTrayIndex = _toolManagerView.toolTrayCurrent.strTrayIndex;
                        workingTransaction.iQuantity = _toolManagerView.iOperateQuantity.Value;
                        workingTransaction.strTransactionStatus = "Complete";

                        // Get quantity by ToolID in Stock.
                        int? iOldStockQuantity = null;
                        if (_toolManagerView.iToolID != null)
                        {
                            iOldStockQuantity = await _toolMachineTrayRepository.GetQuantityByToolID(_toolManagerView.iToolID);
                        }

                        // Update working transaction type.
                        int? iNewStockQuantity = null;
                        if (_toolManagerView.cStatusButton == '0')
                        {
                            workingTransaction.strTransactiomType = "Add New";
                            iNewStockQuantity = iOldStockQuantity - _toolManagerView.iOperateQuantity;
                        }
                        else if (_toolManagerView.cStatusButton == '1')
                        {
                            workingTransaction.strTransactiomType = "Add Plugin";
                            iNewStockQuantity = iOldStockQuantity - _toolManagerView.iOperateQuantity;
                        }
                        else
                        {
                            workingTransaction.strTransactiomType = "Take Out";
                            iNewStockQuantity = iOldStockQuantity + _toolManagerView.iOperateQuantity;
                        }

                        bResultTransaction = await _toolMachineTrayRepository.AddWorkingTransaction(workingTransaction: workingTransaction);

                        bResultStock = await _toolMachineTrayRepository.UpdateQuantityStock(iToolID: _toolManagerView.iToolID, iQuantity: iNewStockQuantity);
                    }

                    if (bResultTransaction)
                    {
                        MessageBox.Show("Lưu Thành Công!");
                        _log.Info("Update stock: " + bResultStock);
                    }
                    else
                    {
                        MessageBox.Show("Lưu Thất Bại!");
                    }
                }
                else
                {
                    MessageBox.Show("Lưu Thất Bại!");
                }
                _toolManagerView.cStatusForm = '4';
                _toolManagerView.SetStatusForm();
            }
        }

        private void _toolManagerView_btnAddNew_Click(object sender, EventArgs e)
        {
            _toolManagerView.cStatusButton = '0';
            _toolManagerView.SetStateButton();
        }

        private void _toolManagerView_btnToolCancel_Click(object sender, EventArgs e)
        {
            _toolManagerView.CancelListTool();
        }

        private void _toolManagerView_btnToolSelect_Click(object sender, EventArgs e)
        {
            if (_toolManagerView.CheckedSelectTool())
            {
                SelectTool();
            }
            else
            {
                MessageBox.Show("Bạn Chưa Chọn Tool!");
                _log.Error("Button Not Selected!");
            }
        }

        private void _toolManagerView_btnflpToolList_DoubleClick(object sender, EventArgs e)
        {
            SelectTool();
        }

        private void _toolManagerView_btnflpToolList_Click(object sender, EventArgs e)
        {
            Guna2GradientButton btn = (Guna2GradientButton)sender;
            _strToolCodeCurrent = btn.Text;
            if (btn.Checked == true)
            {
                btn.Checked = false;
            }
            else
            {
                btn.Checked = true;
            }
            _toolManagerView.SetCheckedButton(_strToolCodeCurrent);
        }

        private void _toolManagerView_txtToolSearch_TextChanged(object sender, EventArgs e)
        {
            _toolManagerView.ToolSearch();
        }

        private void _toolManagerView_txtToolCode_MouseClick(object sender, EventArgs e)
        {
            if (_toolManagerView.cStatusButton != '0')
            {
                return;
            }

            _toolManagerView.toolCodeList = _toolMachineTrayRepository.GetToolCodeList().Result.ToList();
            if (_toolManagerView.toolCodeList == null)
            {
                MessageBox.Show("Danh sách tool rỗng!");
                _log.Error("Tool Code List is Null!");
                return;
            }

            _toolManagerView.tlpHeaderEnabled = false;
            _toolManagerView.tlpFooterEnabled = false;
            _toolManagerView.pLeftContentEnabled = false;
            _toolManagerView.tlpTrayDetailEnabled = false;

            _toolManagerView.CreateToolButton();
        }

        private async void _toolManagerView_txtOperateQuantity_TextChanged(object sender, EventArgs e)
        {
            int iOperateQuantity = _toolManagerView.iOperateQuantity.Value;
            int iTotalQuantity;

            if (_toolManagerView.cStatusButton == '2') // TakeOut
            {
                if (iOperateQuantity > _iCurrentQuantity)
                {
                    _toolManagerView.txtOperateQuantity_Focus();
                    MessageBox.Show("Tray không đủ số lượng để lấy.");
                    _toolManagerView.iOperateQuantity = null;
                    _toolManagerView.iTotalQuantity = null;
                }
                else
                {
                    iTotalQuantity = _iCurrentQuantity - iOperateQuantity;
                    _toolManagerView.iTotalQuantity = iTotalQuantity;
                }
            }
            else // AddNew, AddPlugin
            {
                // 1. Check quantity stock.
                // a. Get quantity stock in database(dtb).
                //_toolManagerView.iToolID = await _toolMachineTrayRepository.GetToolIDByToolCode(_toolManagerView.strToolCode);

                int? iQuantityStock = await _toolMachineTrayRepository.GetQuantityByToolID(iToolID: _toolManagerView.iToolID);

                // b. Between quantity stock dtb and app.
                if (iQuantityStock < _toolManagerView.iOperateQuantity)
                {
                    MessageBox.Show("Kho không đủ số lượng!");
                    _toolManagerView.iOperateQuantity = null;
                    _toolManagerView.iTotalQuantity = null;
                    _toolManagerView.txtOperateQuantity_Focus();
                    return;
                }

                // 2. Check quantity maximum tray.
                iTotalQuantity = _iCurrentQuantity + iOperateQuantity;
                _toolManagerView.iTotalQuantity = iTotalQuantity;
                if (_toolManagerView.iOperateQuantity > 10 || iTotalQuantity > 10)
                {
                    MessageBox.Show("Tray Chỉ Chứa Tối Đa 10 Công Cụ!");
                    if (Program.sessionLogin["UserName"] != null)
                    {
                        _log.Info("Warehouse management adds too many tools: " + Program.sessionLogin["UserName"]);
                    }
                    _toolManagerView.iOperateQuantity = null;
                    _toolManagerView.iTotalQuantity = null;
                    _toolManagerView.txtOperateQuantity_Focus();
                    return;
                }
            }
        }

        private void _toolManagerView_txtOperateQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CheckInputCharacterLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không Được Nhập Chữ!");
                _toolManagerView.txtOperateQuantity_Focus();
            }
        }

        private async void _toolManagerView_btnflpTrayList_Click(object sender, EventArgs e)
        {
            if (sender == null)
            {
                _log.Error("Sender is null!");
                return;
            }

            Guna2Button btn = (Guna2Button)sender;

            if (btn != null)
            {
                if (btn.Tag != null)
                {
                    // Get TrayID
                    _toolManagerView.iTrayID = Convert.ToInt32(btn.Tag);
                    
                    // Get ToolId
                    if (_toolManagerView.iTrayID != null)
                    {
                        _toolManagerView.iToolID = await _toolMachineTrayRepository.GetToolIDByTrayID(_toolManagerView.iTrayID);
                    }
                    
                    //_strTrayIndexCurrent = btn.Text;
                    string strTextButton = btn.Text;
                    int iLength = strTextButton.Length;
                    int i = 0;
                    for (i = 0; i < iLength; i++)
                    {
                        if (strTextButton[i] == '\n')
                        {
                            break;
                        }
                    }

                    _log.Info("Tray and ToolCode Select: " + btn.Text);

                    try
                    {
                        _iCurrentQuantity = await _toolMachineTrayRepository.GetToolQuantity(_toolManagerView.iTrayID);
                        _toolManagerView.cStatusForm = '5';
                        _toolManagerView.SetStatusForm();

                        if (_iCurrentQuantity > -1)
                        {
                            _toolManagerView.iCurrentQuantity = _iCurrentQuantity;
                            // Set Status Button.
                            if (_iCurrentQuantity == 0) // Quantity = 0 | AddNew
                            {
                                _toolManagerView.cStatusForm = '0';
                                _toolManagerView.SetStatusForm();
                            }
                            if (_iCurrentQuantity > 0 && _iCurrentQuantity < 10)  // Quantity > 0 && Quantity < MAX | AddPlugin
                            {
                                _toolManagerView.cStatusForm = '1';
                                _toolManagerView.SetStatusForm();
                            }
                            if (_iCurrentQuantity == 10)  // Quantity = MAX | TakeOut
                            {
                                _toolManagerView.cStatusForm = '2';
                                _toolManagerView.SetStatusForm();
                            }

                            _toolManagerView.toolTrayCurrent = await _toolMachineTrayRepository.GetToolByTrayIndex(_toolManagerView.iTrayID);
                            if (_toolManagerView.toolTrayCurrent != null)
                            {
                                _toolManagerView.strTrayIndex = strTextButton.Substring(0, i).Split(' ').GetValue(1).ToString();
                                _toolManagerView.strToolCode = strTextButton.Substring(i + 1, iLength - 1 - i);
                            }
                            else
                            {
                                MessageBox.Show("Tool is Null in Tray");
                                _log.Error("Tool is Null in Tray!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error: Không Lấy Được Số Lượng Từ Cơ Sở Dữ Liệu!");
                            _log.Error("Quantity Error: " + _iCurrentQuantity.ToString()); // -3
                            _iCurrentQuantity = 0;
                            _toolManagerView.iCurrentQuantity = null;
                            _toolManagerView.strTrayIndex = string.Empty;
                            _toolManagerView.strToolCode = string.Empty;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        _log.Error(ex.Message);
                    }
                }
            }
        }

        private void _toolManagerView_txtTraySearch_TextChanged(object sender, EventArgs e)
        {
            ToolManagerView frm = (ToolManagerView)sender;
            frm.flpTrayList.Controls.Clear();
            _toolManagerView.TrayAndToolSearch();
        }

        private void _toolManagerView_btnTraySearch_Click(object sender, EventArgs e)
        {
            ToolManagerView frm = (ToolManagerView)sender;
            if (string.IsNullOrEmpty(_toolManagerView.strTrayToolSearch))
            {
                return;
            }
            frm.flpTrayList.Controls.Clear();
            _toolManagerView.TrayAndToolSearch();
        }

        private void _toolManagerView_btnAddPlugin_Click(object sender, EventArgs e)
        {
            if (_toolManagerView.iTotalQuantity > 10)
            {
                MessageBox.Show("Tray Chỉ Chứa Tối Đa 10 Công Cụ!");
                _log.Info("Warehouse management adds too many tools: " + Program.sessionLogin["UserName"]);
            }
            else
            {
                _toolManagerView.cStatusButton = '1';
                _toolManagerView.SetStateButton();
                _log.Info("Switch to save state!");
            }
        }

        private void _toolManagerView_btnTakeOut_Click(object sender, EventArgs e)
        {
            _toolManagerView.cStatusButton = '2';
            _toolManagerView.SetStateButton();
        }
        #endregion

        #region Method
        private bool CheckInputCharacterLetter(char cInput)
        {
            return ((cInput < '0' || cInput > '9') && ((Keys)cInput != Keys.Back) && ((Keys)cInput != Keys.Enter));
        }

        private void SelectTool()
        {
            _toolManagerView.strToolCode = _strToolCodeCurrent;
            _toolManagerView.CancelListTool();
            _toolManagerView.cStatusForm = '6';
            _toolManagerView.SetStatusForm();
            _log.Info("Tool select: " + _strToolCodeCurrent);
        }
        #endregion
    }
}
