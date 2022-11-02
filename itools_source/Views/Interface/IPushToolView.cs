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
        int _iTrayId { get; set; }
        int _iCurrentQuantity { get; set; }
        int _iOperateQuantity { get; set; }
        int _iRemainQuantity { get; set; }
        string strSearch { get; set; }
        #endregion

        #region Events
        event EventHandler ClickTakeOut;
        event EventHandler ClickAddOld;
        event EventHandler ClickAddNew;
        event EventHandler ClickNext;
        event EventHandler ClickPrevious;
        event EventHandler Search;
        #endregion

        #region Methods
        void Show();
        void Close();
        #endregion
    }
}
