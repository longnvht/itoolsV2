using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using itools_source.Utils;
using MySql.Data.MySqlClient;
using log4net;
using System.Web.UI.WebControls;
using itools_source.Presenter;

namespace itools_source.Views
{
    public partial class frmLoginView : Form
    {
        private ILog _log = log4net.LogManager.GetLogger(typeof(LoginView).Name);

        public frmLoginView()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strUserName = txtUserName.Text;
            string strPassword = txtPassword.Text;
            _log.Info("Login with username: " + strUserName);
            try
            {
                bool result = EmployeePresenter.CheckUserNameAndPassword(strUserName, strPassword);
                if (result)
                {
                    MessageBox.Show("Đăng Nhập Thành Công!");
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPassword_IconRightClick(object sender, EventArgs e)
        {
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
    }
}
