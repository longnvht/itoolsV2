using itools_source.Views.Interface;
using System;
using System.Windows.Forms;
using System.Drawing;
using VinamiToolUser.Views;

namespace itools_source.Views
{
    public partial class LoginView : Form, ILoginView
    {
        public LoginView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnLogin.Click += (s,e) => 
            { 
                KeyBoard.CloseKeyboard();
                btnLogin_Click?.Invoke(this, EventArgs.Empty); 
            };
            btnCancel.Click += (s,e) => 
            {
                KeyBoard.CloseKeyboard();
                btnCancel_Click?.Invoke(this, EventArgs.Empty); 
            };
            _txtPassword.IconRightClick += delegate { txtPassword_IconRightClick?.Invoke(_txtPassword, EventArgs.Empty); };
            txtPassword.MouseClick += (s, e) => { ShowKeyboard(); };
            txtUserName.MouseClick += (s, e) => { ShowKeyboard(); };
        }

        private void ShowKeyboard()
        {
            var Keyboard = KeyBoard.GetInstance();
            int x = (Screen.PrimaryScreen.Bounds.Right - Keyboard.Width) / 2;
            int y = Screen.PrimaryScreen.Bounds.Bottom - Keyboard.Height;
            Keyboard.Show();
            Keyboard.Location = new Point(x, y);
        }
        public bool Fvisible
        {
            get => this.Visible; set => this.Visible = value;
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
        #endregion

        #region Methods
        #endregion
    }
}
