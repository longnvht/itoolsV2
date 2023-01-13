using Guna.UI2.WinForms;
using itools_source.Models;
using itools_source.Models.Interface;
using itools_source.Repository;
using itools_source.Views;
using itools_source.Views.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;

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
        private void _configSettingView_cmbCompany_SelectedValueChanged(object sender, EventArgs e)
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
                        BindingList<Machine> lstMachineByCompanyID = _machineRepository.GetMachines(companySelect.iCompanyId).Result as BindingList<Machine>;
                        if (lstMachineByCompanyID != null)
                        {
                            frm.cmbMachine.ValueMember = "iMachineId";
                            frm.cmbMachine.DisplayMember = "strMachineName";
                            frm.cmbMachine.DataSource = lstMachineByCompanyID;
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
                if (companySelected == null)
                {
                    MessageDialog.Show("Bạn Chưa Chọn Công Ty.",
                                        "Thông Báo",
                                        MessageDialogButtons.OK,
                                        MessageDialogIcon.Information,
                                        MessageDialogStyle.Default);
                    frm.cmbCompany.Focus();
                }
                else if (machineSelected == null)
                {
                    MessageDialog.Show("Bạn Chưa Chọn Máy.",
                                        "Thông Báo",
                                        MessageDialogButtons.OK,
                                        MessageDialogIcon.Information,
                                        MessageDialogStyle.Default);
                    frm.cmbMachine.Focus();
                }
                else if (string.IsNullOrEmpty(VinamiToolUser.Properties.Settings.Default.SerialPort) || string.IsNullOrWhiteSpace(VinamiToolUser.Properties.Settings.Default.SerialPort))
                {
                    MessageDialog.Show("Bạn Chưa Chọn Cổng.",
                                        "Thông Báo",
                                        MessageDialogButtons.OK,
                                        MessageDialogIcon.Information,
                                        MessageDialogStyle.Default);
                    frm.cmbSerialPort.Focus();
                }
                else
                {
                    VinamiToolUser.Properties.Settings.Default.CompanyId = companySelected.iCompanyId;
                    VinamiToolUser.Properties.Settings.Default.MachineId = machineSelected.iMachineId.Value;
                    VinamiToolUser.Properties.Settings.Default.SerialPort = strSerialSelected;

                    VinamiToolUser.Properties.Settings.Default.Save();
                    MessageDialog.Show("Lưu Thành Công.",
                                        "Thông Báo",
                                        MessageDialogButtons.OK,
                                        MessageDialogIcon.Information,
                                        MessageDialogStyle.Default);
                }
            }
        }

        private void _configSettingView_ConfigSettingView_Load(object sender, EventArgs e)
        {
            ConfigSettingView frm = sender as ConfigSettingView;

            // 1. Load list company
            if (_companyRepository == null)
            {
                _companyRepository = new CompanyRepository();
            }
            List<Company> companies = _companyRepository.GetCompanies().Result.ToList();
            if (companies != null)
            {
                frm.cmbCompany.DataSource = companies;
                frm.cmbCompany.ValueMember = "iCompanyId";
                frm.cmbCompany.DisplayMember = "strCompanyName";
            }

            // 2. Load list serial port
            string[] lstSerialPort = SerialPort.GetPortNames();
            //lstSerialPort = SerialPort.GetPortNames();
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
