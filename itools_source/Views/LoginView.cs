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
            btnLogin.Click += delegate { btnLogin_Click?.Invoke(this, EventArgs.Empty); };
            btnCancel.Click += delegate { btnCancel_Click?.Invoke(this, EventArgs.Empty); };
            txtPassword.IconRightClick += delegate { txtPassword_IconRightClick?.Invoke(txtPassword, EventArgs.Empty); };
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
        public event EventHandler btnLogin_Click;
        public event EventHandler btnCancel_Click;
        public event EventHandler txtPassword_IconRightClick;
        #endregion

        #region Methods
        #endregion
    }
}
