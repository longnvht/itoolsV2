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
            txtJobNumberSearch.TextChanged += delegate { txtTraySearch_TextChanged?.Invoke(this, EventArgs.Empty); };
            btnJobNumberSearch.Click += delegate { btnflpJobNumberList_Click?.Invoke(this, EventArgs.Empty); };
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
        public BindingList<Job> lstJobNumber { get; set; }

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
        public void CreateToolButton()
        {
            if (lstJobNumberButton == null)
            {
                lstJobNumberButton = new List<Guna2GradientButton>();
            }

            int iCount = lstJobNumber.Count > 30 ? 29 : lstJobNumber.Count;

            for (int i = 0; i < iCount; i++)
            {
                Guna2GradientButton btn = new Guna2GradientButton();
                btn.Size = new Size(280, 60);
                btn.Text = lstJobNumber[i].strJobNumber;
                btn.BackColor = Color.Transparent;
                btn.BorderRadius = 15;
                btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
                btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
                btn.Animated = true;
                btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
                btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
                btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
                btn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
                btn.ForeColor = System.Drawing.Color.White;
                btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.FillColor = Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
                btn.CheckedState.FillColor = System.Drawing.Color.DarkOrchid;
                btn.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
                btn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                btn.Click += (s, e) => this.btnflpJobNumberList_Click?.Invoke(s, e);
                btn.DoubleClick += (s, e) => this.btnflpToolList_DoubleClick?.Invoke(s, e);
                lstJobNumberButton.Add(btn);
            }
            this.flpJobNumberList.Controls.AddRange(lstJobNumberButton.ToArray());
        }
        #endregion

        #region Events
        public event EventHandler JobView_Load;
        public event EventHandler txtTraySearch_TextChanged;
        public event EventHandler btnSearch_Click;
        public event EventHandler btnflpJobNumberList_Click;
        public event EventHandler btnflpToolList_DoubleClick;
        #endregion
    }
}
