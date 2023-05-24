using itools_source.Models.Interface;
using itools_source.Presenter;
using itools_source.Repository;
using itools_source.Views;
using itools_source.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Unity;
using VinamiToolUser.Views;

namespace itools_source.Presenters
{
    public class MainPresenter
    {
        #region Properties - Fields
        private readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(MainPresenter).Name);

        private IMainView _view;
        private IUserAccountRepository _userAccountRepository;

        private IJobView _jobView;
        private IGetToolRepository _getToolRepository;
        private IJobRepository _jobRepository;
        private IPermissionRepository _permissionRepository;
        private IMenuRepository _menuRepository;
        #endregion
        public MainPresenter(IMainView mainView, IUserAccountRepository userAccountRepository)
        {
            _view = mainView;
            _userAccountRepository = userAccountRepository;

            _view.MainView_Load += _mainView_MainView_Load;
            _view.btnPrevious_Click += _mainView_btnPrevious_Click;
            _view.btnNext_Click += _mainView_btnNext_Click;
            _view.btnHome_Click += _mainView_btnHome_Click;
            _view.btnLogOut_Click += _mainView_btnLogOut_Click;
        }

        

        #region Events
        private void _mainView_btnHome_Click(object sender, EventArgs e)
        {
            MainView frmMain = (MainView)sender;
            if (frmMain.MdiChildren.Any())
            {
                if (frmMain.ActiveMdiChild.Name == nameof(MenuView))
                {
                    return;
                }

                var menuPresenter = UnityDI.container.Resolve<MenuPresenter>();
                menuPresenter.Run((MainView)_view);

                _view.strJobNumber = null;
                _view.strOPNumber = null;
                _view.iOPId = null;

                frmMain.lblJobNumber.Visible = false;
                frmMain.lblJobNumberDisplay.Visible = false;
                frmMain.lblOPId.Visible = false;
                frmMain.lblOPIdDisplay.Visible = false;

                ToggleButton(true);
            }
        }

        private void _mainView_btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(
                            () =>
                            {
                                var loginPresenter = UnityDI.container.Resolve<LoginPresenter>();
                                loginPresenter.Run();
                            }));

                t.Start();

                _log.Info("MenuView is out MdiChildren to LoginView.");
                _view.Close();
            }
        }

    private void _mainView_btnNext_Click(object sender, EventArgs e)
        {
            MainView frmMain = (MainView)sender;
            if (frmMain.MdiChildren.Any()) // Check is open form children
            {
                string strFormName = frmMain.ActiveMdiChild.Name;

                if (strFormName != null)
                {
                    switch (strFormName)
                    {
                        case nameof(MenuView):
                            MenuView menuViewTemp = frmMain.ActiveMdiChild as MenuView;
                            if (!menuViewTemp.bCheckButton)
                            {
                                MessageBox.Show("Bạn Chưa Chọn Nút!");
                            }
                            else
                            {
                                if (menuViewTemp.strMenuId != null)
                                {
                                    if (_menuRepository == null)
                                    {
                                        _menuRepository = new MenuRepository();
                                    }
                                    List<string> lstFormId = _menuRepository.GetListFormByMenuId(strMenuId: menuViewTemp.strMenuId).Result.ToList(); // Get list form name.
                                    foreach (var item in lstFormId)
                                    {
                                        /*
                                         * GT -> Get Tool -> JobView
                                         * TM -> Tool Manager -> ToolManagerView
                                         * CS - > Check Stock -> CheckStockView
                                         * ST -> Setting -> ConfigView
                                         */

                                        if (item == nameof(JobView))
                                        {
                                            frmMain.ShowHideJobNumberAndOPId(true);

                                            _jobView = JobView.GetInstance((MainView)_view);
                                            _jobView.SetListOPNumberOPType = OpenOPView;
                                            if (_jobRepository == null)
                                            {
                                                _jobRepository = new JobRepository();
                                            }

                                            var jobPresenter = UnityDI.container.Resolve<JobPresenter>();
                                            jobPresenter.Run(_jobView, _jobRepository);
                                            break;
                                        }
                                        if (item == nameof(ToolManagerView))
                                        {
                                            _view.btnNextEnabled = false;

                                            IToolManagerView toolManagerView = ToolManagerView.GetInstance((MainView)_view);
                                            IToolMachineTrayRepository toolMachineTrayRepository = new ToolMachineTrayRepository();

                                            var toolPresenter = UnityDI.container.Resolve<ToolManagerPresenter>();
                                            toolPresenter.Run(toolManagerView, toolMachineTrayRepository);
                                            break;
                                        }
                                        if (item == nameof(StockView))
                                        {
                                            _view.btnNextEnabled = false;


                                            IStockView stockView = StockView.GetInstance((MainView)_view);
                                            IStockRepository stockViewRepositor = new StockRepository();

                                            var stockPresenter = UnityDI.container.Resolve<StockPresenter>();
                                            stockPresenter.Run(stockView, stockViewRepositor);
                                            break;
                                        }
                                        if (item == nameof(ConfigSettingView))
                                        {
                                            _view.btnNextEnabled = false;

                                            IConfigSettingView configSettingView = ConfigSettingView.GetInstance((MainView)_view);
                                            ICompanyRepository stockRepository = new CompanyRepository();

                                            var configPresenter = UnityDI.container.Resolve<ConfigSettingPresenter>();
                                            configPresenter.Run(configSettingView, stockRepository);
                                            break;
                                         
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("MenuId is null.");
                                }
                            }
                            break;
                        case nameof(JobView):
                            frmMain.ShowHideJobNumberAndOPId(true);
                            IJobView jobView = (JobView)frmMain.ActiveMdiChild;
                            if (string.IsNullOrEmpty(jobView.strJobNumberCurrent) && jobView.iPartIDCurrent == null)
                            {
                                MessageBox.Show("Bạn Chưa Chọn JobNumber, Vui Click Nút JobNumber!");
                            }
                            else
                            {
                                OpenOPView(jobView.lstOPNumberOPType, jobView.strJobNumberCurrent);
                            }
                            break;
                        case nameof(OPView):
                            frmMain.ShowHideJobNumberAndOPId(true);
                            IOPView oPview = (OPView)frmMain.ActiveMdiChild;
                            if (oPview.iOPId == null)
                            {
                                MessageBox.Show("Bạn Chưa Chọn OPNumber, Vui Click Nút OPNumber!");
                            }
                            else
                            {
                                if (oPview.iOPId != null)
                                {
                                    if (oPview.lstOPNumberOPType.ContainsKey(oPview.iOPId))
                                    {
                                        string strOPNumber = oPview.lstOPNumberOPType[oPview.iOPId].Keys.ElementAt(0);
                                        OpenGetToolView(iOPId: oPview.iOPId, strOPNumber: strOPNumber);
                                    }
                                }

                                frmMain.btnNext.Enabled = false;
                            }
                            break;
                    }
                }
            }
            KeyBoard.CloseKeyboard();
        }

        private void _mainView_btnPrevious_Click(object sender, EventArgs e)
        {
            MainView frmMain = (MainView)sender;
            if (frmMain.MdiChildren.Any())
            {
                // 1. Get name active mdichild form is form name in project.
                string strFormName = GetNameFormChlidActive(frmMain.ActiveMdiChild.Name);

                // 2. Set load child form.
                if (strFormName != null)
                {
                    _view.CloseFormChild();
                    _view.btnNextEnabled = true;
                    frmMain.ShowHideJobNumberAndOPId(false);
                    switch (strFormName)
                    {
                        // Login -> Main, Main -> Login
                        case nameof(MenuView):
                            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(
                            () =>
                            {
                                var loginPresenter = UnityDI.container.Resolve<LoginPresenter>();
                                loginPresenter.Run();
                            }));

                            t.Start();

                            _log.Info("MenuView is out MdiChildren to LoginView.");
                            _view.Close();
                            break;
                        case nameof(ToolManagerView):
                        case nameof(StockView):
                        case nameof(ConfigSettingView):
                        case nameof(JobView):
                            var menuPresenter = UnityDI.container.Resolve<MenuPresenter>();
                            menuPresenter.Run((MainView)_view);

                            _view.strJobNumber = null;
                            break;
                        // Get data
                        case nameof(OPView):
                            frmMain.ShowHideJobNumberAndOPId(true);
                            _jobView = JobView.GetInstance((MainView)_view);
                            _jobView.SetListOPNumberOPType = OpenOPView;
                            if (_jobRepository == null)
                            {
                                _jobRepository = new JobRepository();
                            }

                            var jobPresenter = UnityDI.container.Resolve<JobPresenter>();
                            jobPresenter.Run(_jobView, _jobRepository);
                            _view.iOPId = null;
                            break;
                        case nameof(GetToolView):
                            frmMain.ShowHideJobNumberAndOPId(true);
                            IOPView oPView = OPView.GetInstance((MainView)_view);
                            if (_view.lstOPNumberOpType_Main != null)
                            {
                                oPView.lstOPNumberOPType = _view.lstOPNumberOpType_Main;
                            }

                            oPView.GetToolViewAction = OpenGetToolView;
                            if (_getToolRepository == null)
                            {
                                _getToolRepository = new GetToolRepository();
                            }

                            var opPresenter = UnityDI.container.Resolve<OPPresenter>();
                            opPresenter.Run(oPView, _getToolRepository);
                            break;
                    }
                }
            }
            KeyBoard.CloseKeyboard();
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
                if (Program.sessionLogin["Name"] != null && Program.sessionLogin["PermissionId"] != null)
                {
                    _view.strName = Program.sessionLogin["Name"].ToString();
                }

                var menuPresenter = UnityDI.container.Resolve<MenuPresenter>();
                menuPresenter.Run((MainView)_view);
            }

            MainView frmMain = (MainView)sender;
            frmMain.ShowHideJobNumberAndOPId(false);

            _log.Info("Login Success!");
        }
        #endregion

        #region Methods
        public void OpenOPView(Dictionary<int?, Dictionary<string, string>> lstOPNumberOpType, string strJobNumber)
        {
            // 1. Data transmission
            if (_view != null)
            {
                IOPView oPView = OPView.GetInstance((MainView)_view);

                if (oPView != null)
                {
                    if (!string.IsNullOrEmpty(strJobNumber) && !string.IsNullOrWhiteSpace(strJobNumber))
                    {
                        _view.strJobNumber = strJobNumber;
                    }

                    if (lstOPNumberOpType != null)
                    {
                        _view.lstOPNumberOpType_Main = lstOPNumberOpType;
                        oPView.lstOPNumberOPType = lstOPNumberOpType;
                    }

                    oPView.GetToolViewAction = OpenGetToolView;

                    // 2. Close JobView, open OPView.
                    if (_getToolRepository == null)
                    {
                        _getToolRepository = new GetToolRepository();
                    }
                    _view.CloseFormChild();

                    var opPresenter = UnityDI.container.Resolve<OPPresenter>();
                    opPresenter.Run(oPView, _getToolRepository);

                    _log.Info("Form close: " + typeof(JobView).Name + ", Open: " + typeof(OPView).Name);
                }
                else
                {
                    _log.Error("oPView is null");
                }
            }
            else
            {
                _log.Error("_mainView is null.");
            }
        }

        public void OpenGetToolView(int? iOPId, string strOPNumber)
        {
            // 1. Data transmission
            if (_view != null)
            {
                GetToolView getToolView = GetToolView.GetInstance((MainView)_view);

                if (getToolView != null)
                {
                    if (iOPId != null)
                    {
                        _view.iOPId = iOPId;
                        getToolView.iOPId = _view.iOPId;
                    }
                    else
                    {
                        _log.Error("iOPId is null.");
                    }

                    if (!string.IsNullOrEmpty(_view.strJobNumber) && !string.IsNullOrWhiteSpace(_view.strJobNumber))
                    {
                        getToolView.strJobNumber = _view.strJobNumber;
                    }
                    else
                    {
                        _log.Error("_mainView.strJobNumber is null.");
                    }

                    if (!string.IsNullOrEmpty(strOPNumber) && !string.IsNullOrWhiteSpace(strOPNumber))
                    {
                        getToolView.strOPNumber = strOPNumber;
                    }
                    else
                    {
                        _log.Error("strOPNumber is null.");
                    }

                    getToolView.EnabledButton = ToggleButton;

                    // 2. Close OPView, open GetToolView
                    if (_getToolRepository == null)
                    {
                        _getToolRepository = new GetToolRepository();
                    }
                    _view.CloseFormChild();

                    var getToolPresenter = UnityDI.container.Resolve<GetToolPresenter>();
                    getToolPresenter.Run(getToolView, _getToolRepository);

                    _log.Info("Form close: " + typeof(OPView).Name + ", Open: " + typeof(GetToolView).Name);
                }
                else
                {
                    _log.Error("getToolView is null");
                }
            }
            else
            {
                _log.Error("_mainView is null");
            }
        }

        public void ToggleButton(bool bToggle)
        {
            _view.btnNextEnabled = bToggle;
        }

        public string GetNameFormChlidActive(string strNameActive) // Get name form child active
        {
            foreach (var item in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (typeof(Form).IsAssignableFrom(item))
                {
                    if (strNameActive == item.Name)
                    {
                        return strNameActive;
                    }
                }
            }
            return null;
        }

        public void Run()
        {
            if (!_view.GetIsDisposed())
            {
                Application.Run(_view as MainView);
            }
        }
        #endregion


        private void ShowChildView(object sender, EventArgs e)
        {
            _view.CloseFormChild();
            Button btn = sender as Button;
            string viewName = btn.Tag.ToString();
            if (viewTypes.ContainsKey(viewName))
            {
                Type viewType = viewTypes[viewName];
                MethodInfo getInstanceMethod = viewType.GetMethod("GetInstance", new Type[] { typeof(Form) });
                object[] args = new object[] { _view };
                Form childView = (Form)getInstanceMethod.Invoke(viewType, args);
                childView.Show();
            }
        }

        private Dictionary<string, Type> viewTypes = new Dictionary<string, Type>()
        {
            { "ToolView", typeof(GetToolView) },
            { "JobView", typeof(JobViewNew) },
            { "SettingView", typeof(ConfigSettingView) }
        };
    }
}
