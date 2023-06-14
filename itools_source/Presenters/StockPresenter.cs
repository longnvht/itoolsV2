using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VinamiToolUser.Models;
using VinamiToolUser.Models.Interface;
using VinamiToolUser.Views.Interface;

namespace VinamiToolUser.Presenters
{
    public class StockPresenter
    {
        private BindingSource _stockSource;
        private IEnumerable<StockModel> _stockList;
        private IStockView _view;
        private IStockRepository _repository;

        public StockPresenter(IStockView view, IStockRepository repository)
        {
            _stockSource = new BindingSource();
            _view = view;
            _repository = repository;
            _view.Presenter = this;
            _view.SetStockBindingSource(_stockSource);
            LoadData();
        }

        private async void LoadData()
        {
            var machineCode = _view.CurrentMachine.MachineCode;
            _stockList = await _repository.GetStockForMachine(machineCode);
            _stockSource.DataSource = _stockList;
        }
    }
}
