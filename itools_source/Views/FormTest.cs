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

        private void FormTest_Load(object sender, EventArgs e)
        {
            //SetToolCodeBindingSource();
            DataGridViewColumn dataGridViewColumn = new DataGridViewColumn();
        }

        public void SetToolCodeBindingSource(BindingSource toolCodeList)
        {
            //dgvToolCode.DataSource = toolCodeList;
        }
    }
}
