using itools_source.Models;
using System;

namespace itools_source.Views.Interface
{
    public interface IMainView
    {
        #region Properties - Fields
        UserAccount userAccountCurrent { get; set; }
        string strName { get; set; }
        #endregion

        #region Event
        event EventHandler MainView_Load;
        event EventHandler btnPrevious_Click;
        event EventHandler btnNext_Click;
        #endregion

        #region Method
        void Show();
        void Close();
        void Hide();
        void CloseFormChild();
        #endregion
    }
}
