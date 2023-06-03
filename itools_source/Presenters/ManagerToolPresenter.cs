using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VinamiToolUser.Models.Interface;
using VinamiToolUser.Models;
using VinamiToolUser.Views.Interface;
using System.Web.UI.WebControls;

namespace VinamiToolUser.Presenters
{
    public class ManagerToolPresenter
    {
        private BindingSource _toolSource;
        private BindingSource _traySource;
        private IEnumerable<TempToolModel> _toolList;
        private IEnumerable<TrayModelManage> _trayList;
        private IManageToolView _view;
        private IManageToolRepository _repository;
        private string _userLogin;

        public ManagerToolPresenter(IManageToolView view, IManageToolRepository repository)
        {
            _toolSource = new BindingSource();
            _traySource = new BindingSource();
            _view = view;
            _repository = repository;
            _view.Presenter = this;
            _userLogin = _view.UserLogin.strUserLogin;
            //_view.SearchTrayEvent += SearchTray;
            _view.GetCurrentToolStock += GetCurrentToolStock;
            _view.SetTrayBindingSource(_traySource);
            _view.SetToolBindingSource(_toolSource);
            _view.SearchEvent += SearchEvent;
            _view.UpdateModifyEvent += UpdateModifyEvent;
            _view.GetStockToolList += GetStockToolList;
            LoadData();
        }

        private async void GetStockToolList(object sender, EventArgs e)
        {
            _toolList = await _repository.GetAllToolList(_userLogin);
            _toolSource.DataSource = _toolList;
        }

        private async void SearchEvent(object sender, EventArgs e)
        {
            if(_view.SearchType == "Tray")
            {
                _trayList = await _repository.GetTrayListByValue(4, _view.SearchValue);
                _traySource.DataSource = _trayList;
                _view.ViewAction = "";
            }
            if (_view.SearchType == "Tool")
            {
                _toolList = await _repository.GetToolListByValue(_userLogin, _view.SearchValue);
                _toolSource.DataSource = _toolList;
                _view.ViewAction = "ShowTool";
            }
        }

        private async void UpdateModifyEvent(object sender, EventArgs e)
        {
            bool result = false;
            TempToolModel currenttool = _view.CurrentTool;
            TrayModelManage currentTray = _view.CurrentTray;
            int toolID = currentTray.ToolID;
            if(_view.ModifyState == "AddNew")
            {
                toolID = currenttool.ToolID;
            }
            int? stockID = null;
            if (currenttool != null)
            {
                stockID = currenttool.StockID;
            }
            int trayID = currentTray.TrayId;
            _view.Log = "--- Giao Dịch:  " + _view.ModifyState;
            _view.Log = "--- Tray Name:  " + currentTray.TrayName;
            _view.Log = "--- Số lượng thao tác:  " + _view.ModifyQty;
            //Update Tray Quantity
            result = await _repository.UpdateStockQuantity(trayID, toolID, _view.NewQty);
            if (result) _view.Log = "--- Cập nhật số lượng tool mới của Tray thành công";
            else _view.Log = "--- Cập nhật số lượng tool mới của Tray thất bại";
            //Update Stock Quantity
            result = await _repository.UpdateTempStockQuantity(stockID, toolID, _userLogin, _view.NewStock);
            if (result) _view.Log = "--- Cập nhật số lượng tồn kho mới của Tool thành công";
            else _view.Log = "--- Cập nhật số lượng tồn kho mới của Tool thất bại";
            //Update Working Transaction
            result = await _repository.UpdateTransaction(4, _userLogin, toolID, _view.CurrentTray.TrayName, _view.ModifyQty, _view.ModifyState, result.ToString());
            if (result) _view.Log = "--- Cập nhật lịch sử giao dịch thành công";
            else _view.Log = "--- Cập nhật lịch sử giao dịch thất bại";

            LoadData();
            _view.ViewAction = "";
        }

        private async void GetCurrentToolStock(object sender, EventArgs e)
        {
            _toolList = await _repository.GetToolListByValue(_userLogin, _view.CurrentTray.ToolCode);
            _view.CurrentTool = _toolList.FirstOrDefault();
        }

        private async void LoadData()
        {
            _trayList = await _repository.GetAllTrayList(4);
            _toolList = await _repository.GetAllToolList(_userLogin);
            _traySource.DataSource = _trayList;
            _toolSource.DataSource = _toolList;
        }
    }
}
