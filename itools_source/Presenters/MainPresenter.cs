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

namespace VinamiToolUser.Presenters
{
    public class MainPresenter
    {
        private MachineModel _currentMachine;
        private IEnumerable<MachineModel> _machineList;
        private IMainView _view;
        private IMainRepository _repository;

        public MainPresenter(IMainView view, IMainRepository repository)
        {
            this._view = view;
            this._repository = repository;
            _view.Presenter = this;
            _view.ConfigChange += ConfigChange;
            GetCurrentMachineAndCheckConfig();
        }

        private void ConfigChange(object sender, EventArgs e)
        {
            GetCurrentMachineAndCheckConfig();
        }

        private async void GetCurrentMachineAndCheckConfig()
        {
            string serial = GetHardDiskSerial();
            _machineList = await _repository.GetCurrentMachineInfo(serial);
            _currentMachine = _machineList.FirstOrDefault();
            bool result = CheckConfig();
            if (result)
            {
                if(_view.UserLogin != null)  _view.CurrentView = "Home";
                else _view.CurrentView = "Login";
            }
            else _view.CurrentView = "Setting";
        }

        private bool CheckConfig()
        {
            //check data base info
            //Check config Null
            //Check machine serial
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

            if (_view.MachineConfig.HardDiskSerial != _currentMachine.MachineSerial || _view.MachineConfig.MachineID != _currentMachine.MachineID)
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
