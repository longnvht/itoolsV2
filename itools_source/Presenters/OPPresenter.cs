using Guna.UI2.WinForms;
using itools_source.Models.Interface;
using itools_source.Views;
using itools_source.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itools_source.Presenters
{
    public class OPPresenter
    {
        #region Properties - Fields
        private IOPView _opView;
        private IGetToolRepository _getToolRepository;

        private log4net.ILog _log = log4net.LogManager.GetLogger(typeof(OPPresenter).Name);
        #endregion

        #region Methods
        public OPPresenter(IOPView opView, IGetToolRepository getToolRepository)
        {
            _opView = opView;
            _getToolRepository = getToolRepository;

            _opView.OPView_Load += _opView_OPView_Load;
            _opView.btnflpOPlList_DoubleClick += _opView_btnflpList_DoubleClick;

            _opView.Show();
        }
        #endregion

        #region Events
        private void _opView_btnflpList_DoubleClick(object sender, EventArgs e)
        {
            Guna2GradientButton btn = (Guna2GradientButton)sender;
            string strOPId = btn.Tag.ToString();
            if (!string.IsNullOrEmpty(strOPId))
            {
                _opView.GetToolViewAction(strOPId);
            }
            _log.Info("OPId: " + strOPId);
        }

        private void _opView_OPView_Load(object sender, EventArgs e)
        {
            // Create list button.
            if (_opView.lstButton == null)
            {
                _opView.lstButton = new List<Guna2GradientButton>();
            }

            int iCountLstOPNumberOpType = _opView.lstOPNumberOPType.Count;
            for (int i = 0; i < iCountLstOPNumberOpType; i++)
            {
                _opView.lstButton.Add(_opView.CreateButton(i));
            }

            // Add to flowlayoutpanel.
            OPView frm = (OPView)sender;
            frm.flpOPList.Controls.AddRange(_opView.lstButton.ToArray());
            _log.Info("Create button list and add button to flowlayoutpanel.");
        }
        #endregion
    }
}
