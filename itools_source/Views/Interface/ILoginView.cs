using System;
using System.Windows.Forms;
using VinamiToolUser.Models;
using VinamiToolUser.Presenter;

namespace VinamiToolUser.Views.Interface
{
    public interface ILoginView
    {
        #region Properties - Fields
        string UserName { get; set; }
        string Password { get; set; }
        string Message { get; set; }
        UserAccount UserLogin { get; set; }
        LoginPresenter Presenter {set; }
        MachineConfigModel CurrentConfig { get; }
        #endregion

        #region Events
        event EventHandler LoginEvent;
        #endregion

        #region Methods
        #endregion
    }
}
