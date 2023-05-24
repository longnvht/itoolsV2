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
        ToolModel SelectedTool { get; set; }
        TrayModel SelectedTray { get; set; }
        string SearchToolValue { get; set; }

        string ToolCode { get; set; }
        string ToolName { get; set; }
        string TrayName { get; set; }
        string Quantity { get; set; }
        GetToolPresenterNew Presenter { set; }
        #endregion

        #region Events
        event EventHandler SelectToolEvent;
        event EventHandler SelectTrayEvent;
        event EventHandler SearchToolEvent;
        event EventHandler UpdateToolStock;

        #endregion

        #region Method
        void SetToolListBindingSource(BindingSource toolList);
        void SetTrayListBindingSource(BindingSource trayList);

        #endregion
    }
}
