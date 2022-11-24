using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
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
        char cStatusForm { get; set; }
        List<Guna2GradientButton> lstToolButton { get; set; }
        Dictionary<int, string> lstToolForOPList { get; set; }
        #endregion

        #region Events
        event EventHandler GetToolView_Load;
        //event EventHandler txtTraySearch_TextChanged;
        //event EventHandler btnTraySearch_Click;
        event EventHandler btnflpToolList_Click;
        //event KeyPressEventHandler txtOperateQuantity_KeyPress;
        //event EventHandler txtOperateQuantity_TextChanged;
        //event EventHandler txtToolCode_MouseClick;
        //event EventHandler txtToolSearch_TextChanged;
        //event EventHandler btnflpToolList_Click;
        //event EventHandler btnflpToolList_DoubleClick;
        //event EventHandler btnToolSelect_Click;
        //event EventHandler btnToolCancel_Click;
        //event EventHandler btnTakeOut_Click;
        //event EventHandler btnAddPlugin_Click;
        //event EventHandler btnAddNew_Click;
        //event EventHandler btnSave_Click;
        #endregion

        #region Methods
        void Show();
        void Close();
        void Hide();
        void SetStatusForm();
        Guna2GradientButton CreateButton(int? iIndex = null);
        #endregion
    }
}
