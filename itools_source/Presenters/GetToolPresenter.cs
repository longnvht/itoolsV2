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
    public class GetToolPresenter
    {
        private BindingSource _toolSource;
        private BindingSource _traySource;
        private IEnumerable<ToolModel> _toolList;
        private IEnumerable<TrayModel> _trayList;
        private IGetToolView _view;
        private string _userLogin;
        private IGetToolRepositoryNew _repository;

        public GetToolPresenter(IGetToolView view, IGetToolRepositoryNew repository)
        {
            _toolSource= new BindingSource();
            _traySource = new BindingSource();
            _view = view;
            _repository = repository;
            _view.Presenter = this;
            _userLogin = _view.UserLogin.UserName;
            _view.SelectToolEvent += SelectTool;
            _view.SearchToolEvent += SearchTool;
            _view.UpdateToolStock += UpdateToolStock;
            _view.SetToolListBindingSource(_toolSource);
            _view.SetTrayListBindingSource(_traySource);
            LoadData();
        }

        private async void SelectTool(object sender, EventArgs e)
        {
            var tool = (ToolModel)_toolSource.Current;
            _view.CurrentTool = tool;
            _trayList = await _repository.GetTrayList(tool.ToolID);
            _traySource.DataSource = _trayList;
        }

        private async void UpdateToolStock(object sender, EventArgs e)
        {
            bool result = false;
            int trayID = _view.CurrentTray.TrayId;
            string trayIndex = _view.CurrentTray.TrayName;
            int toolID = _view.CurrentTool.ToolID;
            int qty = _view.CurrentTray.QtyStock - 1;
            //Update Tray Quantity
            if (_view.GetToolResult)
            {
                result = await _repository.UpdateToolStock(trayID, toolID, qty);
                if (result) _view.LogMessage = "--- Cập nhật số lượng tool mới của Tray thành công";
                else _view.LogMessage = "--- Cập nhật số lượng tool mới của Tray thất bại";
                //Update Get Tool Transaction
                result = await _repository.UpdateGetToolTransaction(4, _userLogin, _view.OpNumber, _view.JobNumber, toolID, trayIndex, 1, "Get Tool", _view.GetToolResult.ToString());
                if (result) _view.LogMessage = "--- Cập nhật lịch sử giao dịch thành công";
                else _view.LogMessage = "--- Cập nhật lịch sử giao dịch thất bại";
            }
            else
            {
                result = await _repository.UpdateGetToolTransaction(4, _userLogin, _view.OpNumber, _view.JobNumber, toolID, trayIndex, 0, "Get Tool", _view.GetToolResult.ToString());
                if (result) _view.LogMessage = "--- Cập nhật lịch sử giao dịch thành công";
                else _view.LogMessage = "--- Cập nhật lịch sử giao dịch thất bại";
            }
            LoadData();
        }

        private async void LoadData()
        {
            _toolList = await _repository.GetToolList(CommonValue.CurrentOP.OpID);
            //_trayList = await _repository.GetAllTrayList();
            _toolSource.DataSource = _toolList;
            _traySource.DataSource = _trayList;
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
    }
}
