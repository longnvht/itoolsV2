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
    public partial class GetToolView : Form, IGetToolView
    {
        public GetToolView()
        {
            InitializeComponent();

            this.Load += delegate { GetToolView_Load?.Invoke(this, EventArgs.Empty); };
        }

        #region Properties - Fields
        // Singleton pattern (Open a single form instance)
        private static GetToolView _instance;

        public static GetToolView GetInstance(Form parentContainer)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new GetToolView();
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
        public int iOPId { get; set; }
        public char cStatusForm { get; set; }
        public List<Guna2GradientButton> lstToolButton { get; set; }
        public Dictionary<int, string> lstToolForOPList { get; set; }
        public string strToolCode
        {
            get
            {
                if (string.IsNullOrEmpty(txtToolCode.Text))
                {
                    return "";
                }
                return txtToolCode.Text;
            }
            set => txtToolCode.Text = value;
        }
        public string strToolModel
        {
            get
            {
                if (string.IsNullOrEmpty(txtModel.Text))
                {
                    return "";
                }
                return txtModel.Text;
            }
            set => txtModel.Text = value;
        }
        public string strToolDescription
        {
            get
            {
                if (string.IsNullOrEmpty(txtDescription.Text))
                {
                    return "";
                }
                return txtDescription.Text;
            }
            set => txtDescription.Text = value;
        }
        #endregion

        #region Methods
        public void SetStatusForm()
        {
            
        }

        public Guna2GradientButton CreateButton(int? iIndex = null)
        {
            Guna2GradientButton btn = new Guna2GradientButton();
            btn.Animated = true;
            btn.BorderRadius = 10;
            btn.DisabledState.BorderColor = Color.DarkGray;
            btn.DisabledState.CustomBorderColor = Color.DarkGray;
            btn.DisabledState.FillColor = Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            btn.DisabledState.FillColor2 = Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            btn.DisabledState.ForeColor = Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            btn.FillColor = Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            btn.FillColor2 = Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            btn.Font = new Font("Segoe UI", 11F);
            btn.ForeColor = Color.White;
            btn.Location = new Point(3, 3);
            btn.Size = new Size(280, 60);
            if (iIndex != null)
            {
                btn.Tag = this.lstToolForOPList.Keys.ElementAt(iIndex.Value);
                btn.Text = this.lstToolForOPList.Values.ElementAt(iIndex.Value);
            }
            btn.Click += (s, e) => { btnflpToolList_Click?.Invoke(s, e); };

            return btn;
        }
        #endregion

        #region Events
        public event EventHandler GetToolView_Load;
        public event EventHandler btnflpToolList_Click;
        #endregion
    }
}
