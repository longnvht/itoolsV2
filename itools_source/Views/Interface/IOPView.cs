using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;

namespace itools_source.Views.Interface
{
    public interface IOPView
    {
        #region Properties - Fields
        int? iOPId { get; set; }
        string strOPNumber { get; set; }
        string strSearch { get; set; }
        List<Guna2GradientButton> lstButton { get; set; }
        Dictionary<int?, Dictionary<string, string>> lstOPNumberOPType { get; set; }
        Action<int?, string> GetToolViewAction { get; set; }
        #endregion

        #region Events
        event EventHandler OPView_Load;
        event EventHandler btnflpOPlList_DoubleClick;
        event EventHandler btnflpOPlList_Click;
        event EventHandler txtOPSearch_MouseDown;
        #endregion

        #region Methods
        void Show();
        void Close();
        void Hide();
        Guna2GradientButton CreateButton(int? iIndex = null);
        #endregion
    }
}
