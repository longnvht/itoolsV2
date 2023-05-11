using Guna.UI2.WinForms;
using itools_source.Models.Interface;
using itools_source.Views;
using itools_source.Views.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VinamiToolUser.Views;

namespace itools_source.Presenters
{
    public class OPPresenter
    {
        #region Properties - Fields
        private log4net.ILog _log = log4net.LogManager.GetLogger(typeof(OPPresenter).Name);

        private IOPView _opView;
        private IGetToolRepository _getToolRepository;

        KeyBoard frmKeyBoard;
        Point clientPoint;
        #endregion

        #region Events
        private void _opView_OPView_FormClosing(object sender, FormClosingEventArgs e)
        {
            KeyBoard.CloseKeyboard();
        }

        private void _opView_btnflpOPlList_Click(object sender, EventArgs e)
        {
            Guna2GradientButton btn = (Guna2GradientButton)sender;

            if (btn.Checked == true)
            {
                btn.Checked = false;
                _opView.iOPId = null;
            }
            else
            {
                btn.Checked = true;
                if (btn.Tag != null)
                {
                    _opView.iOPId = Convert.ToInt32(btn.Tag);
                    _log.Info("Click OPId: " + _opView.iOPId);
                }
                else
                {
                    _log.Error("Tag in Button is null.");
                }
            }
        }

        private void _opView_btnflpList_DoubleClick(object sender, EventArgs e)
        {
            Guna2GradientButton btn = (Guna2GradientButton)sender;
            _opView.iOPId = Convert.ToInt32(btn.Tag);
            string strOPNumber = btn.Text.Split('\r').GetValue(0).ToString();
            if (_opView.iOPId != null)
            {
                _opView.GetToolViewAction(_opView.iOPId, strOPNumber);
            }
            _log.Info("Double click OPId: " + _opView.iOPId);
            KeyBoard.CloseKeyboard();
        }

        private void _opView_txtOPSearch_TextChanged(object sender, EventArgs e) 
        {
            OPView frm = (OPView)sender; 
            frm.flpOPList.Controls.Clear();
            frm.OpSearch(); 
        }

        private void _opView_OPView_Load(object sender, EventArgs e)
        {
            // 1. Create list button.
            if (_opView.lstButton == null)
            {
                _opView.lstButton = new List<Guna2GradientButton>();
            }

            if (_opView.lstOPNumberOPType != null)
            {
                int iCountLstOPNumberOpType = _opView.lstOPNumberOPType.Count;
                for (int i = 0; i < iCountLstOPNumberOpType; i++)
                {
                    _opView.lstButton.Add(_opView.CreateButton(i));
                }

                // 2. Add to flowlayoutpanel.
                OPView frm = (OPView)sender;
                frm.flpOPList.Controls.AddRange(_opView.lstButton.ToArray());
                _log.Info("Create button list and add button to flowlayoutpanel.");
            }
            else
            {
                _log.Error("_opView.lstOPNumberOPType is null.");
            }
        }
        #endregion

        #region Methods
        public void Run(IOPView oPView, IGetToolRepository getToolRepository)
        {
            _opView = oPView;
            _getToolRepository = getToolRepository;

            _opView.OPView_Load += _opView_OPView_Load;
            _opView.btnflpOPlList_DoubleClick += _opView_btnflpList_DoubleClick;
            _opView.btnflpOPlList_Click += _opView_btnflpOPlList_Click;
            _opView.txtOPSearch_TextChanged += _opView_txtOPSearch_TextChanged;
            _opView.OPView_FormClosing += _opView_OPView_FormClosing;

            _opView.Show();
        }
        #endregion
    }
}
