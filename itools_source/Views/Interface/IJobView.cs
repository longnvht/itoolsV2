﻿using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace itools_source.Views.Interface
{
    public interface IJobView
    {
        #region Properties - Fields
        string strJobNumberSearch { get; set; }
        string strJobNumberCurrent { get; set; }
        int? iPartIDCurrent { get; set; }
        List<Guna2GradientButton> lstJobNumberButton { get; set; }
        SortedList<string, string> lstJobNumberPartID { get; set; }
        Dictionary<int?, Dictionary<string, string>> lstOPNumberOPType { get; set; }
        Action<Dictionary<int?, Dictionary<string, string>>, string> SetListOPNumberOPType { get; set; }
        #endregion

        #region Events
        event EventHandler JobView_Load;
        event EventHandler btnflpJobNumberList_DoubleClick;
        event EventHandler btnflpJobNumberList_Click;
        event EventHandler SearchEvent;
        event EventHandler ShowVitualKeyBoard;
        event FormClosingEventHandler JobView_FormClosing;
        #endregion

        #region Methods
        void Show();
        void Close();
        Guna2GradientButton CreateJobNumberButton(string strJobNumber = "");
        void flpJobNumberList_ControlsAddRange(Control[] controls);
        Form GetMdiParent();
        void SetMdiParent(Form mdiParent);
        #endregion
    }
}
