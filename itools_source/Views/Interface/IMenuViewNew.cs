using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VinamiToolUser.Presenters;

namespace VinamiToolUser.Views.Interface
{
    public interface IMenuViewNew
    {
        #region Properties
        string NextView { get ; set; }
        string TempView { get; set; }
        string SearchValue { get; set; }
        MenuPresenterNew Presenter { set; }
        #endregion

        #region Events

        event EventHandler SelectViewEvent;
        event EventHandler EnterViewEvent;

        #endregion

        #region Method
        void SetAppListBindingSource(BindingSource jobList);

        #endregion
    }
}
