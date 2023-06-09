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
using VinamiToolUser.Utils;

namespace VinamiToolUser.Presenters
{
    public class SettingPresenter
    {
        private MachineModel _currentMachine;
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
            _view.SaveConfig += SaveConfig;
            _view.CancelEvent += CancelEvent;
            _view.HddSerial = GetHardDiskSerial();
            GetSerialPortList();
            LoadData();
        }

        private void LoadCurrentConfig()
        {
            if(_view.CurrentMachine != null)
            {
                _currentCompany = _companyList.Where(x => x.CompanyID == _view.CurrentMachine.CompanyID).FirstOrDefault();
                _currentMachine = _machineList.Where(x => x.MachineID == _view.CurrentMachine.MachineID).FirstOrDefault();
                _view.CompanyNameSelect = _currentCompany.CompanyName;
                _view.MachineName = _currentMachine.MachineName;
                if(_view.CurrentConfig != null) { _view.ComPort = _view.CurrentConfig.ComPort; }
            }
        }

        private void CancelEvent(object sender, EventArgs e)
        {
            LoadCurrentConfig();
        }

        private async void LoadData()
        {
            _companyList = await _repository.GetCompanyList();
            _companySource.DataSource = _companyList;
            _machineList = await _repository.GetAllMachineList();
            _machineSource.DataSource = _machineList;
            LoadCurrentConfig();
        }

        private void MachineSelectedEvent(object sender, EventArgs e)
        {
            _currentMachine = _machineSource.Current as MachineModel;
            _view.MachineName = _currentMachine.MachineName;
        }

        private void CompanySelectedEvent(object sender, EventArgs e)
        {
            _currentCompany = _companySource.Current as CompanyModel;
            _view.CompanyNameSelect = _currentCompany.CompanyName;
            LoadMachineData();
        }

        private async void LoadMachineData()
        {
            _machineList = await _repository.GetValidMachine(_currentCompany.CompanyID);
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

        private async void SaveConfig(object sender, EventArgs e)
        {
            MachineConfigModel machineConfig = new MachineConfigModel();
            //Assign Config Value
            machineConfig.CompanyID = _currentCompany.CompanyID;
            machineConfig.MachineID = _currentMachine.MachineID;
            machineConfig.ComPort = _view.ComPort;
            machineConfig.HardDiskSerial = _view.HddSerial;
            //Save Config Value
            
            bool result = await _repository.UpdateMachineSerial(machineConfig.MachineID, machineConfig.HardDiskSerial);
            if (result) 
            {
                CommonValue.ConfigModel = machineConfig;
                _view.SettingMessage = "";
                _view.ReloadConfig();
            }
            else _view.SettingMessage = "Lưu cấu hình thất bại!!!";
        }
    }
}
