using System;
using System.Windows.Forms;

namespace itools_source.Views.Interface
{
    public interface IConfigSettingView
    {
        #region Properties - Fields
        string strCompanyId { get; set; }
        int? MachineID { get; set; }
        string strSerialMachine { get; set; }
        #endregion

        #region Events
        event EventHandler ConfigSettingView_Load;
        event EventHandler btnSave_Click;
        event EventHandler cmbCompany_SelectedValueChanged;
        #endregion

        #region Methods
        void Show();
        void Close();
        void Hide();
        Form GetMdiParent();
        void SetMdiParent(Form mdiParent);
        string GetComputerSerialNumber();
        #endregion
    }
}
