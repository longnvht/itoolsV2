using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using itools_source.Models;
using itools_source.Models.Interface;
using itools_source.Presenters;
using itools_source.Repository;
using itools_source.Views;
using itools_source.Views.Interface;

namespace itools_source.Presenter
{
    public class LoginPresenter
    {
        log4net.ILog _log = log4net.LogManager.GetLogger(typeof(LoginPresenter).Name);

        #region Fields
        private ILoginView _loginView;
        private IAssessorRepository _assessorRepository;
        //private IPushToolView _toolManagerView;
        //private IJobView _jobView;
        #endregion

        public LoginPresenter(ILoginView loginView, IAssessorRepository assessorRepository)
        {
            _loginView = loginView;
            _assessorRepository = assessorRepository;

            // Event handler methods to view events.
            _loginView.LoginEvent += LoginAssessor;
            _loginView.CancelEvent += CancelLogin;
            _loginView.PasswordIconRightClickEvent += PasswordIconRightClick;

            _loginView.Show();
        }

        #region Events
        private void PasswordIconRightClick(object sender, EventArgs e)
        {
            var txtPassword = ((Guna2TextBox)sender);
            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.IconRight = Properties.Resources.pass_hide_24px;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.IconRight = Properties.Resources.pass_show_24px;
            }
        }

        private void CancelLogin(object sender, EventArgs e)
        {
            _loginView.Close();
        }

        private void LoginAssessor(object sender, EventArgs e)
        {
            string strUserName = _loginView.strUserName;
            string strPassword = _loginView.strPassword;
            _log.Info("Login with username: " + strUserName);
            try
            {
                // 1. Get ID, Add Session.
                if (Program.sessionLogin == null)
                {
                    Program.sessionLogin = new Utils.Session();
                }
                Program.sessionLogin["Id"] = _assessorRepository.GetById(strUserName, strPassword);

                // 2. Check Login
                int iAssessorId = Convert.ToInt32(Program.sessionLogin["Id"]);
                if (iAssessorId == -1)
                {
                    MessageBox.Show("Đăng Nhập Thất Bại!");
                    _log.Info("Login Fail!");
                }
                else
                {
                    Program.sessionLogin["UserName"] = strUserName;
                    Program.sessionLogin["Password"] = strPassword;

                    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(
                        () => {
                            IMainView _mainView = new MainView();
                            new MainPresenter(_mainView, _assessorRepository);
                            Application.Run((Form)_mainView);
                        }));
                    t.Start();

                    _loginView.Close();
                    _log.Info("Login Success!");
                }

                //if (_loginView.assessorCurrent == null)
                //{
                //    _loginView.assessorCurrent = new Assessor();
                //}

                //_loginView.assessorCurrent = _assessorRepository.GetAssessor(strUserName, strPassword); // Check Role
                //if (Program.sessionLogin == null)
                //{
                //    Program.sessionLogin = new Utils.Session();
                //}
                //Program.sessionLogin["Id"] = _loginView.assessorCurrent.iAssessorId;
                //Program.sessionLogin["UserName"] = _loginView.assessorCurrent.strUserName;
                //Program.sessionLogin["Password"] = _loginView.assessorCurrent.strPassword;

                //if (_loginView.assessorCurrent != null)
                //{
                //    //MessageBox.Show("Đăng Nhập Thành Công!");
                //    string strRoleName = _assessorRepository.GetRoleName(_loginView.assessorCurrent.iAssessorId);

                //    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc1));
                //    t.Start();

                //    //if (strRoleName == "Admin")
                //    //{
                //    //    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc1));
                //    //    t.Start();
                //    //}
                //    //else
                //    //{
                //    //    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc2));
                //    //    t.Start();
                //    //}
                //    _loginView.Close();
                //    _log.Info("Login Success!");
                //}
                //else
                //{
                //    MessageBox.Show("Đăng Nhập Thất Bại!");
                //    _log.Info("Login Fail!");
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _log.Error(ex.Message);
            }
        }
        #endregion
        #region Method
        public void ThreadProc1()
        {
            //IToolManagerView _toolManagerView = new ToolManagerView();
            //IToolRepository repository = new ToolRepository();
            //new ToolManagerPresenter(_toolManagerView, repository);
            //Application.Run((Form)_toolManagerView);

            IMainView mainView = new MainView();
            IAssessorRepository repository = new AssessorRepository();
            new MainPresenter(mainView, repository);
            Application.Run((Form)mainView);
        }

        public void ThreadProc2()
        {
            IJobView jobView = new JobView();
            IJobRepository repository = new JobRepository();
            new JobPresenter(jobView, repository);
            Application.Run((Form)jobView);
        }
        #endregion
    }
}
