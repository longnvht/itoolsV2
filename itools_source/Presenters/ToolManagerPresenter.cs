using Guna.UI2.WinForms;
using itools_source.Models;
using itools_source.Models.Interface;
using itools_source.Repository;
using itools_source.Utils;
using itools_source.Views;
using itools_source.Views.Interface;
using System;
using System.Drawing;
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
            _toolManagerView.txtOperateQuantity_MouseClick += _toolManagerView_txtOperateQuantity_MouseClick;
            _toolManagerView.txtToolSearch_MouseClick += _toolManagerView_txtToolSearch_MouseClick;
            _toolManagerView.txtTrayToolSearch_MouseClick += _toolManagerView_txtTrayToolSearch_MouseClick;
            _toolManagerView.ToolManagerView_FormClosing += _toolManagerView_ToolManagerView_FormClosing;

            _toolManagerView.Show();
        }

        #region Properties - Fields
        private readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(ToolManagerPresenter).Name);
        private VirtualNumericKeyBoard frmNumericKey;
        private VirtualKeyBoard frmKeyBoard;
        private Point clientPoint;

        private readonly IToolManagerView _toolManagerView;
        private readonly IToolMachineTrayRepository _toolMachineTrayRepository;

        private IToolRepository _toolRepository;
        private IWorkingTransactionRepository _workingTransactionRepository;
        private IStockRepository _stockRepository;
        #endregion

        #region Events
        private void _toolManagerView_ToolManagerView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.OfType<VirtualKeyBoard>().Any())
            {
                frmKeyBoard.Close();
            }
            if (Application.OpenForms.OfType<VirtualNumericKeyBoard>().Any())
            {
                frmNumericKey.Close();
            }
        }

        private void _toolManagerView_txtTrayToolSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (!Application.OpenForms.OfType<VirtualKeyBoard>().Any() && !Application.OpenForms.OfType<VirtualNumericKeyBoard>().Any())
            {
                frmKeyBoard = new VirtualKeyBoard();
                frmKeyBoard.Show();

                ToolManagerView frm = (ToolManagerView)sender;
                frm.txtTrayToolSearch.Focus();

                int iTempX = ((frm.Width - frmKeyBoard.Width) / 2) + (frm.MdiParent as MainView).Location.X;
                int iTempY = ((frm.Height - frmKeyBoard.Height) + 69) + (frm.MdiParent as MainView).Location.Y;

                clientPoint = new Point(iTempX, iTempY);
                frmKeyBoard.Location = clientPoint;
            }
        }

        private void _toolManagerView_txtToolSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (!Application.OpenForms.OfType<VirtualKeyBoard>().Any() && !Application.OpenForms.OfType<VirtualNumericKeyBoard>().Any())
            {
                frmKeyBoard = new VirtualKeyBoard();
                frmKeyBoard.Show();

                ToolManagerView frm = (ToolManagerView)sender;
                frm.txtToolSearch.Focus();

                int iTempX = ((frm.Width - frmKeyBoard.Width) / 2) + (frm.MdiParent as MainView).Location.X;
                int iTempY = ((frm.Height - frmKeyBoard.Height) + 69) + (frm.MdiParent as MainView).Location.Y;

                clientPoint = new Point(iTempX, iTempY);
                frmKeyBoard.Location = clientPoint;
            }
        }

        private void _toolManagerView_txtOperateQuantity_MouseClick(object sender, MouseEventArgs e)
        {
            if (!Application.OpenForms.OfType<VirtualNumericKeyBoard>().Any() && !Application.OpenForms.OfType<VirtualKeyBoard>().Any())
            {
                frmNumericKey = new VirtualNumericKeyBoard();
                frmNumericKey.Show();

                ToolManagerView frm = (ToolManagerView)sender;
                frm.txtOperateQuantity.Focus();

                int iTempX = ((frm.Width - frmNumericKey.Width) / 2) + (frm.MdiParent as MainView).Location.X;
                int iTempY = ((frm.Height - frmNumericKey.Height) + 69) + (frm.MdiParent as MainView).Location.Y;

                clientPoint = new Point(iTempX, iTempY);
                frmNumericKey.Location = clientPoint;
            }
        }

        private async void _toolManagerView_ToolManagerView_Load(object sender, EventArgs e)
        {
            if (VinamiToolUser.Properties.Settings.Default.MachineId != 0)
            {
                var frm = (ToolManagerView)sender;

                frm.cStatusForm = '3';
                frm.SetStatusForm();

                //_iMachineId = Properties.Settings.Default.MachineId;
                _toolManagerView.iMachineId = VinamiToolUser.Properties.Settings.Default.MachineId;

                // Get data TrayId, TrayIndex and ToolCode
                _toolManagerView.lstTrayIndexToolCode = await _toolMachineTrayRepository.GetTrayIndexAndToolCode(_toolManagerView.iMachineId);

                if (_toolManagerView.lstTrayIndexToolCode != null)
                {
                    frm.CreateButtonTray();
                    _log.Info("Create list button tray success.");
                }
                else
                {
                    _log.Error("Create list button tray fail.");
                }
            }
            else
            {
                _log.Warn("Machine is zero.");
            }
        }

        /*Status Add New*/
        private void _toolManagerView_btnToolCancel_Click(object sender, EventArgs e)
        {
            _toolManagerView.CancelListTool();
        }

        private void _toolManagerView_btnToolSelect_Click(object sender, EventArgs e)
        {
            if ((sender as ToolManagerView).CheckedSelectTool())
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
            if (btn != null)
            {
                //_strToolCodeCurrent = btn.Text;
                _toolManagerView.iToolID = btn.Tag as int?;
                _toolManagerView.strToolCode = btn.Text;
            }

            if (btn.Checked == true)
            {
                btn.Checked = false;
            }
            else
            {
                btn.Checked = true;
            }
            _toolManagerView.SetCheckedButton(_toolManagerView.iToolID);
        }

        private void _toolManagerView_txtToolSearch_TextChanged(object sender, EventArgs e)
        {
            (sender as ToolManagerView).ToolSearch();
        }

        private async void _toolManagerView_txtToolCode_MouseClick(object sender, EventArgs e)
        {
            if (_toolManagerView.cStatusButton != '0')
            {
                return;
            }
            if (_toolRepository == null)
            {
                _toolRepository = new ToolRepository();
            }
            _toolManagerView.lstTooIDAndCode = await _toolRepository.GetToolCodeList();
            if (_toolManagerView.lstTooIDAndCode == null)
            {
                MessageBox.Show("Danh sách tool rỗng!");
                _log.Error("Tool Code List is Null!");
                return;
            }

            ToolManagerView frm = sender as ToolManagerView;
            frm.tlpHeader.Enabled = false;
            frm.tlpFooter.Enabled = false;
            frm.pLeftContent.Enabled = false;
            frm.tlpTrayDetail.Enabled = false;

            frm.CreateToolButton();
        }
        /*Status Add New*/

        private async void _toolManagerView_txtOperateQuantity_TextChanged(object sender, EventArgs e)
        {
            ToolManagerView frm = sender as ToolManagerView;

            if (_toolManagerView.cStatusButton == '2') // TakeOut
            {
                if (_toolManagerView.iOperateQuantity > _toolManagerView.iCurrentQuantity)
                {
                    frm.txtOperateQuantity.Focus();
                    MessageBox.Show("Tray không đủ số lượng để lấy.");
                    _toolManagerView.iOperateQuantity = null;
                    _toolManagerView.iTotalQuantity = null;
                }
                else
                {
                    _toolManagerView.iTotalQuantity = _toolManagerView.iCurrentQuantity - _toolManagerView.iOperateQuantity;
                }
            }
            else // AddNew, AddPlugin
            {
                // 1. Check quantity stock.
                // a. Get quantity stock in database(dtb).
                if (_stockRepository == null)
                {
                    _stockRepository = new StockRepository();
                }
                int? iQuantityStock = await _stockRepository.GetQuantityByToolID(iToolID: _toolManagerView.iToolID);

                // b. Between quantity stock dtb and app.
                if (!iQuantityStock.HasValue) // Tool is not in table stock.
                {
                    MessageBox.Show("Tool không có trong kho.");
                    return;
                }

                if (iQuantityStock < _toolManagerView.iOperateQuantity)
                {
                    MessageBox.Show("Kho không đủ số lượng!");
                    _toolManagerView.iOperateQuantity = null;
                    _toolManagerView.iTotalQuantity = null;
                    frm.txtOperateQuantity.Focus();
                    _log.Info("Insufficient stock.");
                    return;
                }

                // 2. Check quantity maximum tray.
                _toolManagerView.iTotalQuantity = _toolManagerView.iCurrentQuantity + _toolManagerView.iOperateQuantity;
                if (_toolManagerView.iOperateQuantity > 10 || _toolManagerView.iTotalQuantity > 10)
                {
                    MessageBox.Show("Tray Chỉ Chứa Tối Đa 10 Công Cụ!");
                    if (Program.sessionLogin["UserName"] != null)
                    {
                        _log.Info("Warehouse management adds too many tools: " + Program.sessionLogin["UserName"]);
                    }
                    _toolManagerView.iOperateQuantity = null;
                    _toolManagerView.iTotalQuantity = null;
                    frm.txtOperateQuantity.Focus();
                    return;
                }
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

                    // Get detailed tool information for ToolsMachineTray
                    /*
                     * 1. TrayID **
                     * 2. MachineID
                     * 3. ToolID *
                     * 4. TrayIndex
                     * 5. Quantity *
                     * 6. CreateDate
                     * 7. UpdateDate *
                     * 8. IsActive
                     * 
                     * Add New(+) -> Update: ToolID, Quantity, UpdateDate
                     * Add Pluin(+), Take Out(-) -> Update: Quantity, UpdateDate
                     */

                    // Get ToolId for table ToolsMachineTray
                    if (_toolManagerView.iTrayID != null)
                    {
                        _toolManagerView.iToolID = await _toolMachineTrayRepository.GetToolIDByTrayID(_toolManagerView.iTrayID);
                    }

                    // Get index endline
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
                        _toolManagerView.iCurrentQuantity = await _toolMachineTrayRepository.GetQuantityInTray(_toolManagerView.iTrayID); // Get quantity in table toolsmachinetray
                        _toolManagerView.cStatusForm = '5';
                        _toolManagerView.SetStatusForm();

                        if (_toolManagerView.iCurrentQuantity > -1)
                        {
                            // Set Status Button.
                            if (_toolManagerView.iCurrentQuantity == 0) // Quantity = 0 | AddNew
                            {
                                _toolManagerView.cStatusForm = '0';
                                _toolManagerView.SetStatusForm();
                            }
                            if (_toolManagerView.iCurrentQuantity > 0 && _toolManagerView.iCurrentQuantity < 10)  // Quantity > 0 && Quantity < MAX | AddPlugin
                            {
                                _toolManagerView.cStatusForm = '1';
                                _toolManagerView.SetStatusForm();
                            }
                            if (_toolManagerView.iCurrentQuantity == 10)  // Quantity = MAX | TakeOut
                            {
                                _toolManagerView.cStatusForm = '2';
                                _toolManagerView.SetStatusForm();
                            }

                            if (_toolManagerView.iTrayID != null)
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
                            _log.Error("Quantity Error: " + _toolManagerView.iCurrentQuantity.ToString()); // -3
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
            frm.TrayAndToolSearch();
        }

        private void _toolManagerView_btnTraySearch_Click(object sender, EventArgs e)
        {
            ToolManagerView frm = (ToolManagerView)sender;
            if (string.IsNullOrEmpty(_toolManagerView.strTrayToolSearch))
            {
                return;
            }
            frm.flpTrayList.Controls.Clear();
            frm.TrayAndToolSearch();
        }

        private void _toolManagerView_btnAddNew_Click(object sender, EventArgs e) // Add New
        {
            _toolManagerView.cStatusButton = '0';
            _toolManagerView.SetStateButton();
        }

        private void _toolManagerView_btnAddPlugin_Click(object sender, EventArgs e) // Add Plugin
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

        private void _toolManagerView_btnTakeOut_Click(object sender, EventArgs e) // Take Out
        {
            _toolManagerView.cStatusButton = '2';
            _toolManagerView.SetStateButton();
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
                (sender as ToolManagerView).txtOperateQuantity.Focus();
            }
            else
            {
                bool bResult = false;

                // Get detailed information
                if (_toolManagerView.toolTrayCurrent == null)
                {
                    _toolManagerView.toolTrayCurrent = new ToolMachineTray();
                }
                _toolManagerView.toolTrayCurrent.iToolsMachineTrayId = _toolManagerView.iTrayID;
                _toolManagerView.toolTrayCurrent.iToolId = _toolManagerView.iToolID;
                _toolManagerView.toolTrayCurrent.iQuantity = _toolManagerView.iTotalQuantity.Value;
                _toolManagerView.toolTrayCurrent.dtCreateDate = null;
                _toolManagerView.toolTrayCurrent.dtUpdateDate = ServerTime.GetServerTime().ToLocalTime();
                _toolManagerView.toolTrayCurrent.isActive = 1;

                if (_toolManagerView.iOperateQuantity > 10)
                {
                    MessageBox.Show("Chỉ Thêm Tối Đa 10 Tool!");
                    return;
                }

                // Check tool is Machine and Tray.
                if (!await _toolMachineTrayRepository.IsToolInMachineTray(iTrayId: _toolManagerView.iTrayID, _toolManagerView.iToolID))
                {
                    MessageBox.Show("Tool Không Có Trong Tray Của Máy!");
                    _log.Info("Tool is not Machine and Tray!");
                    return;
                }

                switch (_toolManagerView.cStatusButton)
                {
                    case '0': // AddNew
                        bResult = await _toolMachineTrayRepository.UpdateTrayQuantityToolID(toolMachineTray: _toolManagerView.toolTrayCurrent);

                        // Load ToolID and ToolCode to TrayIndex
                        foreach (var item in _toolManagerView.lstTrayButton)
                        {
                            string strTrayIndex = item.Text.Split('\r').GetValue(0).ToString();
                            int? iTrayIDCurrent = item.Tag as int?;
                            if (_toolManagerView.iTrayID == iTrayIDCurrent)
                            {
                                StringBuilder strBuiderTray = new StringBuilder(strTrayIndex);
                                strBuiderTray.Append("\r\n");
                                strBuiderTray.Append(_toolManagerView.strToolCode);
                                item.Text = strBuiderTray.ToString();
                                break;
                            }
                        }
                        break;
                    case '1': // AddPlugin
                    case '2': // TakeOut
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
                        workingTransaction.iMachineId = _toolManagerView.iMachineId;
                        if (VinamiToolUser.Properties.Settings.Default.CompanyId != 0)
                        {
                            workingTransaction.iCompanyId = VinamiToolUser.Properties.Settings.Default.CompanyId;
                        }
                        if (Program.sessionLogin["UserName"] != null)
                        {
                            workingTransaction.strUserLogin = Program.sessionLogin["UserName"].ToString();
                        }
                        workingTransaction.strJobNumber = null;
                        workingTransaction.strOPNumber = null;
                        workingTransaction.iTrayId = _toolManagerView.iTrayID;
                        workingTransaction.iQuantity = _toolManagerView.iOperateQuantity.Value;
                        workingTransaction.strTransactionStatus = "Complete";

                        // Get quantity by ToolID in Stock.
                        int? iStockOldQuantity = null;
                        if (_toolManagerView.iToolID != null)
                        {
                            if (_stockRepository == null)
                            {
                                _stockRepository = new StockRepository();
                            }
                            iStockOldQuantity = await _stockRepository.GetQuantityByToolID(_toolManagerView.iToolID);
                        }

                        // Update working transaction type.
                        int? iStockNewQuantity = null;
                        if (_toolManagerView.cStatusButton == '0') // Stock-
                        {
                            workingTransaction.strTransactiomType = "Add New";
                            iStockNewQuantity = iStockOldQuantity - _toolManagerView.iOperateQuantity;
                        }
                        else if (_toolManagerView.cStatusButton == '1') // Stock-
                        {
                            workingTransaction.strTransactiomType = "Add Plugin";
                            iStockNewQuantity = iStockOldQuantity - _toolManagerView.iOperateQuantity;
                        }
                        else // Stock+
                        {
                            workingTransaction.strTransactiomType = "Take Out";
                            iStockNewQuantity = iStockOldQuantity + _toolManagerView.iOperateQuantity;
                        }

                        if (_workingTransactionRepository == null)
                        {
                            _workingTransactionRepository = new WorkingTransactionRepository();
                        }
                        bResultTransaction = await _workingTransactionRepository.AddWorkingTransaction(workingTransaction: workingTransaction);

                        if (_stockRepository == null)
                        {
                            _stockRepository = new StockRepository();
                        }
                        bResultStock = await _stockRepository.UpdateQuantityStock(iToolID: _toolManagerView.iToolID, iQuantity: iStockNewQuantity);
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
        #endregion

        #region Method
        private void SelectTool()
        {
            //_toolManagerView.strToolCode = _strToolCodeCurrent;
            _toolManagerView.CancelListTool();
            _toolManagerView.cStatusForm = '6';
            _toolManagerView.SetStatusForm();
            _log.Info("Tool select - ID: " + _toolManagerView.iToolID + ", ToolCode: " + _toolManagerView.strToolCode);
        }
        #endregion
    }
}
