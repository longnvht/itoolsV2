using Guna.UI2.WinForms;
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
    public partial class JobView : Form, IJobView
    {
        public JobView()
        {
            InitializeComponent();

            this.Load += delegate { JobView_Load?.Invoke(this, EventArgs.Empty); };
            txtJobNumberSearch.TextChanged += delegate { txtJobNumberSearch_TextChanged?.Invoke(this, EventArgs.Empty); };
            btnJobNumberSearch.Click += delegate { btnJobNumberSearch_Click?.Invoke(this, EventArgs.Empty); };
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
        public Job JobCurrent { get; set; }
        public List<Guna2GradientButton> lstJobNumberButton { get; set; }
        public List<string> lstJobNumber { get; set; }

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
            btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            btn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            btn.Font = new System.Drawing.Font("Segoe UI", 11F);
            btn.ForeColor = System.Drawing.Color.White;
            btn.Location = new System.Drawing.Point(3, 3);
            btn.Name = "btnJobNumber";
            btn.Size = new System.Drawing.Size(122, 80);
            btn.Text = strJobNumber;
            btn.Click += delegate { btnflpJobNumberList_Click?.Invoke(this, EventArgs.Empty); };
            btn.DoubleClick += delegate { btnflpJobNumberlList_DoubleClick?.Invoke(this, EventArgs.Empty); };

            return btn;
        }
        #endregion

        #region Events
        public event EventHandler JobView_Load;
        public event EventHandler txtJobNumberSearch_TextChanged;
        public event EventHandler btnJobNumberSearch_Click;
        public event EventHandler btnflpJobNumberList_Click;
        public event EventHandler btnflpJobNumberlList_DoubleClick;
        #endregion
    }
}
