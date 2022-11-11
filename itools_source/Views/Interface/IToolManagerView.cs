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
        int iTrayIndex { get; set; }
        string strToolCode { get; set; }
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
        List<string> toolCodeList { get; set; }
        #endregion

        #region Events
        event EventHandler txtSearch_TextChanged;
        event EventHandler btnSearch_Click;
        event EventHandler btnflpTrayList_Click;
        event KeyPressEventHandler txtOperateQuantity_KeyPress;
        event EventHandler txtOperateQuantity_TextChanged;
        event EventHandler txtOperateQuantity_MouseClick;
        event EventHandler txtToolSearch_TextChanged;
        event EventHandler btnflpToolList_Click;
        event EventHandler btnToolSelect_Click;
        event EventHandler btnToolCancel_Click;
        event EventHandler btnTakeOut_Click;
        event EventHandler btnAddPlugin_Click;
        event EventHandler btnAddNew_Click;
        event EventHandler btnSave_Click;
        #endregion

        #region Methods
        void Show();
        void Close();
        void ShowMessage(string strMessage);
        void SetStatusForm(char cStatus);
        void SetButtonState(char cStatus);
        void txtCurrentQuantity_Focus();
        void txtOperateQuantity_Focus();
        void AddNewListTool();
        void CancelListTool();
        #endregion
    }
}
