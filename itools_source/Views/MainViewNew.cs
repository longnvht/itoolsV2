using itools_source;
using itools_source.Models;
using itools_source.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Unity;
using VinamiToolUser.Models;
using VinamiToolUser.Utils;
using VinamiToolUser.Views.Interface;

namespace VinamiToolUser.Views
{
    public partial class MainViewNew : Form, IMainViewNew
    {
        private UserAccount _userLogin;
        private JobModelNew _currentJob;
        private OPModel _currentOP;
        private ToolModel _currentTool;
        private TrayModel _currentTray;
        private string _currentView;
        private string _tempView;
        private string _prevView;
        private static MainViewNew instance;

        public event EventHandler GotoNextView;

        public MainViewNew()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        public static MainViewNew GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                //instance = new ToolView();
                instance = UnityDI.container.Resolve<IMainViewNew>() as MainViewNew;
            }
            return instance;
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnHome.Click += (s, e) => { ReturnHome(); };
            btnNext.Click += (s,e) => { AssignCurentView(); };
            btnPrev.Click += (s, e) => 
            {
                CurrentView = PrevView; 
            };
            this.Load += MainViewLoad;
            btnClose.Click += (s, e) => { };
            btnClose.Click += (s, e) => { Application.Exit(); };
        }

        private void MainViewLoad(object sender, EventArgs e)
        {
            UserLogin = CommonValue.UserLogin;
            ReturnHome();
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
                txtUserName.Text = _userLogin.strNameStaff;
            } 
        }
        public JobModelNew CurrentJob 
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
                txtCurrentView.Text = _currentView;
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
        

        public void CloseChildView()
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
        }

        public void OpenChildView()
        {
            CloseChildView();
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
            { "Test", typeof(TestView) },
            { "Menu", typeof(MenuViewNew) },
            { "Select Job", typeof(JobViewNew) },
            { "Select Op", typeof(OpViewNew) },
            { "Setting", typeof(ConfigSettingView) },
            { "GetToolView", typeof(GetToolViewNew) },
            { "ManagerTool", typeof(ManageToolView) }
        };
    }
}
