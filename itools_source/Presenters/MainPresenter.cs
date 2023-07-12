using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VinamiToolUser.Models.Interface;
using VinamiToolUser.Models;
using VinamiToolUser.Views.Interface;
using itools_source.Models;
using System.Management;
using VinamiToolUser.Utils;
using MySqlX.XDevAPI.Common;

namespace VinamiToolUser.Presenters
{
    public class MainPresenter
    {
        private string _hddSerial;
        private MachineModel _currentMachine;
        private IMainView _view;
        private IMainRepository _repository;

        public MainPresenter(IMainView view, IMainRepository repository)
        {
            this._view = view;
            this._repository = repository;
            _view.Presenter = this;
            _view.ConfigChange += ConfigChange;
            _view.SyncDataEvent += SyncData;
            _hddSerial = GetHardDiskSerial();
            LoadingAndSyncData();
        }

        private void SyncData(object sender, EventArgs e)
        {
            SynchronizationData();
        }

        private async void LoadingAndSyncData()
        {
            _view.MachineConfig = CommonValue.LoadConfig();
            bool result = await CheckConfig();
            if (result)
            {
                if (_view.UserLogin != null) _view.CurrentView = "Menu";
                else _view.CurrentView = "Login";
                SynchronizationData();
            }
            else _view.CurrentView = "Setting";
        }

        private async void SynchronizationData()
        {
            _view.Message = "Start Sync Data";
            await SyncLocalToHost();
            await SyncHostToLocal();
            _view.Message = "";
        }

        private async Task SyncLocalToHost()
        {
            //SyncLocalToHost_ToolsMachineTray
            //SyncLocalToHost_WorkingTransaction
            bool result = false;
            _view.Message = "Start SyncLocalToHost_ToolsMachineTray";
            result = await _repository.SyncLocalToHost_ToolsMachineTray(_currentMachine.MachineCode, _currentMachine.CompanyCode);
            if (result) _view.Message = "Susces SyncLocalToHost_ToolsMachineTray";
            _view.Message = "Start SyncLocalToHost_WorkingTransaction";
            result = await _repository.SyncLocalToHost_WorkingTransaction(_currentMachine.MachineCode, _currentMachine.CompanyCode);
            if (result) _view.Message = "Susces SyncLocalToHost_WorkingTransaction";
        }

        private async Task SyncHostToLocal()
        {
            //SyncHostToLocal_Assessor
            //SyncHostToLocal_RoleAssessor
            //SyncHostToLocal_Machine
            //SyncHostToLocal_Company
            //SyncHostToLocal_CompanyMachine
            //SyncHostToLocal_Tools
            bool result = false;
            _view.Message = "Start SyncHostToLocal_Assessor";
            result = await _repository.SyncHostToLocal_Assessor(_currentMachine.MachineCode, _currentMachine.CompanyCode);
            if (result) _view.Message = "Susces SyncHostToLocal_Assessor";
            _view.Message = "Start SyncHostToLocal_RoleAssessor";
            result = await _repository.SyncHostToLocal_RoleAssessor(_currentMachine.MachineCode, _currentMachine.CompanyCode);
            if (result) _view.Message = "Susces SyncHostToLocal_RoleAssessor";
            _view.Message = "Start SyncHostToLocal_Machine";
            result = await _repository.SyncHostToLocal_Machine(_currentMachine.MachineCode, _currentMachine.CompanyCode);
            if (result) _view.Message = "Susces SyncHostToLocal_Machine";
            _view.Message = "Start SyncHostToLocal_Company";
            result = await _repository.SyncHostToLocal_Company(_currentMachine.MachineCode, _currentMachine.CompanyCode);
            if (result) _view.Message = "Susces SyncHostToLocal_Company";
            _view.Message = "Start SyncHostToLocal_CompanyMachine";
            result = await _repository.SyncHostToLocal_CompanyMachine(_currentMachine.MachineCode, _currentMachine.CompanyCode);
            if (result) _view.Message = "Susces SyncHostToLocal_CompanyMachine";
            _view.Message = "Start SyncHostToLocal_Tools";
            result = await _repository.SyncHostToLocal_Tools(_currentMachine.MachineCode, _currentMachine.CompanyCode);
            if (result) _view.Message = "Susces SyncHostToLocal_Tools";
        }

        private void ConfigChange(object sender, EventArgs e)
        {
            MenuNavigator();
        }

        private async void MenuNavigator()
        {
            var result = await CheckConfig();
            if (result)
            {
                if (_view.UserLogin != null) _view.CurrentView = "Menu";
                else _view.CurrentView = "Login";
            }
            else _view.CurrentView = "Setting";
        }


        private async Task<MachineModel> GetCurrentMachine()
        {
            var result = await _repository.GetCurrentMachineInfo(_hddSerial);
            return result.FirstOrDefault();
        }

        private async Task<bool>  CheckConfig()
        {
            //check data base info
            //Check config Null
            //Check machine serial
            _currentMachine = await GetCurrentMachine();
            _view.CurrentMachine = _currentMachine;
            bool result = true;

            if (_currentMachine == null)
            {
                result = false;
                _view.Message = "Thiết bị chưa được cấu hình, vui lòng thiết lập các thông số cho thiết bị";
                return result;
            }
            if (_view.MachineConfig == null)
            {
                result = false;
                _view.Message = "Thiết bị chưa được cấu hình, vui lòng thiết lập các thông số cho thiết bị";
                return result;
            }

            if (_view.MachineConfig.HardDiskSerial != _currentMachine.MachineSerial || _view.MachineConfig.MachineCode != _currentMachine.MachineCode)
            {
                result = false;
                _view.Message = "Cấu hình thiết bị không phù hợp, vui lòng thiết lập lại các thông số cho thiết bị";
                return result;
            }
            return result;
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
    }
}
