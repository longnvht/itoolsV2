using Guna.UI2.WinForms;
using itools_source.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace itools_source.Views.Interface
{
    public interface IToolManagerView
    {
        #region Fields
        int? iToolID { get; set; }
        int? iMachineId { get; set; }
        int? iTrayID { get; set; }
        string strMachineCode { get; set; }
        string strTrayIndex { get; set; }
        string strToolCode { get; set; }
        int? iCurrentQuantity { get; set; }
        int? iOperateQuantity { get; set; }
        int? iTotalQuantity { get; set; }
        string strTrayToolSearch { get; set; }
        string strToolSearch { get; set; }
        char cStatusForm { get; set; }
        char cStatusButton { get; set; }
        ToolMachineTray toolTrayCurrent { get; set; }
        Dictionary<int, string> lstTooIDAndCode { get; set; }
        Dictionary<int, Dictionary<string, string>> lstTrayIndexToolCode { get; set; }
        List<Guna2Button> lstTrayButton { get; set; }
        List<Guna2GradientButton> lstToolButton { get; set; }
        #endregion

        #region Events
        event EventHandler ToolManagerView_Load;
        event EventHandler txtTraySearch_TextChanged;
        event EventHandler btnTraySearch_Click;
        event EventHandler btnflpTrayList_Click;
        event EventHandler txtOperateQuantity_TextChanged;
        event EventHandler txtToolSearch_TextChanged;
        event EventHandler btnflpToolList_Click;
        event EventHandler btnflpToolList_DoubleClick;
        event EventHandler btnToolSelect_Click;
        event EventHandler btnToolCancel_Click;
        event EventHandler btnTakeOut_Click;
        event EventHandler ShowToolList;
        event EventHandler btnAddPlugin_Click;
        event EventHandler btnAddNew_Click;
        event EventHandler btnSave_Click;
        event FormClosingEventHandler ToolManagerView_FormClosing;
        #endregion

        #region Methods
        void Show();
        void Close();
        void SetStatusForm();
        void SetStateButton();
        void SetCheckedButton(int? iToolID);
        void CancelListTool();
        Form GetMdiParent();
        void SetMdiParent(Form mdiParent);
        #endregion
    }
}
