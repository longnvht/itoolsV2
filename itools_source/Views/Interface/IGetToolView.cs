using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Windows.Forms;

namespace itools_source.Views.Interface
{
    public interface IGetToolView
    {
        #region Properties - Fields
        int? iOPId { get; set; }
        int iToolId { get; set; }
        string strToolCode { get; set; }
        string strToolModel { get; set; }
        string strToolDescription { get; set; }
        string strTrayIndex { get; set; }
        string strMachineCode { get; set; }
        char cStatusForm { get; set; }
        SerialPort serialPortGetTool { get; set; }
        List<Guna2GradientButton> lstToolButton { get; set; }
        List<Guna2GradientButton> lstTrayButton { get; set; }
        Dictionary<int, string> lstToolForOPList { get; set; }
        Dictionary<string, string> lstMachineTray { get; set; }
        Dictionary<int, List<object>> lstMachineTrayQuantity { get; set; }
        Action<bool> EnabledButton { get; set; }
        #endregion

        #region Events
        event EventHandler GetToolView_Load;
        event EventHandler btnflpToolList_Click;
        event EventHandler btnflpTrayMachineList_Click;
        event EventHandler btnflpTrayMachineList_DoubleClick;
        event SerialDataReceivedEventHandler serialPort_GetTool_DataReceived;
        event EventHandler btnCancelSelectTray_Click;
        event EventHandler btnGetTool_Click;
        event EventHandler toggleShowAll_Click;
        #endregion

        #region Methods
        void Show();
        void Close();
        void Hide();
        void SetStatusForm();
        void CreateListButton(bool bCheck);
        void flpTrayMachineList_AddRange(Control[] controls);
        void flpTrayMachineList_Clear();
        Guna2GradientButton CreateButton(object strText, object iQuantity, string strEventName, object obTag = null);
        void SetCheckedButton(string strContinueButton);
        #endregion
    }
}
