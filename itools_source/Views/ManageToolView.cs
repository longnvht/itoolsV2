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
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Unity;
using VinamiToolUser.Models;
using VinamiToolUser.Models.Interface;
using VinamiToolUser.Presenters;
using VinamiToolUser.Views.Components;
using VinamiToolUser.Views.Interface;
using static System.Net.Mime.MediaTypeNames;

namespace VinamiToolUser.Views
{
    public partial class ManageToolView : Form, IManageToolView
    {
        private static log4net.ILog _logger = log4net.LogManager.GetLogger(typeof(ManageToolView).Name);
        private static ManageToolView _instance;
        private const int maxQtyItem = 11;
        private int _newQty;
        private string _searchType;
        private string _log;
        private string _modifyState;
        private string _modifyAction;
        private IMainView _mainView;
        private TrayModelManage _currentTray;
        private TempToolModel _currentTool;

        #region Properties
        public TrayModelManage CurrentTray 
        { 
            get => _currentTray;
            set
            {
                _currentTray = value;
                if(value != null)
                {
                    TrayName = _currentTray.TrayName;
                    ToolCode = _currentTray.ToolCode;
                    QuantityTool = _currentTray.QtyStock.ToString();
                }
            }
        }
        public TempToolModel CurrentTool 
        { 
            get => _currentTool;
            set
            { 
                _currentTool = value;
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

        public int NewQty
        {
            get => _newQty;
            set
            {
                _newQty = value;
                if(value < 0)  lblNewQty.Text = ""; 
                else lblNewQty.Text = "New Qty: " + value.ToString();
            }
        }

        public ManagerToolPresenter Presenter { private get; set; }
        public string SearchType 
        { 
            get => _searchType;
            set
            {
                _searchType = value;
                if (String.IsNullOrEmpty(value)) { btnSearch.Enabled = false; }
                else
                {
                    btnSearch.Enabled = true;
                    txtSearch.PlaceholderText = "Search " + value;
                }
            }
        }

        public string Log
        { 
            get => _log;
            set
            {
                _log = value; 
                if (!String.IsNullOrEmpty(value)) { ShowLog(rtbLog, value, Color.Blue, true); }
            }
        }

        public int ModifyQty { get => Int32.Parse(txtModifyQty.Text); set => txtModifyQty.Text = value.ToString(); }
        public UserAccount UserLogin { get => _mainView.UserLogin;}

        public MachineModel CurrentMachine => _mainView.CurrentMachine;

        public MachineConfigModel CurrentConfig => _mainView.MachineConfig;

        #endregion

        #region Methods
        public ManageToolView()
        {
            InitializeComponent();
            AssignEvent();
        }
        public static ManageToolView GetInstance(Form parentContainer)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                //instance = new ToolView();
                _instance = UnityDI.container.Resolve<IManageToolView>() as ManageToolView;
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
                GetStockToolList?.Invoke(this, EventArgs.Empty);
            };
            lstTool.ItemClick += SelectToolChange;
            btnSelect.Click += (s, e) =>
            {
                ModifyState = "AddNew";
                ViewAction = "Modify";
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
                KeyBoard.CloseKeyboard();
            };
            txtModifyQty.TextChanged += CheckInpuValue;
            txtModifyQty.MouseClick += (s, e) => { ShowKeyboard(true); };
            txtSearch.MouseClick += (s, e) => { ShowKeyboard(false); };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    KeyBoard.CloseKeyboard();
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            btnSave.Click += (s,e) => 
            {
                KeyBoard.CloseKeyboard();
                Log = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "- Update Transaction To Database!";
                if(ModifyState == "AddNew")
                {
                    AddNewToolEvent?.Invoke(this, EventArgs.Empty);
                }
                else UpdateModifyEvent?.Invoke(this, EventArgs.Empty); 
            };
            txtModifyQty.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    KeyBoard.CloseKeyboard();
                    Log = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "- Update Transaction To Database!";
                    if (ModifyState == "AddNew")
                    {
                        AddNewToolEvent?.Invoke(this, EventArgs.Empty);
                    }
                    else UpdateModifyEvent?.Invoke(this, EventArgs.Empty);
                }
            };
        }
        private void ShowLog(RichTextBox box, string text, Color color, bool AddNewLine = false)
        {
            _logger.Info(text);
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

        private void ShowKeyboard(bool numType)
        {
            var Keyboard = KeyBoard.GetInstance();
            Keyboard.isNumeric = numType;
            int x = 0;
            //int x = (Screen.PrimaryScreen.Bounds.Right - Keyboard.Width) / 2;
            int y = Screen.PrimaryScreen.Bounds.Bottom - Keyboard.Height;
            Keyboard.Show();
            Keyboard.Location = new Point(x, y);
        }

        private void CheckInpuValue(object sender, EventArgs e)
        {
            bool result = true;
            NewQty = -1;
            lblErrorProvider.Text = "";
            txtModifyQty.BorderColor = Color.FromArgb(213, 218, 223);
            var value = txtModifyQty.Text;
            result = CheckValueForModifyState(ModifyState, value);
            if (result) btnSave.Enabled = true;
            else
            {
                btnSave.Enabled = false;
            }
        }

        private bool CheckValueForModifyState(string state, string value)
        {
            var result = true;
            if (String.IsNullOrEmpty(value))
            {
                lblErrorProvider.Text = "Giá trị không được để trống!";
                result = false;
                return result;
            }
            int.TryParse(QuantityTool, out int qty);
            int.TryParse(value, out int actionQty);
            if (actionQty == 0) 
            {
                txtModifyQty.BorderColor = Color.Red;
                lblErrorProvider.Text = "Số lượng thao tác phải khác không";
                result = false;
                return result;
            }
            switch (state)
            {
                case "PutIn":
                    {
                        if (actionQty > maxQtyItem - qty)
                        {
                            txtModifyQty.BorderColor = Color.Red;
                            lblErrorProvider.Text = "Số tool cho vượt quá số lượng có thể chứa của Tray";
                            result = false;
                        }
                        else
                        {
                            NewQty = qty + actionQty;
                        }
                    }
                    break;
                case "TakeOut":
                    {
                        if (actionQty > qty)
                        {
                            txtModifyQty.BorderColor = Color.Red;
                            lblErrorProvider.Text = "Số lượng vượt quá số tool có trên tray!";
                            result = false;
                        }
                        else
                        {
                            NewQty = qty - actionQty;
                        }

                    }
                    break;
                case "AddNew":
                    {
                        if (actionQty > maxQtyItem - qty)
                        {
                            txtModifyQty.BorderColor = Color.Red;
                            lblErrorProvider.Text = "Số tool cho vào vượt quá số lượng có thể chứa của Tray";
                            result = false;
                        }
                        else
                        {
                            NewQty = qty + actionQty;
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
            btnSave.Enabled = false;
            if (state == null) ShowModify(false);
            else
            {
                ShowModify(true);
                lblModify.Text = state + " Qty";
                txtModifyQty.Text = "";
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
                        tblCompleteAction.Visible = true;
                        StateModifyDisplay(null);
                        SearchType = "Tray";
                        SearchValue = "";
                    }
                    break;
                case "ShowTool":
                    {
                        grbTrayList.Enabled = false;
                        pnTrayAction.Visible = false;
                        grbToolList.Visible = true;
                        pnToolAction.Visible = false;
                        tblCompleteAction.Visible = true;
                        StateModifyDisplay(null);
                        SearchType = "Tool";
                        SearchValue = "";
                    }
                    break;
                case "SelectTool":
                    {
                        grbTrayList.Enabled = false;
                        pnTrayAction.Visible = false;
                        grbToolList.Visible = true;
                        pnToolAction.Visible = true;
                        tblCompleteAction.Visible = true;
                        StateModifyDisplay(null);
                        SearchType = "Tool";
                        SearchValue = "";
                    }
                    break;
                case "Modify":
                    {
                        grbTrayList.Enabled = false;
                        pnTrayAction.Visible = false;
                        grbToolList.Visible = false;
                        pnToolAction.Visible = false;
                        tblCompleteAction.Visible = true;
                        StateModifyDisplay(ModifyState);
                        SearchType = "";
                        SearchValue = "";
                    }
                    break;
                default:
                    {
                        grbTrayList.Enabled = true;
                        pnTrayAction.Visible= false;
                        grbToolList.Visible= false;
                        pnToolAction.Visible= false;
                        tblCompleteAction.Visible = false;
                        StateModifyDisplay(null);
                        SearchType = "Tray";
                    }
                    break;
            }
        }
        private void ShowModify(bool status)
        {
            lblModify.Visible = status;
            txtModifyQty.Visible = status;
            lblErrorProvider.Visible = status;
            lblNewQty.Visible = status;
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
            _mainView = MainView.GetInstance();
            _mainView.PrevView = "Menu";
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
        #endregion

        #region Event
        public event EventHandler TraySelected;
        public event EventHandler GetStockToolList;
        public event EventHandler UpdateModifyEvent;
        public event EventHandler AddNewToolEvent;
        public event EventHandler SearchEvent;
        #endregion
    }
}
