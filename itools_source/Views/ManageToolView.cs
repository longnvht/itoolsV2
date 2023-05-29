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

namespace VinamiToolUser.Views
{
    public partial class ManageToolView : Form, IManageToolView
    {
        private const int maxQtyItem = 10;
        private string _modifyState;
        private string _modifyAction;
        private TrayModelManage _currentTray;
        private ToolModel _currentTool;
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
        public ToolModel CurrentTool { get => _currentTool; set => _currentTool = value; }
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

        public ToolMangerPresenter Presenter { private get; set; }

        public ManageToolView()
        {
            InitializeComponent();
            AssignEvent();
        }

        public event EventHandler TraySelected;
        public event EventHandler ToolSelected;
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
            };
            btnTakeOut.Click += (s, e) => 
            { 
                ModifyState = "TakeOut";
                ViewAction = "Modify";
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
            };
        }

        private void SelectToolChange(object sender, ListButton.ItemClickEventArgs e)
        {
            ViewAction = "SelectTool";
            CurrentTool = e.Item as ToolModel;
        }

        private void StateModifyDisplay(string state)
        {
            txtModifyQty.Text = state + " Qty";
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
            lblResult.Visible = status;
            txtModifyQty.Visible = status;
            txtResult.Visible = status;
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
            Presenter = new ToolMangerPresenter(this, repository);
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
