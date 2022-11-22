using Guna.UI2.WinForms;
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
    public partial class OPView : Form, IOPView
    {
        public OPView()
        {
            InitializeComponent();

            this.Load += delegate { OPView_Load?.Invoke(this, EventArgs.Empty); };
        }

        #region Properties - Fields
        public string strPartID { get; set; }
        public string strOPNumber { get; set; }
        public string strSearch
        {
            get
            {
                if (string.IsNullOrEmpty(_txtOPSearch.Text))
                {
                    return "";
                }
                return _txtOPSearch.Text;
            }
            set => _txtOPSearch.Text = value;
        }
        public List<Guna2GradientButton> lstButton { get; set; }
        public SortedList<string, string> lstOPNumberOpType { get; set; }

        // Singleton pattern (Open a single form instance)
        private static OPView _instance;
        public static OPView GetInstance(Form parentContainer)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new OPView();
                _instance.MdiParent = parentContainer;
                _instance.FormBorderStyle = FormBorderStyle.None;
                _instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (_instance.WindowState == FormWindowState.Minimized)
                {
                    _instance.WindowState = FormWindowState.Normal;
                }
                _instance.BringToFront();
            }
            return _instance;
        }
        #endregion

        #region Events
        public event EventHandler OPView_Load;
        public event EventHandler btnflpOPlList_DoubleClick;
        #endregion

        #region Methods
        public Guna2GradientButton CreateButton(string strButtonText = null)
        {
            Guna2GradientButton btn = new Guna2GradientButton();
            btn.Animated = true;
            btn.BorderRadius = 10;
            btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            btn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            btn.Font = new System.Drawing.Font("Segoe UI", 11F);
            btn.ForeColor = System.Drawing.Color.White;
            btn.Location = new System.Drawing.Point(3, 3);
            btn.Size = new System.Drawing.Size(122, 80);
            if (strButtonText != null)
            {
                btn.Text = strButtonText;
            }
            btn.DoubleClick += (s, e) => { btnflpOPlList_DoubleClick?.Invoke(s, e); };

            return btn;
        }
        //public void ListOPNumberOPType(SortedList<string, string> lstOPNumberOpType)
        //{
        //    this.lstOPNumberOpType = lstOPNumberOpType;
        //}
        #endregion
    }
}
