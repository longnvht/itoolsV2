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
using VinamiToolUser.Models.Interface;
using VinamiToolUser.Presenters;
using VinamiToolUser.Views.Interface;

namespace VinamiToolUser.Views
{
    public partial class MenuViewNew : Form, IMenuViewNew
    {
        private MainViewNew _mainView;
        private string _nextView;
        private string _tempView;
        private static MenuViewNew instance;
        public MenuViewNew()
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
            _mainView = MainViewNew.GetInstance();
            _mainView.PrevView = "";
            IMenuRepositoryNew repository = UnityDI.container.Resolve<IMenuRepositoryNew>();
            Presenter = new MenuPresenterNew(this, repository);
        }

        public static MenuViewNew GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                //instance = new ToolView();
                instance = UnityDI.container.Resolve<IMenuViewNew>() as MenuViewNew;
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
        public MenuPresenterNew Presenter { private get; set; }
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

        public event EventHandler SelectViewEvent;
        public event EventHandler EnterViewEvent;

        public void SetAppListBindingSource(BindingSource viewList)
        {
            lstMenu.DataSource = viewList;
        }
    }
}
