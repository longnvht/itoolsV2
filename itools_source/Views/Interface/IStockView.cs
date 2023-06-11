using VinamiToolUser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VinamiToolUser.Presenters;

namespace VinamiToolUser.Views.Interface
{
    public interface IStockView
    {
        #region Propesties
        MachineModel CurrentMachine { get; }
        StockPresenter Presenter { set; }
        #endregion
        #region Method
        void SetStockBindingSource(BindingSource stockSource);
        #endregion
    }
}
