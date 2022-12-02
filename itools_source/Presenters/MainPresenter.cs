using itools_source.Models.Interface;
using itools_source.Views;
using itools_source.Views.Interface;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace itools_source.Presenters
{
    public class MainPresenter
    {
        public MainPresenter(IMainView mainView, IUserAccountRepository assessorRepository)
        {
            this._mainView = mainView;
            _assessorRepository = assessorRepository;

            this._mainView.FormLoad += FormLoad;
            this._mainView.Previous += Previous;
            this._mainView.Next += Next;
        }

        #region Properties - Fields
        log4net.ILog _log = log4net.LogManager.GetLogger(typeof(MainPresenter).Name);

        private IMainView _mainView;
        private IUserAccountRepository _userAccountRepository;
        private IGetToolRepository _getToolRepository;
        #endregion

        #region Events
        private void Next(object sender, EventArgs e)
        {
            MessageBox.Show("Next");
        }

        private void Previous(object sender, EventArgs e)
        {

        }

        private void FormLoad(object sender, EventArgs e)
        {
            if (Program.sessionLogin == null)
            {
                _log.Info("Seesion Login is Null!");
                return;
            }

            if (_mainView.userAccountCurrent == null)
            {
                _mainView.userAccountCurrent = new Models.UserAccount();
            }

            if (_userAccountRepository != null)
            {
                //_mainView.userAccountCurrent = _assessorRepository.GetUserAccount(Program.sessionLogin["UserName"].ToString(), Program.sessionLogin["Password"].ToString());
            }

            if (_mainView.userAccountCurrent != null)
            {
                _mainView.strName = _mainView.userAccountCurrent.strNameStaff;

                // Check Role
                //string strRoleName = _assessorRepository.GetRoleName(_mainView.userAccountCurrent.iID);
                //if (strRoleName == "Admin")
                //{
                //    IToolManagerView toolManagerView = ToolManagerView.GetInstance((MainView)_mainView);
                //    IToolMachineTrayRepository toolRepository = new ToolMachineTrayRepository();
                //    new ToolManagerPresenter(toolManagerView, toolRepository);
                //}
                //else
                //{
                //    IJobView jobView = JobView.GetInstance((MainView)_mainView);
                //    jobView.SetListOPNumberOPType = ListOPNumberOPType;
                //    _getToolRepository = new GetToolRepository();
                //    new JobPresenter(jobView, _getToolRepository);
                //}
                //_log.Info("Login Success!");
            }
        }
        #endregion

        #region Methods
        public void ListOPNumberOPType(Dictionary<string, Dictionary<string, string>> lstOPNumberOpType)
        {
            // 1. Data transmission
            IOPView oPView = OPView.GetInstance((MainView)_mainView);
            oPView.lstOPNumberOPType = lstOPNumberOpType;
            oPView.GetToolViewAction = OpenGetToolView;

            // 2. Close JobView, open OPView.
            _mainView.CloseFormChild();
            new OPPresenter(oPView, _getToolRepository);

            _log.Info("Form close: " + typeof(JobView).Name + ", Open: " + typeof(OPView).Name);
        }

        public void OpenGetToolView(int iOPId)
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
