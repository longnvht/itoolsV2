using Guna.UI2.WinForms;
using itools_source.Views.Interface;
using System;
using System.Collections.Generic;
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
        public bool bCheckButton { get; set; }
        #endregion

        #region Events
        public event EventHandler MenuView_Load;
        #endregion

        #region Methods
        public void SetCheckedButton(string strContinueButton)
        {
            if (_flpMenu.Controls.Count > 0)
            {
                foreach (Control item in _flpMenu.Controls)
                {
                    Guna2GradientTileButton btn = (Guna2GradientTileButton)item;
                    if ((item.GetType() != typeof(Guna2GradientTileButton)) || (strContinueButton == btn.Text))
                    {
                        continue;
                    }
                    if (btn.Checked)
                    {
                        btn.Checked = false;
                        return;
                    }
                }
            }
        }

        public void ShowHideJobNumberAndOPId(bool bStatus)
        {
            ((MainView)MdiParent).ShowHideJobNumberAndOPId(bStatus);
        }

        public Form GetMdiParent()
        {
            return MdiParent;
        }

        public void SetMdiParent(Form mdiParent)
        {
            if (this.IsDisposed)
            {
                if (this.WindowState == FormWindowState.Minimized)
                {
                    this.WindowState = FormWindowState.Normal;
                }
                else
                {
                    this.Dock = DockStyle.Fill;
                }
                this.BringToFront();
            }
            else
            {
                this.MdiParent = mdiParent;
                this.FormBorderStyle = FormBorderStyle.None;
                this.Dock = DockStyle.Fill;
            }
        }
        #endregion




    }
}
