using Guna.UI2.WinForms;
using itools_source.Models.Interface;
using itools_source.Views;
using itools_source.Views.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace itools_source.Presenters
{
    public class JobPresenter
    {
        public JobPresenter(IJobView jobView, IJobRepository jobRepository)
        {
            _jobView = jobView;
            _jobRepository = jobRepository;

            _jobView.JobView_Load += _jobView_JobView_Load;
            _jobView.btnJobNumberSearch_Click += _jobView_btnJobNumberSearch_Click;
            _jobView.btnflpJobNumberList_DoubleClick += _jobView_btnflpJobNumberList_DoubleClick;
            _jobView.btnflpJobNumberList_Click += _jobView_btnflpJobNumberList_Click;
            _jobView.txtJobNumberSearch_MouseClick += _jobView_txtJobNumberSearch_MouseClick;

            _jobView.Show();
        }

        #region Fields
        private IJobView _jobView;
        private IJobRepository _jobRepository;

        private log4net.ILog _log = log4net.LogManager.GetLogger(typeof(JobPresenter).Name);
        VirtualKeyBoard frmKeyBoard;
        Point clientPoint;
        #endregion

        #region Events
        private void _jobView_txtJobNumberSearch_MouseClick(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<VirtualKeyBoard>().Any())
            {
                frmKeyBoard = new VirtualKeyBoard();
                frmKeyBoard.Show();

                JobView frm = (JobView)sender;
                frm.txtJobNumberSearch.Focus();

                Point p = new Point();
                clientPoint = frm.txtJobNumberSearch.PointToScreen(p);
                frmKeyBoard.Location = new Point(clientPoint.X, clientPoint.Y + frm.txtJobNumberSearch.Height);
                clientPoint.Y += frm.txtJobNumberSearch.Height;
            }
        }

        private async void _jobView_btnflpJobNumberList_Click(object sender, EventArgs e)
        {
            Guna2GradientButton btn = (Guna2GradientButton)sender;
            if (btn != null)
            {
                if (btn.Checked == true)
                {
                    btn.Checked = false;
                    _jobView.strJobNumberCurrent = null;
                    _jobView.iPartIDCurrent = null;
                }
                else
                {
                    btn.Checked = true;
                    if (!string.IsNullOrEmpty(btn.Text) && btn.Tag != null)
                    {
                        _jobView.strJobNumberCurrent = btn.Text;
                        _jobView.iPartIDCurrent = Convert.ToInt32(btn.Tag);
                        if (_jobView.iPartIDCurrent != null && !string.IsNullOrWhiteSpace(_jobView.strJobNumberCurrent))
                        {
                            _jobView.lstOPNumberOPType = await _jobRepository.GetOPByJobPartOPID(_jobView.strJobNumberCurrent, _jobView.iPartIDCurrent);
                            _log.Info("Get JobNumber and PartID, list OP number op type.");
                        }
                    }
                    else
                    {
                        _log.Error("Text and Tag in Button is null.");
                    }
                }
            }
        }

        private async void _jobView_btnflpJobNumberList_DoubleClick(object sender, EventArgs e)
        {
            Guna2GradientButton btn = (Guna2GradientButton)sender;
            _jobView.strJobNumberCurrent = btn.Text;
            _jobView.iPartIDCurrent = Convert.ToInt32(btn.Tag);

            if (_jobView.iPartIDCurrent != null && !string.IsNullOrWhiteSpace(_jobView.strJobNumberCurrent))
            {
                _jobView.lstOPNumberOPType = await _jobRepository.GetOPByJobPartOPID(_jobView.strJobNumberCurrent, _jobView.iPartIDCurrent);
                if (_jobView.lstOPNumberOPType != null && _jobView.strJobNumberCurrent != null)
                {
                    // Clear data.
                    // ???
                    // Clear data.
                    _jobView.SetListOPNumberOPType(_jobView.lstOPNumberOPType, _jobView.strJobNumberCurrent); // Callback to form main or menu.
                }
                else
                {
                    _log.Error("_jobView.lstOPNumberOPType and _jobView.strJobNumberCurrent is null.");
                }
            }
        }

        private async void _jobView_btnJobNumberSearch_Click(object sender, EventArgs e)
        {
            JobView frmJobView = (JobView)sender;

            // 1. Clear and add old list button to flowlayoutpanel
            frmJobView.flpJobNumberList.Controls.Clear();
            if (string.IsNullOrEmpty(_jobView.strJobNumberSearch) || string.IsNullOrWhiteSpace(_jobView.strJobNumberSearch))
            {
                return;
            }

            // 2. Select JobNumber and PartID.
            _jobView.lstJobNumberPartID = await _jobRepository.GetJobByJobNumber(_jobView.strJobNumberSearch);
            if (Program.sessionLogin["UserName"] != null && !string.IsNullOrEmpty(_jobView.strJobNumberSearch))
            {
                _log.Info("User: " + Program.sessionLogin["UserName"] + ", Search JobNumber: " + _jobView.strJobNumberSearch);
            }

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
