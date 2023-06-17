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
            _view.SearchTool += SearchToolStock;
            _view.SetStockBindingSource(_stockSource);
            LoadData();
        }

        private async void SearchToolStock(object sender, EventArgs e)
        {

            var companyCode = _view.CurrentMachine.CompanyCode;
            var serachValue = _view.SearchValue;
            if (String.IsNullOrEmpty(serachValue))
            {
                _stockList = await _repository.GetStockForMachine(companyCode);
                _stockSource.DataSource = _stockList;
            }
            else
            {
                _stockList = await _repository.SearchStockForMachine(companyCode, serachValue);
                _stockSource.DataSource = _stockList;
            }
        }

        private async void LoadData()
        {
            var companyCode = _view.CurrentMachine.CompanyCode;
            _stockList = await _repository.GetStockForMachine(companyCode);
            _stockSource.DataSource = _stockList;
        }
    }
}
