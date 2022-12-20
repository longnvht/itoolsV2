using Guna.UI2.WinForms;
using itools_source.Views.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace itools_source.Views
{
    public partial class GetToolView : Form, IGetToolView
    {
        public GetToolView()
        {
            InitializeComponent();

            this.Load += delegate { GetToolView_Load?.Invoke(this, EventArgs.Empty); };
            serialPort_GetTool.DataReceived += (s, e) => { serialPort_GetTool_DataReceived?.Invoke(s, e); };
            _btnGetTool.Click += delegate { btnGetTool_Click?.Invoke(this, EventArgs.Empty); };
            _btnCancelSelectTray.Click += delegate { btnCancelSelectTray_Click?.Invoke(this, EventArgs.Empty); };
            _toggleShowAll.Click += delegate { toggleShowAll_Click?.Invoke(this, EventArgs.Empty); };
        }

        #region Properties - Fields
        private static log4net.ILog _log = log4net.LogManager.GetLogger(typeof(GetToolView).Name);

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
        public string strJobNumber { get; set; }
        public int? iOPId { get; set; }
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

        public int iToolId { get; set; }
        public string strTrayIndex { get; set; }
        public string strMachineCode { get; set; }
        public Dictionary<int, List<object>> lstTrayQuantity { get; set; }
        public List<Guna2GradientButton> lstTrayButton { get; set; }
        public SerialPort serialPortGetTool { get => serialPort_GetTool; set => serialPort_GetTool = value; }
        public Dictionary<int, List<object>> lstMachineTrayQuantity { get; set; }
        public Action<bool> EnabledButton { get; set; }
        #endregion

        #region Methods
        public Guna2GradientButton CreateButton(object strText, object iQuantity, string strEventName, object obTag = null)
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
            btn.CheckedState.FillColor = System.Drawing.Color.DarkOrchid;
            btn.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            btn.Font = new Font("Segoe UI", 11F);
            btn.ForeColor = Color.White;
            btn.Location = new Point(3, 3);
            btn.Size = new Size(240, 60);
            if (obTag != null)
            {
                btn.Tag = obTag;
            }
            if (strText != null)
            {
                btn.Text = strText.ToString();
                if (iQuantity != null)
                {
                    btn.Text += "\n\r" + iQuantity.ToString();
                }
            }

            if (strEventName == "Tray")
            {
                btn.Click += (s, e) =>
                {
                    btnflpTrayMachineList_Click?.Invoke(s, e);
                };
                btn.DoubleClick += (s, e) =>
                {
                    btnflpTrayMachineList_DoubleClick?.Invoke(s, e);
                };
            }

            if (strEventName == "Tool")
            {
                btn.Click += (s, e) =>
                {
                    btnflpToolList_Click?.Invoke(s, e);
                };
            }
            return btn;
        }

        public void SetStatusForm()
        {
            switch (cStatusForm)
            {
                case '0': // Default
                    txtToolCode.Enabled = false;
                    txtModel.Enabled = false;
                    txtDescription.Enabled = false;
                    btnGetTool.Enabled = false;

                    _tlpToolMachineList.Height = Height;
                    _tlpToolMachineList.Visible = false;
                    break;
                case '1': // Click tool -> On FlowLayoutPandel Select TrayIndex.
                    _tlpToolMachineList.Visible = true;
                    _tlpToolMachineList.Dock = DockStyle.Right;
                    break;
                case '2': // Click tool -> Off FlowLayoutPandel Select TrayIndex.
                    if (tlpToolMachineList.Visible == true)
                    {
                        tlpToolMachineList.Visible = false;
                        tlpToolMachineList.Dock = DockStyle.Right;
                        tlpToolMachineList.BringToFront();
                    }
                    break;
                case '3': // Cancel select TrayIndex or view Machine/Tray.
                    _tlpToolMachineList.Visible = false;
                    break;
                case '4': // Double select TrayIndex.
                    btnGetTool.Enabled = false;
                    break;
            }
        }

        public void CreateListButton(bool bCheck)
        {
            if (this.lstTrayButton == null)
            {
                this.lstTrayButton = new List<Guna2GradientButton>();
            }

            // 1. Clear controls ToolTray.
            this.flpTrayMachineList.Controls.Clear();
            this.lstTrayButton.Clear();

            // 2. Add button to Tray List.
            if (bCheck) // Machine tray.
            {
                foreach (var item in this.lstTrayQuantity)
                {
                    this.lstTrayButton.Add(CreateButton(item.Value[0], item.Value[1], "Tray", null));
                }
            }
            else // Machine tray quantity.
            {
                foreach (var item in this.lstMachineTrayQuantity)
                {
                    this.lstTrayButton.Add(CreateButton(item.Value[0] + " - " + item.Value[1], item.Value[2], "Tray", null));
                }
            }

            // 3. Add button list to flowlayoutpanel.
            this.flpTrayMachineList.Controls.AddRange(this.lstTrayButton.ToArray());
            _log.Info("Create button tray list and add button tray to flowlayoutpanel.");
        }

        public void flpTrayMachineList_AddRange(Control[] controls)
        {
            _flpTrayMachineList.Controls.AddRange(controls);
        }

        public void flpTrayMachineList_Clear()
        {
            _flpTrayMachineList.Controls.Clear();
        }

        public void SetCheckedButton(string strContinueButton)
        {
            if (_flpTrayMachineList.Controls.Count > 0)
            {
                foreach (Control item in _flpTrayMachineList.Controls)
                {
                    Guna2GradientButton btn = (Guna2GradientButton)item;
                    if (strContinueButton == btn.Text)
                    {
                        if (btn.Checked)
                        {
                            _btnGetTool.Enabled = true;
                        }
                        else
                        {
                            _btnGetTool.Enabled = false;
                        }
                        continue;
                    }
                    if (btn.Checked)
                    {
                        btn.Checked = false;
                        return;
                    }
                }
            }
        }

        public void GetJobNumberInMainView()
        {
            MessageDialog.Show(((MainView)MdiParent).strJobNumber);
        }

        public void GetOPIdInMainView()
        {
            MessageDialog.Show(((MainView)MdiParent).iOPId.ToString());
        }
        #endregion

        #region Events
        public event EventHandler GetToolView_Load;
        public event EventHandler btnflpToolList_Click;
        public event EventHandler btnflpTrayMachineList_Click;
        public event EventHandler btnflpTrayMachineList_DoubleClick;
        public event SerialDataReceivedEventHandler serialPort_GetTool_DataReceived;
        public event EventHandler btnCancelSelectTray_Click;
        public event EventHandler btnGetTool_Click;
        public event EventHandler toggleShowAll_Click;
        #endregion
    }
}
