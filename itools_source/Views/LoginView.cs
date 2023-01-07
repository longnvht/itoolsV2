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
            _txtPassword.IconRightClick += delegate { txtPassword_IconRightClick?.Invoke(_txtPassword, EventArgs.Empty); };
            _txtUserName.MouseClick += delegate { txtUserName_MouseClick?.Invoke(this, EventArgs.Empty as MouseEventArgs); };
            _txtPassword.MouseClick += delegate { txtPassword_MouseClick?.Invoke(this, EventArgs.Empty as MouseEventArgs); };
        }

        #region Properties - Fields
        public string strUserName
        {
            get { return _txtUserName.Text; }
            set { _txtUserName.Text = value; }
        }
        public string strPassword
        {
            get { return _txtPassword.Text; }
            set { _txtPassword.Text = value; }
        }
        #endregion

        #region Events
        public event EventHandler btnLogin_Click;
        public event EventHandler btnCancel_Click;
        public event EventHandler txtPassword_IconRightClick;
        public event MouseEventHandler txtUserName_MouseClick;
        public event MouseEventHandler txtPassword_MouseClick;
        #endregion

        #region Methods
        #endregion
    }
}
