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
        ToolModel CurrentTool { get; set; }
        string SearchValue { get; set; }
        ToolMangerPresenter Presenter { set; }

        #endregion

        #region Events
        event EventHandler TraySelected;
        event EventHandler ToolSelected;
        event EventHandler Search;
        event EventHandler AddingTool;
        event EventHandler TakeOutTool;
        event EventHandler AddNewTool;
        #endregion

        #region Methods
        void SetTrayBindingSource(BindingSource trayList);
        void SetToolBindingSource(BindingSource toolList);
        #endregion
    }
}
