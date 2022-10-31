using itools_source.Models.Interface;
using itools_source.Presenter;
using itools_source.Views;
using itools_source.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Presenters
{
    public class PushToolPresenter
    {
        log4net.ILog _log = log4net.LogManager.GetLogger(typeof(PushToolPresenter).Name);

        #region Fields
        private IPushToolView _pushToolView;
        private IToolRepository _toolRepository;

        public PushToolPresenter(IPushToolView pushToolView, IToolRepository toolRepository)
        {
            _pushToolView = pushToolView;
            _toolRepository = toolRepository;

            _pushToolView.Show();
        }
        //private 
        #endregion
    }
}
