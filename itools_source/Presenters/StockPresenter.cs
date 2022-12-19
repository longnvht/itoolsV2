using itools_source.Models.Interface;
using itools_source.Views;
using itools_source.Views.Interface;
using System;

namespace itools_source.Presenters
{
    public class StockPresenter
    {
        public StockPresenter(IStockView stockView, IStockRepository stockRepository)
        {
            _stockView = stockView;
            _stockRepository = stockRepository;

            _stockView.StockView_Load += _stockView_StockView_Load;

            _stockView.Show();
        }

        private async void _stockView_StockView_Load(object sender, EventArgs e)
        {
            StockView frm = (StockView)sender;

            // Park data in combobox
            frm.colToolId.DataSource = await _stockRepository.GetToolIdToolCode();
            frm.colToolId.ValueMember = "iToolId";
            frm.colToolId.DisplayMember = "strToolCode";

            // Park data in guna datagridview
            frm.dgvStock.Columns["_colToolId"].DataPropertyName = "iToolId";
            frm.dgvStock.Columns["colQuantity"].DataPropertyName = "iQuantity";
            frm.dgvStock.Columns["colLocation"].DataPropertyName = "strLocation";
            frm.dgvStock.DataSource = await _stockRepository.GetStocks();
        }

        #region Properties - Fields
        private readonly IStockView _stockView;
        private readonly IStockRepository _stockRepository;
        #endregion

        #region Events
        #endregion

        #region Methods
        #endregion
    }
}
