using Guna.UI2.WinForms;
using itools_source.Models.Interface;
using itools_source.Views;
using itools_source.Views.Interface;
using System;
using System.Windows.Forms;

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

        #region Properties - Fields
        private readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(StockPresenter).Name);

        private readonly IStockView _stockView;
        private readonly IStockRepository _stockRepository;
        #endregion

        #region Events
        #endregion

        #region Methods
        private async void _stockView_StockView_Load(object sender, EventArgs e)
        {
            if (VinamiToolUser.Properties.Settings.Default.MachineId == null || VinamiToolUser.Properties.Settings.Default.MachineId <= 0)
            {
                MessageDialog.Show("Không Lấy Được Mã Máy.");
                _log.Error("MechineID is null.");
                return;
            }

            StockView frm = (StockView)sender;

            // Park data in combobox
            frm.colToolId.DataSource = await _stockRepository.GetToolIdToolCode();
            frm.colToolId.ValueMember = "iToolId";
            frm.colToolId.DisplayMember = "strToolCode";

            // Park data in guna datagridview
            //frm.dgvStock.Columns["_colTrayIndex"].DataPropertyName = "strTrayIndex";
            //frm.dgvStock.Columns["_colToolId"].DataPropertyName = "iToolId";
            //frm.dgvStock.Columns["_colQuantity"].DataPropertyName = "iQuantity";
            //frm.dgvStock.Columns["_colUpdateDate"].DataPropertyName = "dtUpdateDate";
            frm.dgvStock.DataSource = await _stockRepository.GetReportStockByMachineID(VinamiToolUser.Properties.Settings.Default.MachineId);
        }
        #endregion
    }
}
