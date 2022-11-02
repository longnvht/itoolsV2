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
        #endregion

        public PushToolPresenter(IPushToolView pushToolView, IToolRepository toolRepository)
        {
            _pushToolView = pushToolView;
            _toolRepository = toolRepository;


            _pushToolView.ClickTakeOut += TakeOut;
            _pushToolView.ClickAddOld += AddOld;
            _pushToolView.ClickAddNew += AddNew;
            _pushToolView.ClickNext += Next;
            _pushToolView.ClickPrevious += Previous;
            _pushToolView.Search += Search;
            
            _pushToolView.Show();
        }

        #region Events
        private void Search(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Previous(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Next(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNew(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddOld(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TakeOut(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
