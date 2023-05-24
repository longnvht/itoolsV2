using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VinamiToolUser.Models.Interface;
using VinamiToolUser.Models;
using VinamiToolUser.Views.Interface;
using VinamiToolUser.Views;
using VinamiToolUser.Utils;
using static VinamiToolUser.Views.Components.StockInfoTreeView;
using VinamiToolUser.Views.Components;

namespace VinamiToolUser.Presenters
{
    public class GetToolPresenterNew
    {
        private BindingSource _toolSource;
        private BindingSource _traySource;
        private IEnumerable<ToolModel> _toolList;
        private IEnumerable<TrayModel> _trayList;
        private IGetToolViewNew _view;
        private IGetToolRepositoryNew _repository;

        public GetToolPresenterNew(IGetToolViewNew view, IGetToolRepositoryNew repository)
        {
            _toolSource= new BindingSource();
            _traySource = new BindingSource();
            _view = view;
            _repository = repository;
            _view.Presenter = this;
            _view.SelectToolEvent += SelectTool;
            //_view.SelectTrayEvent += SelectTray;
            _view.SearchToolEvent += SearchTool;
            //_view.SearchTrayEvent += SearchTray;
            _view.SetToolListBindingSource(_toolSource);
            _view.SetTrayListBindingSource(_traySource);
            LoadData();
        }

        private async void LoadData()
        {
            _toolList = await _repository.GetToolList(CommonValue.CurrentOP.OpID);
            //_trayList = await _repository.GetAllTrayList();
            _toolSource.DataSource = _toolList;
            _traySource.DataSource = _trayList;
        }

        private void SearchTray(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private async void SearchTool(object sender, EventArgs e)
        {
            var searchValue = _view.SearchToolValue;
            if (String.IsNullOrEmpty(searchValue))
            {
                _toolList = await _repository.GetToolList(CommonValue.CurrentOP.OpID);
            }
            else
            {
                _toolList = await _repository.GetToolListByToolCode(CommonValue.CurrentOP.OpID, _view.SearchToolValue);
            }
            _toolSource.DataSource = _toolList;
        }

        private async void SelectTool(object sender, EventArgs e)
        {
            var tool = (ToolModel)_toolSource.Current;
            _view.ToolCode = tool.ToolCode;
            _view.ToolName = tool.ToolName;
            _view.TrayName = "";
            _view.Quantity = "";
            _trayList = await _repository.GetTrayList(tool.ToolID);
            _traySource.DataSource = _trayList;
        }

        private void SelectTray(object sender, TrayNodeClickEventArgs e)
        {
            //throw new NotImplementedException();
        }
    }
}
