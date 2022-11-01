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
using log4net;

namespace itools_source.Presenter
{
    public class LoginPresenter
    {
        log4net.ILog _log = log4net.LogManager.GetLogger(typeof(LoginPresenter).Name);

        #region Fields
        private ILoginView _loginView;
        private IAssessorRepository _assessorRepository;
        private IPushToolView _pushToolView;
        private IJobView _jobView;
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
                if (_loginView.assessorCurrent == null)
                {
                    _loginView.assessorCurrent = new Assessor();
                }

                _loginView.assessorCurrent = _assessorRepository.GetAssessor(strUserName, strPassword); // Check Role
                if (_loginView.assessorCurrent != null)
                {
                    MessageBox.Show("Đăng Nhập Thành Công!");
                    string strRoleName = _assessorRepository.GetRoleName(_loginView.assessorCurrent.iAssessorId);
                    if (strRoleName == "Admin")
                    {
                        System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc1));
                        t.Start();
                    }
                    else
                    {
                        System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc2));
                        t.Start();
                    }
                    _loginView.Close();
                    _log.Info("Login Success!");
                }
                else
                {
                    MessageBox.Show("Đăng Nhập Thất Bại!");
                    _log.Info("Login Fail!");
                }
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
            _pushToolView = new PushToolView();
            IToolRepository repository = new ToolRepository();
            new PushToolPresenter(_pushToolView, repository);
            Application.Run((Form)_pushToolView);
        }

        public void ThreadProc2()
        {
            _jobView = new JobView();
            IJobRepository repository = new JobRepository();
            new JobPresenter(_jobView, repository);
            Application.Run((Form)_jobView);
        }
        #endregion
    }
}
