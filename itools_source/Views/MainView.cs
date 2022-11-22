using itools_source.Models;
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
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();

            this.btnPrevious.Click += delegate { Previous?.Invoke(this, EventArgs.Empty); };
            this.btnNext.Click += delegate { Next?.Invoke(this, EventArgs.Empty); };
            this.Load += delegate { FormLoad?.Invoke(this, EventArgs.Empty); };
        }

        public string strName { get => lblName.Text; set => lblName.Text = value; }
        
        public Assessor assessorCurrent { get; set; }

        public event EventHandler FormLoad;
        public event EventHandler Previous;
        public event EventHandler Next;

        public void CloseFormChild()
        {
            if (MdiChildren.Any())
            {
                MdiChildren[0].Close();
            }
            else
            {
                MessageBox.Show("Ahihi");
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MdiChildren.Any().ToString());
            if (MdiChildren.Any())
            {
                MdiChildren[0].Close();
            }
            else
            {
                MessageBox.Show("Ahihi");
            }
            //MessageBox.Show(Environment.MachineName);
        }
    }
}
