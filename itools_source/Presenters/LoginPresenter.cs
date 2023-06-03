using Guna.UI2.WinForms;
using VinamiToolUser.Models;
using VinamiToolUser.Models.Interface;
using VinamiToolUser.Views;
using VinamiToolUser.Views.Interface;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Unity;
using VinamiToolUser.Utils;

namespace VinamiToolUser.Presenter
{
    public class LoginPresenter
    {
        #region Properties - Fields
        private readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(LoginPresenter).Name);

        private readonly ILoginView _loginView;
        private readonly IUserAccountRepository _userAccountRepository;

        #endregion
        public LoginPresenter(ILoginView loginView, IUserAccountRepository userAccountRepository)
        {
            _loginView = loginView;
            _userAccountRepository = userAccountRepository;

            // Event handler methods to view events.
            _loginView.btnLogin_Click += _loginView_btnLogin_Click;
            _loginView.btnCancel_Click += _loginView_btnCancel_Click;
            _loginView.txtPassword_IconRightClick += _loginView_txtPassword_IconRightClick;
        }

        #region Events

        private void _loginView_txtPassword_IconRightClick(object sender, EventArgs e)
        {
            var txtPassword = ((Guna2TextBox)sender);
            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.IconRight = VinamiToolUser.Properties.Resources.pass_hide_24px;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.IconRight = VinamiToolUser.Properties.Resources.pass_show_24px;
            }
        }

        private void _loginView_btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void _loginView_btnLogin_Click(object sender, EventArgs e)
        {
            string strUserName = _loginView.strUserName;
            string strPassword = Utils.Encryption.CreateMD5(_loginView.strPassword);
            _log.Info("Login with username: " + strUserName);
            try
            {
                // 1. Get ID, Add Session.
                if (Program.sessionLogin == null)
                {
                    Program.sessionLogin = new Utils.Session();
                }

                // 2. Get user account.
                UserAccount userAccount = await _userAccountRepository.GetUserAccount(strUserName, strPassword);
                if (userAccount == null)
                {

                    DialogResult dlgOk = MessageBox.Show("Đăng Nhập Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _log.Info("Login Fail!");
                    return;
                }
                else
                {
                    if (userAccount.iID == 0)
                    {

                        DialogResult dlgOk = MessageBox.Show("Đăng Nhập Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _log.Info("Login Fail!");
                        return;
                    }
                    CommonValue.UserLogin = userAccount;
                    Program.sessionLogin["Id"] = userAccount.iID;
                    Program.sessionLogin["UserName"] = strUserName; // UserLogin
                    Program.sessionLogin["Password"] = strPassword;
                    Program.sessionLogin["Name"] = userAccount.strNameStaff;
                    Program.sessionLogin["PermissionId"] = userAccount.strPermissionId;
                    Program.sessionLogin["LoginTime"] = Utils.ServerTime.GetServerTime().ToLocalTime().ToString();

                    //System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(
                    //        () =>
                    //        {
                    //            //var mainPresenter = UnityDI.container.Resolve<MainPresenter>();
                    //            //mainPresenter.Run();
                    //            MainViewNew mainViewNew = MainViewNew.GetInstance();
                    //            mainViewNew.UserLogin = userAccount;
                    //            mainViewNew.Show();
                    //        }));

                    //t.Start();

                    MainView mainViewNew = MainView.GetInstance();
                    mainViewNew.Show();

                    _log.Info("Login Success!");
                    _loginView.Fvisible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _log.Error(ex.Message);
            }
        }
        #endregion

        #region Methods
        public void Run()
        {
            Application.Run(_loginView as LoginView);
        }
        #endregion
    }
}
