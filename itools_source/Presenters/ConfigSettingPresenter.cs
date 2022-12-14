using itools_source.Models;
using itools_source.Models.Interface;
using itools_source.Repository;
using itools_source.Views;
using itools_source.Views.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itools_source.Presenters
{
    public class ConfigSettingPresenter
    {
        public ConfigSettingPresenter(IConfigSettingView configSettingView, ICompanyRepository companyRepository)
        {
            _configSettingView = configSettingView;
            _companyRepository = companyRepository;

            _configSettingView.ConfigSettingView_Load += _configSettingView_ConfigSettingView_Load;
            _configSettingView.btnSave_Click += _configSettingView_btnSave_Click;
            _configSettingView.cmbCompany_SelectedValueChanged += _configSettingView_cmbCompany_SelectedValueChanged;

            _configSettingView.Show();
        }

        #region Properties - Fields
        private readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(MenuPresenter).Name);

        IConfigSettingView _configSettingView;
        ICompanyRepository _companyRepository;

        IMachineRepository _machineRepository;
        #endregion

        #region Events
        private async void _configSettingView_cmbCompany_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sender != null)
            {
                ConfigSettingView frm = sender as ConfigSettingView;

                if (frm.cmbCompany.SelectedItem != null)
                {
                    Company companySelect = frm.cmbCompany.SelectedItem as Company;

                    // Load list machine
                    if (_machineRepository == null)
                    {
                        _machineRepository = new MachineRepository();
                    }
                    if (companySelect != null)
                    {
                        if (await _machineRepository.GetMachines(companySelect.iCompanyId) != null)
                        {
                            frm.cmbMachine.ValueMember = "iMachineId";
                            frm.cmbMachine.DisplayMember = "strMachineName";
                            frm.cmbMachine.DataSource = await _machineRepository.GetMachines(companySelect.iCompanyId);
                        }
                    }
                }
            }
        }

        private void _configSettingView_btnSave_Click(object sender, EventArgs e)
        {
            if (sender != null)
            {
                ConfigSettingView frm = sender as ConfigSettingView;

                // Get list company, machine and get serial port.
                Company companySelected = frm.cmbCompany.SelectedItem as Company;
                Machine machineSelected = frm.cmbMachine.SelectedItem as Machine;
                string strSerialSelected = frm.cmbSerialPort.SelectedItem as string;

                // Set company, machine, and serial port to Properties.Setting
                if (companySelected != null)
                {
                    Properties.Settings.Default.CompanyId = companySelected.iCompanyId;
                }
                if (machineSelected != null)
                {
                    //Properties.Settings.Default.MachineId = machineSelected.iMachineId;
                }
                if (!string.IsNullOrEmpty(Properties.Settings.Default.SerialPort = strSerialSelected) || !string.IsNullOrWhiteSpace(Properties.Settings.Default.SerialPort = strSerialSelected))
                {
                    Properties.Settings.Default.SerialPort = strSerialSelected;
                }

                Properties.Settings.Default.Save();
            }
        }

        private async void _configSettingView_ConfigSettingView_Load(object sender, EventArgs e)
        {
            ConfigSettingView frm = sender as ConfigSettingView;

            // 1. Load list company
            if (_companyRepository == null)
            {
                _companyRepository = new CompanyRepository();
            }
            if (await _companyRepository.GetCompanies() != null)
            {
                frm.cmbCompany.DataSource = await _companyRepository.GetCompanies();
                frm.cmbCompany.ValueMember = "iCompanyId";
                frm.cmbCompany.DisplayMember = "strCompanyName";
            }

            // 2. Load list serial port
            string[] lstSerialPort = null;
            lstSerialPort = SerialPort.GetPortNames();
            if (lstSerialPort != null)
            {
                frm.cmbSerialPort.Items.AddRange(lstSerialPort);
            }
        }
        #endregion

        #region Methods
        #endregion
    }
}
