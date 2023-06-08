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

namespace VinamiToolUser.Presenters
{
    public class MainPresenter
    {
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
            _machineList = await _repository.GetCurrentMachineInfo(_view.HddSerial, _view.MachineConfig.MachineID);
            _view.CurrentMachine = _machineList.FirstOrDefault();
            bool result = _view.CheckConfig();
            if (result)
            {
                if(_view.UserLogin != null)  _view.CurrentView = "Home";
                else _view.CurrentView = "Login";
            }
            else _view.CurrentView = "Setting";
        }
    }
}
