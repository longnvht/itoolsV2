using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VinamiToolUser.Models;
using VinamiToolUser.Presenters;

namespace VinamiToolUser.Views.Interface
{
    public interface IJobView
    {
        #region Properties
        string SearchValue { get; set; }
        string NextView { get; set; }
        string TempView { get; set; }
        JobModel SelectedJob { get; set; }
        JobPresenter Presenter { set; }
        #endregion

        #region Events
        event EventHandler SearchEvent;
        event EventHandler SelectJobEvent;
        event EventHandler ChoseJobEvent;


        #endregion

        #region Method
        void SetJobListBindingSource(BindingSource jobList);
        #endregion
    }
}
