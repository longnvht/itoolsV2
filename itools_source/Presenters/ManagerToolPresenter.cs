using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VinamiToolUser.Models.Interface;
using VinamiToolUser.Models;
using VinamiToolUser.Views.Interface;

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

        public ManagerToolPresenter(IManageToolView view, IManageToolRepository repository)
        {
            _toolSource = new BindingSource();
            _traySource = new BindingSource();
            _view = view;
            _repository = repository;
            _view.Presenter = this;
            //_view.SearchTrayEvent += SearchTray;
            _view.GetCurrentToolStock += GetCurrentToolStock;
            _view.SetTrayBindingSource(_traySource);
            _view.SetToolBindingSource(_toolSource);
            LoadData();
        }

        private async void GetCurrentToolStock(object sender, EventArgs e)
        {
            _toolList = await _repository.GetToolListByValue("181119", _view.CurrentTray.ToolCode);
            _view.CurrentTool = _toolList.FirstOrDefault();
        }

        private async void LoadData()
        {
            _trayList = await _repository.GetAllTrayList(4);
            _toolList = await _repository.GetAllToolList("181119");
            _traySource.DataSource = _trayList;
            _toolSource.DataSource = _toolList;
        }
    }
}
