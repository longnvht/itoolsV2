using itools_source;
using itools_source.Presenters;
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

namespace VinamiToolUser.Views
{
    public partial class JobViewNew : Form, IJobViewNew
    {
        private string _jobNumber;
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
            lstJob.ItemDoubleClick += delegate { ChoseJobEvent?.Invoke(this, EventArgs.Empty); };
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
        }

        private void ShowKeyboard()
        {
            var Keyboard = KeyBoard.GetInstance();
            int x = (Screen.PrimaryScreen.Bounds.Right - Keyboard.Width) / 2;
            int y = Screen.PrimaryScreen.Bounds.Bottom - Keyboard.Height;
            Keyboard.Show();
            Keyboard.Location = new Point(x, y);
        }

        public string JobNumber { get => _jobNumber; set => _jobNumber = value; }
        public string SearchValue { get => txtSearch.Text; set => txtSearch.Text=value; }
        public JobPresenterNew Presenter { private get; set; }

        public event EventHandler SearchEvent;
        public event EventHandler SelectJobEvent;
        public event EventHandler ChoseJobEvent;

        public void SetJobListBindingSource(BindingSource jobList)
        {
            lstJob.DataSource = jobList;
        }
    }
}
