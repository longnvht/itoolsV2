using Guna.UI2.WinForms;
using itools_source.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itools_source.Views.Interface
{
    public interface IJobView
    {
        #region Properties - Fields
        string strJobNumberSearch { get; set; }
        Job JobCurrent { get; set; }
        List<Guna2GradientButton> lstJobNumberButton { get; set; }
        SortedList<string, string> lstJobNumberPartID { get; set; }
        SortedList<string, string> lstOPNumberOpType { get; set; }
        Action<SortedList<string, string>> SetListOPNumberOPType { get; set; }
        #endregion
        #region Events
        event EventHandler JobView_Load;
        event EventHandler txtJobNumberSearch_TextChanged;
        event EventHandler btnJobNumberSearch_Click;
        event EventHandler btnflpJobNumberList_Click;
        event EventHandler btnflpJobNumberList_DoubleClick;
        #endregion
        #region Methods
        void Show();
        void Close();
        Guna2GradientButton CreateJobNumberButton(string strJobNumber = "");
        void flpJobNumberList_ControlsAddRange(Control[] controls);
        #endregion
    }
}
