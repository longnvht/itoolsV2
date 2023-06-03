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

namespace VinamiToolUser.Presenters
{
    public class SettingPresenter
    {
        private BindingSource _companySource;
        private BindingSource _machineSource;
        private IEnumerable<MachineModel> _machineList;
        private IEnumerable<CompanyModel> _companyList;
        private ISettingView _view;
        private ISettingRepository _repository;


        public SettingPresenter(ISettingView view, ISettingRepository repository)
        {

            this._companySource = new BindingSource();
            this._machineSource = new BindingSource();
            this._view = view;
            this._repository = repository;
            this._view.Presenter = this;
            this._view.SetCompanyBindingSource(_companySource);
            this._view.SetMachineBindingSource(_machineSource);
            LoadData();
        }

        private async void LoadData()
        {
            _companyList = await _repository.GetCompanyList();
            _companySource.DataSource = _companyList;

            _machineList = await _repository.GetMachineList();
            _machineSource.DataSource = _machineList;
        }
    }
}
