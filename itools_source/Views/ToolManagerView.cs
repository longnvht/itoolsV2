using Guna.UI2.WinForms;
using itools_source.Models;
using itools_source.Properties;
using itools_source.Repository;
using itools_source.Utils;
using itools_source.Views.Interface;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itools_source.Views
{
    public partial class ToolManagerView : Form, IToolManagerView
    {
        public ToolManagerView()
        {
            InitializeComponent();

            this.Load += delegate { ToolManagerView_Load?.Invoke(this, EventArgs.Empty); };
            txtTraySearch.TextChanged += delegate { txtTraySearch_TextChanged?.Invoke(this, EventArgs.Empty); };
            btnSave.Click += delegate { btnSave_Click?.Invoke(this, EventArgs.Empty); };
            txtOperateQuantity.KeyPress += (s, e) => { txtOperateQuantity_KeyPress(s, e); };
            txtOperateQuantity.TextChanged += delegate { txtOperateQuantity_TextChanged?.Invoke(this, EventArgs.Empty); };
            txtToolCode.MouseClick += delegate { txtToolCode_MouseClick?.Invoke(this, EventArgs.Empty); };
            txtToolSearch.TextChanged += delegate { txtToolSearch_TextChanged?.Invoke(this, EventArgs.Empty); };
            btnToolSelect.Click += delegate { btnToolSelect_Click?.Invoke(this, EventArgs.Empty); };
            btnToolCancel.Click += delegate { btnToolCancel_Click?.Invoke(this, EventArgs.Empty); };
            btnTakeOut.Click += delegate { btnTakeOut_Click?.Invoke(this, EventArgs.Empty); };
            btnAddPlugin.Click += delegate { btnAddPlugin_Click?.Invoke(this, EventArgs.Empty); };
            btnAddNew.Click += delegate { btnAddNew_Click?.Invoke(this, EventArgs.Empty); };
            btnTraySearch.Click += delegate { btnTraySearch_Click?.Invoke(this, EventArgs.Empty); };
        }

        #region Fields
        private static log4net.ILog _log = log4net.LogManager.GetLogger(typeof(ToolManagerView).Name);

        public string strMachineCode { get; set; }
        public string strTrayIndex
        {
            get
            {
                if (string.IsNullOrEmpty(txtTrayIndex.Text))
                {
                    return "";
                }
                return txtTrayIndex.Text;
            }
            set => txtTrayIndex.Text = value;
        }
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
        public int? iCurrentQuantity
        {
            get
            {
                if (string.IsNullOrEmpty(txtCurrentQuantity.Text))
                {
                    return 0;
                }
                return Convert.ToInt32(txtCurrentQuantity.Text);
            }
            set => txtCurrentQuantity.Text = value.ToString();
        }
        public int? iOperateQuantity
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
        public int? iTotalQuantity
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
        public string strTraySearch
        {
            get
            {
                if (string.IsNullOrEmpty(txtTraySearch.Text))
                {
                    return "";
                }
                return txtTraySearch.Text;
            }
            set => txtTraySearch.Text = value;
        }
        public string strToolSearch
        {
            get
            {
                if (string.IsNullOrEmpty(txtToolSearch.Text))
                {
                    return "";
                }
                return txtToolSearch.Text;
            }
            set => txtToolSearch.Text = value;
        }
        public bool btnAddNewEnabled { get => btnAddNew.Enabled; set => btnAddNew.Enabled = value; }
        public bool btnAddPluginEnabled { get => btnAddPlugin.Enabled; set => btnAddPlugin.Enabled = value; }
        public bool btnTakeOutEnabled { get => btnTakeOut.Enabled; set => btnTakeOut.Enabled = value; }
        public bool btnSaveEnabled { get => btnSave.Enabled; set => btnSave.Enabled = value; }
        public bool tlpHeaderEnabled { get => tlpHeader.Enabled; set => tlpHeader.Enabled = value; }
        public bool tlpFooterEnabled { get => tlpFooter.Enabled; set => tlpFooter.Enabled = value; }
        public bool pLeftContentEnabled { get => pLeftContent.Enabled; set => pLeftContent.Enabled = value; }
        public bool tlpTrayDetailEnabled { get => tlpTrayDetail.Enabled; set => tlpTrayDetail.Enabled = value; }
        public bool txtOperateQuantityEnable { get => txtOperateQuantity.Enabled; set => txtOperateQuantity.Enabled = value; }
        public bool txtCurrentQuantityEnbale { get => txtCurrentQuantity.Enabled; set => txtCurrentQuantity.Enabled = value; }
        public char cStatusForm { get; set; }
        public char cStatusButton { get; set; }
        public ToolMachineTray toolTrayCurrent { get; set; }
        public List<string> toolCodeList { get; set; }
        public SortedDictionary<string, string> sortTrayToolCode { get; set; }
        public List<Guna2Button> lstTrayButton { get; set; }
        public List<Guna2GradientButton> lstToolButton { get; set; }
        #endregion

        #region Method
        public void ToolSearch()
        {
            flpToolList.Controls.Clear();
            if (string.IsNullOrEmpty(strToolSearch))
            {
                flpToolList.Controls.AddRange(lstToolButton.ToArray());
                return;
            }
            string strSeacrhTest = strToolSearch.ToLower();

            List<Guna2GradientButton> lstSearch = new List<Guna2GradientButton>();
            int iCount = lstToolButton.Count;
            for (int i = 0; i < iCount; i++)
            {
                string strTextButton = lstToolButton[i].Text.ToLower();
                if (strTextButton.Contains(strSeacrhTest))
                {
                    lstSearch.Add(lstToolButton[i]);
                }
            }
            flpToolList.Controls.AddRange(lstSearch.ToArray());
        }
        
        public void TrayAndToolSearch()
        {
            //flpTrayList.Controls.Clear();
            if (string.IsNullOrEmpty(strTraySearch))
            {
                _flpTrayList.Controls.AddRange(lstTrayButton.ToArray());
                return;
            }
            string strSeacrhTest = strTraySearch.ToLower();

            List<Guna2Button> lstSearch = new List<Guna2Button>();
            int iCount = lstTrayButton.Count;
            for (int i = 0; i < iCount; i++)
            {
                string strTextButton = lstTrayButton[i].Text.ToLower();
                if (strTextButton.Contains(strSeacrhTest))
                {
                    lstSearch.Add(lstTrayButton[i]);
                }
            }
            _flpTrayList.Controls.AddRange(lstSearch.ToArray());
        }

        public void SetStatusForm()
        {
            this.txtOperateQuantity.Enabled = false;
            this.txtToolCode.Enabled = false;
            this.btnSave.Enabled = false;
            this.notifiTakeout.Text = "Off";
            this.notifiAddPlugin.Text = "Off";
            this.notifiAddNew.Text = "Off";
            this.notifiTakeout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.notifiAddPlugin.FillColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.notifiAddNew.FillColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

            switch (cStatusForm)
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

                    this.tlpTooList.Visible = false;
                    this.tlpTooList.Dock = DockStyle.Right;
                    this.tlpTooList.BringToFront();
                    break;
                case '4': // Save
                    this.txtOperateQuantity.Enabled = false;
                    this.btnTakeOut.Enabled = false;
                    this.btnAddPlugin.Enabled = false;
                    this.btnAddNew.Enabled = false;
                    this.btnSave.Enabled = false;

                    //this.iCurrentQuantity = null;
                    //this.iOperateQuantity = null;
                    //this.strTrayIndex = null;
                    //this.strToolCode = null;

                    //this.txtTrayIndex.Text = string.Empty;
                    //this.txtToolCode.Text = string.Empty;
                    //this.txtCurrentQuantity.Text = string.Empty;
                    //this.txtOperateQuantity.Text = string.Empty;
                    this.txtTotalQuantity.Text = string.Empty;
                    break;
                case '5':
                    this.txtOperateQuantity.Text = string.Empty;
                    this.txtTotalQuantity.Text = string.Empty;
                    break;
                case '6': // Select Tool in List
                    this.txtOperateQuantity.Enabled = false;
                    this.btnTakeOut.Enabled = false;
                    this.btnAddPlugin.Enabled = false;
                    this.btnAddNew.Enabled = false;
                    this.btnSave.Enabled = true;

                    //this.iCurrentQuantity = 0;
                    //this.strTrayIndex = 0;
                    //this.strToolCode = string.Empty;

                    //this.txtTrayIndex.Text = string.Empty;
                    //this.txtToolCode.Text = string.Empty;
                    //this.txtCurrentQuantity.Text = string.Empty;
                    break;
            }
        }

        public void SetStateButton()
        {
            switch (cStatusButton)
            {
                case '0': // AddNew
                    this.btnTakeOut.Enabled = false;
                    this.btnAddPlugin.Enabled = false;
                    this.btnSaveEnabled = true;
                    this.txtToolCode.Enabled = true;
                    this.notifiAddNew.FillColor = Color.LimeGreen;
                    this.notifiAddNew.Text = "On";
                    break;
                case '1': // AddPlugin
                    this.btnSave.Enabled = true;
                    this.btnTakeOut.Enabled = false;
                    this.btnAddNew.Enabled = false;
                    this.txtOperateQuantity.Enabled = true;
                    this.txtOperateQuantity_Focus();
                    this.notifiAddPlugin.FillColor = Color.LimeGreen;
                    this.notifiAddPlugin.Text = "On";
                    break;
                case '2': // TakeOut
                    this.btnAddPlugin.Enabled = false;
                    this.btnAddNew.Enabled = false;
                    this.txtOperateQuantity.Enabled = true;
                    this.btnSave.Enabled = true;
                    this.txtOperateQuantity_Focus();
                    this.notifiTakeout.FillColor = Color.LimeGreen;
                    this.notifiTakeout.Text = "On";
                    break;
            }
        }

        public void CreateButtonTray(SortedDictionary<string, string> sortDictionary)
        {
            if (lstTrayButton == null)
            {
                lstTrayButton = new List<Guna2Button>();
            }
            foreach (var item in sortDictionary)
            {
                Guna2Button btn = new Guna2Button();
                btn.Size = new Size(280, 60);
                string strTrayIndex = item.Key.Replace("_", " ");
                btn.Text = strTrayIndex + "\r\n" + item.Value;

                btn.BackColor = Color.Transparent;
                btn.BorderRadius = 15;
                btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
                btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
                btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
                btn.ForeColor = System.Drawing.Color.White;
                btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.FillColor = Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
                btn.CheckedState.FillColor = System.Drawing.Color.DarkOrchid;
                btn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                btn.Click += (s, e) => this.btnflpTrayList_Click?.Invoke(s, e);
                lstTrayButton.Add(btn);
            }
            _flpTrayList.Controls.AddRange(lstTrayButton.ToArray());
        }
        
        public void CreateToolButton()
        {
            if (tlpTooList.Visible == false)
            {
                tlpTooList.Visible = true;
                tlpTooList.Dock = DockStyle.Right;
                tlpTooList.BringToFront();
            }

            if (lstToolButton == null)
            {
                lstToolButton = new List<Guna2GradientButton>();
            }
            for (int i = 0; i < 49; i++)
            {
                //Guna2Button btn = new Guna2Button();
                Guna2GradientButton btn = new Guna2GradientButton();
                btn.Size = new Size(280, 60);
                btn.Text = toolCodeList[i];
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
                btn.Click += (s, e) => this.btnflpToolList_Click?.Invoke(s, e);
                btn.DoubleClick += (s, e) => this.btnflpToolList_DoubleClick?.Invoke(s, e);
                lstToolButton.Add(btn);
            }
            this.flpToolList.Controls.AddRange(lstToolButton.ToArray());
        }

        public void CancelListTool()
        {
            if (toolCodeList == null)
            {
                MessageBox.Show("Tool Code List is Null!");
                _log.Error("Tool Code List is Null!");
                return;
            }

            tlpHeader.Enabled = true;
            tlpFooter.Enabled = true;
            pLeftContent.Enabled = true;
            tlpTrayDetail.Enabled = true;
            this.txtToolCode.Enabled = true;

            if (tlpTooList.Visible == true)
            {
                tlpTooList.Visible = false;
                tlpTooList.Dock = DockStyle.None;
                tlpTooList.SendToBack();
            }

            // Reset button in flpToolList
            if (flpToolList.Controls.Count > 0)
            {
                foreach (Control item in flpToolList.Controls)
                {
                    Guna2GradientButton btn = (Guna2GradientButton)item;
                    if (item.GetType() != typeof(Guna2GradientButton))
                    {
                        continue;
                    }
                    if (((Guna2GradientButton)item).Checked)
                    {
                        ((Guna2GradientButton)item).Checked = false;
                        return;
                    }
                }
            }
        }

        public void txtCurrentQuantity_Focus()
        {
            txtCurrentQuantity.Focus();
        }

        public void txtOperateQuantity_Focus()
        {
            txtOperateQuantity.Focus();
        }

        public void SetCheckedButton(string strContinueButton)
        {
            if (flpToolList.Controls.Count > 0)
            {
                foreach (Control item in flpToolList.Controls)
                {
                    Guna2GradientButton btn = (Guna2GradientButton)item;
                    if (item.GetType() != typeof(Guna2GradientButton) || strContinueButton == ((Guna2GradientButton)item).Text)
                    {
                        continue;
                    }
                    if (((Guna2GradientButton)item).Checked)
                    {
                        ((Guna2GradientButton)item).Checked = false;
                        return;
                    }
                }
            }
        }

        public bool CheckedSelectTool()
        {
            if (flpToolList.Controls.Count > 0)
            {
                foreach (Control item in flpToolList.Controls)
                {
                    Guna2GradientButton btn = (Guna2GradientButton)item;
                    if (item.GetType() != typeof(Guna2GradientButton))
                    {
                        continue;
                    }
                    if (((Guna2GradientButton)item).Checked)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        // Singleton pattern (Open a single form instance)
        private static ToolManagerView _instance;

        public static ToolManagerView GetInstance(Form parentContainer)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new ToolManagerView();
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
        public event EventHandler ToolManagerView_Load;
        public event EventHandler txtTraySearch_TextChanged;
        public event EventHandler btnTraySearch_Click;
        public event EventHandler btnflpTrayList_Click;
        public event KeyPressEventHandler txtOperateQuantity_KeyPress;
        public event EventHandler txtOperateQuantity_TextChanged;
        public event EventHandler txtToolCode_MouseClick;
        public event EventHandler txtToolSearch_TextChanged;
        public event EventHandler btnflpToolList_Click;
        public event EventHandler btnflpToolList_DoubleClick;
        public event EventHandler btnToolSelect_Click;
        public event EventHandler btnToolCancel_Click;
        public event EventHandler btnTakeOut_Click;
        public event EventHandler btnAddPlugin_Click;
        public event EventHandler btnAddNew_Click;
        public event EventHandler btnSave_Click;
        #endregion
    }
}
