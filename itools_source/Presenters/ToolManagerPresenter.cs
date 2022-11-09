using Guna.UI2.WinForms;
using itools_source.Models.Interface;
using itools_source.Presenter;
using itools_source.Repository;
using itools_source.Views;
using itools_source.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            _toolManagerView.ClickTakeOut += TakeOut;
            _toolManagerView.ClickAddPlugin += AddPlugin;
            _toolManagerView.ClickAddNew += AddNew;
            _toolManagerView.ClickSave += Save;
            _toolManagerView.Search += Search;
            _toolManagerView.ClickBtnFlowPanel += ClickBtnFlowPanelEvent;
            _toolManagerView.KeyPressOperateQuantity += KeyPressOperateQuantityEvent;
            _toolManagerView.OperateQuantityTextChanged += OperateQuantityTextChangedEvent;

            _toolManagerView.Show();
        }

        #region Properties - Fields
        log4net.ILog _log = log4net.LogManager.GetLogger(typeof(ToolManagerPresenter).Name);
        private int _iCurrentQuantity = 0;

        private IToolManagerView _toolManagerView;
        private IToolRepository _toolRepository;
        #endregion

        #region Method
        private bool CheckInputCharacterLetter(char cInput)
        {
            return ((cInput < '0' || cInput > '9') && ((Keys)cInput != Keys.Back) && ((Keys)cInput != Keys.Enter));
        }
        #endregion

        #region Events
        private void OperateQuantityTextChangedEvent(object sender, EventArgs e)
        {
            int iOperateQuantity = _toolManagerView.iOperateQuantity;
            int iTotalQuantity;

            if (_toolManagerView.cStatusButton == '2') // TakeOut
            {
                if (iOperateQuantity > _iCurrentQuantity)
                {
                    _toolManagerView.iOperateQuantity = 0;
                    _toolManagerView.iTotalQuantity = 0;
                    _toolManagerView.txtOperateQuantityFocus();
                    MessageBox.Show("Tray không đủ số lượng để lấy.");
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
            }
        }

        private void KeyPressOperateQuantityEvent(object sender, KeyPressEventArgs e)
        {
            if (CheckInputCharacterLetter(e.KeyChar))
            {
                e.Handled = true;
                _toolManagerView.ShowMessage("Không Được Nhập Chữ!");
                _toolManagerView.txtOperateQuantityFocus();
            }
        }

        private void ClickBtnFlowPanelEvent(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            string stTrayIndex = btn.Text.Replace(" ", "_");

            _iCurrentQuantity = _toolRepository.GetToolQuantity(stTrayIndex);
            _toolManagerView.iCurrentQuantity = _iCurrentQuantity;
            _toolManagerView.cStatusForm = '5';
            _toolManagerView.SetStatusForm(_toolManagerView.cStatusForm);

            if (_iCurrentQuantity > -1)
            {
                // Set Status Button.
                if (_iCurrentQuantity == 0) // Quantity = 0 | AddNew
                {
                    _toolManagerView.cStatusForm = '0';
                    _toolManagerView.SetStatusForm(_toolManagerView.cStatusForm);
                }
                if (_iCurrentQuantity > 0 && _iCurrentQuantity < 10)  // Quantity > 0 && Quantity < MAX | AddPlugin
                {
                    _toolManagerView.cStatusForm = '1';
                    _toolManagerView.SetStatusForm(_toolManagerView.cStatusForm);
                }
                if (_iCurrentQuantity == 10)  // Quantity = MAX | TakeOut
                {
                    _toolManagerView.cStatusForm = '2';
                    _toolManagerView.SetStatusForm(_toolManagerView.cStatusForm);
                }

                _toolManagerView.toolTrayCurrent = _toolRepository.GetToolByTrayIndex(stTrayIndex, "VM-6");
                if (_toolManagerView.toolTrayCurrent != null)
                {
                    _toolManagerView.iTrayIndex = Convert.ToInt32(btn.Text.Split(' ').GetValue(1));
                    _toolManagerView.strToolCode = _toolManagerView.toolTrayCurrent.strToolCode;
                }
                else
                {
                    _toolManagerView.ShowMessage("Tool is Null in Tray");
                }
            }
            else
            {
                _log.Error("Quantity Error: " + _iCurrentQuantity.ToString());
            }
        }

        private void Search(object sender, EventArgs e)
        {

        }

        private void AddNew(object sender, EventArgs e)
        {
            _toolManagerView.cStatusButton = '0';
            _toolManagerView.SetButtonState(_toolManagerView.cStatusButton);
        }

        private void Save(object sender, EventArgs e)
        {
            if (_toolManagerView.iOperateQuantity == 0)
            {
                _toolManagerView.ShowMessage("Bạn Chưa Nhập Số Lượng!");
            }
            else
            {
                switch (_toolManagerView.cStatusButton)
                {
                    case '0': // AddNew

                        break;
                    case '1': // AddPlugin
                        break;
                    case '2': // TakeOut

                        break;
                }
                
                _toolManagerView.cStatusForm = '4';
                _toolManagerView.SetStatusForm(_toolManagerView.cStatusForm);
            }
        }

        private void AddPlugin(object sender, EventArgs e)
        {
            _toolManagerView.cStatusButton = '1';
            _toolManagerView.SetButtonState(_toolManagerView.cStatusButton);
        }

        private void TakeOut(object sender, EventArgs e)
        {
            _toolManagerView.cStatusButton = '2';
            _toolManagerView.SetButtonState(_toolManagerView.cStatusButton);
        }
        #endregion
    }
}
