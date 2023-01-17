using Guna.UI2.WinForms;
using itools_source.Models.Interface;
using itools_source.Repository;
using itools_source.Views;
using itools_source.Views.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Unity;

namespace itools_source.Presenters
{
    public class MenuPresenter
    {
        public MenuPresenter(IMenuView menuView, IMenuRepository menuRepository, IMainView mainView)
        {
            _menuView = menuView;
            _menuRepository = menuRepository;
            _mainView = mainView;

            // Event handler methods to view events.
            _menuView.MenuView_Load += _menuView_MenuView_Load;

            _menuView.Show();
        }

        #region Fields
        private readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(MenuPresenter).Name);

        private readonly IMenuView _menuView;
        private readonly IMenuRepository _menuRepository;

        private IMainView _mainView;
        private IGetToolRepository _getToolRepository;
        private IJobRepository _jobRepository;
        #endregion

        #region Events
        private void _menuView_MenuView_Load(object sender, EventArgs e)
        {
            if (Program.sessionLogin["UserName"] != null)
            {
                if (_menuRepository.GetListMenuByUserLogin(Program.sessionLogin["UserName"].ToString()).Result == null)
                {
                    MessageBox.Show("Tài Khoản Chưa Được Phân Quyền.");
                    _log.Error("Unauthorized Account: " + Program.sessionLogin["UserName"]);
                    return;
                }

                MenuView frm = (MenuView)sender;
                _menuView.lstMenu = _menuRepository.GetListMenuByUserLogin(Program.sessionLogin["UserName"].ToString()).Result.ToList();

                if (_menuView.lstMenu != null)
                {
                    foreach (var item in _menuView.lstMenu)
                    {
                        Guna2GradientTileButton btn = new Guna2GradientTileButton
                        {
                            ForeColor = Color.FromArgb(241, 241, 242),
                            FillColor = Color.FromArgb(25, 149, 173),
                            FillColor2 = Color.FromArgb(25, 149, 173),
                            Size = new Size(100, 100),
                            Margin = new Padding(10),
                            BorderRadius = 20,
                            Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                            Text = item.strMenuDescription,
                            Tag = item.strMenuId,
                            Dock = DockStyle.None
                        };
                        btn.DoubleClick += btnItem_DoubleClick;
                        btn.Click += btnItem_Click;

                        frm.flpMenu.Controls.Add(btn);
                    }
                }
            }
        }
        #endregion

        #region Methods
        private void btnItem_DoubleClick(object sender, EventArgs e)
        {
            Guna2GradientTileButton btn = (Guna2GradientTileButton)sender;
            if (btn != null && btn.Tag != null) // Check button is null
            {
                _menuView.strMenuId = btn.Tag.ToString();

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
                        _menuView.ShowHideJobNumberAndOPId(true);
                        
                        IJobView jobView = JobView.GetInstance((MainView)_menuView.GetMdiParent());
                        jobView.SetListOPNumberOPType = OpenOPView;
                        _jobRepository = new JobRepository();

                        var jobPresenter = ConfigUnity.unityContainer.Resolve<JobPresenter>();
                        jobPresenter.Run(jobView, _jobRepository);
                        
                        break;
                    }
                    if (item == nameof(ToolManagerView))
                    {
                        _menuView.ShowHideJobNumberAndOPId(false);
                        (_menuView.GetMdiParent() as MainView).btnNextEnabled = false;

                        IToolManagerView toolManagerView = ToolManagerView.GetInstance((MainView)_menuView.GetMdiParent());
                        IToolMachineTrayRepository toolMachineTrayRepository = new ToolMachineTrayRepository();

                        var toolPresenter = ConfigUnity.unityContainer.Resolve<ToolManagerPresenter>();
                        toolPresenter.Run(toolManagerView, toolMachineTrayRepository);
                        break;
                    }
                    if (item == nameof(StockView))
                    {
                        _menuView.ShowHideJobNumberAndOPId(false);
                        (_menuView.GetMdiParent() as MainView).btnNextEnabled = false;

                        var stockPresenter = ConfigUnity.unityContainer.Resolve<StockPresenter>();
                        stockPresenter.Run((MainView)_menuView.GetMdiParent());
                        break;
                    }
                    if (item == nameof(ConfigSettingView))
                    {
                        _menuView.ShowHideJobNumberAndOPId(false);
                        (_menuView.GetMdiParent() as MainView).btnNextEnabled = false;

                        var configPresenter = ConfigUnity.unityContainer.Resolve<ConfigSettingPresenter>();
                        configPresenter.Run((MainView)_menuView.GetMdiParent());
                        break;
                    }
                }
            }
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            Guna2GradientTileButton btn = (Guna2GradientTileButton)sender;
            _menuView.SetCheckedButton(btn.Text);
            if (btn.Checked == true)
            {
                btn.Checked = false;
                _menuView.bCheckButton = false;
                _menuView.strMenuId = null;
            }
            else
            {
                btn.Checked = true;
                _menuView.bCheckButton = true;
                if (btn.Tag != null)
                {
                    _menuView.strMenuId = btn.Tag.ToString();
                }
            }
        }

        public void OpenOPView(Dictionary<int?, Dictionary<string, string>> lstOPNumberOpType, string strJobNumber)
        {
            if (_menuView.GetMdiParent() == null)
            {
                _log.Error("_mainView is Null");
                return;
            }

            // 1. Data transmission
            IOPView oPView = OPView.GetInstance((MainView)_menuView.GetMdiParent());

            if (lstOPNumberOpType != null)
            {
                _mainView.lstOPNumberOpType_Main = lstOPNumberOpType;
                oPView.lstOPNumberOPType = lstOPNumberOpType;
            }
            else
            {
                _log.Error("lstOPNumberOpType is null.");
            }

            if (strJobNumber != null)
            {
                _mainView.strJobNumber = strJobNumber;
            }
            else
            {
                _log.Error("strJobNumber is null.");
            }

            oPView.GetToolViewAction = OpenGetToolView;

            // 2. Close JobView, open OPView.
            _mainView.CloseFormChild();
            if (_getToolRepository == null)
            {
                _getToolRepository = new GetToolRepository();
            }
            var opPresenter = ConfigUnity.unityContainer.Resolve<OPPresenter>();
            opPresenter.Run(oPView, _getToolRepository);

            _log.Info("Form close: " + typeof(JobView).Name + ", Open: " + typeof(OPView).Name);
        }

        public void OpenGetToolView(int? iOPId, string strOPNumber)
        {
            // 1. Data transmission
            if (_menuView.GetMdiParent() != null)
            {
                GetToolView getToolView = GetToolView.GetInstance((MainView)_menuView.GetMdiParent());
                if (iOPId != null)
                {
                    _mainView.iOPId = iOPId;
                    getToolView.iOPId = _mainView.iOPId;
                }

                if (!string.IsNullOrEmpty(strOPNumber) && !string.IsNullOrWhiteSpace(strOPNumber))
                {
                    getToolView.strOPNumber = strOPNumber;
                }

                getToolView.strJobNumber = _mainView.strJobNumber;
                getToolView.EnabledButton = ToggleButton;

                // 2. Close OPView, open GetToolView
                _mainView.CloseFormChild();
                if (_getToolRepository == null)
                {
                    _getToolRepository = new GetToolRepository();
                }
                
                var getToolPresenter = ConfigUnity.unityContainer.Resolve<GetToolPresenter>();
                getToolPresenter.Run(getToolView, _getToolRepository);

                _log.Info("Form close: " + typeof(OPView).Name + ", Open: " + typeof(GetToolView).Name);
            }
            else
            {
                _log.Error("_mainView is Null");
            }
        }

        public void ToggleButton(bool bToggle)
        {
            (_menuView.GetMdiParent() as MainView).btnNextEnabled = bToggle;
        }

        public void Run(Form parentContainer)
        {
            if (_menuView != null)
            {
                _menuView.SetMdiParent((MainView)parentContainer);
            }
            else
            {
                _log.Error("_menuView is null.");
            }
        }
        #endregion
    }
}
