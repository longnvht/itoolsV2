using itools_source.Models;
using itools_source.Views.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itools_source.Views
{
    public partial class StockView : Form, IStockView
    {
        public StockView()
        {
            InitializeComponent();
            this.Load += delegate { StockView_Load?.Invoke(this, EventArgs.Empty); };
        }

        #region Properties - Fields

        public BindingList<Stock> lstStock { get; set; }

        // Singleton pattern (Open a single form instance)
        private static StockView _instance;

        public static StockView GetInstance(Form parentContainer)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new StockView
                {
                    MdiParent = parentContainer,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
            }
            else
            {
                if (_instance.WindowState == FormWindowState.Minimized)
                {
                    _instance.WindowState = FormWindowState.Normal;
                }
                _instance.BringToFront();
            }
            return _instance;
        }
        #endregion

        #region Events
        public event EventHandler StockView_Load;
        #endregion

        #region Methods
        #endregion
    }
}
