using Guna.UI2.WinForms;
using itools_source.Models;
using itools_source.Views.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace itools_source.Views
{
    public partial class ToolManagerView : Form, IToolManagerView
    {
        public ToolManagerView()
        {
            InitializeComponent();

            this.Load += delegate { ToolManagerView_Load?.Invoke(this, EventArgs.Empty); };
            _txtTrayToolSearch.TextChanged += delegate { txtTraySearch_TextChanged?.Invoke(this, EventArgs.Empty); };
            btnSave.Click += delegate { btnSave_Click?.Invoke(this, EventArgs.Empty); };
            _txtOperateQuantity.TextChanged += delegate { txtOperateQuantity_TextChanged?.Invoke(this, EventArgs.Empty); };
            _txtToolCode.MouseClick += delegate { txtToolCode_MouseClick?.Invoke(this, EventArgs.Empty); };
            _txtToolSearch.TextChanged += delegate { txtToolSearch_TextChanged?.Invoke(this, EventArgs.Empty); };
            btnToolSelect.Click += delegate { btnToolSelect_Click?.Invoke(this, EventArgs.Empty); };
            btnToolCancel.Click += delegate { btnToolCancel_Click?.Invoke(this, EventArgs.Empty); };
            btnTakeOut.Click += delegate { btnTakeOut_Click?.Invoke(this, EventArgs.Empty); };
            btnAddPlugin.Click += delegate { btnAddPlugin_Click?.Invoke(this, EventArgs.Empty); };
            btnAddNew.Click += delegate { btnAddNew_Click?.Invoke(this, EventArgs.Empty); };
            btnTraySearch.Click += delegate { btnTraySearch_Click?.Invoke(this, EventArgs.Empty); };
            _txtOperateQuantity.MouseClick += delegate { txtOperateQuantity_MouseClick?.Invoke(this, EventArgs.Empty as MouseEventArgs); };
            _txtToolSearch.MouseClick += delegate { txtToolSearch_MouseClick?.Invoke(this, EventArgs.Empty as MouseEventArgs); };
            _txtTrayToolSearch.MouseClick += delegate { txtTrayToolSearch_MouseClick?.Invoke(this, EventArgs.Empty as MouseEventArgs); };
            FormClosing += delegate { ToolManagerView_FormClosing?.Invoke(this, EventArgs.Empty as FormClosingEventArgs); };
        }

        #region Properties - Fields
        private static log4net.ILog _log = log4net.LogManager.GetLogger(typeof(ToolManagerView).Name);

        public string strMachineCode { get; set; }
        public string strTrayIndex
        {
            get
            {
                if (string.IsNullOrEmpty(_txtTrayIndex.Text))
                {
                    return "";
                }
                return _txtTrayIndex.Text;
            }
            set => _txtTrayIndex.Text = value;
        }
        public string strToolCode
        {
            get
            {
                if (string.IsNullOrEmpty(_txtToolCode.Text))
                {
                    return "";
                }
                return _txtToolCode.Text;
            }
            set => _txtToolCode.Text = value;
        }
        public int? iCurrentQuantity
        {
            get
            {
                if (string.IsNullOrEmpty(_txtCurrentQuantity.Text))
                {
                    return 0;
                }
                return Convert.ToInt32(_txtCurrentQuantity.Text);
            }
            set => _txtCurrentQuantity.Text = value.ToString();
        }
        public int? iOperateQuantity
        {
            get
            {
                if (string.IsNullOrEmpty(_txtOperateQuantity.Text))
                {
                    return 0;
                }
                return Convert.ToInt32(_txtOperateQuantity.Text);
            }
            set => _txtOperateQuantity.Text = value.ToString();
        }
        public int? iTotalQuantity
        {
            get
            {
                if (string.IsNullOrEmpty(_txtTotalQuantity.Text))
                {
                    return 0;
                }
                return Convert.ToInt32(_txtTotalQuantity.Text);
            }
            set => _txtTotalQuantity.Text = value.ToString();
        }
        public string strTrayToolSearch
        {
            get
            {
                if (string.IsNullOrEmpty(_txtTrayToolSearch.Text))
                {
                    return "";
                }
                return _txtTrayToolSearch.Text;
            }
            set => _txtTrayToolSearch.Text = value;
        }
        public string strToolSearch
        {
            get
            {
                if (string.IsNullOrEmpty(_txtToolSearch.Text))
                {
                    return "";
                }
                return _txtToolSearch.Text;
            }
            set => _txtToolSearch.Text = value;
        }
        public char cStatusForm { get; set; }
        public char cStatusButton { get; set; }
        public ToolMachineTray toolTrayCurrent { get; set; }
        public Dictionary<int, Dictionary<string, string>> lstTrayIndexToolCode { get; set; }
        public List<Guna2Button> lstTrayButton { get; set; }
        public List<Guna2GradientButton> lstToolButton { get; set; }
        public int? iToolID { get; set; }
        public int? iMachineId { get; set; }
        public int? iTrayID { get; set; }
        public Dictionary<int, string> lstTooIDAndCode { get; set; }
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
            if (string.IsNullOrEmpty(strTrayToolSearch))
            {
                _flpTrayList.Controls.AddRange(lstTrayButton.ToArray());
                return;
            }
            string strSeacrhTest = strTrayToolSearch.ToLower();

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
            this._txtOperateQuantity.Enabled = false;
            this._txtToolCode.Enabled = false;
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

                    this._txtTrayIndex.Enabled = false;
                    this._txtToolCode.Enabled = false;
                    this._txtCurrentQuantity.Enabled = false;
                    this._txtTotalQuantity.Enabled = false;

                    this._tlpToolList.Visible = false;
                    this._tlpToolList.Dock = DockStyle.Right;
                    this._tlpToolList.BringToFront();
                    break;
                case '4': // Save
                    this._txtOperateQuantity.Enabled = false;

                    this.btnTakeOut.Enabled = false;
                    this.btnAddPlugin.Enabled = false;
                    this.btnAddNew.Enabled = false;
                    this.btnSave.Enabled = false;

                    this._txtTotalQuantity.Text = string.Empty;
                    break;
                case '5':
                    this._txtOperateQuantity.Text = string.Empty;
                    this._txtTotalQuantity.Text = string.Empty;
                    break;
                case '6': // Select Tool in List
                    this._txtOperateQuantity.Enabled = true;
                    this._txtOperateQuantity.Focus();
                    this._txtToolCode.Enabled = true;

                    this.btnTakeOut.Enabled = false;
                    this.btnAddPlugin.Enabled = false;
                    this.btnSave.Enabled = true;

                    this.notifiAddNew.Text = "On";
                    this.notifiAddNew.FillColor = Color.LimeGreen;
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
                    this.btnSave.Enabled = true;

                    this._txtToolCode.Enabled = true;

                    this.notifiAddNew.FillColor = Color.LimeGreen;
                    this.notifiAddNew.Text = "On";
                    break;
                case '1': // AddPlugin
                    this.btnSave.Enabled = true;
                    this.btnTakeOut.Enabled = false;
                    this.btnAddNew.Enabled = false;

                    this._txtOperateQuantity.Enabled = true;
                    this._txtOperateQuantity.Focus();

                    this.notifiAddPlugin.FillColor = Color.LimeGreen;
                    this.notifiAddPlugin.Text = "On";
                    break;
                case '2': // TakeOut
                    this.btnAddPlugin.Enabled = false;
                    this.btnAddNew.Enabled = false;
                    this.btnSave.Enabled = true;

                    this._txtOperateQuantity.Enabled = true;
                    this._txtOperateQuantity.Focus();

                    this.notifiTakeout.FillColor = Color.LimeGreen;
                    this.notifiTakeout.Text = "On";
                    break;
            }
        }

        public void CreateButtonTray()
        {
            if (lstTrayButton == null)
            {
                lstTrayButton = new List<Guna2Button>();
            }

            foreach (var item in this.lstTrayIndexToolCode)
            {
                Guna2Button btn = new Guna2Button();
                btn.Size = new Size(280, 60);

                string strTrayIndex = item.Value.ElementAt(0).Key.Replace("_", " ");
                string strToolCode = item.Value.ElementAt(0).Value;
                btn.Text = strTrayIndex + "\r\n" + strToolCode;
                btn.Tag = item.Key;

                btn.BackColor = Color.Transparent;
                btn.BorderRadius = 15;
                btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
                btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
                btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
                btn.ForeColor = System.Drawing.Color.White;
                btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.FillColor = Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
                btn.CheckedState.FillColor = System.Drawing.Color.DarkOrchid;
                btn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                btn.Click += (s, e) => this.btnflpTrayList_Click?.Invoke(s, e);
                lstTrayButton.Add(btn);
            }
            _flpTrayList.Controls.AddRange(lstTrayButton.ToArray());
        }

        public void CreateToolButton()
        {
            if (_tlpToolList.Visible == false)
            {
                _tlpToolList.Visible = true;
                _tlpToolList.Dock = DockStyle.Right;
                _tlpToolList.BringToFront();
            }

            if (lstToolButton == null)
            {
                lstToolButton = new List<Guna2GradientButton>();
            }
            int iCount = lstTooIDAndCode.Count > 50 ? 49 : lstTooIDAndCode.Count;
            for (int i = 0; i < iCount; i++)
            {
                Guna2GradientButton btn = new Guna2GradientButton();
                btn.Size = new Size(280, 60);

                btn.Tag = lstTooIDAndCode.Keys.ElementAt(i);
                btn.Text = lstTooIDAndCode.Values.ElementAt(i);

                btn.BackColor = Color.Transparent;
                btn.BorderRadius = 15;
                btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
                btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
                btn.Animated = true;
                btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
                btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
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
            if (lstTooIDAndCode == null)
            {
                MessageBox.Show("Tool Code List is Null!");
                _log.Error("Tool Code List is Null!");
                return;
            }

            tlpHeader.Enabled = true;
            tlpFooter.Enabled = true;
            pLeftContent.Enabled = true;
            tlpTrayDetail.Enabled = true;
            this._txtToolCode.Enabled = true;

            if (_tlpToolList.Visible == true)
            {
                _tlpToolList.Visible = false;
                _tlpToolList.Dock = DockStyle.None;
                _tlpToolList.SendToBack();
            }

            // Reset button in flpToolList
            if (flpToolList.Controls.Count > 0)
            {
                foreach (Control item in flpToolList.Controls)
                {
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

        public void SetCheckedButton(int? iToolID)
        {
            if (flpToolList.Controls.Count > 0)
            {
                foreach (Control item in flpToolList.Controls)
                {
                    if (item.GetType() != typeof(Guna2GradientButton) || iToolID == (((Guna2GradientButton)item).Tag as int?))
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
        public event MouseEventHandler txtOperateQuantity_MouseClick;
        public event MouseEventHandler txtToolSearch_MouseClick;
        public event MouseEventHandler txtTrayToolSearch_MouseClick;
        public event FormClosingEventHandler ToolManagerView_FormClosing;
        #endregion
    }
}
