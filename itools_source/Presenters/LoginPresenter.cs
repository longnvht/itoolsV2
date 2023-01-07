using Guna.UI2.WinForms;
using itools_source.Models;
using itools_source.Models.Interface;
using itools_source.Presenters;
using itools_source.Views;
using itools_source.Views.Interface;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace itools_source.Presenter
{
    public class LoginPresenter
    {
        public LoginPresenter(ILoginView loginView, IUserAccountRepository userAccountRepository)
        {
            _loginView = loginView;
            _userAccountRepository = userAccountRepository;

            // Event handler methods to view events.
            _loginView.btnLogin_Click += _loginView_btnLogin_Click;
            _loginView.btnCancel_Click += _loginView_btnCancel_Click;
            _loginView.txtPassword_IconRightClick += _loginView_txtPassword_IconRightClick;
            _loginView.txtUserName_MouseClick += _loginView_txtUserName_MouseClick;
            _loginView.txtPassword_MouseClick += _loginView_txtPassword_MouseClick;

            _loginView.Show();
        }

        #region Fields
        private readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(LoginPresenter).Name);

        private readonly ILoginView _loginView;
        private readonly IUserAccountRepository _userAccountRepository;

        VirtualNumericKeyBoard frmNumericKey;
        VirtualKeyBoard frmKeyBoard;
        Point clientPoint;
        #endregion

        #region Events

        private void _loginView_txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (!Application.OpenForms.OfType<VirtualKeyBoard>().Any() && !Application.OpenForms.OfType<VirtualNumericKeyBoard>().Any())
            {
                frmKeyBoard = new VirtualKeyBoard();
                frmKeyBoard.Show();

                LoginView frmLogin = (LoginView)sender;
                frmLogin.txtPassword.Focus();

                Point p = new Point();
                clientPoint = frmLogin.txtPassword.PointToScreen(p);
                frmKeyBoard.Location = new System.Drawing.Point(clientPoint.X - 125, clientPoint.Y + frmLogin.txtPassword.Height);
                clientPoint.Y += frmLogin.txtPassword.Height;
            }
        }
        private void _loginView_txtUserName_MouseClick(object sender, MouseEventArgs e)
        {
            if (!Application.OpenForms.OfType<VirtualNumericKeyBoard>().Any() && !Application.OpenForms.OfType<VirtualKeyBoard>().Any())
            {
                frmNumericKey = new VirtualNumericKeyBoard();
                frmNumericKey.Show();

                LoginView frmLogin = (LoginView)sender;
                frmLogin.txtUserName.Focus();

                Point p = new Point();
                clientPoint = frmLogin.txtUserName.PointToScreen(p);
                frmNumericKey.Location = new System.Drawing.Point(clientPoint.X, clientPoint.Y + frmLogin.txtUserName.Height);
                clientPoint.Y += frmLogin.txtUserName.Height;
            }
        }

        private void _loginView_txtPassword_IconRightClick(object sender, EventArgs e)
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
                    if (Application.OpenForms.OfType<VirtualNumericKeyBoard>().Any())
                    {
                        if (frmNumericKey != null)
                        {
                            frmNumericKey.Location = new System.Drawing.Point(clientPoint.X, clientPoint.Y + 20);
                        }
                    }

                    DialogResult dlgOk = MessageBox.Show("Đăng Nhập Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (dlgOk == DialogResult.OK)
                    {
                        if (frmNumericKey != null)
                        {
                            frmNumericKey.Location = new System.Drawing.Point(clientPoint.X, clientPoint.Y);
                        }
                    }
                    _log.Info("Login Fail!");
                    return;
                }
                else
                {
                    if (userAccount.iID == 0)
                    {
                        if (Application.OpenForms.OfType<VirtualNumericKeyBoard>().Any())
                        {
                            frmNumericKey.Location = new System.Drawing.Point(clientPoint.X, clientPoint.Y - 312);
                        }

                        DialogResult dlgOk = MessageBox.Show("Đăng Nhập Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (dlgOk == DialogResult.OK)
                        {
                            frmNumericKey.Location = new System.Drawing.Point(clientPoint.X, clientPoint.Y);
                        }
                        _log.Info("Login Fail!");
                        return;
                    }
                    Program.sessionLogin["Id"] = userAccount.iID;
                    Program.sessionLogin["UserName"] = strUserName; // UserLogin
                    Program.sessionLogin["Password"] = strPassword;
                    Program.sessionLogin["Name"] = userAccount.strNameStaff;
                    Program.sessionLogin["PermissionId"] = userAccount.strPermissionId;
                    Program.sessionLogin["LoginTime"] = Utils.ServerTime.GetServerTime().ToLocalTime().ToString();

                    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(
                            () =>
                            {
                                IMainView mainView = new MainView();
                                new MainPresenter(mainView, _userAccountRepository);
                                Application.Run((Form)mainView);
                            }));

                    t.Start();

                    _log.Info("Login Success!");
                    _loginView.Close();
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
        #endregion
    }
}
