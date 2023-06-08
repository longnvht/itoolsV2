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
using VinamiToolUser.Utils;
using Guna.UI2.WinForms;

namespace itools_source.Views
{
    public partial class SettingView : Form, ISettingView
    {
        private UserAccount _userLogin;
        private CompanyModel _company;
        private MachineModel _machine;
        private static SettingView instance;

        public SettingView()
        {
            InitializeComponent();
            AsignEvent();
        }

        #region Properties - Fields
        public SettingPresenter Presenter { private get; set; }
        public CompanyModel Company 
        { 
            get => _company;
            set
            {
                _company = value;
                txtMachine.Text = "";
                if (_company != null) txtCompany.Text = _company.CompanyName;
                else txtCompany.Text = "";
            }
        }
        public MachineModel Machine 
        { 
            get => _machine;
            set 
            { 
                _machine = value;
                if(_machine != null) txtMachine.Text = _machine.MachineName;
                else { txtMachine.Text = ""; };
            }
        }

        public string HddSerial { get => txtHardDiskSerial.Text; set => txtHardDiskSerial.Text = value; }
        public string ComPort
        {
            get => cbxComPort.Text;
        }

        public string Message { get => lblSaveMessage.Text; set => lblSaveMessage.Text = value; }
        public UserAccount UserLogin { get => _userLogin; set => _userLogin = value; }

        #endregion

        #region Methods
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

        private void AsignEvent()
        {
            this.Load += SettingViewLoad;
            txtCompany.Click += (s, e) => 
            {
                grbSetting.Enabled = false;
                grbCompanyList.Visible = true; 
            };
            txtMachine.Click += (s, e) => 
            {
                grbSetting.Enabled = false;
                grbMachineList.Visible = true; 
            };
            btnCompanyCancel.Click += (s, e) =>
            {
                grbSetting.Enabled = true;
                grbCompanyList.Visible = false;
            };
            btnMachineCancel.Click += (s, e) =>
            {
                grbSetting.Enabled = true;
                grbMachineList.Visible = false;
            };
            btnCompanySelect.Click += (s, e) =>
            {
                grbSetting.Enabled = true;
                grbCompanyList.Visible = false;
                CompanySelectEvent?.Invoke(this, EventArgs.Empty);
                CheckSaveCondition();
            };
            btnMachineSelect.Click += (s, e) =>
            {
                grbSetting.Enabled = true;
                grbMachineList.Visible = false;
                MachineSelectEvent?.Invoke(this, EventArgs.Empty);
                CheckSaveCondition();
            };
            cbxComPort.SelectedIndexChanged += (s, e) =>
            {
                CheckSaveCondition();
            };

            btnSave.Click += (s, e) =>
            {
                SaveConfig?.Invoke(this, EventArgs.Empty);
                SetDisplayMode(0);
            };
            btnEdit.Click += (s, e) =>
            {
                SetDisplayMode(1);
            };
            btnCancel.Click += (s, e) => 
            { 
                CancelEvent?.Invoke(this, EventArgs.Empty);
                SetDisplayMode(0); 
            };
            btnExit.Click += (s, e) => { Application.Exit(); };
        }

        private void SettingViewLoad(object sender, EventArgs e)
        {
            ISettingRepository repository = UnityDI.container.Resolve<ISettingRepository>();
            Presenter = new SettingPresenter(this, repository);
            grbCompanyList.Visible = false;
            grbMachineList.Visible = false;
            SetDisplayMode(0);
            CheckSaveCondition();
        }

        public void SetMachineBindingSource(BindingSource machineList)
        {
            lstMachine.DataSource = machineList;
        }
        public void SetCompanyBindingSource(BindingSource companyList)
        {
            lstCompany.DataSource = companyList;
        }

        public void SetPortBindingSource(BindingSource portList)
        {
            cbxComPort.DataSource = portList;
        }

        /// <summary>
        /// Đặt chế độ hiển thị cho Setting Form
        /// </summary>
        /// <param name="mode">Chế độ hiển thị, 0: View Mode, 1: Edit Mode. </param>
        private void SetDisplayMode(int mode)
        {
            switch (mode)
            {
                case 0:
                    {
                        if (UserLogin == null) btnExit.Visible = true;
                        grbCompanyList.Visible = false;
                        grbMachineList.Visible = false;
                        btnEdit.Enabled = true;
                        txtCompany.Enabled = false;
                        txtMachine.Enabled = false;
                        cbxComPort.Enabled = false;
                        btnCancel.Enabled = false;
                        btnSave.Enabled = false;
                    }
                    break;
                case 1:
                    {
                        btnExit.Visible = false;
                        btnEdit.Enabled = false;
                        if(Company == null) txtCompany.Enabled = true;
                        if(Machine == null) txtMachine.Enabled = true;
                        cbxComPort.Enabled = true;
                        btnCancel.Enabled = true;
                        btnSave.Enabled = false;
                    }
                    break;
            }
        }
        public void CheckSaveCondition()
        {
            bool result = true;
            var machine = txtMachine.Text;
            if (String.IsNullOrEmpty(machine)) result = false;
            var company = txtCompany.Text;
            if (String.IsNullOrEmpty(company)) result = false;
            var comport = cbxComPort.Text;
            if (String.IsNullOrEmpty(comport)) result = false;
            if(result) btnSave.Enabled = true;
            else btnSave.Enabled = false;
        }

        #endregion

        #region Events

        public event EventHandler CompanySelectEvent;
        public event EventHandler MachineSelectEvent;
        public event EventHandler SaveConfig;
        public event EventHandler ComPortSelectedEvent;
        public event EventHandler CancelEvent;

        #endregion

    }
}
