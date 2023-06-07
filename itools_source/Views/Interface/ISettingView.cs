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
        SettingPresenter Presenter { set; }
        CompanyModel Company { get; set; }
        MachineModel Machine { get; set; }
        #endregion

        #region Events
        event EventHandler CompanySelectEvent;
        event EventHandler MachineSelectEvent;
        event EventHandler ComPortSelectedEvent;
        event EventHandler SaveConfig;

        #endregion

        #region Methods
        void SetMachineBindingSource(BindingSource machineList);
        void SetCompanyBindingSource(BindingSource companyList);
        void SetPortBindingSource(BindingSource portList);
        void CheckSaveCondition();
        #endregion
    }
}
