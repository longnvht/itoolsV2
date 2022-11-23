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
    public class GetToolPresenter
    {
        #region Properties - Fields
        private IGetToolView _getToolView;
        private IGetToolRepository _getToolRepository;
        #endregion

        #region Methods
        public GetToolPresenter(IGetToolView getToolView, IGetToolRepository getToolRepository)
        {
            _getToolView = getToolView;
            _getToolRepository = getToolRepository;

            _getToolView.GetToolView_Load += _getToolView_GetToolView_Load;

            _getToolView.Show();
        }

        private void _getToolView_GetToolView_Load(object sender, EventArgs e)
        {
            MessageBox.Show(_getToolView.strOPId);
            GetToolView frm = (GetToolView)sender;
            frm.cStatusForm = '3';
            frm.SetStatusForm();
        }
        #endregion

        #region Evens
        #endregion
    }
}
