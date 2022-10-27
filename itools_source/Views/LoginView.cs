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

namespace itools_source.Views
{
    public partial class frmLoginView : Form
    {
        public frmLoginView()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            txtPassword.Text = Encryption._strEncrypt(txtUserName.Text);
        }

        private void btnDencrypt_Click(object sender, EventArgs e)
        {
            txtRePassword.Text = Encryption.strDecrypt(txtPassword.Text);
        }
    }
}
