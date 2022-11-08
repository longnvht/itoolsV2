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
using itools_source.Views.Interface;
using System.Runtime.Remoting.Messaging;
using itools_source.Models;

namespace itools_source.Views
{
    public partial class LoginView : Form, ILoginView
    {
        public LoginView()
        {
            InitializeComponent();
            btnLogin.Click += delegate { LoginEvent?.Invoke(this, EventArgs.Empty); };
            btnCancel.Click += delegate { CancelEvent?.Invoke(this, EventArgs.Empty); };
            txtPassword.IconRightClick += delegate { PasswordIconRightClickEvent?.Invoke(txtPassword, EventArgs.Empty); };
        }

        #region Properties - Fields
        public string strUserName
        {
            get { return txtUserName.Text; }
            set { txtUserName.Text = value; }
        }
        public string strPassword
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }
        #endregion

        #region Events
        public Assessor assessorCurrent { get; set; }

        public event EventHandler LoginEvent;
        public event EventHandler CancelEvent;
        public event EventHandler PasswordIconRightClickEvent;
        #endregion

        #region Method
        public void ShowMessage(string strMessage)
        {
            MessageBox.Show(strMessage);
        }
        #endregion
    }
}
