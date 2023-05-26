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
        private OPModel _selectedOP;
        private string _nextView;
        private string _tempView;
        private IMainViewNew _mainView;
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
            lstOp.ItemDoubleClick += (s,e) => 
            {
                KeyBoard.CloseKeyboard();
                ChoseOpEvent?.Invoke(this, EventArgs.Empty); 
            };
            btnSearch.Click += delegate 
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
            txtSearch.MouseClick += (s, e) => { ShowKeyboard(); };
        }

        private void OpViewLoad(object sender, EventArgs e)
        {
            _mainView = MainViewNew.GetInstance();
            _mainView.PrevView = "Select Job";
            CurrentJob = CommonValue.CurrentJob;
            IOpRepositoryNew repository = UnityDI.container.Resolve<IOpRepositoryNew>();
            Presenter = new OpPresenterNew(this, repository);
        }

        private void ShowKeyboard()
        {
            var Keyboard = KeyBoard.GetInstance();
            int x = (Screen.PrimaryScreen.Bounds.Right - Keyboard.Width) / 2;
            int y = Screen.PrimaryScreen.Bounds.Bottom - Keyboard.Height;
            Keyboard.Show();
            Keyboard.Location = new Point(x, y);
        }

        public JobModelNew  CurrentJob { get => _currentJob; set => _currentJob = value; }
        public string SearchValue { get => txtSearch.Text; set => txtSearch.Text = value; }
        public OpPresenterNew Presenter { private get; set; }
        public OPModel SelectedOP 
        { 
            get => _selectedOP;
            set 
            { 
                _selectedOP = value;
                _mainView.CurrentOP = value;
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
        public event EventHandler OpSelectEvent;
        public event EventHandler ChoseOpEvent;

        public void SetOpListBindingSource(BindingSource opList)
        {
            lstOp.DataSource = opList;
        }
    }
}
