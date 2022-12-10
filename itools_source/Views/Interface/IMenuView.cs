using itools_source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Views.Interface
{
    public interface IMenuView
    {
        #region Properties - Fields
        string strMenuId { get; set; }
        string strMenuName { get; set; }
        List<Menu> lstMenu { get; set; }
        bool bCheckButton { get; set; }
        #endregion
        #region Events
        event EventHandler MenuView_Load;
        #endregion
        #region Methods
        void Show();
        void Close();
        void SetCheckedButton(string strContinueButton);
        #endregion
    }
}
