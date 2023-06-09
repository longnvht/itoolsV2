using itools_source.Models;
using System;
using System.Windows.Forms;
using VinamiToolUser.Models;
using VinamiToolUser.Presenters;

namespace itools_source.Views.Interface
{
    public interface ISettingView
    {
        #region Properties - Fields
        string HddSerial { get; set; }
        string ComPort { get; set; }
        string SettingMessage { set; }
        UserAccount UserLogin { get; set; } 
        SettingPresenter Presenter { set; }
        string CompanyNameSelect { get; set; }
        string MachineName { get; set; }
        MachineModel CurrentMachine { get;}
        MachineConfigModel CurrentConfig { get;}
        #endregion

        #region Events
        event EventHandler CompanySelectEvent;
        event EventHandler MachineSelectEvent;
        event EventHandler ComPortSelectedEvent;
        event EventHandler SaveConfig;
        event EventHandler CancelEvent;

        #endregion

        #region Methods
        void SetMachineBindingSource(BindingSource machineList);
        void SetCompanyBindingSource(BindingSource companyList);
        void SetPortBindingSource(BindingSource portList);
        void CheckSaveCondition();
        void ReloadConfig();
        #endregion
    }
}
