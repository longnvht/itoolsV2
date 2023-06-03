using itools_source.Views.Interface;
using System;
using System.Collections;
using System.Management;
using System.Management.Instrumentation;
using System.Windows.Forms;
using VinamiToolUser.Views.Interface;
using VinamiToolUser.Views;
using VinamiToolUser;
using Unity;
using VinamiToolUser.Presenters;
using VinamiToolUser.Models.Interface;
using System.IO.Ports;
using VinamiToolUser.Models;
using Salaros.Configuration;
using MySql.Data.MySqlClient;
using itools_source.Models;

namespace itools_source.Views
{
    public partial class SettingView : Form, ISettingView
    {
        private string appConfig = @"C:\ProgramData\VinamItools\VinamItoolsConfig.dat";
        private string _hddSerial;
        private MainView _mainView;

        private MachineConfigModel configModel;
        public SettingView()
        {
            InitializeComponent();
            AsignEvent();
        }

        private void AsignEvent()
        {
            this.Load += SettingViewLoad;
            btnSave.Click += (s, e) => { SaveConfig(); };
            btnEdit.Click += (s, e) =>
            {
                lblCompany.Text = cbxCompany.DisplayMember;
                lblMachine.Text = cbxMachine.DisplayMember;
                cbxCompany.DisplayMember = "CompanyName";
                cbxMachine.DisplayMember = "MachineName";
            };
            
        }

        private void SettingViewLoad(object sender, EventArgs e)
        {
            cbxCompany.DisplayMember = "CompanyName";
            cbxMachine.DisplayMember = "MachineName";
            ISettingRepository repository = UnityDI.container.Resolve<ISettingRepository>();
            Presenter = new SettingPresenter(this, repository);
            _mainView = MainView.GetInstance();
            _mainView.PrevView = "Menu";
            GetSerialPortList();
            _hddSerial = GetHardDiskSerial();
            txtHardDiskSerial.Text = _hddSerial;
            configModel = new MachineConfigModel();
            cbxCompany.DisplayMember = "CompanyName";
            cbxMachine.DisplayMember = "MachineName";
        }

        private void LoadConfig()
        {
            try
            {
                // load config .dat

                // check dictionary to link null -> create link
                var cfg = new ConfigParser(appConfig);
                int machineID;
                if(Int32.TryParse(cfg.GetValue("CONFIG", "MachineID"), out machineID))
                {
                    configModel.MachineID = machineID;
                }
                if (configModel.MachineID >= 0)
                {
                    configModel.MachineID = machineID;
                    configModel.ComPort = cfg.GetValue("CONFIG", "ComPort");
                    configModel.HardDiskSerial = cfg.GetValue("CONFIG", "HardDiskSerial");
                }

            }
            catch (Exception)
            {

            }
        }

        void SaveConfig()
        {
            string machineID = (cbxMachine.SelectedItem as MachineModel).MachineID.ToString();
            string comPort = cbxComPort.SelectedText;
            string hardDiskSerial = txtHardDiskSerial.Text;
            var cfg = new ConfigParser(appConfig);

            //

            cfg.SetValue("CONFIG", "MachineID", machineID);
            cfg.SetValue("CONFIG", "ComPort", comPort);
            cfg.SetValue("CONFIG", "HardDiskSerial", hardDiskSerial);
            cfg.Save();
        }

        private void GetSerialPortList()
        {
            string[] ports = SerialPort.GetPortNames();

            // Add all port names to the combo box:
            foreach (string port in ports)
            {
                cbxComPort.Items.Add(port);
            }
        }

        #region Properties - Fields
        public string strCompanyId { get; set; }
        public int? MachineID { get; set; }
        public string strSerialMachine { get; set; }
        public SettingPresenter Presenter { private get; set; }

        // Singleton pattern (Open a single form instance)
        private static SettingView instance;

        public static SettingView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = UnityDI.container.Resolve<ISettingView>() as SettingView;
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }
        #endregion

        #region Events

        #endregion

        #region Methods
        private string GetHardDiskSerial()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
            foreach (ManagementObject wmiObject in searcher.Get())
            {
                if (wmiObject["SerialNumber"] != null)
                {
                    return wmiObject["SerialNumber"].ToString().Trim();
                }
            }
            return string.Empty;

        }
        public void SetCompanyBindingSource(BindingSource companyList)
        {
            cbxCompany.DataSource = companyList;
        }

        public void SetMachineBindingSource(BindingSource machineList)
        {
            cbxMachine.DataSource = machineList;
        }
        
        #endregion



    }
}
