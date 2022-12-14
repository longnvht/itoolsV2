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
        bool btnAddNewEnabled { get; set; }
        bool btnAddPluginEnabled { get; set; }
        bool btnTakeOutEnabled { get; set; }
        bool btnSaveEnabled { get; set; }
        bool tlpHeaderEnabled { get; set; }
        bool tlpFooterEnabled { get; set; }
        bool pLeftContentEnabled { get; set; }
        bool tlpTrayDetailEnabled { get; set; }
        bool txtOperateQuantityEnable { get; set; }
        bool txtCurrentQuantityEnbale { get; set; }
        char cStatusForm { get; set; }
        char cStatusButton { get; set; }
        ToolMachineTray toolTrayCurrent { get; set; }
        List<string> toolCodeList { get; set; }
        Dictionary<int, Dictionary<string, string>> lstTrayIndexToolCode { get; set; }
        List<Guna2Button> lstTrayButton { get; set; }
        List<Guna2GradientButton> lstToolButton { get; set; }
        #endregion

        #region Events
        event EventHandler ToolManagerView_Load;
        event EventHandler txtTraySearch_TextChanged;
        event EventHandler btnTraySearch_Click;
        event EventHandler btnflpTrayList_Click;
        event KeyPressEventHandler txtOperateQuantity_KeyPress;
        event EventHandler txtOperateQuantity_TextChanged;
        event EventHandler txtToolCode_MouseClick;
        event EventHandler txtToolSearch_TextChanged;
        event EventHandler btnflpToolList_Click;
        event EventHandler btnflpToolList_DoubleClick;
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
        //void CreateTrayButton();
        void CreateToolButton();
        void SetStatusForm();
        void SetStateButton();
        void SetCheckedButton(string strContinueButton);
        void CancelListTool();
        bool CheckedSelectTool();
        void TrayAndToolSearch();
        void ToolSearch();
        void txtCurrentQuantity_Focus();
        void txtOperateQuantity_Focus();
        #endregion
    }
}
