using Guna.UI2.WinForms;
using itools_source.Models.Interface;
using itools_source.Views;
using itools_source.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Presenters
{
    public class JobPresenter
    {
        #region Fields
        private IJobView _jobView;
        private IGetToolRepository _jobRepository;
        #endregion

        public JobPresenter(IJobView jobView, IGetToolRepository jobRepository)
        {
            _jobView = jobView;
            _jobRepository = jobRepository;

            _jobView.JobView_Load += _jobView_JobView_Load;
            _jobView.txtTraySearch_TextChanged += _jobView_txtTraySearch_TextChanged;
            _jobView.btnflpJobNumberList_Click += _jobView_btnflpJobNumberList_Click;
        }
        private void _jobView_btnflpJobNumberList_Click(object sender, EventArgs e)
        {
            
        }

        private void _jobView_txtTraySearch_TextChanged(object sender, EventArgs e)
        {
            JobView frmJobView = (JobView)sender;
            frmJobView.flpJobNumberList.Controls.Clear();
            if(string.IsNullOrEmpty(_jobView.strJobNumberSearch))
            {
                frmJobView.Controls.AddRange(frmJobView.lstJobNumberButton.ToArray());
                return;
            }
            string strSeacrhTest = _jobView.strJobNumberSearch.ToLower();

            List<Guna2GradientButton> lstSearch = new List<Guna2GradientButton>();
            int iCount = _jobView.lstJobNumberButton.Count;
            for (int i = 0; i < iCount; i++)
            {
                string strTextButton = _jobView.lstJobNumberButton[i].Text.ToLower();
                if (strTextButton.Contains(strSeacrhTest))
                {
                    lstSearch.Add(_jobView.lstJobNumberButton[i]);
                }
            }
            frmJobView.flpJobNumberList.Controls.AddRange(lstSearch.ToArray());
        }

        private void _jobView_JobView_Load(object sender, EventArgs e)
        {
            
        }
    }
}
