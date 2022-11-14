using Google.Protobuf.WellKnownTypes;
using Guna.UI2.WinForms;
using itools_source.Models.Interface;
using itools_source.Presenter;
using itools_source.Repository;
using itools_source.Utils;
using itools_source.Views;
using itools_source.Views.Interface;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace itools_source.Presenters
{
    public class ToolManagerPresenter
    {
        public ToolManagerPresenter(IToolManagerView pushToolView, IToolRepository toolRepository)
        {
            _toolManagerView = pushToolView;
            _toolRepository = toolRepository;

            _toolManagerView.txtSearch_TextChanged += _toolManagerView_txtSearch_TextChanged;
            _toolManagerView.btnSearch_Click += _toolManagerView_btnSearch_Click;
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

        #region Events
        private void _toolManagerView_btnSave_Click(object sender, EventArgs e)
        {
            if (_toolManagerView.iOperateQuantity == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Số Lượng!");
                _toolManagerView.txtOperateQuantity_Focus();
            }
            else
            {
                switch (_toolManagerView.cStatusButton)
                {
                    case '0': // AddNew
                        if (_toolManagerView.iOperateQuantity == 0)
                        {
                            MessageBox.Show("Bạn Chưa Nhập Số Lượng!");
                        }
                        else if (_toolManagerView.iOperateQuantity > 10)
                        {
                            MessageBox.Show("Số Lượng Tối Đa Thêm Vào Là 10!");
                        }
                        else
                        {
                            /*
                             * 1. ToolsMachineTrayID
                             * 2. MachineCode
                             * 3. ToolCode
                             * 4. TrayIndex
                             * 5. Quantity
                             * 6. CreateDate
                             * 7. UpdateDate
                             * 8. IsActive
                             */
                            if (_toolRepository.GetTheLargestToolMachineTray() is null)
                            {
                                _log.Info("ToolMachineID is null!");
                                return;
                            }
                            int? iToolMachineID = _toolRepository.GetTheLargestToolMachineTray() + 1;
                            
                            _toolManagerView.toolTrayCurrent.iToolsMachineTrayId = iToolMachineID.Value;
                            _toolManagerView.toolTrayCurrent.strMachineCode = _toolManagerView.strToolCode;
                            _toolManagerView.toolTrayCurrent.strTrayIndex = _toolManagerView.strTrayIndex;
                            _toolManagerView.toolTrayCurrent.iQuantity = _toolManagerView.iTotalQuantity;
                            _toolManagerView.toolTrayCurrent.dtCreateDate = null;

                            CultureInfo cul = new CultureInfo("vi-VN");
                            cul.DateTimeFormat.ShortDatePattern = "yyyy/MM/dd";
                            cul.DateTimeFormat.LongDatePattern = "yyyy/MM/dd";
                            cul.DateTimeFormat.ShortTimePattern = "HH:mm:ss";
                            cul.DateTimeFormat.LongTimePattern = "HH:mm:ss";
                            Thread.CurrentThread.CurrentCulture = cul;
                            _toolManagerView.toolTrayCurrent.dtUpdateDate = ServerTime.GetServerTime().ToLocalTime();
                            _toolManagerView.toolTrayCurrent.isActive = 1;

                            MessageBox.Show("ID: " + _toolManagerView.toolTrayCurrent.iToolsMachineTrayId +
                                            "\nMachine Code: " + _toolManagerView.toolTrayCurrent.strMachineCode +
                                            "\nTray Index: " + _toolManagerView.toolTrayCurrent.strTrayIndex +
                                            "\nQuantity: " + _toolManagerView.toolTrayCurrent.iQuantity +
                                            "\nCreate Date: " + _toolManagerView.toolTrayCurrent.dtCreateDate +
                                            "\nUpdate Date: " + _toolManagerView.toolTrayCurrent.dtUpdateDate +
                                            "\nIsActive: " + _toolManagerView.toolTrayCurrent.isActive);
                        }
                        break;
                    case '1': // AddPlugin
                        break;
                    case '2': // TakeOut

                        break;
                }
                MessageBox.Show("Lưu Thành Công!");
                _toolManagerView.cStatusForm = '4';
                _toolManagerView.SetStatusForm();
            }
        }

        private void _toolManagerView_btnAddNew_Click(object sender, EventArgs e)
        {
            _toolManagerView.cStatusButton = '0';
            _toolManagerView.SetButtonState();
        }

        private void _toolManagerView_btnToolCancel_Click(object sender, EventArgs e)
        {
            //_toolManagerView.cStatusForm = '3';
            //_toolManagerView.SetStatusForm(_toolManagerView.cStatusForm);
            _toolManagerView.CancelListTool();
        }

        private void _toolManagerView_btnToolSelect_Click(object sender, EventArgs e)
        {
            if (_toolManagerView.CheckedSelectTool())
            {
                _toolManagerView.strToolCode = strToolCodeCurrent;
                _toolManagerView.cStatusForm = '6';
                _toolManagerView.SetStatusForm();
                _toolManagerView.CancelListTool();
                _toolManagerView.txtOperateQuantityEnable = true;
                _toolManagerView.txtOperateQuantity_Focus();
                _log.Info("Tool select: " + strToolCodeCurrent);
            }
            else
            {
                MessageBox.Show("Bạn Chưa Chọn Tool!");
                _log.Error("Button Not Selected!");
            }
        }

        private void _toolManagerView_btnflpToolList_DoubleClick(object sender, EventArgs e)
        {
            _toolManagerView.strToolCode = strToolCodeCurrent;
            _toolManagerView.cStatusForm = '6';
            _toolManagerView.SetStatusForm();
            _toolManagerView.CancelListTool();
            _toolManagerView.txtOperateQuantityEnable = true;
            _toolManagerView.txtOperateQuantity_Focus();
            _log.Info("Tool select: " + strToolCodeCurrent);
        }

        private void _toolManagerView_btnflpToolList_Click(object sender, EventArgs e)
        {
            Guna2GradientButton btn = (Guna2GradientButton)sender;
            strToolCodeCurrent = btn.Text;
            if (btn.Checked == true)
            {
                btn.Checked = false;
            }
            else
            {
                btn.Checked = true;
            }
            _toolManagerView.SetCheckedButton(strToolCodeCurrent);
            //_toolManagerView.cStatusForm = '3';
            //_toolManagerView.SetStatusForm(_toolManagerView.cStatusForm);
            //_toolManagerView.CancelListTool();
        }

        private void _toolManagerView_txtToolSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void _toolManagerView_txtToolCode_MouseClick(object sender, EventArgs e)
        {
            if (_toolManagerView.cStatusButton != '0')
            {
                return;
            }
            _toolManagerView.toolCodeList = _toolRepository.GetToolCodeList().ToList();
            _toolManagerView.AddNewListTool();
        }

        private void _toolManagerView_txtOperateQuantity_TextChanged(object sender, EventArgs e)
        {
            int iOperateQuantity = _toolManagerView.iOperateQuantity;
            int iTotalQuantity;

            if (_toolManagerView.cStatusButton == '2') // TakeOut
            {
                if (iOperateQuantity > _iCurrentQuantity)
                {
                    _toolManagerView.txtOperateQuantity_Focus();
                    MessageBox.Show("Tray không đủ số lượng để lấy.");
                    _toolManagerView.iOperateQuantity = 0;
                    _toolManagerView.iTotalQuantity = 0;
                }
                else
                {
                    iTotalQuantity = _iCurrentQuantity - iOperateQuantity;
                    _toolManagerView.iTotalQuantity = iTotalQuantity;
                }
            }
            else // AddNew, AddPlugin
            {
                iTotalQuantity = _iCurrentQuantity + iOperateQuantity;
                _toolManagerView.iTotalQuantity = iTotalQuantity;
                if (_toolManagerView.iTotalQuantity > 10)
                {
                    MessageBox.Show("Tray Chỉ Chứa Tối Đa 10 Công Cụ!");
                    _log.Info("Warehouse management adds too many tools: " + Program.sessionLogin["UserName"]);
                    _toolManagerView.iOperateQuantity = 0;
                    _toolManagerView.iTotalQuantity = 0;
                    _toolManagerView.txtOperateQuantity_Focus();
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

        private void _toolManagerView_btnflpTrayList_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            string strTrayIndex = btn.Text.Replace(" ", "_");
            _log.Info("Tray Select: " + strTrayIndex);
            try
            {
                _iCurrentQuantity = _toolRepository.GetToolQuantity(strTrayIndex);
                _toolManagerView.iCurrentQuantity = _iCurrentQuantity;
                _toolManagerView.cStatusForm = '5';
                _toolManagerView.SetStatusForm();

                if (_iCurrentQuantity > -1)
                {
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

                    string strMachine = "VM-6";
                    _toolManagerView.toolTrayCurrent = _toolRepository.GetToolByTrayIndex(strTrayIndex, strMachine);
                    if (_toolManagerView.toolTrayCurrent != null)
                    {
                        _toolManagerView.strTrayIndex = btn.Text.Split(' ').GetValue(1).ToString();
                        _toolManagerView.strToolCode = _toolManagerView.toolTrayCurrent.strToolCode;
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
                    _log.Error("Quantity Error: " + _iCurrentQuantity.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _log.Error(ex.Message);
            }
        }

        private void _toolManagerView_btnSearch_Click(object sender, EventArgs e)
        {
            
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
                _toolManagerView.SetButtonState();
                _log.Info("Switch to save state!");
            }
        }

        private void _toolManagerView_txtSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void _toolManagerView_btnTakeOut_Click(object sender, EventArgs e)
        {
            _toolManagerView.cStatusButton = '2';
            _toolManagerView.SetButtonState();
        }
        #endregion

        #region Properties - Fields
        log4net.ILog _log = log4net.LogManager.GetLogger(typeof(ToolManagerPresenter).Name);
        private int _iCurrentQuantity = 0;
        private string strToolCodeCurrent = "";

        private IToolManagerView _toolManagerView;
        private IToolRepository _toolRepository;
        #endregion

        #region Method
        private bool CheckInputCharacterLetter(char cInput)
        {
            return ((cInput < '0' || cInput > '9') && ((Keys)cInput != Keys.Back) && ((Keys)cInput != Keys.Enter));
        }
        #endregion
    }
}
