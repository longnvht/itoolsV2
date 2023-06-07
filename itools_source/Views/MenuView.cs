using itools_source;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using VinamiToolUser.Models;
using VinamiToolUser.Models.Interface;
using VinamiToolUser.Presenters;
using VinamiToolUser.Views.Interface;

namespace VinamiToolUser.Views
{
    public partial class MenuView : Form, IMenuView
    {
        private IMainView _mainView;
        private string _nextView;
        private string _tempView;
        private static MenuView instance;
        public MenuView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            
        }

        private void AssociateAndRaiseViewEvents()
        {
            lstMenu.ItemClick += delegate { SelectViewEvent?.Invoke(this, EventArgs.Empty); };
            lstMenu.ItemDoubleClick += delegate { EnterViewEvent?.Invoke(this, EventArgs.Empty); };
            this.Load += MenuViewLoad;
        }

        private void MenuViewLoad(object sender, EventArgs e)
        {
            _mainView = MainView.GetInstance();
            _mainView.PrevView = "";
            IMenuRepository repository = UnityDI.container.Resolve<IMenuRepository>();
            Presenter = new MenuPresenter(this, repository);
        }

        public static MenuView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                //instance = new ToolView();
                instance = UnityDI.container.Resolve<IMenuView>() as MenuView;
                instance.MdiParent = parentContainer;
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

        public string SearchValue { get => txtSearch.Text; set => txtSearch.Text = value; }
        public MenuPresenter Presenter { private get; set; }
        public string NextView 
        { 
            get => _nextView;
            set 
            {
                _nextView = value;
                _mainView.CurrentView = value;
            } 
        }
        public string TempView 
        { 
            get => _tempView;
            set 
            {
                _tempView = value;
                _mainView.TempView = value;
            } 
        }

        public UserAccount UserLogin => _mainView.UserLogin;

        public event EventHandler SelectViewEvent;
        public event EventHandler EnterViewEvent;

        public void SetAppListBindingSource(BindingSource viewList)
        {
            lstMenu.DataSource = viewList;
        }
    }
}
