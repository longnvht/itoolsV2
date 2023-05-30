using Google.Protobuf.WellKnownTypes;
using itools_source;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using VinamiToolUser.Models;
using VinamiToolUser.Models.Interface;
using VinamiToolUser.Presenters;
using VinamiToolUser.Views.Components;
using VinamiToolUser.Views.Interface;
using static AutoMapper.Internal.ExpressionFactory;

namespace VinamiToolUser.Views
{
    public partial class ManageToolView : Form, IManageToolView
    {
        private const int maxQtyItem = 10;
        private int _crQtyStock;
        private string _modifyState;
        private string _modifyAction;
        private TrayModelManage _currentTray;
        private TempToolModel _currentTool;
        public TrayModelManage CurrentTray 
        { 
            get => _currentTray;
            set
            {
                _currentTray = value;
                TrayName = _currentTray.TrayName;
                ToolCode = _currentTray.ToolCode;
                QuantityTool = _currentTray.QtyStock.ToString();

            }
        }
        public TempToolModel CurrentTool 
        { 
            get => _currentTool;
            set
            { 
                _currentTool = value;
                _crQtyStock = _currentTool.ToolQuantity;
                txtStockQty.Text = _crQtyStock.ToString();
            }
        }
        public string SearchValue { get => txtSearch.Text; set => txtSearch.Text = value; }
        public string TrayName { get => txtTrayNumber.Text; set => txtTrayNumber.Text = value; }
        public string ToolCode { get => txtToolCode.Text; set => txtToolCode.Text = value; }
        public string QuantityTool 
        { 
            get => txtQty.Text;
            set
            {
                txtQty.Text = value;
                DisplayTrayAction(value);
            }
        }

        public string ModifyState 
        { 
            get => _modifyState;
            set
            {
                _modifyState = value;
                StateModifyDisplay(value);
            }
        }
        public string ViewAction
        {
            get => _modifyAction;
            set
            {
                _modifyAction = value;
                StateActionDisplay(value);
            }
        }

        public ManagerToolPresenter Presenter { private get; set; }

        public ManageToolView()
        {
            InitializeComponent();
            AssignEvent();
        }

        public event EventHandler TraySelected;
        public event EventHandler ToolSelected;
        public event EventHandler GetCurrentToolStock;
        public event EventHandler AddingTool;
        public event EventHandler TakeOutTool;
        public event EventHandler AddNewTool;
        public event EventHandler Search;

        private void AssignEvent()
        {
            this.Load += ManagerToolViewLoad;
            lstTray.ItemClick += SelectTray;
            btnPutIn.Click += (s,e) => 
            { 
                ModifyState = "PutIn";
                ViewAction = "Modify";
                GetCurrentToolStock?.Invoke(this, EventArgs.Empty);
            };
            btnTakeOut.Click += (s, e) => 
            { 
                ModifyState = "TakeOut";
                ViewAction = "Modify";
                GetCurrentToolStock?.Invoke(this, EventArgs.Empty);
            };
            btnAddNew.Click += (s, e) => 
            { 
                ModifyState = btnPutIn.Tag.ToString();
                ViewAction = "ShowTool";
            };
            lstTool.ItemClick += SelectToolChange;
            btnSelect.Click += (s, e) =>
            {
                ViewAction = "Modify";
                ModifyState = "AddNew";
                txtToolCode.Text = CurrentTool.ToolCode;
            };
            btnCancelSelect.Click += (s, e) =>
            {
                ViewAction = "SelectTray";
            };
            btnCancel.Click += (s, e) =>
            {
                ViewAction = "";
                txtToolCode.Text = CurrentTray.ToolCode;
            };
            txtModifyQty.TextChanged += (s, e) =>
            {
                bool result = true;
                var text = txtModifyQty.Text;
                if (String.IsNullOrEmpty(text))
                {
                    erpModifyQuantity.SetError(txtModifyQty, "Giá trị không được để trống!");
                    result = false;
                }

                else
                {
                    int.TryParse(text, out int value);
                    result = CheckValueForModifyState(ModifyState, value);
                }
                if(result) btnSave.Enabled = true;
                else btnSave.Enabled = false;
            };
        }

        private bool CheckValueForModifyState(string state, int value)
        {
            erpModifyQuantity.Clear();
            var result = true;
            int.TryParse(QuantityTool, out int qty);
            switch (state)
            {
                case "PutIn":
                    {
                        if (value > maxQtyItem - qty||value >_crQtyStock)
                        {
                            erpModifyQuantity.SetError(txtModifyQty, "Số tool cho vào vượt quá số lượng tồn kho\n" +
                                                                     " hoặc vượt quá số lượng có thể chứa của Tray");
                            result = false;
                        }
                    }
                    break;
                case "TakeOut":
                    {
                        if (value > qty) 
                        {
                            erpModifyQuantity.SetError(txtModifyQty, "Số lượng vượt quá số tool có trên tray!");
                            result = false;
                        }
                        
                    }
                    break;
                case "AddNew":
                    {
                        if (value > maxQtyItem - qty || value > _crQtyStock)
                        {
                            erpModifyQuantity.SetError(txtModifyQty, "Số tool cho vào vượt quá số lượng tồn kho\n" +
                                                                     " hoặc vượt quá số lượng có thể chứa của Tray");
                            result = false;
                        }
                    }
                    break;
            }
            return result;
        }

        private void SelectToolChange(object sender, ListButton.ItemClickEventArgs e)
        {
            ViewAction = "SelectTool";
            CurrentTool = e.Item as TempToolModel;
        }

        private void StateModifyDisplay(string state)
        {
            lblModify.Text = state + " Qty";
            switch (state)
            {
                case "PutIn":
                    {
                        ShowModify(true);
                    }
                    break;
                case "TakeOut":
                    {
                        ShowModify(true);
                    }
                    break;
                case "AddNew":
                    {
                        ShowModify(true);
                        pnToolAction.Visible = false;
                    }
                    break;
                default:
                    {
                        ShowModify(false);
                    }
                    break;
            }
            
        }
        private void StateActionDisplay(string state)
        {
            switch (state)
            {
                case "SelectTray":
                    {
                        grbTrayList.Enabled = true;
                        pnTrayAction.Visible = true;
                        grbToolList.Visible = false;
                        pnToolAction.Visible = false;
                        StateModifyDisplay(null);
                    }
                    break;
                case "ShowTool":
                    {
                        grbTrayList.Enabled = false;
                        pnTrayAction.Visible = false;
                        grbToolList.Visible = true;
                        pnToolAction.Visible = false;
                        StateModifyDisplay(null);
                    }
                    break;
                case "SelectTool":
                    {
                        grbTrayList.Enabled = false;
                        pnTrayAction.Visible = false;
                        grbToolList.Visible = true;
                        pnToolAction.Visible = true;
                        StateModifyDisplay(null);
                    }
                    break;
                case "Modify":
                    {
                        grbTrayList.Enabled = false;
                        pnTrayAction.Visible = false;
                        grbToolList.Visible = false;
                        pnToolAction.Visible = false;
                        StateModifyDisplay(ModifyState);
                    }
                    break;
                default:
                    {
                        grbTrayList.Enabled = true;
                        pnTrayAction.Visible= false;
                        grbToolList.Visible= false;
                        pnToolAction.Visible= false;
                        StateModifyDisplay(null);
                    }
                    break;
            }
        }
        private void ShowModify(bool status)
        {
            lblModify.Visible = status;
            lblStock.Visible = status;
            txtModifyQty.Visible = status;
            txtStockQty.Visible = status;
        }
        private void DisplayTrayAction(string value)
        {
            int.TryParse(value, out int qty);
            if (0 < qty)
            {
                btnAddNew.Visible = false;
                btnTakeOut.Visible = true;
                if (qty < maxQtyItem) { btnPutIn.Visible = true; }
                else btnPutIn.Visible = false;
            }
            else
            {
                btnAddNew.Visible = true;
                btnTakeOut.Visible = false;
                btnPutIn.Visible = true;
            }
        }

        private void SelectTray(object sender, ListButton.ItemClickEventArgs e)
        {
            ViewAction = "SelectTray";
            TrayModelManage tray = e.Item as TrayModelManage;
            CurrentTray = tray;
        }

        private void ManagerToolViewLoad(object sender, EventArgs e)
        {
            ViewAction = null;
            ModifyState = null;
            IManageToolRepository repository = UnityDI.container.Resolve<IManageToolRepository>();
            Presenter = new ManagerToolPresenter(this, repository);
        }

        public void SetTrayBindingSource(BindingSource trayList)
        {
            lstTray.DataSource = trayList;
        }

        public void SetToolBindingSource(BindingSource toolList)
        {
            lstTool.DataSource = toolList;
        }
    }
}
