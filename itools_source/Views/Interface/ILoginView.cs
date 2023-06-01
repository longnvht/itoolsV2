using System;
using System.Windows.Forms;

namespace VinamiToolUser.Views.Interface
{
    public interface ILoginView
    {
        #region Properties - Fields
        string strUserName { get; set; }
        string strPassword { get; set; }
        bool Fvisible { get; set; }
        #endregion

        #region Events
        event EventHandler btnLogin_Click;
        event EventHandler btnCancel_Click;
        event EventHandler txtPassword_IconRightClick;
        #endregion

        #region Methods
        void Show();
        void Close();
        void Hide();
        #endregion
    }
}
