using itools_source.Models;
using System;
using System.Collections.Generic;

namespace itools_source.Views.Interface
{
    public interface IMainView
    {
        #region Properties - Fields
        UserAccount userAccountCurrent { get; set; }
        string strName { get; set; }
        bool btnNextEnabled { get; set; }
        string strJobNumber { get; set; }
        string strOPNumber { get; set; }
        int? iOPId { get; set; }
        Dictionary<int?, Dictionary<string, string>> lstOPNumberOpType_Main { get; set; }
        #endregion

        #region Events
        event EventHandler MainView_Load;
        event EventHandler btnPrevious_Click;
        event EventHandler btnNext_Click;
        event EventHandler btnHome_Click;
        #endregion

        #region Methods
        void Show();
        void Close();
        void Hide();
        void CloseFormChild();
        bool GetIsDisposed();
        #endregion
    }
}
