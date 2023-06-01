using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VinamiToolUser.Models;
using VinamiToolUser.Presenters;

namespace VinamiToolUser.Views.Interface
{
    public interface IManageToolView
    {
        #region Properties
        TrayModelManage CurrentTray { get; set; }
        TempToolModel CurrentTool { get; set; }
        string SearchValue { get; set; }
        string SearchType { get; set; }
        string ViewAction { get; set; }
        string ModifyState { get; set; }
        int NewQty { get; set; }
        int NewStock { get; set; }
        ManagerToolPresenter Presenter { set; }

        #endregion

        #region Events
        event EventHandler TraySelected;
        event EventHandler GetStockToolList;
        event EventHandler SearchEvent;
        event EventHandler UpdateModifyEvent;
        event EventHandler GetCurrentToolStock;
        #endregion

        #region Methods
        void SetTrayBindingSource(BindingSource trayList);
        void SetToolBindingSource(BindingSource toolList);
        #endregion
    }
}
