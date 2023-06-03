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
        OPModel CurrentOP { get; set; }
        ToolModel CurrentTool { get; set; }
        TrayModel CurrentTray { get; set; }
        //MainPresenterNew Presenter { set; }
        #endregion

        #region Events

        //event EventHandler GotoPrevView;

        #endregion

        #region Method
        //void CloseChildView();

        #endregion
    }
}
