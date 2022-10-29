using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using itools_source.Models;
using itools_source.Models.Interface;
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
            //string strUserName = txtUserName.Text;
            //string strPassword = txtPassword.Text;
            string strUserName = _loginView.strUserName;
            string strPassword = _loginView.strPassword;
            _log.Info("Login with username: " + strUserName);
            try
            {
                Assessor assessor = _assessorRepository.CheckUserNameAndPassword(strUserName, strPassword);
                if (assessor != null)
                {
                    MessageBox.Show("Đăng Nhập Thành Công!");
                    string strRoleName = _assessorRepository.GetRoleName(assessor.iAssessorId);
                    MessageBox.Show(strRoleName);
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
    }
}
