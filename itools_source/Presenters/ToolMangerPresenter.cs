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
    public class ToolMangerPresenter
    {
        private BindingSource _toolSource;
        private BindingSource _traySource;
        private IEnumerable<ToolModel> _toolList;
        private IEnumerable<TrayModelManage> _trayList;
        private IManageToolView _view;
        private IManageToolRepository _repository;

        public ToolMangerPresenter(IManageToolView view, IManageToolRepository repository)
        {
            _toolSource = new BindingSource();
            _traySource = new BindingSource();
            _view = view;
            _repository = repository;
            _view.Presenter = this;
            //_view.SearchTrayEvent += SearchTray;
            _view.SetTrayBindingSource(_traySource);
            _view.SetToolBindingSource(_toolSource);
            LoadData();
        }

        private async void LoadData()
        {
            _trayList = await _repository.GetAllTrayList(4);
            _traySource.DataSource = _trayList;
            _toolSource.DataSource = _toolList;
        }
    }
}
