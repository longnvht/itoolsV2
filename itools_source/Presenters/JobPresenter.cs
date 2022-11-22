using Guna.UI2.WinForms;
using itools_source.Models.Interface;
using itools_source.Repository;
using itools_source.Views;
using itools_source.Views.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace itools_source.Presenters
{
    public class JobPresenter
    {
        #region Fields
        private IJobView _jobView;
        private IGetToolRepository _getToolRepository;

        private log4net.ILog _log = log4net.LogManager.GetLogger(typeof(JobPresenter).Name);
        #endregion

        #region Methods
        public JobPresenter(IJobView jobView, IGetToolRepository getToolRepository)
        {
            _jobView = jobView;
            _getToolRepository = getToolRepository;

            _jobView.JobView_Load += _jobView_JobView_Load;
            _jobView.txtJobNumberSearch_TextChanged += _jobView_txtJobNumberSearch_TextChanged;
            _jobView.btnflpJobNumberList_Click += _jobView_btnflpJobNumberList_Click;
            _jobView.btnflpJobNumberList_DoubleClick += _jobView_btnflpJobNumberList_DoubleClick;

            _jobView.Show();
        }
        #endregion

        #region Events
        private void _jobView_btnflpJobNumberList_DoubleClick(object sender, EventArgs e)
        {
            Guna2GradientButton btn = (Guna2GradientButton)sender;
            string strJobNumber = btn.Text;
            string strPartID = null;
            foreach (var item in _jobView.lstJobNumberPartID)
            {
                if (item.Key == strJobNumber)
                {
                    strPartID = item.Value;
                    break;
                }
            }
            if (strPartID != null)
            {
                _jobView.lstOPNumberOpType = _getToolRepository.GetOPByJobAndPart(strJobNumber, strPartID);
                if (_jobView.lstOPNumberOpType != null)
                {
                    _jobView.SetListOPNumberOPType(_jobView.lstOPNumberOpType);

                    //List<Guna2GradientButton> lstSearch = new List<Guna2GradientButton>();
                    //if (_jobView.lstJobNumberButton != null)
                    //{
                    //    if (_jobView.lstJobNumberPartID != null)
                    //    {
                    //        int iCount = _jobView.lstJobNumberPartID.Keys.Count;
                    //        for (int i = 0; i < iCount; i++)
                    //        {
                    //            _jobView.lstJobNumberButton[i].Text = _jobView.lstJobNumberPartID.Keys[i];
                    //            lstSearch.Add(_jobView.lstJobNumberButton[i]);
                    //        }
                    //        _jobView.flpJobNumberList_ControlsAddRange(lstSearch.ToArray());
                    //        _log.Info("List Button: " + lstSearch.ToString());
                    //    }
                    //}
                }
            }
        }

        private void _jobView_btnflpJobNumberList_Click(object sender, EventArgs e)
        {

        }

        private void _jobView_txtJobNumberSearch_TextChanged(object sender, EventArgs e)
        {
            JobView frmJobView = (JobView)sender;

            // 1. Clear and add old list button to flowlayoutpanel
            frmJobView.flpJobNumberList.Controls.Clear();
            if (string.IsNullOrEmpty(_jobView.strJobNumberSearch))
            {
                frmJobView.flpJobNumberList.Controls.AddRange(frmJobView.lstJobNumberButton.ToArray());
                return;
            }

            // 2. Select JobNumber and PartID.
            _jobView.lstJobNumberPartID = _getToolRepository.GetJobByJobNumber(_jobView.strJobNumberSearch);
            _log.Info("User: " + Program.sessionLogin["UserName"] + ", Search JobNumber: " + _jobView.strJobNumberSearch);

            // 3. Rename text button.
            List<Guna2GradientButton> lstSearch = new List<Guna2GradientButton>();
            if (_jobView.lstJobNumberButton != null)
            {
                if (_jobView.lstJobNumberPartID != null)
                {
                    int iCount = _jobView.lstJobNumberPartID.Keys.Count;
                    for (int i = 0; i < iCount; i++)
                    {
                        _jobView.lstJobNumberButton[i].Text = _jobView.lstJobNumberPartID.Keys[i];
                        lstSearch.Add(_jobView.lstJobNumberButton[i]);
                    }
                    frmJobView.flpJobNumberList.Controls.AddRange(lstSearch.ToArray());
                    _log.Info("List Button: " + lstSearch.ToString());
                }
            }
        }

        private void _jobView_JobView_Load(object sender, EventArgs e)
        {
            JobView frm = (JobView)sender;
            frm.flpJobNumberList.PerformLayout();
            frm.guna2VScrollBar_flpJobNumberList.ScrollbarSize = 30;
            frm.guna2VScrollBar_flpJobNumberList.Size = new System.Drawing.Size(30, frm.flpJobNumberList.Height);

            // Create list button.
            if (_jobView.lstJobNumberButton == null)
            {
                _jobView.lstJobNumberButton = new List<Guna2GradientButton>();
            }
            for (int i = 0; i < 50; i++)
            {
                _jobView.lstJobNumberButton.Add(_jobView.CreateJobNumberButton());
            }

            //_jobView.lstJobNumber = (List<string>)_getToolRepository.GetJobByNumber();

            //if (_jobView.lstJobNumber != null)
            //{
            //    if (_jobView.lstJobNumberButton == null)
            //    {
            //        _jobView.lstJobNumberButton = new List<Guna2GradientButton>();
            //    }
            //    int iCount = _jobView.lstJobNumber.Count;
            //    for (int i = 0; i < iCount; i++)
            //    {
            //        _jobView.lstJobNumberButton.Add(_jobView.CreateJobNumberButton());
            //    }
            //    //frm.flpJobNumberList.Controls.AddRange(_jobView.lstJobNumberButton.ToArray());
            //}
        }
        #endregion
    }
}
