using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itools_source.Views.Interface
{
    public interface ILoginView
    {
        #region Properties - Fields
        string strUserName { get; set; }
        string strPassword { get; set; }
        #endregion

        #region Events
        event EventHandler LoginEvent;
        event EventHandler CancelEvent;
        event EventHandler PasswordIconRightClickEvent;
        #endregion

        #region Methods
        void Show();
        void Close();
        #endregion
    }
}
