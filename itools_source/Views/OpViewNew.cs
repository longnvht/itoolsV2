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
using VinamiToolUser.Utils;
using VinamiToolUser.Views.Interface;

namespace VinamiToolUser.Views
{
    public partial class OpViewNew : Form, IOPViewNew
    {
        private static OpViewNew instance;
        private JobModelNew _currentJob;
        public OpViewNew()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        public static OpViewNew GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                //instance = new ToolView();
                instance = UnityDI.container.Resolve<IOPViewNew>() as OpViewNew;
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
            this.Load += OpViewLoad;
            lstOp.ItemClick += delegate { OpSelectEvent?.Invoke(this, EventArgs.Empty); };
            lstOp.ItemDoubleClick += delegate { ChoseOpEvent?.Invoke(this, EventArgs.Empty); };
            btnSearch.MouseClick += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    KeyBoard.CloseKeyboard();
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
        }

        private void OpViewLoad(object sender, EventArgs e)
        {
            CurrentJob = CommonValue.CurrentJob;
            IOpRepositoryNew repository = UnityDI.container.Resolve<IOpRepositoryNew>();
            Presenter = new OpPresenterNew(this, repository);
        }

        public JobModelNew  CurrentJob { get => _currentJob; set => _currentJob = value; }
        public string SearchValue { get => txtSearch.Text; set => txtSearch.Text = value; }
        public OpPresenterNew Presenter { private get; set; }

        public event EventHandler SearchEvent;
        public event EventHandler OpSelectEvent;
        public event EventHandler ChoseOpEvent;

        public void SetOpListBindingSource(BindingSource opList)
        {
            lstOp.DataSource = opList;
        }
    }
}
