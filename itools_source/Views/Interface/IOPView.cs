using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Views.Interface
{
    public interface IOPView
    {
        #region Properties - Fields
        string strPartID { get; set; }
        string strOPNumber { get; set; }
        string strSearch { get; set; }
        List<Guna2GradientButton> lstButton { get; set; }
        SortedList<string, string> lstOPNumberOpType { get; set; }
        #endregion

        #region Events
        event EventHandler OPView_Load;
        event EventHandler btnflpOPlList_DoubleClick;
        #endregion

        #region Methods
        void Show();
        void Close();
        void Hide();
        Guna2GradientButton CreateButton(string strButtonText = null);
        //void ListOPNumberOPType(SortedList<string, string> lstOPNumberOpType);
        #endregion
    }
}
