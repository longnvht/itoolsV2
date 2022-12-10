using Guna.UI2.WinForms;
using itools_source.Models.Interface;
using itools_source.Models;
using itools_source.Presenter;
using itools_source.Views.Interface;
using itools_source.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using itools_source.Repository;

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
                        Guna2GradientTileButton btn = new Guna2GradientTileButton();
                        btn.ForeColor = Color.Navy;
                        btn.FillColor = Color.DarkSeaGreen;
                        btn.FillColor2 = Color.DarkSeaGreen;
                        btn.Size = new Size(150, 150);
                        btn.Margin = new Padding(10);
                        btn.BorderRadius = 20;
                        btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                        btn.Text = item.strMenuDescription;
                        btn.Tag = item.strMenuId;
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
                        _getToolRepository = new GetToolRepository();
                        new JobPresenter(jobView, _getToolRepository);
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
