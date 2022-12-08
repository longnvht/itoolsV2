using Guna.UI2.WinForms;
using itools_source.Models.Interface;
using itools_source.Views;
using itools_source.Views.Interface;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace itools_source.Presenters
{
    public class JobPresenter
    {
        public JobPresenter(IJobView jobView, IGetToolRepository getToolRepository)
        {
            _jobView = jobView;
            _getToolRepository = getToolRepository;

            _jobView.JobView_Load += _jobView_JobView_Load;
            _jobView.txtJobNumberSearch_TextChanged += _jobView_txtJobNumberSearch_TextChanged;
            _jobView.btnflpJobNumberList_DoubleClick += _jobView_btnflpJobNumberList_DoubleClick;
            _jobView.btnflpJobNumberList_Click += _jobView_btnflpJobNumberList_Click;

            _jobView.Show();
        }

        #region Fields
        private IJobView _jobView;
        private IGetToolRepository _getToolRepository;

        private log4net.ILog _log = log4net.LogManager.GetLogger(typeof(JobPresenter).Name);
        #endregion

        #region Events
        private void _jobView_btnflpJobNumberList_Click(object sender, EventArgs e)
        {
            Guna2GradientButton btn = (Guna2GradientButton)sender;
            if (btn.Checked == true)
            {
                btn.Checked = false;
            }
            else
            {
                btn.Checked = true;
                _jobView.strJobNumberCurrent = btn.Text;
                _jobView.iPartIDCurrent = Convert.ToInt32(btn.Tag);
                if (_jobView.iPartIDCurrent != null && !string.IsNullOrWhiteSpace(_jobView.strJobNumberCurrent))
                {
                    _jobView.lstOPNumberOPType = _getToolRepository.GetOPByJobPartOPID(_jobView.strJobNumberCurrent, _jobView.iPartIDCurrent);
                }
            }
        }

        private void _jobView_btnflpJobNumberList_DoubleClick(object sender, EventArgs e)
        {
            Guna2GradientButton btn = (Guna2GradientButton)sender;
            _jobView.strJobNumberCurrent = btn.Text;
            _jobView.iPartIDCurrent = Convert.ToInt32(btn.Tag);

            if (_jobView.iPartIDCurrent != null && !string.IsNullOrWhiteSpace(_jobView.strJobNumberCurrent))
            {
                _jobView.lstOPNumberOPType = _getToolRepository.GetOPByJobPartOPID(_jobView.strJobNumberCurrent, _jobView.iPartIDCurrent);
                if (_jobView.lstOPNumberOPType != null)
                {
                    // Clear data.
                    // ???
                    // Clear data.
                    _jobView.SetListOPNumberOPType(_jobView.lstOPNumberOPType); // Callback to form main.
                }
            }
        }

        private async void _jobView_txtJobNumberSearch_TextChanged(object sender, EventArgs e)
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
            _jobView.lstJobNumberPartID = await _getToolRepository.GetJobByJobNumber(_jobView.strJobNumberSearch);
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
                        _jobView.lstJobNumberButton[i].Tag = _jobView.lstJobNumberPartID.Values[i];
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
        }
        #endregion

        #region Methods
        #endregion
    }
}
