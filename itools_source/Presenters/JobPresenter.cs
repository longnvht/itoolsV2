using Guna.UI2.WinForms;
using itools_source.Models.Interface;
using itools_source.Views;
using itools_source.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public JobPresenter(IJobView jobView, IGetToolRepository getToolRepository)
        {
            _jobView = jobView;
            _getToolRepository = getToolRepository;

            _jobView.JobView_Load += _jobView_JobView_Load;
            _jobView.txtJobNumberSearch_TextChanged += _jobView_txtJobNumberSearch_TextChanged;
            _jobView.btnflpJobNumberList_Click += _jobView_btnflpJobNumberList_Click;
            _jobView.btnflpJobNumberlList_DoubleClick += _jobView_btnflpJobNumberlList_DoubleClick;

            _jobView.Show();
        }

        private void _jobView_btnflpJobNumberlList_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void _jobView_btnflpJobNumberList_Click(object sender, EventArgs e)
        {
            
        }

        private void _jobView_txtJobNumberSearch_TextChanged(object sender, EventArgs e)
        {
            JobView frmJobView = (JobView)sender;

            frmJobView.flpJobNumberList.Controls.Clear();
            if(string.IsNullOrEmpty(_jobView.strJobNumberSearch))
            {
                frmJobView.flpJobNumberList.Controls.AddRange(frmJobView.lstJobNumberButton.ToArray());
                return;
            }

            _jobView.lstJobNumber = _getToolRepository.GetJobByNumber(_jobView.strJobNumberSearch).ToList();
            _log.Info("User: " + Program.sessionLogin["UserName"] + ", Search JobNumber: " + _jobView.strJobNumberSearch);
            List<Guna2GradientButton> lstSearch = new List<Guna2GradientButton>();
            if (_jobView.lstJobNumberButton != null)
            {
                if (_jobView.lstJobNumber != null)
                {
                    int iCount = _jobView.lstJobNumber.Count;
                    for (int i = 0; i < iCount; i++)
                    {
                        _jobView.lstJobNumberButton[i].Text = _jobView.lstJobNumber[i];
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
    }
}
