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
        BindingList<Job> lstJobNumber { get; set; }
        List<Guna2GradientButton> lstJobNumberButton { get; set; }
        #endregion
        #region Events
        event EventHandler JobView_Load;
        event EventHandler txtTraySearch_TextChanged;
        event EventHandler btnSearch_Click;
        event EventHandler btnflpJobNumberList_Click;
        event EventHandler btnflpToolList_DoubleClick;
        #endregion
    }
}
