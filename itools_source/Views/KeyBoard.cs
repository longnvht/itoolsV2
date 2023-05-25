using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace VinamiToolUser.Views
{
    public partial class KeyBoard : Form
    {
        private static KeyBoard instance;
        public KeyBoard()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        public static KeyBoard GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new KeyBoard();
                //int x = (Screen.PrimaryScreen.Bounds.Right - instance.Width) / 2;
                //int y = Screen.PrimaryScreen.Bounds.Bottom - instance.Height;
                //instance.Location = new Point(x, y);
            }
            else
            {
                instance.BringToFront();
            }
            return instance;
        }

        public static void CloseKeyboard()
        {
            if (instance != null) { instance.Close(); }
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
            set { swStyle.Checked = value; }
        }

        private void AssociateAndRaiseViewEvents()
        {
            swStyle.CheckedChanged += (s, e) =>
            {
                SetStyle(swStyle.Checked);
            };
            btnClose.Click += (s, e) => { this.Close(); };
        }
        private void SetStyle(bool style)
        {
            if (style == true)
            {
                vtKeyBoard.IsNumeric = true;
                txtStyle.Text = "123";
                this.Width = 320;
            }
            else
            {
                vtKeyBoard.IsNumeric = false;
                txtStyle.Text = "ABC";
                this.Width = 1000;
            }
        }
    }
}
