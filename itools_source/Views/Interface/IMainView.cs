using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VinamiToolUser.Presenters;
using itools_source.Models;
using VinamiToolUser.Models;

namespace VinamiToolUser.Views.Interface
{
    public interface IMainView
    {
        #region Properties
        UserAccount UserLogin  { get; set; }
        JobModel CurrentJob { get; set; }
        string CurrentView { get; set; }
        string TempView { get; set; } 
        string PrevView { get; set; }
        string HddSerial { get; set; }
        string Message { get; set; }

        bool IsRunning { get; set; }

        MachineConfigModel MachineConfig { get; set; }
        OPModel CurrentOP { get; set; }
        ToolModel CurrentTool { get; set; }
        TrayModel CurrentTray { get; set; }
        MainPresenter Presenter { set; }
        MachineModel CurrentMachine { get; set; }
        #endregion

        #region Events

        event EventHandler ConfigChange;
        event EventHandler SyncDataEvent;

        #endregion

        #region Method
        void LoadConfig();
        #endregion
    }
}
