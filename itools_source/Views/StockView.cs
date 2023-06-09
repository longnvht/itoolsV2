using itools_source.Models;
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
        public MachineModel CurrentMachine => _mainView.CurrentMachine;

        public StockPresenter Presenter { private get; set; }

        public StockView()
        {
            InitializeComponent();
            AssignEvent();
        }

        private void AssignEvent()
        {
            this.Load += StockViewLoad;
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
    }
}
