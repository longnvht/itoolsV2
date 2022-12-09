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
        public MenuPresenter(IMenuView menuView, IMenuRepository menuRepository)
        {
            _menuView = menuView;
            _menuRepository = menuRepository;

            // Event handler methods to view events.
            _menuView.MenuView_Load += _menuView_MenuView_Load;

            _menuView.Show();
        }

        #region Fields
        private readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(MenuPresenter).Name);

        private readonly IMenuView _menuView;
        private readonly IMenuRepository _menuRepository;
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
                        btn.Click += btnItem_Click;

                        frm.flpMenu.Controls.Add(btn);
                    }
                }
            }
        }
        #endregion

        #region Methods
        private void btnItem_Click(object sender, EventArgs e)
        {
            Guna2GradientTileButton btn = (Guna2GradientTileButton)sender;
            MessageBox.Show(btn.Tag.ToString());
            if (btn != null && btn.Tag != null)
            {
                List<string> lstFormId = _menuRepository.GetListFormByMenuId(strMenuId: btn.Tag.ToString()).Result.ToList();
                foreach (var item in lstFormId)
                {
                    //if (item == nameof(ToolManagerView))
                    //{
                    //    //((MainView)sender).btnNext.Enabled = false;
                    //    //IToolManagerView toolManagerView = ToolManagerView.GetInstance((MainView)_mainView);
                    //    //IToolMachineTrayRepository toolRepository = new ToolMachineTrayRepository();
                    //    //new ToolManagerPresenter(toolManagerView, toolRepository);
                    //    MessageBox.Show(item);
                    //    break;
                    //}
                    if (item == nameof(JobView))
                    {
                        MessageBox.Show(item);
                        //IJobView jobView = JobView.GetInstance((MainView)_mainView);
                        //jobView.SetListOPNumberOPType = OpenOPView;
                        //_getToolRepository = new GetToolRepository();
                        //new JobPresenter(jobView, _getToolRepository);
                        break;
                    }
                }
            }
        }

        //public void OpenOPView(Dictionary<int?, Dictionary<string, string>> lstOPNumberOpType)
        //{
        //    // 1. Data transmission
        //    IOPView oPView = OPView.GetInstance((MainView)_mainView);
        //    _lstOPNumberOpType_Main = lstOPNumberOpType;
        //    oPView.lstOPNumberOPType = lstOPNumberOpType;
        //    oPView.GetToolViewAction = OpenGetToolView;

        //    // 2. Close JobView, open OPView.
        //    _mainView.CloseFormChild();
        //    new OPPresenter(oPView, _getToolRepository);

        //    _log.Info("Form close: " + typeof(JobView).Name + ", Open: " + typeof(OPView).Name);
        //}

        //public void OpenGetToolView(int? iOPId)
        //{
        //    // 1. Data transmission
        //    GetToolView getToolView = GetToolView.GetInstance((MainView)_mainView);
        //    getToolView.iOPId = iOPId;
        //    getToolView.EnabledButton = ToggleButton;

        //    // 2. Close OPView, open GetToolView
        //    _mainView.CloseFormChild();
        //    new GetToolPresenter(getToolView, _getToolRepository);

        //    _log.Info("Form close: " + typeof(OPView).Name + ", Open: " + typeof(GetToolView).Name);
        //}
        #endregion
    }
}
