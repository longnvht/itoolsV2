using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VinamiToolUser.Models.Interface;
using VinamiToolUser.Models;
using VinamiToolUser.Utils;
using VinamiToolUser.Views.Interface;
using VinamiToolUser.Views;

namespace VinamiToolUser.Presenters
{
    public class OpPresenterNew
    {
        private BindingSource _bindingSource;
        private IEnumerable<OPModel> _opList;
        private IOPViewNew _view;
        private IOpRepositoryNew _repository;
        

        public OpPresenterNew(IOPViewNew view, IOpRepositoryNew repository)
        {
            
            this._bindingSource = new BindingSource();
            this._view = view;
            this._repository = repository;
            this._view.Presenter = this;
            this._view.SearchEvent += SearchOp;
            this._view.OpSelectEvent += SelectOp;
            _view.ChoseOpEvent += ChoseOp;
            this._view.SetOpListBindingSource(_bindingSource);
            LoadOpList();
        }

        private void ChoseOp(object sender, EventArgs e)
        {
            var op = (OPModel)_bindingSource.Current;
            _view.SelectedOP = op;
            _view.NextView = "GetToolView";
        }

        private async void LoadOpList()
        {
            _opList = await _repository.GetAll(_view.CurrentJob);
            _bindingSource.DataSource = _opList;
        }

        private void SelectOp(object sender, EventArgs e)
        {
            var op = (OPModel)_bindingSource.Current;
            _view.TempView = "GetToolView";
            _view.SelectedOP = op;
        }

        private async void SearchOp(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(_view.SearchValue);
            if (emptyValue == false)
                _opList = await _repository.GetByValue(_view.CurrentJob, _view.SearchValue);
            else _opList = await _repository.GetAll(_view.CurrentJob);
            _bindingSource.DataSource = _opList;
        }
    }
}
