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
            btnAddOld.Click += delegate { ClickAddOld?.Invoke(this, EventArgs.Empty); };
            btnAddNew.Click += delegate { ClickAddNew?.Invoke(this, EventArgs.Empty); };
            btnNext.Click += delegate { ClickNext?.Invoke(this, EventArgs.Empty); };
            btnPrev.Click += delegate { ClickPrevious?.Invoke(this, EventArgs.Empty); };
            btnSearch.Click += delegate { Search?.Invoke(this, EventArgs.Empty); };

            CreateButtonTool();
        }

        private void CreateButtonTool()
        {
            for (int i = 1; i < 61; i++)
            {              
                Button btn = new Button();
                btn.Size = new Size(280, 60);
                if (i < 10)
                {
                    btn.Text = "TRAY_0" + i.ToString();
                }
                else
                {
                    btn.Text = "TRAY_" + i.ToString();
                }
                btn.UseVisualStyleBackColor = true;
                
                this.flpListTool.Controls.Add(btn);
            }
        }

        public int _iToolId { get => Convert.ToInt32(txtToolId.Text); set => txtToolId.Text = value.ToString(); }
        public Tool toolCurrent { get; set; }
        public int _iTrayId { get => Convert.ToInt32(txtTrayId.Text); set => txtTrayId.Text = value.ToString(); }
        public int _iCurrentQuantity { get => Convert.ToInt32(txtCurrentQuantity.Text); set => txtCurrentQuantity.Text = value.ToString(); }
        public int _iOperateQuantity { get => Convert.ToInt32(txtOperateQuantity.Text); set => txtOperateQuantity.Text = value.ToString(); }
        public int _iRemainQuantity { get => Convert.ToInt32(txtRemainQuantity.Text); set => txtRemainQuantity.Text = value.ToString(); }
        public string strSearch { get => txtSearch.Text; set => txtSearch.Text = value; }

        public event EventHandler ClickTakeOut;
        public event EventHandler ClickAddOld;
        public event EventHandler ClickAddNew;
        public event EventHandler ClickNext;
        public event EventHandler ClickPrevious;
        public event EventHandler Search;
    }
}
