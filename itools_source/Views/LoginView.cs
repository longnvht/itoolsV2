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

namespace itools_source.Views
{
    public partial class frmLoginView : Form
    {
        public frmLoginView()
        {
            InitializeComponent();
        }

        //private ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private ILog _log = log4net.LogManager.GetLogger(typeof(LoginView).Name);

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            //txtPassword.Text = Encryption.StrEncrypt(txtUserName.Text);
            MySqlConnection conn = MySqlConnect.Open();
            try
            {
                MessageBox.Show("Connect Open!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection!");
            }
        }

        private void btnDencrypt_Click(object sender, EventArgs e)
        {
            //txtRePassword.Text = Encryption.strDecrypt(txtPassword.Text);
            lblTest.Text = "Ahihi";
            //_log.Info("Log Info");
            _log.Debug("Log Debug");
        }
    }
}
