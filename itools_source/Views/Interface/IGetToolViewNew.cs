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
    public interface IGetToolViewNew
    {
        #region Properties
        ToolModel CurrentTool { get; set; }
        TrayModel CurrentTray { get; set; }
        string SearchToolValue { get; set; }
        string LogMessage { set; }
        bool GetToolResult { get; set; }
        UserAccount UserLogin { get; }
        string OpNumber { get; }
        string JobNumber { get; }
        GetToolPresenterNew Presenter { set; }
        #endregion

        #region Events
        event EventHandler SelectToolEvent;
        event EventHandler SearchToolEvent;
        event EventHandler UpdateToolStock;

        #endregion

        #region Method
        void SetToolListBindingSource(BindingSource toolList);
        void SetTrayListBindingSource(BindingSource trayList);

        #endregion
    }
}
