using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VinamiToolUser.Models.Interface;
using VinamiToolUser.Models;
using VinamiToolUser.Views.Interface;
using itools_source.Views.Interface;
using itools_source.Models;
using System.Management;
using VinamiToolUser.Views;
using System.IO.Ports;

namespace VinamiToolUser.Presenters
{
    public class SettingPresenter
    {
        private MainView _mainView;
        private MachineConfigModel _machineConfig;
        private MachineModel _curentMachine;
        private CompanyModel _currentCompany;
        private BindingSource _companySource;
        private BindingSource _portSource;
        private BindingSource _machineSource;
        private IEnumerable<MachineModel> _machineList;
        private IEnumerable<CompanyModel> _companyList;
        private ISettingView _view;
        private ISettingRepository _repository;

        public SettingPresenter(ISettingView view, ISettingRepository repository)
        {
            _companySource = new BindingSource();
            _machineSource = new BindingSource();
            _portSource = new BindingSource();
            _view = view;
            _repository = repository;
            _view.Presenter = this;
            _view.SetCompanyBindingSource(_companySource);
            _view.SetMachineBindingSource(_machineSource);
            _view.SetPortBindingSource(_portSource);
            _view.CompanySelectEvent += CompanySelectedEvent;
            _view.MachineSelectEvent += MachineSelectedEvent;
            view.SaveConfig += SaveConfig;
            _view.HddSerial = GetHardDiskSerial();

            GetSerialPortList();
            LoadDataAndSetDisplayMember();
        }

        private async void LoadDataAndSetDisplayMember()
        {
            _companyList = await _repository.GetCompanyList();
            _companySource.DataSource = _companyList;
            LoadCurrentMachine();
        }

        private void MachineSelectedEvent(object sender, EventArgs e)
        {
            _curentMachine = _machineSource.Current as MachineModel;
            _view.Machine = _curentMachine;
        }

        private void CompanySelectedEvent(object sender, EventArgs e)
        {
            _currentCompany = _companySource.Current as CompanyModel;
            _view.Company = _currentCompany;
            LoadMachineData();
        }

        private async void LoadCurrentMachine()
        {
            _machineList = await _repository.GetCurentMachine(_view.HddSerial);
            if(_machineList.Count() > 0) 
            {
                _curentMachine = _machineList.FirstOrDefault();
            }
            else _machineList = await _repository.GetAllMachineList();
            _machineSource.DataSource = _machineList;
            _view.Machine = _curentMachine;
        }
        private async void LoadMachineData()
        {
            if (_currentCompany == null) _machineList = await _repository.GetAllMachineList();
            else _machineList = await _repository.GetMachineListForCompany(_currentCompany.CompanyID);
            _machineSource.DataSource = _machineList;
        }

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

        private void GetSerialPortList()
        {
            string[] ports = SerialPort.GetPortNames();
            _portSource.DataSource = ports;
        }

        private void SaveConfig(object sender, EventArgs e)
        {
            _machineConfig = new MachineConfigModel();
            //Assign Config Value
            _machineConfig.CompanyID = _currentCompany.CompanyID;
            _machineConfig.MachineID = _curentMachine.MachineID;
            _machineConfig.ComPort = _view.ComPort;
            _machineConfig.HardDiskSerial = _view.HddSerial;
            //Save Config Value
            _mainView.MachineConfig = _machineConfig;
        }
    }
}
