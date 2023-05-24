using itools_source;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VinamiToolUser.Views.Interface;

namespace VinamiToolUser.Views
{
    public partial class TestView : Form
    {
        private static TestView instance;
        public TestView()
        {
            InitializeComponent();
        }

        public static TestView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new TestView();
                //instance = UnityDI.container.Resolve<IMenuViewNew>() as MenuViewNew;
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
    }
}
