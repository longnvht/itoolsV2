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
            _userLogin = _view.UserLogin.UserName;
            //_view.SearchTrayEvent += SearchTray;
            _view.SetTrayBindingSource(_traySource);
            _view.SetToolBindingSource(_toolSource);
            _view.SearchEvent += SearchEvent;
            _view.UpdateModifyEvent += UpdateModifyEvent;
            _view.AddNewToolEvent += AddNewToolEvent;
            _view.GetStockToolList += GetStockToolList;
            LoadData();
        }

        private async void AddNewToolEvent(object sender, EventArgs e)
        {
            bool result = false;
            TempToolModel currenttool = _view.CurrentTool;
            TrayModelManage currentTray = _view.CurrentTray;
            string toolCode = currenttool.ToolCode;
            string trayName = currentTray.TrayName;
            _view.Log = "--- Transaction Type:  " + _view.ModifyState;
            _view.Log = "--- Tray Name:  " + currentTray.TrayName;
            _view.Log = "--- Quantity:  " + _view.ModifyQty;
            //Update Tray Quantity
            result = await _repository.AddNewToolToTray(_view.CurrentConfig.MachineCode, toolCode, trayName, _view.NewQty);
            if (result) _view.Log = "--- Update New Tool And Quantity To DataBase Success!";
            else _view.Log = "--- Update New Tool And Quantity To DataBase Fail!";
            //Update Working Transaction
            result = await _repository.UpdateTransaction(_view.CurrentConfig.CompanyCode, _view.CurrentMachine.MachineCode, _userLogin, toolCode, _view.CurrentTray.TrayName, _view.ModifyQty, _view.ModifyState, result.ToString());
            if (result) _view.Log = "--- Update AddTool Transaction Success!";
            else _view.Log = "--- Update AddTool Transaction Fail!";
            
            LoadData();
            _view.IsRunning = false;
            _view.ViewAction = "";
        }

        private async void GetStockToolList(object sender, EventArgs e)
        {
            _toolList = await _repository.GetAllToolList(_view.CurrentConfig.CompanyCode);
            _toolSource.DataSource = _toolList;
        }

        private async void SearchEvent(object sender, EventArgs e)
        {
            if(_view.SearchType == "Tray")
            {
                _trayList = await _repository.GetTrayListByValue(_view.CurrentMachine.MachineCode, _view.SearchValue);
                _traySource.DataSource = _trayList;
                _view.ViewAction = "";
            }
            if (_view.SearchType == "Tool")
            {
                _toolList = await _repository.GetToolListByValue(_view.CurrentMachine.CompanyCode, _view.SearchValue);
                _toolSource.DataSource = _toolList;
                _view.ViewAction = "ShowTool";
            }
        }

        private async void UpdateModifyEvent(object sender, EventArgs e)
        {
            bool result = false;
            TempToolModel currenttool = _view.CurrentTool;
            TrayModelManage currentTray = _view.CurrentTray;
            string toolCode = currentTray.ToolCode;
            int trayID = currentTray.TrayId;
            _view.Log = "--- Transaction Type:  " + _view.ModifyState;
            _view.Log = "--- Tray Name:  " + currentTray.TrayName;
            _view.Log = "--- Quantity:  " + _view.ModifyQty;
            //Update Tray Quantity
            result = await _repository.UpdateStockQuantity(trayID, toolCode, _view.NewQty);
            if (result) _view.Log = "--- Update Tool Quantity To Database Success!";
            else _view.Log = "--- Update Tool Quantity To Database fail!";
            //Update Working Transaction
            result = await _repository.UpdateTransaction(_view.CurrentConfig.CompanyCode, _view.CurrentMachine.MachineCode, _userLogin, toolCode, _view.CurrentTray.TrayName, _view.ModifyQty, _view.ModifyState, result.ToString());
            if (result) _view.Log = "--- Update Transaction Success!";
            else _view.Log = "--- Update Transaction Fail!";
            
            LoadData();
            _view.IsRunning = false;
            _view.ViewAction = "";
        }

        private async void LoadData()
        {
            _trayList = await _repository.GetAllTrayList(_view.CurrentMachine.MachineCode);
            _toolList = await _repository.GetAllToolList(_view.CurrentConfig.CompanyCode);
            _traySource.DataSource = _trayList;
            _toolSource.DataSource = _toolList;
        }
    }
}
