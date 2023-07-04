using VinamiToolUser.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using VinamiToolUser.Models.Interface;
using VinamiToolUser.Presenters;
using VinamiToolUser.Repository;
using VinamiToolUser.Views.Interface;

namespace VinamiToolUser.Views
{
    public partial class StockView : Form,IStockView
    {
        private MainView _mainView;
        private static StockView _instance;

        public event EventHandler SearchTool;

        public MachineModel CurrentMachine => _mainView.CurrentMachine;

        public StockPresenter Presenter { private get; set; }
        public string SearchValue { get => txtSearch.Text; set => txtSearch.Text = value; }

        public StockView()
        {
            InitializeComponent();
            AssignEvent();
        }

        private void AssignEvent()
        {
            this.Load += StockViewLoad;
            btnSearch.MouseClick += (s, e) => 
            {
                KeyBoard.CloseKeyboard(); 
                SearchTool?.Invoke(this, EventArgs.Empty); 
            };
            txtSearch.KeyDown += (s, e) =>
            {
                if(e.KeyCode == Keys.Enter)
                {
                    KeyBoard.CloseKeyboard();
                    SearchTool?.Invoke(this, EventArgs.Empty);
                }
            };
            txtSearch.MouseClick += (s, e) => { ShowKeyboard(); };
        }

        public static StockView GetInstance(Form parentContainer)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                //instance = new ToolView();
                _instance = UnityDI.container.Resolve<IStockView>() as StockView;
                _instance.MdiParent = parentContainer;
                _instance.FormBorderStyle = FormBorderStyle.None;
                _instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (_instance.WindowState == FormWindowState.Minimized)
                    _instance.WindowState = FormWindowState.Normal;
                _instance.BringToFront();
            }
            return _instance;
        }

        private void StockViewLoad(object sender, EventArgs e)
        {
            _mainView = MainView.GetInstance();
            _mainView.PrevView = "Menu";
            IStockRepository repository = UnityDI.container.Resolve<IStockRepository>();
            Presenter = new StockPresenter(this, repository);
        }

        public void SetStockBindingSource(BindingSource stockSource)
        {
            dgvTool.DataSource = stockSource;
        }
        private void ShowKeyboard()
        {
            var Keyboard = KeyBoard.GetInstance();
            int x = (Screen.PrimaryScreen.Bounds.Right - Keyboard.Width) / 2;
            int y = Screen.PrimaryScreen.Bounds.Bottom - Keyboard.Height;
            Keyboard.Show();
            Keyboard.Location = new Point(x, y);
        }
    }
}
