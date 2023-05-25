using itools_source;
using itools_source.Views.Interface;
using itools_source.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using Unity;
using VinamiToolUser.Models.Interface;
using VinamiToolUser.Presenters;
using VinamiToolUser.Views.Interface;
using VinamiToolUser.Models;

namespace VinamiToolUser.Views
{
    public partial class JobViewNew : Form, IJobViewNew
    {
        private MainViewNew _mainView;
        private JobModelNew _selectedJob;
        private string _nextView;
        private string _tempView;
        public JobViewNew()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private static JobViewNew instance;
        public static JobViewNew GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                //instance = new ToolView();
                instance = UnityDI.container.Resolve<IJobViewNew>() as JobViewNew;
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

        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += (s,e) =>
            {
                KeyBoard.CloseKeyboard();
                SearchEvent?.Invoke(this, EventArgs.Empty); 
            };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    KeyBoard.CloseKeyboard();
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
                    
            };
            //Job Select Event
            lstJob.ItemClick += delegate { SelectJobEvent?.Invoke(this, EventArgs.Empty); };
            lstJob.ItemDoubleClick += (s,e) => 
            {
                KeyBoard.CloseKeyboard();
                ChoseJobEvent?.Invoke(this, EventArgs.Empty); 
            };
            txtSearch.Click += (s, e) =>
            {
                ShowKeyboard();
            };
            this.Load += JobViewLoad;
        }

        private void JobViewLoad(object sender, EventArgs e)
        {
            IJobRepositoryNew repositoryNew = UnityDI.container.Resolve<IJobRepositoryNew>();
            Presenter = new JobPresenterNew(this, repositoryNew);
            _mainView = MainViewNew.GetInstance();
            _mainView.PrevView = "Menu";
        }

        private void ShowKeyboard()
        {
            var Keyboard = KeyBoard.GetInstance();
            int x = (Screen.PrimaryScreen.Bounds.Right - Keyboard.Width) / 2;
            int y = Screen.PrimaryScreen.Bounds.Bottom - Keyboard.Height;
            Keyboard.Show();
            Keyboard.Location = new Point(x, y);
        }

        public string SearchValue { get => txtSearch.Text; set => txtSearch.Text=value; }
        public JobPresenterNew Presenter { private get; set; }
        public JobModelNew SelectedJob 
        { 
            get => _selectedJob;
            set 
            { 
                _selectedJob = value; 
                _mainView.CurrentJob = value;
            }
        }
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


        public event EventHandler SearchEvent;
        public event EventHandler SelectJobEvent;
        public event EventHandler ChoseJobEvent;

        public void SetJobListBindingSource(BindingSource jobList)
        {
            lstJob.DataSource = jobList;
        }
    }
}
