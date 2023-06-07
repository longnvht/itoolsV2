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
using System.Collections.Generic;

namespace VinamiToolUser.Presenter
{
    public class LoginPresenter
    {
        #region Properties - Fields
        private readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(LoginPresenter).Name);
        private IEnumerable<UserAccount> _userList;
        private readonly ILoginView _view;
        private readonly ILoginRepository _repository;

        #endregion
        public LoginPresenter(ILoginView view, ILoginRepository repository)
        {
            _view = view;
            _repository = repository;
            _view.Presenter = this;
            // Event handler methods to view events.
            _view.LoginEvent += LoginEvent;
        }

        #region Events

        private async void LoginEvent(object sender, EventArgs e)
        {
            string strUserName = _view.UserName;
            string strPassword = Utils.Encryption.CreateMD5(_view.Password);
            _log.Info("Login with username: " + strUserName);
            try
            {
                _userList = await _repository.GetUserAccount(strUserName, strPassword);

                if (_userList.Count() <= 0)
                {
                    _view.Message = "Sai tên đăng nhập hoặc mật khẩu!!!";
                    return;
                }
                else
                {
                    _view.UserLogin = _userList.FirstOrDefault();
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

        #region Methods
        #endregion
    }
}
