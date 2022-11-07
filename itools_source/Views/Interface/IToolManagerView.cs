using itools_source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Views.Interface
{
    public interface IToolManagerView
    {
        #region Fields
        string strToolCode { get; set; }
        int iTrayId { get; set; }
        int iCurrentQuantity { get; set; }
        int iOperateQuantity { get; set; }
        int iRemainQuantity { get; set; }
        string strSearch { get; set; }
        ToolsMachineTray toolTrayCurrent { get; set; }
        #endregion

        #region Events
        event EventHandler ClickTakeOut;
        event EventHandler ClickAddOld;
        event EventHandler ClickAddNew;
        event EventHandler ClickNext;
        event EventHandler ClickPrevious;
        event EventHandler Search;
        event EventHandler ClickBtnFlowPanel;
        #endregion

        #region Methods
        void Show();
        void Close();
        void ShowMessage(string e);
        void SetButtonState(int iStatus);
        #endregion
    }
}
