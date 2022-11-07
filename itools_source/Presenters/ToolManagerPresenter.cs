using itools_source.Models.Interface;
using itools_source.Presenter;
using itools_source.Views;
using itools_source.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace itools_source.Presenters
{
    public class ToolManagerPresenter
    {
        log4net.ILog _log = log4net.LogManager.GetLogger(typeof(ToolManagerPresenter).Name);

        #region Fields
        private IToolManagerView _toolManagerView;
        private IToolRepository _toolRepository;
        #endregion

        public ToolManagerPresenter(IToolManagerView pushToolView, IToolRepository toolRepository)
        {
            _toolManagerView = pushToolView;
            _toolRepository = toolRepository;

            _toolManagerView.ClickTakeOut += TakeOut;
            _toolManagerView.ClickAddOld += AddOld;
            _toolManagerView.ClickAddNew += AddNew;
            _toolManagerView.ClickNext += Next;
            _toolManagerView.ClickPrevious += Previous;
            _toolManagerView.Search += Search;
            _toolManagerView.ClickBtnFlowPanel += ClickBtnFlowPanelEvent;

            _toolManagerView.Show();
        }

        private void ClickBtnFlowPanelEvent(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            string stTrayIndex = btn.Text.Replace(" ", "_");

            _toolManagerView.iCurrentQuantity = _toolRepository.GetToolQuantity(stTrayIndex);

            if (_toolManagerView.iCurrentQuantity > -1)
            {
                // Set Status Button.
                if (_toolManagerView.iCurrentQuantity == 0)
                {
                    _toolManagerView.SetButtonState(0);
                }
                if (_toolManagerView.iCurrentQuantity > 0 && _toolManagerView.iCurrentQuantity < 10)
                {
                    _toolManagerView.SetButtonState(1);
                }
                if (_toolManagerView.iCurrentQuantity == 10)
                {
                    _toolManagerView.SetButtonState(2);
                }

                _toolManagerView.toolTrayCurrent = _toolRepository.GetToolByTrayIndex(stTrayIndex, "VM-6");
                if (_toolManagerView.toolTrayCurrent != null)
                {
                    _toolManagerView.iTrayId = Convert.ToInt32(btn.Text.Split(' ').GetValue(1));
                    _toolManagerView.strToolCode = _toolManagerView.toolTrayCurrent.strToolCode;
                }
                else
                {
                    _toolManagerView.ShowMessage("Tool is Null in Tray");
                }
            }
            else
            {
                _log.Error("Quantity Error: " + _toolManagerView.iCurrentQuantity.ToString());
            }
        }

        #region Events
        private void Search(object sender, EventArgs e)
        {
            //((Form)sender).
        }

        private void Previous(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
        }

        private void Next(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNew(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddOld(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TakeOut(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
