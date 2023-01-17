using itools_source.Models;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace itools_source.Views.Interface
{
    public interface IStockView
    {
        #region Properties - Fields
        BindingList<Stock> lstStock { get; set; }
        #endregion

        #region Events
        event EventHandler StockView_Load;
        #endregion

        #region Methos
        void Show();
        void Close();
        Form GetMdiParent();
        void SetMdiParent(Form mdiParent);
        #endregion
    }
}
