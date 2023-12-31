﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VinamiToolUser.Models;
using VinamiToolUser.Presenters;

namespace VinamiToolUser.Views.Interface
{
    public interface IOPViewNew
    {
        #region Properties
        JobModel CurrentJob { get; set; }
        OPModel SelectedOP { get; set; }
        string NextView { get; set; }
        string TempView { get; set; }
        string SearchValue { get; set; }
        OpPresenter Presenter { set; }
        #endregion

        #region Events
        event EventHandler SearchEvent;
        event EventHandler OpSelectEvent;
        event EventHandler ChoseOpEvent;


        #endregion

        #region Method
        void SetOpListBindingSource(BindingSource opList);
        #endregion
    }
}
