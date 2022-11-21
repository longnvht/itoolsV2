using itools_source.Models.Interface;
using itools_source.Presenter;
using itools_source.Repository;
using itools_source.Views;
using itools_source.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itools_source.Presenters
{
    public class MainPresenter
    {
        log4net.ILog _log = log4net.LogManager.GetLogger(typeof(MainPresenter).Name);

        private IMainView _mainView;
        private IAssessorRepository _assessorRepository;

        public MainPresenter(IMainView mainView, IAssessorRepository assessorRepository)
        {
            this._mainView = mainView;
            _assessorRepository = assessorRepository;

            this._mainView.FormLoad += FormLoad;
            this._mainView.Previous += Previous;
            this._mainView.Next += Next;
        }

        private void Next(object sender, EventArgs e)
        {
            MessageBox.Show("Next");
        }

        private void Previous(object sender, EventArgs e)
        {
            MessageBox.Show("Previous");
        }

        private void FormLoad(object sender, EventArgs e)
        {
            if (Program.sessionLogin == null)
            {
                _log.Info("Seesion Login is Null!");
                return;
            }

            if (_mainView.assessorCurrent == null)
            {
                _mainView.assessorCurrent = new Models.Assessor();
            }

            if (_assessorRepository != null)
            {
                _mainView.assessorCurrent = _assessorRepository.GetAssessor(Program.sessionLogin["UserName"].ToString(), Program.sessionLogin["Password"].ToString());
            }            

            if (_mainView.assessorCurrent != null)
            {
                _mainView.strName = _mainView.assessorCurrent.strLastName + " " + _mainView.assessorCurrent.strFirstName;

                // Check Role
                string strRoleName = _assessorRepository.GetRoleName(_mainView.assessorCurrent.iAssessorId);
                if (strRoleName == "Admin")
                {
                    IToolManagerView toolManagerView = ToolManagerView.GetInstance((MainView)_mainView);
                    IToolMachineTrayRepository toolRepository = new ToolMachineTrayRepository();
                    new ToolManagerPresenter(toolManagerView, toolRepository);
                }
                else
                {
                    IJobView jobView = JobView.GetInstance((MainView)_mainView);
                    IGetToolRepository getToolRepository = new GetToolRepository();
                    new JobPresenter(jobView, getToolRepository);
                }
                _log.Info("Login Success!");
            }
        }
    }
}
