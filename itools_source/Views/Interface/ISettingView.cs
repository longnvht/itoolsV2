using System;
using System.Windows.Forms;
using VinamiToolUser.Presenters;

namespace itools_source.Views.Interface
{
    public interface ISettingView
    {
        #region Properties - Fields
        string strCompanyId { get; set; }
        int? MachineID { get; set; }
        string strSerialMachine { get; set; }
        SettingPresenter Presenter { set; }
        #endregion

        #region Events

        #endregion

        #region Methods
        void SetMachineBindingSource(BindingSource machineList);
        void SetCompanyBindingSource(BindingSource companyList);
        #endregion
    }
}
