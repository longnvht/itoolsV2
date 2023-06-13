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
        MachineModel CurrentMachine { get; }
        MachineConfigModel CurrentConfig { get; }
        TrayModelManage CurrentTray { get; set; }
        TempToolModel CurrentTool { get; set; }
        UserAccount  UserLogin { get; }
        string SearchValue { get; set; }
        string SearchType { get; set; }
        string ViewAction { get; set; }
        string ModifyState { get; set; }
        string Log{ get; set; }
        int NewQty { get; set; }
        int ModifyQty { get; set; }
        ManagerToolPresenter Presenter { set; }

        #endregion

        #region Events
        event EventHandler TraySelected;
        event EventHandler GetStockToolList;
        event EventHandler SearchEvent;
        event EventHandler UpdateModifyEvent;
        event EventHandler AddNewToolEvent;
        #endregion

        #region Methods
        void SetTrayBindingSource(BindingSource trayList);
        void SetToolBindingSource(BindingSource toolList);
        #endregion
    }
}
