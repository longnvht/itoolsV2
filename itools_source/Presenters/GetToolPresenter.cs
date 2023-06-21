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
        private BindingSource _otherTraySource;

        private IEnumerable<ToolModel> _toolList;
        private IEnumerable<TrayModel> _trayList;
        private IEnumerable<TrayModel> _otherTrayList;
        private IGetToolView _view;
        private string _userLogin;
        private IGetToolRepository _repository;

        public GetToolPresenter(IGetToolView view, IGetToolRepository repository)
        {
            _toolSource= new BindingSource();
            _traySource = new BindingSource();
            _otherTraySource = new BindingSource();
            _view = view;
            _repository = repository;
            _view.Presenter = this;
            _userLogin = _view.UserLogin.UserName;
            _view.SelectToolEvent += SelectTool;
            _view.SearchToolEvent += SearchTool;
            _view.UpdateToolStock += UpdateToolStock;
            _view.SetToolListBindingSource(_toolSource);
            _view.SetCurrentTrayListBindingSource(_traySource);
            _view.SetOtherTrayListBindingSource(_otherTraySource);
            LoadData();
        }

        private async void SelectTool(object sender, EventArgs e)
        {
            var tool = (ToolModel)_toolSource.Current;
            _view.CurrentTool = tool;
            _trayList = await _repository.GetCurrentTrayList(tool.ToolCode, _view.CurrentMachine.MachineCode);
            _traySource.DataSource = _trayList;
            _otherTrayList = await _repository.GetOtherTrayList(tool.ToolCode, _view.CurrentMachine.MachineCode, _view.CurrentConfig.CompanyCode);
            _otherTraySource.DataSource = _otherTrayList;
        }

        private async void UpdateToolStock(object sender, EventArgs e)
        {
            bool result = false;
            int trayID = _view.CurrentTray.TrayId;
            string trayIndex = _view.CurrentTray.TrayName;
            string toolCode = _view.CurrentTool.ToolCode;
            int qty = _view.CurrentTray.QtyStock - 1;
            //Update Tray Quantity
            if (_view.GetToolResult)
            {
                result = await _repository.UpdateToolStock(trayID, qty);
                if (result) _view.LogMessage = "--- Cập nhật số lượng tool mới của Tray thành công";
                else _view.LogMessage = "--- Cập nhật số lượng tool mới của Tray thất bại";
                //Update Get Tool Transaction
                result = await _repository.UpdateGetToolTransaction(_view.CurrentConfig.CompanyCode, _view.CurrentMachine.MachineCode,  _userLogin, CommonValue.CurrentWorkInfo.WorkCode, CommonValue.CurrentWorkInfo.WorkMachineCode, toolCode, trayIndex, 1, "GetTools", _view.GetToolResult.ToString());
                if (result) _view.LogMessage = "--- Cập nhật lịch sử giao dịch thành công";
                else _view.LogMessage = "--- Cập nhật lịch sử giao dịch thất bại";
            }
            else
            {
                result = await _repository.UpdateGetToolTransaction(_view.CurrentConfig.CompanyCode, _view.CurrentMachine.MachineCode, _userLogin, CommonValue.CurrentWorkInfo.WorkCode, CommonValue.CurrentWorkInfo.WorkMachineCode, toolCode, trayIndex, 0, "GetTools", _view.GetToolResult.ToString());
                if (result) _view.LogMessage = "--- Cập nhật lịch sử giao dịch thành công";
                else _view.LogMessage = "--- Cập nhật lịch sử giao dịch thất bại";
            }
            LoadData();
        }

        private async void LoadData()
        {
            _toolList = await _repository.GetToolList(_view.CurrentConfig.CompanyCode);
            //_trayList = await _repository.GetAllTrayList();
            _toolSource.DataSource = _toolList;
            _traySource.DataSource = _trayList;
        }

        private async void SearchTool(object sender, EventArgs e)
        {
            var searchValue = _view.SearchToolValue;
            if (String.IsNullOrEmpty(searchValue))
            {
                _toolList = await _repository.GetToolList(_view.CurrentConfig.CompanyCode);
            }
            else
            {
                _toolList = await _repository.GetToolListByToolCode(_view.CurrentConfig.CompanyCode, _view.SearchToolValue);
            }
            _toolSource.DataSource = _toolList;
        }
    }
}
