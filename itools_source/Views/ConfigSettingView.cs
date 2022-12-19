using itools_source.Views.Interface;
using System;
using System.Windows.Forms;

namespace itools_source.Views
{
    public partial class ConfigSettingView : Form, IConfigSettingView
    {
        public ConfigSettingView()
        {
            InitializeComponent();
            this.Load += delegate { ConfigSettingView_Load?.Invoke(this, EventArgs.Empty); };
            btnSave.Click += delegate { btnSave_Click?.Invoke(this, EventArgs.Empty); };
            cmbCompany.SelectedValueChanged += delegate { cmbCompany_SelectedValueChanged?.Invoke(this, EventArgs.Empty); };
        }

        #region Properties - Fields
        public string strCompanyId { get; set; }
        public string strMachineId { get; set; }

        // Singleton pattern (Open a single form instance)
        private static ConfigSettingView _instance;

        public static ConfigSettingView GetInstance(Form parentContainer)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new ConfigSettingView();
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
        #endregion

        #region Events
        public event EventHandler ConfigSettingView_Load;
        public event EventHandler btnSave_Click;
        public event EventHandler cmbCompany_SelectedValueChanged;
        #endregion

        #region Methods
        #endregion
    }
}
