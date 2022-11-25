using Guna.UI2.WinForms;
using itools_source.Models.Interface;
using itools_source.Views;
using itools_source.Views.Interface;
using log4net;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itools_source.Presenters
{
    public class GetToolPresenter
    {
        #region Properties - Fields
        private IGetToolView _getToolView;
        private IGetToolRepository _getToolRepository;

        private log4net.ILog _log = log4net.LogManager.GetLogger(typeof(OPPresenter).Name);
        #endregion

        #region Methods
        public GetToolPresenter(IGetToolView getToolView, IGetToolRepository getToolRepository)
        {
            _getToolView = getToolView;
            _getToolRepository = getToolRepository;

            _getToolView.GetToolView_Load += _getToolView_GetToolView_Load;
            _getToolView.btnflpTrayMachineList_Click += _getToolView_btnflpTrayMachineList_Click;
            _getToolView.btnflpTrayMachineList_DoubleClick += _getToolView_btnflpTrayMachineList_DoubleClick;

            _getToolView.Show();
        }

        private void _getToolView_btnflpTrayMachineList_DoubleClick(object sender, EventArgs e)
        {
            Guna2GradientButton btn = (Guna2GradientButton)sender;
            if (string.IsNullOrEmpty(btn.Text) || btn.Tag == null)
            {
                MessageBox.Show("Nút Không Có Dữ Liệu!");
                return;
            }
        }
        #endregion

        #region Evens
        private async void _getToolView_btnflpTrayMachineList_Click(object sender, EventArgs e)
        {
            Guna2GradientButton btn = (Guna2GradientButton)sender;
            if (string.IsNullOrEmpty(btn.Text) || btn.Tag == null)
            {
                _getToolView.cStatusForm = '2';
                _getToolView.SetStatusForm();
                MessageBox.Show("Nút Không Có Dữ Liệu!");
                return;
            }

            // 1. Show view select TrayIndex.
            _getToolView.cStatusForm = '1';
            _getToolView.SetStatusForm();

            /*
             * 2. Get data tool:
             *  a. Id
             *  b. Code
             *  c. Model
             *  d. Description
             */
            _getToolView.iToolId = Convert.ToInt32(btn.Tag);
            _getToolView.strToolCode = btn.Text;
            Dictionary<string, string> lstModelDes = await _getToolRepository.GetModelDescriptionByToolId(_getToolView.iToolId);

            if (lstModelDes != null)
            {
                _getToolView.strToolModel = lstModelDes.Keys.ElementAt(0);
                _getToolView.strToolDescription = lstModelDes.Values.ElementAt(0);
                _log.Info("Get ToolModel: " + _getToolView.strToolModel + ", ToolDescription: " + _getToolView.strToolDescription);

                // 3. Get tool tray data.
                _getToolView.lstMachineTray = await _getToolRepository.GetMachineTrayByToolCode(_getToolView.strToolCode, "VM-1");
                if (_getToolView.lstMachineTray != null)
                {
                    // 1. Create list button.
                    if (_getToolView.lstTrayButton == null)
                    {
                        _getToolView.lstTrayButton = new List<Guna2GradientButton>();
                    }

                    // a. Clear controls ToolTray.
                    _getToolView.flpTrayMachineList_Clear();
                    _getToolView.lstTrayButton.Clear();

                    // b. Add button to Tray List.
                    foreach (var item in _getToolView.lstMachineTray)
                    {
                        _getToolView.lstTrayButton.Add(_getToolView.CreateButton(item.Value, item.Key, _getToolView_btnflpTrayMachineList_DoubleClick));
                    }

                    // 2. Add button list to flowlayoutpanel.
                    _getToolView.flpTrayMachineList_AddRange(_getToolView.lstTrayButton.ToArray());
                    _log.Info("Create button tray list and add button tray to flowlayoutpanel.");
                }
            }
            else
            {
                _log.Error("Get data ToolModel and ToolDescription fail!");
            }
        }

        private async void _getToolView_GetToolView_Load(object sender, EventArgs e)
        {
            GetToolView frm = (GetToolView)sender;

            _getToolView.cStatusForm = '0';
            _getToolView.SetStatusForm();

            _getToolView.lstToolForOPList = await _getToolRepository.GetByToolForOP(_getToolView.iOPId);

            if (_getToolView.lstToolForOPList != null)
            {
                // 1. Create list button.
                if (_getToolView.lstToolButton == null)
                {
                    _getToolView.lstToolButton = new List<Guna2GradientButton>();
                }

                foreach (var item in _getToolView.lstToolForOPList)
                {
                    _getToolView.lstToolButton.Add(_getToolView.CreateButton(item.Key, item.Value, _getToolView_btnflpToolList_Click));
                }

                //int iCount = _getToolView.lstToolForOPList.Count;
                //for (int i = 0; i < 20; i++)
                //{
                //    if (i < iCount)
                //    {
                //        _getToolView.lstToolButton.Add(_getToolView.CreateButton(i));
                //    }
                //    else
                //    {
                //        _getToolView.lstToolButton.Add(_getToolView.CreateButton());
                //    }
                //}

                // 2. Add to flowlayoutpanel.
                frm.flpToolList.Controls.AddRange(_getToolView.lstToolButton.ToArray());
                _log.Info("Create button list and add button to flowlayoutpanel.");
            }
        }
        #endregion
    }
}
