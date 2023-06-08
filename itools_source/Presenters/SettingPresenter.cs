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
            _mainView = MainView.GetInstance();
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
            LoadDataAndSetDisplayMember();
        }

        private void CancelEvent(object sender, EventArgs e)
        {
            LoadCurrentMachine();
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
            _curentMachine = _machineList.FirstOrDefault();
            _view.Machine = _curentMachine;
            if (_curentMachine != null)
            {
                _currentCompany = _companyList.Where(x => x.CompanyID == _curentMachine.CompanyID).FirstOrDefault();
                _view.Company = _currentCompany;
            }
            else 
            {
                _currentCompany = null;
                _view.Company = _currentCompany;
            }
        }
        private async void LoadMachineData()
        {
            if (_currentCompany == null) _machineList = await _repository.GetAllMachineList();
            else _machineList = await _repository.GetValidMachine(_currentCompany.CompanyID);
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
            _machineConfig = new MachineConfigModel();
            //Assign Config Value
            _machineConfig.CompanyID = _currentCompany.CompanyID;
            _machineConfig.MachineID = _curentMachine.MachineID;
            _machineConfig.ComPort = _view.ComPort;
            _machineConfig.HardDiskSerial = _view.HddSerial;
            //Save Config Value
            
            bool result = await _repository.UpdateMachineSerial(_machineConfig.MachineID, _machineConfig.HardDiskSerial);
            if (result) { _mainView.MachineConfig = _machineConfig; }
            else _view.Message = "Lưu cấu hình thất bại!!!";
        }
    }
}
