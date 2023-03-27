using itools_source.Views.Interface;
using System;
using System.Management;
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
        public int? MachineID { get; set; }
        public string strSerialMachine { get; set; }

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
        public string GetComputerSerialNumber()
        {
            ManagementClass mc = new ManagementClass("Win32_BIOS");
            ManagementObjectCollection moc = mc.GetInstances();

            string serialNumber = "";

            foreach (ManagementObject mo in moc)
            {
                serialNumber = mo["SerialNumber"].ToString();
                break;
            }
            return serialNumber;
        }
        #endregion
    }
}
