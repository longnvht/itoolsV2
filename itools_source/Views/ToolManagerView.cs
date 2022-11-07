using itools_source.Models;
using itools_source.Utils;
using itools_source.Views.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itools_source.Views
{
    public partial class ToolManagerView : Form, IToolManagerView
    {
        public ToolManagerView()
        {
            InitializeComponent();
            btnTakeOut.Click += delegate { ClickTakeOut?.Invoke(this, EventArgs.Empty); };
            btnAddPlugin.Click += delegate { ClickAddOld?.Invoke(this, EventArgs.Empty); };
            btnAddNew.Click += delegate { ClickAddNew?.Invoke(this, EventArgs.Empty); };
            btnNext.Click += delegate { ClickNext?.Invoke(this, EventArgs.Empty); };
            btnPrev.Click += delegate { ClickPrevious?.Invoke(this, EventArgs.Empty); };
            btnSearch.Click += delegate { Search?.Invoke(this, EventArgs.Empty); };

            CreateButtonTool();
            this.flpListTool.PerformLayout();
            guna2VScrollBar1.Size = new System.Drawing.Size(30, flpListTool.Height);

            this.btnAddNew.Enabled = false;
            this.btnAddPlugin.Enabled = false;
            this.btnTakeOut.Enabled = false;
            this.txtCurrentQuantity.Enabled = false;
            this.txtOperateQuantity.Enabled = false;
        }

        public void ShowMessage(string e)
        {
            MessageBox.Show(e);
        }

        private void CreateButtonTool()
        {
            for (int i = 1; i < 61; i++)
            {              
                Button btn = new Button();
                btn.Size = new Size(280, 60);
                if (i < 10)
                {
                    btn.Text = "TRAY 0" + i.ToString();
                }
                else
                {
                    btn.Text = "TRAY " + i.ToString();
                }
                btn.UseVisualStyleBackColor = true;
                btn.Click += (s, e) => this.ClickBtnFlowPanel?.Invoke(s, e);
                this.flpListTool.Controls.Add(btn);
            }
        }

        public string strToolCode { get => txtToolId.Text; set => txtToolId.Text = value.ToString(); }
        public int iTrayId { get => Convert.ToInt32(txtTrayId.Text); set => txtTrayId.Text = value.ToString(); }
        public int iCurrentQuantity { get => Convert.ToInt32(txtCurrentQuantity.Text); set => txtCurrentQuantity.Text = value.ToString(); }
        public int iOperateQuantity { get => Convert.ToInt32(txtOperateQuantity.Text); set => txtOperateQuantity.Text = value.ToString(); }
        public int iRemainQuantity { get => Convert.ToInt32(txtRemainQuantity.Text); set => txtRemainQuantity.Text = value.ToString(); }
        public string strSearch { get => txtSearch.Text; set => txtSearch.Text = value; }
        public ToolsMachineTray toolTrayCurrent { get; set; }

        public event EventHandler ClickTakeOut;
        public event EventHandler ClickAddOld;
        public event EventHandler ClickAddNew;
        public event EventHandler ClickNext;
        public event EventHandler ClickPrevious;
        public event EventHandler Search;
        public event EventHandler ClickBtnFlowPanel;

        #region Method
        public void SetButtonState(int iStatus)
        {
            if (iStatus == 0) // Quantity = 0
            {
                this.btnAddNew.Enabled = true;
                this.btnAddPlugin.Enabled = true;
                this.btnTakeOut.Enabled = false;
            }
            else if (iStatus == 1) // Quantity > 0 && Quantity < MAX
            {
                this.btnAddNew.Enabled = false;
                this.btnAddPlugin.Enabled = true;
                this.btnTakeOut.Enabled = true;
            }
            else // Quantity = MAX
            {
                this.btnAddNew.Enabled = false;
                this.btnAddPlugin.Enabled = false;
                this.btnTakeOut.Enabled = true;
            }
        }
        #endregion
    }
}
