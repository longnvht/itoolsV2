using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using VinamiToolUser.Models;
using VinamiToolUser.Models.Interface;
using VinamiToolUser.Utils;
using VinamiToolUser.Views;
using VinamiToolUser.Views.Interface;

namespace VinamiToolUser.Presenters
{
    public class JobPresenter
    {
        private BindingSource _bindingSource;
        private IEnumerable<JobModel> _jobList;
        private IJobView _view;
        private IJobRepository _repository;
        

        public JobPresenter(IJobView view, IJobRepository repository)
        {
            
            this._bindingSource = new BindingSource();
            this._view = view;
            this._repository = repository;
            this._view.Presenter = this;
            this._view.SearchEvent += SearchJob;
            this._view.SelectJobEvent += SelectJob;
            _view.ChoseJobEvent += ChoseJob;
            this._view.SetJobListBindingSource(_bindingSource);
            LoadJobList();
        }

        private void ChoseJob(object sender, EventArgs e)
        {
            var job = (JobModel)_bindingSource.Current;
            _view.SelectedJob = job;
            _view.NextView = "SelectOp";
        }

        private async void LoadJobList()
        {
            _jobList = await _repository.GetAll();
            _bindingSource.DataSource = _jobList;
        }

        private void SelectJob(object sender, EventArgs e)
        {
            var job = (JobModel)_bindingSource.Current;
            _view.SelectedJob = job;
            _view.TempView = "SelectOp";
        }

        private async void SearchJob(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this._view.SearchValue);
            if (emptyValue == false)
                _jobList = await  _repository.GetByValue(this._view.SearchValue);
            _bindingSource.DataSource = _jobList;
            //_view.SearchValue = "";
        }
    }
}
