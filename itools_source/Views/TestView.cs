using itools_source.Presenter;
using itools_source.Utils;
using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace itools_source.Views
{
    public partial class frmTest : Form
    {
        //private ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private ILog _log = log4net.LogManager.GetLogger(typeof(LoginView).Name);

        public frmTest()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            //txtPassword.Text = Encryption.StrEncrypt(txtUserName.Text);
            //_log.Info("Passwrod Encrypt");
            string strUserName = txtUserName.Text;
            string strPassword = txtPassword.Text;
            _log.Info("Login with username: " + strUserName);
            try
            {
                bool result = EmployeePresenter.CheckUserNameAndPassword("admin", "123456");
                if (result)
                {
                    MessageBox.Show("Login Success!");
                    _log.Info("Login Success!");
                }
                else
                {
                    MessageBox.Show("Login Fail!");
                    _log.Info("Login Fail!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _log.Error(ex.Message);
            }
        }

        private void btnDencrypt_Click(object sender, EventArgs e)
        {
            txtRePassword.Text = Encryption.StrDecrypt(txtPassword.Text);
            _log.Info("Password Decrypt");
        }
    }
}
