using Guna.UI2.WinForms;
using itools_source.Models;
using System;
using System.Collections.Generic;
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
        Dictionary<string, Dictionary<string, string>> lstOPNumberOPType { get; set; }
        Action<Dictionary<string, Dictionary<string, string>>> SetListOPNumberOPType { get; set; }
        #endregion
        #region Events
        event EventHandler JobView_Load;
        event EventHandler txtJobNumberSearch_TextChanged;
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
