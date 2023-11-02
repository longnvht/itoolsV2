using VinamiToolUser.Views.Interface;
using System;
using System.Windows.Forms;
using System.Drawing;
using VinamiToolUser.Views;
using System.Management.Instrumentation;
using Unity;
using VinamiToolUser.Models;
using VinamiToolUser.Presenter;
using VinamiToolUser.Models.Interface;
using VinamiToolUser.Presenters;

namespace VinamiToolUser.Views
{
    public partial class LoginView : Form, ILoginView
    {
        private static LoginView instance;
        private IMainView _mainView;
        UserAccount _userLogin;
        private bool _passwordHide;
        public LoginView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        public static LoginView GetInstance(Form container)
        {
            if (instance == null || instance.IsDisposed)
            {
                //instance = new ToolView();
                instance = UnityDI.container.Resolve<ILoginView>() as LoginView;
                instance.MdiParent = container;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }

        private void AssociateAndRaiseViewEvents()
        {
            this.Load += LoginViewLoad;
            btnLogin.MouseClick += (s,e) => 
            { 
                KeyBoard.CloseKeyboard();
                LoginEvent?.Invoke(this, EventArgs.Empty); 
            };
            btnExit.MouseClick += (s,e) => 
            {
                KeyBoard.CloseKeyboard();
                Application.Exit();
            };
            txtPassword.IconRightClick += (s,e) =>  
            {
                PasswordHide = !PasswordHide;
            };
            txtPassword.MouseClick += (s, e) => { ShowKeyboard(); };
            txtUserName.MouseClick += (s, e) => { ShowKeyboard(); };
            txtPassword.TextChanged += (s, e) => { CheckValidInput(); };
            txtUserName.TextChanged += (s, e) => { CheckValidInput(); };
            txtPassword.KeyDown += (s, e) =>
            {
                if(e.KeyCode == Keys.Enter)
                {
                    if (CheckValidInput())
                    {
                        KeyBoard.CloseKeyboard();
                        LoginEvent?.Invoke(this, EventArgs.Empty);
                    }
                    else
                    {
                        Message = "Tên đăng nhập và mật khẩu không được để trống!";
                    }

                }
            };
        }


        #region Properties - Fields
        public string UserName
        {
            get { return txtUserName.Text; }
            set { txtUserName.Text = value; }
        }
        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }

        public UserAccount UserLogin 
        { 
            get => _userLogin;
            set 
            { 
                _userLogin = value; 
                _mainView.UserLogin = _userLogin;
            }
        }

        public LoginPresenter Presenter { private get; set; }
        public string Message { get => lblMessage.Text; set => lblMessage.Text = value; }
        public bool PasswordHide 
        { 
            get => _passwordHide;
            set
            {
                _passwordHide = value;
                if (PasswordHide)
                {
                    txtPassword.PasswordChar = '\0';
                    txtPassword.IconRight = Properties.Resources.pass_hide_24px;
                }
                else
                {
                    txtPassword.PasswordChar = '●';
                    txtPassword.IconRight = Properties.Resources.pass_show_24px;
                }
            } 
        }

        public MachineConfigModel CurrentConfig => _mainView.MachineConfig;

        #endregion

        #region Events
        public event EventHandler LoginEvent;
        #endregion

        #region Methods
        private void LoginViewLoad(object sender, EventArgs e)
        {
            lblVersion.Text = "Version: " + Application.ProductVersion;
            lblDate.Text = DateTime.Now.ToString("d");
            ILoginRepository repository = UnityDI.container.Resolve<ILoginRepository>();
            Presenter = new LoginPresenter(this, repository);
            _mainView = MainView.GetInstance();
            PasswordHide = false;
            CheckValidInput();
        }

        private void CheckValidInput()
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            if(String.IsNullOrEmpty(userName.Trim()) || String.IsNullOrEmpty(password))
            {
                btnLogin.Enabled = false;
            }
            else btnLogin.Enabled = true;
        }

        private void ShowKeyboard()
        {
            var Keyboard = KeyBoard.GetInstance();
            int x = (Screen.PrimaryScreen.Bounds.Right - Keyboard.Width) / 2;
            int y = Screen.PrimaryScreen.Bounds.Bottom - Keyboard.Height;
            Keyboard.Show();
            Keyboard.Location = new Point(x, y);
        }

        #endregion
    }
}
