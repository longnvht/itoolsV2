using itools_source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Views.Interface
{
    public interface IMainView
    {
        #region Properties - Fields
        Assessor assessorCurrent { get; set; }
        string strName { get; set; }
        #endregion

        #region Event
        event EventHandler FormLoad;
        event EventHandler Previous;
        event EventHandler Next;
        #endregion

        #region Method
        void Show();
        void Close();
        void Hide();
        void CloseFormChild();
        #endregion
    }
}
