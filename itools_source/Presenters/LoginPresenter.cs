using Guna.UI2.WinForms;
using itools_source.Models.Interface;
using itools_source.Presenters;
using itools_source.Views;
using itools_source.Views.Interface;
using System;
using System.Windows.Forms;

namespace itools_source.Presenter
{
    public class LoginPresenter
    {
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

        #region Fields
        log4net.ILog _log = log4net.LogManager.GetLogger(typeof(LoginPresenter).Name);

        private ILoginView _loginView;
        private IAssessorRepository _assessorRepository;
        #endregion

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

                // 2. Check Login.
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

                    Program.sessionLogin["LoginTime"] = Utils.ServerTime.GetServerTime().ToLocalTime().ToString();

                    string strRoleName = _assessorRepository.GetRoleName(Convert.ToInt32(Program.sessionLogin["Id"]));
                    Program.sessionLogin["Role"] = strRoleName;

                    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(
                        () =>
                        {
                            IMainView mainView = new MainView();
                            new MainPresenter(mainView, _assessorRepository);
                            Application.Run((Form)mainView);
                        }));

                    t.Start();

                    _loginView.Close();
                    _log.Info("Login Success!");
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
        #endregion
    }
}
