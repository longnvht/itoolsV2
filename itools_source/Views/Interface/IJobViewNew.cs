using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VinamiToolUser.Presenters;

namespace VinamiToolUser.Views.Interface
{
    public interface IJobViewNew
    {
        #region Properties
        string JobNumber { get; set; }
        string SearchValue { get; set; }
        JobPresenterNew Presenter { set; }
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
