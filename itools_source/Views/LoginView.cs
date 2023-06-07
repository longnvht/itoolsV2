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
        private MainView _mainView;
        UserAccount _userLogin;
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
            btnLogin.Click += (s,e) => 
            { 
                KeyBoard.CloseKeyboard();
                LoginEvent?.Invoke(this, EventArgs.Empty); 
            };
            btnCancel.Click += (s,e) => 
            {
                KeyBoard.CloseKeyboard();
                Application.Exit();
            };
            txtPassword.IconRightClick += (s,e) =>  
            {

            };
            txtPassword.MouseClick += (s, e) => { ShowKeyboard(); };
            txtUserName.MouseClick += (s, e) => { ShowKeyboard(); };
        }

        private void LoginViewLoad(object sender, EventArgs e)
        {
            lblVersion.Text = "Version: " + Application.ProductVersion;
            lblDate.Text = DateTime.Now.ToString("d");
            ILoginRepository repository = UnityDI.container.Resolve<ILoginRepository>();
            Presenter = new LoginPresenter(this, repository);
            _mainView = MainView.GetInstance();

        }

        private void ShowKeyboard()
        {
            var Keyboard = KeyBoard.GetInstance();
            int x = (Screen.PrimaryScreen.Bounds.Right - Keyboard.Width) / 2;
            int y = Screen.PrimaryScreen.Bounds.Bottom - Keyboard.Height;
            Keyboard.Show();
            Keyboard.Location = new Point(x, y);
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

        #endregion

        #region Events
        public event EventHandler LoginEvent;
        #endregion

        #region Methods
        #endregion
    }
}
