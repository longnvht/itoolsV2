﻿using itools_source.Models.Interface;
using itools_source.Presenter;
using itools_source.Repository;
using itools_source.Views;
using itools_source.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        private IMenuView _menuView;
        private IJobView _jobView;
        private IGetToolRepository _getToolRepository;
        private IJobRepository _jobRepository;
        private IPermissionRepository _permissionRepository;
        private IMenuRepository _menuRepository;
        #endregion

        #region Events
        private void _mainView_btnNext_Click(object sender, EventArgs e)
        {
            MainView frmMain = (MainView)sender;
            if (frmMain.MdiChildren.Any()) // Check is open form children
            {
                string strFormName = GetNameFormChlidActive(frmMain.ActiveMdiChild.Name);
                if (strFormName != null)
                {
                    switch (strFormName)
                    {
                        case nameof(MenuView):
                            if (_menuView != null)
                            {
                                if (!_menuView.bCheckButton)
                                {
                                    MessageBox.Show("Bạn Chưa Chọn Nút!");
                                }
                                else
                                {
                                    if (_menuView.strMenuId != null)
                                    {
                                        if (_menuRepository == null)
                                        {
                                            _menuRepository = new MenuRepository();
                                        }
                                        List<string> lstFormId = _menuRepository.GetListFormByMenuId(strMenuId: _menuView.strMenuId).Result.ToList(); // Get list form name.
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
                                                _jobView = JobView.GetInstance((MainView)_mainView);
                                                _jobView.SetListOPNumberOPType = OpenOPView;
                                                _jobRepository = new JobRepository();
                                                new JobPresenter(_jobView, _jobRepository);
                                                break;
                                            }
                                            if (item == nameof(ToolManagerView))
                                            {
                                                _mainView.btnNextEnabled = false;
                                                IToolManagerView toolManagerView = ToolManagerView.GetInstance((MainView)_mainView);
                                                IToolMachineTrayRepository toolRepository = new ToolMachineTrayRepository();
                                                new ToolManagerPresenter(toolManagerView, toolRepository);
                                                break;
                                            }
                                            if (item == nameof(StockView))
                                            {
                                                _mainView.btnNextEnabled = false;
                                                IStockView stockView = StockView.GetInstance((MainView)_mainView);
                                                IStockRepository stockRepository = new StockRepository();
                                                new StockPresenter(stockView, stockRepository);
                                                break;
                                            }
                                            if (item == nameof(ConfigSettingView))
                                            {
                                                _mainView.btnNextEnabled = false;
                                                IConfigSettingView configSettingView = ConfigSettingView.GetInstance((MainView)_mainView);
                                                ICompanyRepository companyRepository = new CompanyRepository();
                                                new ConfigSettingPresenter(configSettingView, companyRepository);
                                                break;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("MenuId is null.");
                                    }
                                }
                            }
                            break;
                        case nameof(JobView):
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
                    _mainView.CloseFormChild();
                    _mainView.btnNextEnabled = true;
                    switch (strFormName)
                    {
                        // Login -> Main, Main -> Login
                        case nameof(MenuView):
                            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(
                            () =>
                            {
                                ILoginView loginView = new Views.LoginView();
                                if (_userAccountRepository == null)
                                {
                                    _userAccountRepository = new UserAccountRepository();
                                }
                                new LoginPresenter(loginView, _userAccountRepository);
                                Application.Run((Form)loginView);
                            }));

                            t.Start();

                            _log.Info("MenuView is out MdiChildren to LoginView.");
                            _mainView.Close();
                            break;
                        case nameof(ToolManagerView):
                        case nameof(JobView):
                            _menuView = MenuView.GetInstance((MainView)_mainView);
                            _menuRepository = new MenuRepository();
                            new MenuPresenter(_menuView, _menuRepository, _mainView);
                            _mainView.strJobNumber = null;
                            break;
                        // Get data
                        case nameof(OPView):
                            _jobView = JobView.GetInstance((MainView)_mainView);
                            _jobView.SetListOPNumberOPType = OpenOPView;
                            if (_jobRepository == null)
                            {
                                _jobRepository = new JobRepository();
                            }
                            new JobPresenter(_jobView, _jobRepository);
                            _mainView.iOPId = null;
                            break;
                        case nameof(GetToolView):
                            IOPView oPView = OPView.GetInstance((MainView)_mainView);
                            if (_mainView.lstOPNumberOpType_Main != null)
                            {
                                oPView.lstOPNumberOPType = _mainView.lstOPNumberOpType_Main;
                            }

                            oPView.GetToolViewAction = OpenGetToolView;
                            if (_getToolRepository == null)
                            {
                                _getToolRepository = new GetToolRepository();
                            }
                            new OPPresenter(oPView, _getToolRepository);
                            break;
                    }
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
                if (Program.sessionLogin["Name"] != null && Program.sessionLogin["PermissionId"] != null)
                {
                    _mainView.strName = Program.sessionLogin["Name"].ToString();
                    _mainView.strRole = await _permissionRepository.GetPermissionNameById(Program.sessionLogin["PermissionId"].ToString());
                }

                _menuView = MenuView.GetInstance((MainView)_mainView);
                IMenuRepository menuRepository = new MenuRepository();
                new MenuPresenter(_menuView, menuRepository, _mainView);
            }
            _log.Info("Login Success!");
        }
        #endregion

        #region Methods
        public void OpenOPView(Dictionary<int?, Dictionary<string, string>> lstOPNumberOpType, string strJobNumber)
        {
            // 1. Data transmission
            if (_mainView != null)
            {
                IOPView oPView = OPView.GetInstance((MainView)_mainView);

                if (oPView != null)
                {
                    if (!string.IsNullOrEmpty(strJobNumber) && !string.IsNullOrWhiteSpace(strJobNumber))
                    {
                        _mainView.strJobNumber = strJobNumber;
                    }

                    if (lstOPNumberOpType != null)
                    {
                        _mainView.lstOPNumberOpType_Main = lstOPNumberOpType;
                        oPView.lstOPNumberOPType = lstOPNumberOpType;
                    }

                    oPView.GetToolViewAction = OpenGetToolView;

                    // 2. Close JobView, open OPView.
                    if (_getToolRepository == null)
                    {
                        _getToolRepository = new GetToolRepository();
                    }
                    _mainView.CloseFormChild();
                    new OPPresenter(oPView, _getToolRepository);

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
            if (_mainView != null)
            {
                GetToolView getToolView = GetToolView.GetInstance((MainView)_mainView);

                if (getToolView != null)
                {
                    if (iOPId != null)
                    {
                        _mainView.iOPId = iOPId;
                        getToolView.iOPId = _mainView.iOPId;
                    }
                    else
                    {
                        _log.Error("iOPId is null.");
                    }

                    if (!string.IsNullOrEmpty(_mainView.strJobNumber) && !string.IsNullOrWhiteSpace(_mainView.strJobNumber))
                    {
                        getToolView.strJobNumber = _mainView.strJobNumber;
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
                    _mainView.CloseFormChild();
                    new GetToolPresenter(getToolView, _getToolRepository);

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
            _mainView.btnNextEnabled = bToggle;
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
        #endregion
    }
}
