using itools_source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Views.Interface
{
    public interface IPushToolView
    {
        #region Fields
        int _iToolId { get; set; }
        Tool toolCurrent { get; set; }
        #endregion

        #region Events
        event EventHandler TakeOut;
        event EventHandler Add;
        event EventHandler AddNew;
        #endregion

        #region Methods
        void Show();
        void Close();
        #endregion
    }
}
