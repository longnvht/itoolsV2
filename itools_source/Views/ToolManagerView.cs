using Guna.UI2.WinForms;
using itools_source.Models;
using itools_source.Properties;
using itools_source.Repository;
using itools_source.Utils;
using itools_source.Views.Interface;
using Org.BouncyCastle.Bcpg.OpenPgp;
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
    public partial class ToolManagerView : Form, IToolManagerView
    {
        public ToolManagerView()
        {
            InitializeComponent();
            btnTakeOut.Click += delegate { ClickTakeOut?.Invoke(this, EventArgs.Empty); };
            btnAddPlugin.Click += delegate { ClickAddPlugin?.Invoke(this, EventArgs.Empty); };
            btnAddNew.Click += delegate { ClickAddNew?.Invoke(this, EventArgs.Empty); };
            btnSave.Click += delegate { ClickSave?.Invoke(this, EventArgs.Empty); };
            btnSearch.Click += delegate { Search?.Invoke(this, EventArgs.Empty); };
            txtOperateQuantity.KeyPress += (s, e) => { KeyPressOperateQuantity(s, e); };
            txtOperateQuantity.TextChanged += delegate { OperateQuantityTextChanged?.Invoke(this, EventArgs.Empty); };

            CreateButtonTray();
            this.flpListTray.PerformLayout();
            guna2VScrollBar1.Size = new System.Drawing.Size(30, flpListTray.Height);

            SetStatusForm('3');
            MessageBox.Show(tlpTooList.Visible.ToString());
            //tlpTooList.Visible = true;
        }

        #region Fields
        private static log4net.ILog _log = log4net.LogManager.GetLogger(typeof(ToolManagerView).Name);

        public string strToolCode
        {
            get
            {
                if (string.IsNullOrEmpty(strToolCode))
                {
                    return txtToolCode.Text;
                }
                return "";
            }
            set => txtToolCode.Text = value.ToString();
        }
        public int iTrayIndex
        {
            get
            {
                if (string.IsNullOrEmpty(txtTrayIndex.Text))
                {
                    return Convert.ToInt32(txtTrayIndex.Text);
                }
                return 0;
            }
            set => txtTrayIndex.Text = value.ToString();
        }
        public int iCurrentQuantity
        {
            get
            {
                if (string.IsNullOrEmpty(txtCurrentQuantity.Text))
                {
                    Convert.ToInt32(txtCurrentQuantity.Text);
                }
                return 0;
            }
            set => txtCurrentQuantity.Text = value.ToString();
        }
        public int iOperateQuantity
        {
            get
            {
                if (string.IsNullOrEmpty(txtOperateQuantity.Text))
                {
                    return 0;
                }
                return Convert.ToInt32(txtOperateQuantity.Text);
            }
            set => txtOperateQuantity.Text = value.ToString();
        }
        public int iTotalQuantity
        {
            get
            {
                if (string.IsNullOrEmpty(txtTotalQuantity.Text))
                {
                    return 0;
                }
                return Convert.ToInt32(txtTotalQuantity.Text);
            }
            set => txtTotalQuantity.Text = value.ToString();
        }
        public string strSearch { get => txtSearch.Text; set => txtSearch.Text = value; }
        public ToolsMachineTray toolTrayCurrent { get; set; }
        public char _cSatusView { get; set; }
        public bool btnAddNewEnable
        {
            get => btnAddNew.Enabled;
            set => btnAddNew.Enabled = value;
        }
        public bool btnAddPluginEnable
        {
            get => btnAddPlugin.Enabled;
            set => btnAddPlugin.Enabled = value;
        }
        public bool btnTakeOutEnable
        {
            get => btnTakeOut.Enabled;
            set => btnTakeOut.Enabled = value;
        }
        public bool btnSaveEnable
        {
            get => btnSave.Enabled;
            set => btnSave.Enabled = value;
        }
        public bool txtOperateQuantityEnable { get => txtOperateQuantity.Enabled; set => txtOperateQuantity.Enabled = value; }
        public bool txtCurrentQuantityEnbale { get => txtCurrentQuantity.Enabled; set => txtCurrentQuantity.Enabled = value; }
        public char cStatusForm { get; set; }
        public char cStatusButton { get; set; }
        public List<string> toolCodeList { get; set; }
        #endregion

        #region Method
        public void SetStatusForm(char cStatus)
        {
            this.txtOperateQuantity.Enabled = false;
            this.btnSave.Enabled = false;
            this.notifiTakeout.Text = "Off";
            this.notifiAddPlugin.Text = "Off";
            this.notifiAddNew.Text = "Off";
            this.notifiTakeout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.notifiAddPlugin.FillColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.notifiAddNew.FillColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

            switch (cStatus)
            {
                case '0': // AddNew
                    this.btnAddNew.Enabled = true;
                    this.btnAddPlugin.Enabled = true;
                    this.btnTakeOut.Enabled = false;
                    break;
                case '1': // AddNew, AddPlugin 
                    this.btnAddNew.Enabled = false;
                    this.btnAddPlugin.Enabled = true;
                    this.btnTakeOut.Enabled = true;
                    break;
                case '2': // TakeOut
                    this.btnAddNew.Enabled = false;
                    this.btnAddPlugin.Enabled = false;
                    this.btnTakeOut.Enabled = true;
                    break;
                case '3': // Status Default
                    this.btnAddNew.Enabled = false;
                    this.btnAddPlugin.Enabled = false;
                    this.btnTakeOut.Enabled = false;

                    this.txtTrayIndex.Enabled = false;
                    this.txtToolCode.Enabled = false;
                    this.txtCurrentQuantity.Enabled = false;
                    this.txtTotalQuantity.Enabled = false;
                    break;
                case '4': // Save
                    this.txtOperateQuantity.Enabled = false;
                    this.btnTakeOut.Enabled = false;
                    this.btnAddPlugin.Enabled = false;
                    this.btnAddNew.Enabled = false;
                    this.btnSave.Enabled = false;

                    //this.iCurrentQuantity = 0;
                    this.iOperateQuantity = 0;
                    //this.iTrayIndex = 0;
                    //this.strToolCode = string.Empty;

                    //this.txtTrayIndex.Text = string.Empty;
                    //this.txtToolCode.Text = string.Empty;
                    //this.txtCurrentQuantity.Text = string.Empty;
                    this.txtOperateQuantity.Text = string.Empty;
                    this.txtTotalQuantity.Text = string.Empty;
                    break;
                case '5':
                    this.txtOperateQuantity.Text = string.Empty;
                    this.txtTotalQuantity.Text = string.Empty;
                    break;
            }
        }

        public void SetButtonState(char cStatus)
        {
            switch (cStatus)
            {
                case '0': // AddNew
                    this.btnTakeOut.Enabled = false;
                    this.btnAddPluginEnable = false;
                    this.btnSaveEnable = true;
                    this.txtOperateQuantity.Enabled = true;
                    this.txtOperateQuantityFocus();
                    this.notifiAddNew.FillColor = Color.LimeGreen;
                    this.notifiAddNew.Text = "On";
                    break;
                case '1': // AddPlugin
                    this.btnSave.Enabled = true;
                    this.btnTakeOut.Enabled = false;
                    this.btnAddNew.Enabled = false;
                    this.txtOperateQuantity.Enabled = true;
                    this.txtOperateQuantityFocus();
                    this.notifiAddPlugin.FillColor = Color.LimeGreen;
                    this.notifiAddPlugin.Text = "On";
                    break;
                case '2': // TakeOut
                    this.btnAddPlugin.Enabled = false;
                    this.btnAddNew.Enabled = false;
                    this.txtOperateQuantity.Enabled = true;
                    this.btnSave.Enabled = true;
                    this.txtOperateQuantityFocus();
                    this.notifiTakeout.FillColor = Color.LimeGreen;
                    this.notifiTakeout.Text = "On";
                    break;
            }
        }

        public void ShowMessage(string strMessage)
        {
            MessageBox.Show(strMessage);
        }

        private void CreateButtonTray()
        {
            for (int i = 1; i < 61; i++)
            {
                Guna2Button btn = new Guna2Button();
                btn.Size = new Size(280, 60);
                if (i < 10)
                {
                    btn.Text = "TRAY 0" + i.ToString();
                }
                else
                {
                    btn.Text = "TRAY " + i.ToString();
                }

                btn.BackColor = Color.Transparent;
                btn.BorderRadius = 15;
                btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
                btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
                btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
                btn.ForeColor = System.Drawing.Color.White;
                btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.FillColor = Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
                btn.Click += (s, e) => this.ClickBtnFlowPanel?.Invoke(s, e);
                this.flpListTray.Controls.Add(btn);
            }
        }

        public void AddNewListTool()
        {
            if (toolCodeList == null)
            {
                MessageBox.Show("Tool Code List is Null!");
                _log.Error("Tool Code List is Null: " + toolCodeList.Count());
                return;
            }

            //tlpHeader.Enabled = false;
            //tlpDetailTray.Enabled = false;
            //flpListTray.Enabled = false;
            //btnTakeOut.Enabled = false;
            //btnAddPlugin.Enabled = false;
            //btnSave.Enabled = false;

            tlpHeader.Enabled = false;
            tlpFooter.Enabled = false;
            tlpContent.Enabled = false;

            if (tlpTooList.Visible == false)
            {
                tlpTooList.Visible = true;
            }

            //Panel panelAddToolCode = new Panel();
            //panelAddToolCode.Size = new Size(320, 450);
            //panelAddToolCode.BackColor = Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            //panelAddToolCode.Location = new Point(480, 0);
            //panelAddToolCode.Margin = new Padding(2);

            //Guna2TextBox txtSearchTool = new Guna2TextBox();
            //FlowLayoutPanel flpListTool = new FlowLayoutPanel();

            //// 
            //// txtSearch
            //// 
            //this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            //this.txtSearch.BorderRadius = 8;
            //this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            //this.txtSearch.DefaultText = "";
            //this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            //this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            //this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            //this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            //this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            //this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            //this.txtSearch.Location = new System.Drawing.Point(3, 7);
            //this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            //this.txtSearch.Name = "txtSearch";
            //this.txtSearch.PasswordChar = '\0';
            //this.txtSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            //this.txtSearch.PlaceholderText = "Tìm Kiếm";
            //this.txtSearch.SelectedText = "";
            //this.txtSearch.Size = new System.Drawing.Size(319, 36);
            //this.txtSearch.TabIndex = 0;
            //this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            //flpListTool.AutoScroll = true;
            ////flpListTool.BackColor = Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            //flpListTool.BackColor = Color.White;
            //flpListTool.Location = new Point(480, 0);
            //flpListTool.Margin = new Padding(2);
            //flpListTool.RightToLeft = RightToLeft.No;
            //flpListTool.Size = new Size(310, 450);

            //// VScrollBar
            //Guna2VScrollBar guna2VScrollBar = new Guna2VScrollBar();

            //guna2VScrollBar.BindingContainer = flpListTool;
            //guna2VScrollBar.AutoRoundedCorners = true;
            //guna2VScrollBar.LargeChange = 10;
            //flpListTool.PerformLayout();
            //guna2VScrollBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            //guna2VScrollBar.ScrollbarSize = 30;
            //guna2VScrollBar.Size = new System.Drawing.Size(30, flpListTool.Height);
            //guna2VScrollBar.ThumbSize = 100F;

            //Controls.Add(flpListTool);
            //Controls.Add(guna2VScrollBar);

            //Guna2Elipse guna2Elipse = new Guna2Elipse();
            //guna2Elipse.BorderRadius = 20;
            //guna2Elipse.TargetControl = flpListTool;

            //flpListTool.BringToFront();

            //int iToolCodeList = toolCodeList.Count;

            //for (int i = 0; i < 50; i++)
            //{
            //    Guna2GradientButton btn = new Guna2GradientButton();

            //    btn.Animated = true;
            //    btn.AutoRoundedCorners = true;
            //    btn.BorderRadius = 22;
            //    btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            //    btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            //    btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            //    btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            //    btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            //    btn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            //    btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //    btn.ForeColor = System.Drawing.Color.White;
            //    btn.Location = new System.Drawing.Point(3, 3);
            //    btn.Size = new System.Drawing.Size(280, 46);
            //    btn.Text = toolCodeList[i];
            //    //btn.Click += (s, e) => ClickBtnFlowPanel?.Invoke(s, e);

            //    flpListTool.Controls.Add(btn);
            //}

            ////panelAddToolCode.Controls.Add(flpListTool);
        }

        // Singleton pattern (Open a single form instance)
        private static ToolManagerView instance;
        public static ToolManagerView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ToolManagerView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }

        public void txtCurrentQuantityFocus()
        {
            txtCurrentQuantity.Focus();
        }

        public void txtOperateQuantityFocus()
        {
            txtOperateQuantity.Focus();
        }
        #endregion

        #region Events
        public event EventHandler ClickTakeOut;
        public event EventHandler ClickAddPlugin;
        public event EventHandler ClickAddNew;
        public event EventHandler ClickSave;
        public event EventHandler Search;
        public event EventHandler ClickBtnFlowPanel;
        public event KeyPressEventHandler KeyPressOperateQuantity;
        public event EventHandler OperateQuantityTextChanged;
        #endregion
    }
}
