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
    public partial class MenuView : Form, IMenuView
    {
        public MenuView()
        {
            InitializeComponent();
            Load += delegate { MenuView_Load?.Invoke(this, EventArgs.Empty); };
        }

        #region Properties - Fields
        // Singleton pattern (Open a single form instance)
        private static MenuView _instance;

        public static MenuView GetInstance(Form parentContainer)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new MenuView();
                _instance.MdiParent = parentContainer;
                _instance.FormBorderStyle = FormBorderStyle.None;
                _instance.Dock = DockStyle.Fill;
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

        public string strMenuId { get; set; }
        public string strMenuName { get; set; }
        public List<Models.Menu> lstMenu { get; set; }
        #endregion
        #region Events
        public event EventHandler MenuView_Load;
        public event EventHandler btnItem_Click;
        #endregion
        #region Methods
        #endregion
    }
}
