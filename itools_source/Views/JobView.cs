using Guna.UI2.WinForms;
using itools_source.Views.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace itools_source.Views
{
    public partial class JobView : Form, IJobView
    {
        public delegate void SetListOPNumberOPType(SortedList<string, string> lstOPNumberOpType);
        public JobView()
        {
            InitializeComponent();

            this.Load += delegate { JobView_Load?.Invoke(this, EventArgs.Empty); };
            btnJobNumberSearch.Click += delegate { btnJobNumberSearch_Click?.Invoke(this, EventArgs.Empty); };
            _txtJobNumberSearch.MouseClick += delegate { txtJobNumberSearch_MouseClick?.Invoke(this, EventArgs.Empty as MouseEventArgs); };
            _txtJobNumberSearch.KeyDown += delegate { txtJobNumberSearch_KeyDown?.Invoke(this, EventArgs.Empty as KeyEventArgs); };
            FormClosing += delegate { JobView_FormClosing?.Invoke(this, EventArgs.Empty as FormClosingEventArgs); };
        }

        #region Properties - Fields
        public string strJobNumberSearch
        {
            get
            {
                if (string.IsNullOrEmpty(txtJobNumberSearch.Text))
                {
                    return "";
                }
                return txtJobNumberSearch.Text;
            }
            set => txtJobNumberSearch.Text = value;
        }
        public string strJobNumberCurrent { get; set; }
        public int? iPartIDCurrent { get; set; }
        public List<Guna2GradientButton> lstJobNumberButton { get; set; }
        public SortedList<string, string> lstJobNumberPartID { get; set; }
        public Dictionary<int?, Dictionary<string, string>> lstOPNumberOPType { get; set; }
        Action<Dictionary<int?, Dictionary<string, string>>, string> IJobView.SetListOPNumberOPType { get; set; }

        // Singleton pattern (Open a single form instance)
        private static JobView _instance;
        public static JobView GetInstance(Form parentContainer)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new JobView();
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

        #region Methods
        public Guna2GradientButton CreateJobNumberButton(string strJobNumber = "")
        {
            Guna2GradientButton btn = new Guna2GradientButton();
            btn.Animated = true;
            btn.BorderRadius = 10;
            btn.BorderThickness = 1;
            btn.BorderColor = Color.FromArgb(70,71,117);
            btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
            btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
            btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            btn.FillColor = System.Drawing.Color.WhiteSmoke;
            btn.FillColor2 = System.Drawing.Color.WhiteSmoke;
            btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(238, 238, 255);
            btn.CheckedState.FillColor2 = Color.FromArgb(148, 111, 207);
            btn.Font = new System.Drawing.Font("Segoe UI", 12F);
            btn.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64);
            btn.Location = new System.Drawing.Point(3, 3);
            btn.Size = new System.Drawing.Size(120, 100);
            btn.Margin = new System.Windows.Forms.Padding(10);
            btn.Text = strJobNumber;
            btn.Click += (s, e) => { btnflpJobNumberList_Click?.Invoke(s, e); };
            btn.DoubleClick += (s, e) => { btnflpJobNumberList_DoubleClick?.Invoke(s, e); };

            return btn;
        }

        public void flpJobNumberList_ControlsAddRange(Control[] controls)
        {
            this.flpJobNumberList.Controls.AddRange(controls);
        }

        public Form GetMdiParent()
        {
            return MdiParent;
        }

        public void SetMdiParent(Form mdiParent)
        {
            if (this.IsDisposed)
            {
                if (this.WindowState == FormWindowState.Minimized)
                {
                    this.WindowState = FormWindowState.Normal;
                }
                else
                {
                    this.Dock = DockStyle.Fill;
                }
                this.BringToFront();
            }
            else
            {
                this.MdiParent = mdiParent;
                this.FormBorderStyle = FormBorderStyle.None;
                this.Dock = DockStyle.Fill;
            }
        }
        #endregion

        #region Events
        public event EventHandler JobView_Load;
        public event EventHandler btnJobNumberSearch_Click;
        public event EventHandler btnflpJobNumberList_Click;
        public event EventHandler btnflpJobNumberList_DoubleClick;
        public event EventHandler txtJobNumberSearch_MouseClick;
        public event EventHandler txtJobNumberSearch_KeyDown;
        public event FormClosingEventHandler JobView_FormClosing;
        #endregion
    }
}
