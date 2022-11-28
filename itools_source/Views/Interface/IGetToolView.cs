using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itools_source.Views.Interface
{
    public interface IGetToolView
    {
        #region Properties - Fields
        int iOPId { get; set; }
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
        #endregion

        #region Events
        event EventHandler GetToolView_Load;
        //event EventHandler txtTraySearch_TextChanged;
        //event EventHandler btnTraySearch_Click;
        event EventHandler btnflpTrayMachineList_Click;
        //event EventHandler txtToolCode_MouseClick;
        //event EventHandler txtToolSearch_TextChanged;
        //event EventHandler btnflpToolList_Click;
        event EventHandler btnflpTrayMachineList_DoubleClick;
        //event EventHandler btnToolSelect_Click;
        //event EventHandler btnToolCancel_Click;
        //event EventHandler btnTakeOut_Click;
        //event EventHandler btnAddPlugin_Click;
        //event EventHandler btnAddNew_Click;
        //event EventHandler btnSave_Click;
        event SerialDataReceivedEventHandler serialPort_GetTool_DataReceived;
        #endregion

        #region Methods
        void Show();
        void Close();
        void Hide();
        void SetStatusForm();
        void flpTrayMachineList_AddRange(Control[] controls);
        void flpTrayMachineList_Clear();
        Guna2GradientButton CreateButton(object strText, object obTag, EventHandler eventHandler);
        #endregion
    }
}
