using Guna.UI2.WinForms;
using itools_source.Models;
using itools_source.Properties;
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

            CreateButtonTool();
            this.flpListTool.PerformLayout();
            guna2VScrollBar1.Size = new System.Drawing.Size(30, flpListTool.Height);

            SetStatusForm('3');
        }

        #region Fields
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
        #endregion

        #region Method
        public void SetStatusForm(char cStatus)
        {
            this.txtOperateQuantity.Enabled = false;
            this.btnSave.Enabled = false;
            this.notifiTakeout.Text = "Off";
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

                    this.iCurrentQuantity = 0;
                    this.iOperateQuantity = 0;
                    this.iTrayIndex = 0;
                    this.strToolCode = string.Empty;

                    this.txtTrayIndex.Text = string.Empty;
                    this.txtToolCode.Text = string.Empty;
                    this.txtCurrentQuantity.Text = string.Empty;
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

        private void CreateButtonTool()
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
                btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
                btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
                btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
                btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
                btn.ForeColor = System.Drawing.Color.White;
                btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.FillColor = Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));

                btn.Click += (s, e) => this.ClickBtnFlowPanel?.Invoke(s, e);
                this.flpListTool.Controls.Add(btn);
            }
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
