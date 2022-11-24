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
            _getToolView.btnflpToolList_Click += _getToolView_btnflpToolList_Click;

            _getToolView.Show();
        }
        #endregion

        #region Evens
        private void _getToolView_btnflpToolList_Click(object sender, EventArgs e)
        {
            foreach (var item in _getToolView.lstToolForOPList)
            {
                MessageBox.Show(item.Key.ToString(), item.Value);
            }
        }
        private async void _getToolView_GetToolView_Load(object sender, EventArgs e)
        {
            GetToolView frm = (GetToolView)sender;
            frm.cStatusForm = '3';
            frm.SetStatusForm();

            frm.tlpToolMachineList.Visible = false;
            frm.tlpToolMachineList.Dock = DockStyle.Right;
            frm.tlpToolMachineList.BringToFront();

            _getToolView.lstToolForOPList = await _getToolRepository.GetByToolForOP(_getToolView.iOPId);

            if (_getToolView.lstToolForOPList != null)
            {
                // 1. Create list button.
                if (_getToolView.lstToolButton == null)
                {
                    _getToolView.lstToolButton = new List<Guna2GradientButton>();
                }

                int iCount = _getToolView.lstToolForOPList.Count;
                for (int i = 0; i < iCount; i++)
                {
                    _getToolView.lstToolButton.Add(_getToolView.CreateButton(i));
                }

                // 2. Add to flowlayoutpanel.
                frm.flpToolList.Controls.AddRange(_getToolView.lstToolButton.ToArray());
                _log.Info("Create button list and add button to flowlayoutpanel.");
            }
        }
        #endregion
    }
}
