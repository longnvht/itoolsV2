using itools_source.Models;
using itools_source.Views.Interface;
using System;
using System.Windows.Forms;

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
        #endregion
    }
}
