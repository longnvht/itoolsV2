using itools_source.Models;
using System;

namespace itools_source.Views.Interface
{
    public interface ILoginView
    {
        #region Properties - Fields
        string strUserName { get; set; }
        string strPassword { get; set; }
        Assessor assessorCurrent { get; set; }
        #endregion

        #region Events
        event EventHandler LoginEvent;
        event EventHandler CancelEvent;
        event EventHandler PasswordIconRightClickEvent;
        #endregion

        #region Methods
        void Show();
        void Close();
        void Hide();
        void ShowMessage(string strMessage);
        #endregion
    }
}
