using itools_source.Models;
using itools_source.Models.Interface;
using itools_source.Presenter;
using itools_source.Repository;
using itools_source.Views;
using itools_source.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace itools_source.Presenters
{
    public class MainPresenter
    {
        public MainPresenter(IMainView mainView, IUserAccountRepository userAccountRepository)
        {
            this._mainView = mainView;
            _userAccountRepository = userAccountRepository;

            this._mainView.MainView_Load += _mainView_MainView_Load;
            this._mainView.btnPrevious_Click += _mainView_btnPrevious_Click;
            this._mainView.btnNext_Click += _mainView_btnNext_Click;
        }

        #region Properties - Fields
        log4net.ILog _log = log4net.LogManager.GetLogger(typeof(MainPresenter).Name);

        private IMainView _mainView;
        private IUserAccountRepository _userAccountRepository;
        private IGetToolRepository _getToolRepository;
        private IPermissionRepository _permissionRepository;
        private Dictionary<int?, Dictionary<string, string>> _lstOPNumberOpType_Main = null;
        #endregion

        #region Events
        private void _mainView_btnNext_Click(object sender, EventArgs e)
        {
            MainView frmMain = (MainView)sender;
            if (frmMain.MdiChildren.Any()) // Check is open form children
            {
                string strFormName = frmMain.MdiChildren[0].Name; // Get form name.
                switch (strFormName)
                {
                    case nameof(JobView):
                        IJobView jobView = (JobView)frmMain.MdiChildren[0];
                        if (string.IsNullOrEmpty(jobView.strJobNumberCurrent) && jobView.iPartIDCurrent == null)
                        {
                            MessageBox.Show("Bạn Chưa Chọn JobNumber, Vui Click Nút JobNumber!");
                        }
                        else
                        {
                            OpenOPView(jobView.lstOPNumberOPType);
                        }
                        break;
                    case nameof(OPView):
                        IOPView oPview = (OPView)frmMain.MdiChildren[0];
                        if (oPview == null)
                        {
                            MessageBox.Show("Bạn Chưa Chọn OPNumber, Vui Click Nút OPNumber!");
                        }
                        else
                        {
                            OpenGetToolView(oPview.iOPId);
                        }
                        break;
                    case nameof(GetToolView):
                        break;
                }
            }
        }

        private void _mainView_btnPrevious_Click(object sender, EventArgs e)
        {
            MainView frmMain = (MainView)sender;
            if (frmMain.MdiChildren.Any())
            {
                string strFormName = frmMain.MdiChildren[0].Name;

                frmMain.MdiChildren[0].Close();

                switch (strFormName)
                {
                    // Login -> Main, Main -> Login
                    case nameof(ToolManagerView):
                    case nameof(JobView):
                        System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(
                        () =>
                        {
                            ILoginView loginView = new Views.LoginView();
                            IUserAccountRepository userAccountRepository = new UserAccountRepository();
                            new LoginPresenter(loginView, userAccountRepository);
                            Application.Run((Form)loginView);
                        }));

                        t.Start();

                        _log.Info("ToolManagerView is out MdiChildren to LoginView.");
                        _mainView.Close();
                        break;
                    // Getdata
                    case nameof(OPView):
                        IJobView jobView = JobView.GetInstance((MainView)_mainView);
                        jobView.SetListOPNumberOPType = OpenOPView;
                        jobView.strJobNumberSearch = "Abc";
                        _getToolRepository = new GetToolRepository();
                        new JobPresenter(jobView, _getToolRepository);
                        break;
                    case nameof(GetToolView):
                        IOPView oPView = OPView.GetInstance((MainView)_mainView);
                        oPView.lstOPNumberOPType = _lstOPNumberOpType_Main;
                        oPView.GetToolViewAction = OpenGetToolView;
                        new OPPresenter(oPView, _getToolRepository);
                        break;
                }
            }
        }

        private async void _mainView_MainView_Load(object sender, EventArgs e)
        {
            if (Program.sessionLogin == null)
            {
                _log.Info("Seesion Login is Null!");
                return;
            }

            List<string> lstForm = await _userAccountRepository.GetListFormByUserLogin(Program.sessionLogin["UserName"].ToString());
            if (lstForm != null)
            {
                _permissionRepository = new PermissionRepository();
                _mainView.strName = Program.sessionLogin["Name"].ToString();
                _mainView.strRole = await _permissionRepository.GetPermissionNameById(Program.sessionLogin["PermissionId"].ToString());

                foreach (var item in lstForm)
                {
                    if (item == typeof(ToolManagerView).Name)
                    {
                        IToolManagerView toolManagerView = ToolManagerView.GetInstance((MainView)_mainView);
                        IToolMachineTrayRepository toolRepository = new ToolMachineTrayRepository();
                        new ToolManagerPresenter(toolManagerView, toolRepository);
                        break;
                    }
                    if (item == typeof(JobView).Name)
                    {
                        IJobView jobView = JobView.GetInstance((MainView)_mainView);
                        jobView.SetListOPNumberOPType = OpenOPView;
                        _getToolRepository = new GetToolRepository();
                        new JobPresenter(jobView, _getToolRepository);
                        break;
                    }
                }
            }
            _log.Info("Login Success!");
        }
        #endregion

        #region Methods
        public void OpenOPView(Dictionary<int?, Dictionary<string, string>> lstOPNumberOpType)
        {
            // 1. Data transmission
            IOPView oPView = OPView.GetInstance((MainView)_mainView);
            _lstOPNumberOpType_Main = lstOPNumberOpType;
            oPView.lstOPNumberOPType = lstOPNumberOpType;
            oPView.GetToolViewAction = OpenGetToolView;

            // 2. Close JobView, open OPView.
            _mainView.CloseFormChild();
            new OPPresenter(oPView, _getToolRepository);

            _log.Info("Form close: " + typeof(JobView).Name + ", Open: " + typeof(OPView).Name);
        }

        public void OpenGetToolView(int? iOPId)
        {
            // 1. Data transmission
            GetToolView getToolView = GetToolView.GetInstance((MainView)_mainView);
            getToolView.iOPId = iOPId;

            // 2. Close OPView, open GetToolView
            _mainView.CloseFormChild();
            new GetToolPresenter(getToolView, _getToolRepository);

            _log.Info("Form close: " + typeof(OPView).Name + ", Open: " + typeof(GetToolView).Name);
        }
        #endregion
    }
}
