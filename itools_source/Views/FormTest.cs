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
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        //bool _bActive = false;

        private void FormTest_Load(object sender, EventArgs e)
        {
            //SetToolCodeBindingSource();
            tlpTooList.Visible = true;
        }

        public void SetToolCodeBindingSource(BindingSource toolCodeList)
        {
            //dgvToolCode.DataSource = toolCodeList;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            //if (_bActive == false)
            //{
            //    _bActive = true;
            //    this.tlpDetailTray.ColumnCount = 1;
            //    this.tlpDetailTray.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            //    this.tlpDetailTray.Controls.Add(this.tlpTooList, 0, 0);
            //}
            //else
            //{
            //    _bActive = false;
            //    this.tlpDetailTray.ColumnCount = 3;
            //    this.tlpDetailTray.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            //    this.tlpDetailTray.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.7F));
            //    this.tlpDetailTray.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.3F));
            //    this.tlpDetailTray.Controls.Add(this.tlpTooList, 1, 0);
            //    tlpDetailTray.Refresh();
            //}
        }
    }
}
