using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VinamiToolUser.Views
{
    public partial class KeyBoard : Form
    {
        public KeyBoard()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        const int WS_EX_NOACTIVATE = 0x08000000;
        const int WS_EX_TOPMOST = 0x00000008;
        const int WS_EX_WINDOWEDGE = 0x00000100;
        const int WS_CHILD = 0x40000000;
        private const int WS_EX_TOOLWINDOW = 0x00000080;

        public Point LocationPoint
        {
            get; set;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams ret = base.CreateParams;
                ret.Style = WS_CHILD;
                ret.ExStyle |= WS_EX_NOACTIVATE | WS_EX_TOPMOST | WS_EX_WINDOWEDGE | WS_EX_TOOLWINDOW;
                ret.X = LocationPoint.X;
                ret.Y = LocationPoint.Y;
                return ret;
            }
        }
        public bool isNumeric
        {
            get { return vtKeyBoard.IsNumeric; }
            set { SetStyle(value); }
        }

        Point lastPoint;
        private void pnTitle_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void pnTiltle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnNum.Click += (s, e) =>
            {
                SetStyle(btnNum.Checked);

            };
            btnClose.Click += (s, e) => { this.Close(); };
            pnTitle.MouseMove += pnTiltle_MouseMove;
            pnTitle.MouseDown += pnTitle_MouseDown;
        }
        private void SetStyle(bool style)
        {
            if (style == false)
            {
                btnNum.Checked = true;
                vtKeyBoard.IsNumeric = true;
                btnNum.Text = "123";
                this.Width = 320;
            }
            else
            {
                btnNum.Checked = false;
                vtKeyBoard.IsNumeric = false;
                btnNum.Text = "ABC";
                this.Width = 900;
            }
        }
    }
}
