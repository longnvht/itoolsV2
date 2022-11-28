using Guna.UI2.WinForms;
using itools_source.Views.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace itools_source.Views
{
    public partial class GetToolView : Form, IGetToolView
    {
        public GetToolView()
        {
            InitializeComponent();

            this.Load += delegate { GetToolView_Load?.Invoke(this, EventArgs.Empty); };
            serialPort_GetTool.DataReceived += (s, e) => { serialPort_GetTool_DataReceived?.Invoke(s, e); };
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

        public int iToolId { get; set; }
        public string strTrayIndex { get; set; }
        public string strMachineCode { get; set; }
        public Dictionary<string, string> lstMachineTray { get; set; }
        public List<Guna2GradientButton> lstTrayButton { get; set; }
        public SerialPort serialPortGetTool { get => serialPort_GetTool; set => serialPort_GetTool = value; }
        #endregion

        #region Methods
        public Guna2GradientButton CreateButton(object obTag, object strText, EventHandler eventHandler)
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
            btn.Size = new Size(240, 60);
            if (obTag != null)
            {
                btn.Tag = obTag;
            }
            if (strText != null)
            {
                btn.Text = strText.ToString();
            }
            btn.Click += (s, e) => { eventHandler?.Invoke(s, e); };
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

                    tlpToolMachineList.Visible = false;
                    tlpToolMachineList.Dock = DockStyle.Right;
                    tlpToolMachineList.BringToFront();
                    break;
                case '1': // Click tool -> On FlowLayoutPandel Select TrayIndex.
                    if (tlpToolMachineList.Visible == false)
                    {
                        tlpToolMachineList.Visible = true;
                        tlpToolMachineList.Dock = DockStyle.Right;
                        tlpToolMachineList.BringToFront();
                    }
                    break;
                case '2': // Click tool -> Off FlowLayoutPandel Select TrayIndex.
                    if (tlpToolMachineList.Visible == true)
                    {
                        tlpToolMachineList.Visible = false;
                        tlpToolMachineList.Dock = DockStyle.Right;
                        tlpToolMachineList.BringToFront();
                    }
                    break;
            }
        }

        public void flpTrayMachineList_AddRange(Control[] controls)
        {
            _flpTrayMachineList.Controls.AddRange(controls);
        }

        public void flpTrayMachineList_Clear()
        {
            _flpTrayMachineList.Controls.Clear();
        }
        #endregion

        #region Events
        public event EventHandler GetToolView_Load;
        public event EventHandler btnflpTrayMachineList_Click;
        public event EventHandler btnflpTrayMachineList_DoubleClick;
        public event SerialDataReceivedEventHandler serialPort_GetTool_DataReceived;
        #endregion
    }
}
