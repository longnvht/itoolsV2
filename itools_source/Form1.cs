using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itools_source
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            //serialPort1.
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            lblTest.Text = guna2TextBox1.Text;
        }
    }
}
