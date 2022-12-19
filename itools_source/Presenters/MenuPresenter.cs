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
        private Dictionary<int?, Dictionary<string, string>> _lstOPNumberOpType_Main = null;
        #endregion

        #region Events
        private void _menuView_MenuView_Load(object sender, EventArgs e)
        {
            if (Program.sessionLogin["UserName"] != null)
            {
                MenuView frm = (MenuView)sender;
                _menuView.lstMenu = _menuRepository.GetListMenuByUserLogin(Program.sessionLogin["UserName"].ToString()).Result.ToList();

                if (_menuView.lstMenu != null)
                {
                    foreach (var item in _menuView.lstMenu)
                    {
                        Guna2GradientTileButton btn = new Guna2GradientTileButton
                        {
                            ForeColor = Color.Navy,
                            FillColor = Color.DarkSeaGreen,
                            FillColor2 = Color.DarkSeaGreen,
                            Size = new Size(150, 150),
                            Margin = new Padding(10),
                            BorderRadius = 20,
                            Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                            Text = item.strMenuDescription,
                            Tag = item.strMenuId
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
                        IJobView jobView = JobView.GetInstance((MainView)_mainView);
                        jobView.SetListOPNumberOPType = OpenOPView;
                        _jobRepository = new JobRepository();
                        new JobPresenter(jobView, _jobRepository);
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
                        IStockView stockView = StockView.GetInstance((MainView)_mainView);
                        IStockRepository stockRepository = new StockRepository();
                        new StockPresenter(stockView, stockRepository);
                        break;
                    }
                    if (item == nameof(ConfigSettingView))
                    {
                        IConfigSettingView configSettingView = ConfigSettingView.GetInstance((MainView)_mainView);
                        ICompanyRepository companyRepository = new CompanyRepository();
                        new ConfigSettingPresenter(configSettingView, companyRepository);
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

        public void OpenOPView(Dictionary<int?, Dictionary<string, string>> lstOPNumberOpType)
        {
            // 1. Data transmission
            IOPView oPView = OPView.GetInstance((MainView)_mainView);
            _lstOPNumberOpType_Main = lstOPNumberOpType;
            oPView.lstOPNumberOPType = lstOPNumberOpType;
            oPView.GetToolViewAction = OpenGetToolView;

            // 2. Close JobView, open OPView.
            _mainView.CloseFormChild();
            if (_getToolRepository == null)
            {
                _getToolRepository = new GetToolRepository();
            }
            new OPPresenter(oPView, _getToolRepository);

            _log.Info("Form close: " + typeof(JobView).Name + ", Open: " + typeof(OPView).Name);
        }

        public void OpenGetToolView(int? iOPId)
        {
            // 1. Data transmission
            GetToolView getToolView = GetToolView.GetInstance((MainView)_mainView);
            getToolView.iOPId = iOPId;
            getToolView.EnabledButton = ToggleButton;

            // 2. Close OPView, open GetToolView
            _mainView.CloseFormChild();
            if (_getToolRepository == null)
            {
                _getToolRepository = new GetToolRepository();
            }
            new GetToolPresenter(getToolView, _getToolRepository);

            _log.Info("Form close: " + typeof(OPView).Name + ", Open: " + typeof(GetToolView).Name);
        }

        public void ToggleButton(bool bToggle)
        {
            _mainView.btnNextEnabled = bToggle;
        }
        #endregion
    }
}
