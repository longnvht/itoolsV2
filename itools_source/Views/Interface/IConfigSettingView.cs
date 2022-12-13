using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Views.Interface
{
    public interface IConfigSettingView
    {
        #region Properties - Fields
        string strCompanyId { get; set; }
        string strMachineId { get; set; }
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
        #endregion
    }
}
