using itools_source.Models;
using System;

namespace itools_source.Views.Interface
{
    public interface IMainView
    {
        #region Properties - Fields
        UserAccount userAccountCurrent { get; set; }
        string strName { get; set; }
        string strRole { get; set; }
        bool btnNextEnabled { get; set; }
        #endregion

        #region Events
        event EventHandler MainView_Load;
        event EventHandler btnPrevious_Click;
        event EventHandler btnNext_Click;
        #endregion

        #region Methods
        void Show();
        void Close();
        void Hide();
        void CloseFormChild();
        #endregion
    }
}
