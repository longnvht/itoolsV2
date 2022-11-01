using itools_source.Models.Interface;
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
        private IJobRepository _jobRepository;

        public JobPresenter(IJobView jobView, IJobRepository jobRepository)
        {
            _jobView = jobView;
            _jobRepository = jobRepository;
        }
        #endregion
    }
}
