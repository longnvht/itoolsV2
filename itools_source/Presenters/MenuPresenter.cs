﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VinamiToolUser.Models.Interface;
using VinamiToolUser.Models;
using VinamiToolUser.Views.Interface;
using System.Web.UI.WebControls;
using VinamiToolUser.Views;

namespace VinamiToolUser.Presenters
{
    public class MenuPresenter
    {
        private BindingSource _bindingSource;
        private IEnumerable<MenuModel> _viewList;
        private IMenuView _view;
        private IMenuRepository _repository;

        public MenuPresenter(IMenuView view, IMenuRepository repository)
        {
            _bindingSource = new BindingSource();
            
            _view = view;
            _repository = repository;
            _view.Presenter = this;
            _view.SelectViewEvent += SelectView;
            _view.EnterViewEvent += EnterView;
            _view.SetAppListBindingSource(_bindingSource);
            LoadViewList();
        }

        private async void LoadViewList()
        {
            _viewList = await _repository.GetByPermission(_view.UserLogin.PermisionID);
            _bindingSource.DataSource = _viewList;
        }

        private void EnterView(object sender, EventArgs e)
        {
            var selectView = (MenuModel)_bindingSource.Current;
            _view.NextView = selectView.ViewName;
        }

        private void SelectView(object sender, EventArgs e)
        {
            var selectView = (MenuModel)_bindingSource.Current;
            _view.TempView = selectView.ViewName;
        }
    }
}
