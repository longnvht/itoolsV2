using itools_source;
using itools_source.Models;
using itools_source.Views;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Management.Instrumentation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Unity;
using VinamiToolUser.Models;
using VinamiToolUser.Models.Interface;
using VinamiToolUser.Presenters;
using VinamiToolUser.Utils;
using VinamiToolUser.Views.Interface;

namespace VinamiToolUser.Views
{
    public partial class MainView : Form, IMainView
    {
        private MachineModel _currentMachine;
        private UserAccount _userLogin;
        private JobModel _currentJob;
        private OPModel _currentOP;
        private ToolModel _currentTool;
        private TrayModel _currentTray;
        private MachineConfigModel _machineConfig;
        private string _currentView;
        private string _tempView;
        private string _prevView;
        private string _hddSerial;
        private static MainView instance;

        public event EventHandler ConfigChange;

        public MainView()
        {
            InitializeComponent();
            AssignEvents();
        }

        public static MainView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                //instance = new ToolView();
                instance = UnityDI.container.Resolve<IMainView>() as MainView;
            }
            return instance;
        }

        private void AssignEvents()
        {
            btnHome.Click += (s, e) => { ReturnHome(); };
            btnNext.Click += (s,e) => { AssignCurentView(); };
            btnPrev.Click += (s, e) => 
            {
                CurrentView = PrevView; 
            };
            this.Load += MainViewLoad;
            btnLogOut.Click += (s, e) => 
            {
                UserLogin = null;
                CurrentView = "Login";
            };
        }

        private void MainViewLoad(object sender, EventArgs e)
        {
            tsInfo.Visible = false;
            tlpHeader.Visible = false;
            tlpFooter.Visible = false;
            IMainRepository repository = UnityDI.container.Resolve<IMainRepository>();
            Presenter = new MainPresenter(this, repository);
            LoadConfig();
        }

        public void AssignCurentView()
        {
            CurrentView = TempView;
        }

        public UserAccount UserLogin 
        { 
            get => _userLogin;
            set
            {
                _userLogin = value;
                if (_userLogin != null)
                {
                    ReturnHome();
                    txtUserName.Text = _userLogin.FullName;
                }
            } 
        }
        public JobModel CurrentJob 
        { 
            get => _currentJob;
            set 
            { 
                _currentJob = value;
                CommonValue.CurrentJob = value;
                CurrentOP = null;
                CurrentTool = null;
                CurrentTray = null;
                UpdateTitleStatus();
            } 
        }

        public OPModel CurrentOP 
        { 
            get => _currentOP;
            set
            { 
                _currentOP = value;
                CommonValue.CurrentOP = value;
                CurrentTool = null;
                CurrentTray = null;
                UpdateTitleStatus();
            }
        }
        public ToolModel CurrentTool 
        { 
            get => _currentTool;
            set
            {
                _currentTool = value;
                CommonValue.CurrentTool = value;
                CurrentTray = null;
                UpdateTitleStatus();
            }
        }
        public TrayModel CurrentTray 
        { 
            get => _currentTray;
            set
            {
                _currentTray = value;
                CommonValue.CurrentTray = value;
                UpdateTitleStatus();
            }
        }

        public string CurrentView 
        { 
            get => _currentView;
            set
            {
                _currentView = value;
                TempView = null;
                OpenChildView();
            }  
        }
        public string TempView 
        { 
            get => _tempView;
            set 
            {
                _tempView = value;
                if(string.IsNullOrEmpty(value)) btnNext.Enabled = false;
                else btnNext.Enabled = true;
            }
        }
        public string PrevView 
        { 
            get => _prevView;
            set
            {
                _prevView = value;
                if(String.IsNullOrEmpty(value)) btnPrev.Enabled = false;
                else btnPrev.Enabled = true;
            }
        }

        public MachineConfigModel MachineConfig { get => _machineConfig; set => _machineConfig = value; }

        public void LoadConfig()
        {
            MachineConfig = CommonValue.LoadConfig();
            ConfigChange?.Invoke(this, EventArgs.Empty);
        }

        public MachineModel CurrentMachine { get => _currentMachine; set => _currentMachine = value; }
        public MainPresenter Presenter { private get; set; }
        public string HddSerial { get => _hddSerial; set => _hddSerial = value; }
        public string Message 
        { 
            get => tslMessage.Text;
            set 
            { 
                tslMessage.Text = value; 
                if(String.IsNullOrEmpty(value)) { tsInfo.Visible = false; }
                else tsInfo.Visible = true;
            }
        }

        public void CloseChildView()
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
        }

        public void OpenChildView()
        {
            CloseChildView();
            if(UserLogin == null)
            {
                tlpHeader.Visible = false;
                tlpFooter.Visible = false;
            }
            else
            {
                tlpHeader.Visible = true;
                tlpFooter.Visible = true;
                txtCurrentView.Text = _currentView;
            }

            if (viewTypes.ContainsKey(_currentView))
            {
                Type viewType = viewTypes[_currentView];
                MethodInfo getInstanceMethod = viewType.GetMethod("GetInstance", new Type[] { typeof(Form) });
                object[] args = new object[] { this };
                Form childView = (Form)getInstanceMethod.Invoke(viewType, args);
                childView.Show();
            }
        }
        private void UpdateTitleStatus()
        {
            string title = "";
            if (_currentJob != null) { title = "JOB: " + _currentJob.JobNumber; };
            if (_currentOP != null) { title += "/OP: " + _currentOP.OpNumber; };
            if (_currentTool != null) { title += "/TOOL: " + _currentTool.ToolCode; };
            if (_currentTray != null) { title += "/TRAY: " + _currentTray.TrayName; };
            txtStatus.Text = title;
        }
        private void ReturnHome()
        {
            CurrentView = "Menu";
            TempView = null;
        }

        

        private Dictionary<string, Type> viewTypes = new Dictionary<string, Type>()
        {
            { "Login", typeof(LoginView) },
            { "Menu", typeof(MenuView) },
            { "Select Job", typeof(JobView) },
            { "Select Op", typeof(OpView) },
            { "Setting", typeof(SettingView) },
            { "GetToolView", typeof(GetToolView) },
            { "ManagerTool", typeof(ManageToolView) },
            { "StockView", typeof(StockView) }
        };
    }
}
