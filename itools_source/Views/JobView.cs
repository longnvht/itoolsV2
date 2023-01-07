using Guna.UI2.WinForms;
using itools_source.Views.Interface;
using System;
using System.Collections.Generic;
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
            txtJobNumberSearch.TextChanged += delegate { txtJobNumberSearch_TextChanged?.Invoke(this, EventArgs.Empty); };
            btnJobNumberSearch.Click += delegate { btnJobNumberSearch_Click?.Invoke(this, EventArgs.Empty); };
            _txtJobNumberSearch.MouseClick += delegate { txtJobNumberSearch_MouseClick?.Invoke(this, EventArgs.Empty as MouseEventArgs); };
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
            btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
            btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
            btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
            btn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
            btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(96)))), ((int)(((byte)(122)))));
            btn.Font = new System.Drawing.Font("Segoe UI", 11F);
            btn.ForeColor = System.Drawing.Color.White;
            btn.Location = new System.Drawing.Point(3, 3);
            btn.Size = new System.Drawing.Size(122, 80);
            btn.Text = strJobNumber;
            btn.Click += (s, e) => { btnflpJobNumberList_Click?.Invoke(s, e); };
            btn.DoubleClick += (s, e) => { btnflpJobNumberList_DoubleClick?.Invoke(s, e); };

            return btn;
        }

        public void flpJobNumberList_ControlsAddRange(Control[] controls)
        {
            this.flpJobNumberList.Controls.AddRange(controls);
        }
        #endregion

        #region Events
        public event EventHandler JobView_Load;
        public event EventHandler txtJobNumberSearch_TextChanged;
        public event EventHandler btnJobNumberSearch_Click;
        public event EventHandler btnflpJobNumberList_Click;
        public event EventHandler btnflpJobNumberList_DoubleClick;
        public event EventHandler txtJobNumberSearch_MouseClick;
        #endregion
    }
}
