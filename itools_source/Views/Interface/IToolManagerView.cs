using itools_source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itools_source.Views.Interface
{
    public interface IToolManagerView
    {
        #region Fields
        string strToolCode { get; set; }
        int iTrayIndex { get; set; }
        int iCurrentQuantity { get; set; }
        int iOperateQuantity { get; set; }
        int iTotalQuantity { get; set; }
        string strSearch { get; set; }
        ToolsMachineTray toolTrayCurrent { get; set; }
        bool btnAddNewEnable { get; set; }
        bool btnAddPluginEnable { get; set; }
        bool btnTakeOutEnable { get; set; }
        bool btnSaveEnable { get; set; }
        bool txtOperateQuantityEnable { get; set; }
        bool txtCurrentQuantityEnbale { get; set; }
        char cStatusForm { get; set; }
        char cStatusButton { get; set; }
        #endregion

        #region Events
        event EventHandler ClickTakeOut;
        event EventHandler ClickAddPlugin;
        event EventHandler ClickAddNew;
        event EventHandler ClickSave;
        event EventHandler Search;
        event EventHandler ClickBtnFlowPanel;
        event KeyPressEventHandler KeyPressOperateQuantity;
        event EventHandler OperateQuantityTextChanged;
        #endregion

        #region Methods
        void Show();
        void Close();
        void ShowMessage(string strMessage);
        void SetStatusForm(char cStatus);
        void SetButtonState(char cStatus);
        void txtCurrentQuantityFocus();
        void txtOperateQuantityFocus();
        #endregion
    }
}
