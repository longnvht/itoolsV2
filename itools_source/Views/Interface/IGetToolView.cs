using itools_source.Models;
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
    public interface IGetToolView
    {
        #region Properties
        ToolModel CurrentTool { get; set; }
        TrayModel CurrentTray { get; set; }
        string SearchToolValue { get; set; }
        string LogMessage { set; }
        bool GetToolResult { get; set; }
        bool IsRunning { get; set; }

        UserAccount UserLogin { get; }
        string OpNumber { get; }
        string JobNumber { get; }
        MachineConfigModel CurrentConfig { get; }
        GetToolPresenter Presenter { set; }
        MachineModel CurrentMachine { get; }

        #endregion

        #region Events
        event EventHandler SelectToolEvent;
        event EventHandler SearchToolEvent;
        event EventHandler UpdateToolStock;

        #endregion

        #region Method
        void SetToolListBindingSource(BindingSource toolList);
        void SetCurrentTrayListBindingSource(BindingSource trayList);
        void SetOtherTrayListBindingSource(BindingSource trayList);

        #endregion
    }
}
