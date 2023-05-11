﻿using Guna.UI2.WinForms;
using itools_source.Views.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VinamiToolUser.Views;

namespace itools_source.Views
{
    public partial class OPView : Form, IOPView
    {
        public OPView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            this.Load += delegate { OPView_Load?.Invoke(this, EventArgs.Empty); };
            _txtOPSearch.MouseClick += (s, e) => { ShowKeyboard(true); };
            _txtOPSearch.TextChanged += delegate { txtOPSearch_TextChanged?.Invoke(this, EventArgs.Empty as MouseEventArgs); };
            this.FormClosing += delegate { OPView_FormClosing?.Invoke(this, EventArgs.Empty as FormClosingEventArgs); };
        }

        private void ShowKeyboard(bool type)
        {
            var kb = KeyBoard.GetInstance();
            kb.isNumeric = type;
            int x = (Screen.PrimaryScreen.Bounds.Right - kb.Width) / 2;
            int y = Screen.PrimaryScreen.Bounds.Bottom - kb.Height;
            kb.Show();
            kb.Location = new Point(x, y);
        }

        #region Properties - Fields
        public int? iOPId { get; set; }
        public string strOPNumber { get; set; }
        public string strSearch
        {
            get
            {
                if (string.IsNullOrEmpty(_txtOPSearch.Text))
                {
                    return "";
                }
                return _txtOPSearch.Text;
            }
            set => _txtOPSearch.Text = value;
        }
        public List<Guna2GradientButton> lstButton { get; set; }
        public Dictionary<int?, Dictionary<string, string>> lstOPNumberOPType { get; set; }
        public Action<int?, string> GetToolViewAction { get; set; }

        // Singleton pattern (Open a single form instance)
        private static OPView _instance;
        public static OPView GetInstance(Form parentContainer)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new OPView
                {
                    MdiParent = parentContainer,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
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
        public event EventHandler OPView_Load;
        public event EventHandler btnflpOPlList_DoubleClick;
        public event EventHandler btnflpOPlList_Click;
        public event EventHandler txtOPSearch_TextChanged;
        public event FormClosingEventHandler OPView_FormClosing;
        #endregion

        #region Methods
        public Guna2GradientButton CreateButton(int? iIndex = null)
        {
            Guna2GradientButton btn = new Guna2GradientButton
            {
                Animated = true,
                BorderRadius = 10
            };
            btn.BorderThickness = 1;
            btn.BorderColor = System.Drawing.Color.FromArgb(70, 71, 117);
            btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
            btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
            btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            btn.FillColor = System.Drawing.Color.WhiteSmoke;
            btn.FillColor2 = System.Drawing.Color.WhiteSmoke;
            btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(238, 238, 255);
            btn.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(148, 111, 207);
            btn.Font = new System.Drawing.Font("Segoe UI", 12F);
            btn.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64);
            btn.Margin = new System.Windows.Forms.Padding(10);
            btn.Location = new System.Drawing.Point(3, 3);
            btn.Size = new System.Drawing.Size(120, 100);
            if (iIndex != null)
            {
                btn.Tag = this.lstOPNumberOPType.Keys.ElementAt(iIndex.Value);

                string strOPNumber = this.lstOPNumberOPType.Values.ElementAt(iIndex.Value).Keys.ElementAt(0);
                string strOPType = this.lstOPNumberOPType.Values.ElementAt(iIndex.Value).Values.ElementAt(0);
                btn.Text = strOPNumber + "\r\n" + strOPType;
            }
            btn.DoubleClick += (s, e) => { btnflpOPlList_DoubleClick?.Invoke(s, e); };
            btn.Click += (s, e) => { btnflpOPlList_Click?.Invoke(s, e); };

            return btn;
        }

        public Form GetMdiParent()
        {
            return MdiParent;
        }

        public void SetMdiParent(Form mdiParent)
        {
            if (this.IsDisposed)
            {
                if (this.WindowState == FormWindowState.Minimized)
                {
                    this.WindowState = FormWindowState.Normal;
                }
                else
                {
                    this.Dock = DockStyle.Fill;
                }
                this.BringToFront();
            }
            else
            {
                this.MdiParent = mdiParent;
                this.FormBorderStyle = FormBorderStyle.None;
                this.Dock = DockStyle.Fill;
            }
        }
        internal void OpSearch() 
        {
            if (string.IsNullOrEmpty(strSearch)) 
            { 
                _flpOPList.Controls.AddRange(lstButton.ToArray()); 
                return; 
            } 
            string strSeacrhTest = strSearch.ToLower(); 
            List<Guna2GradientButton> lstSearch = new List<Guna2GradientButton>();
            int iCount = lstButton.Count; 
            for (int i = 0; i < iCount; i++) 
            { 
                string strTextButton = lstButton[i].Text.ToLower();
                if (strTextButton.Contains(strSeacrhTest))
                { 
                    lstSearch.Add(lstButton[i]); 
                } 
            } 
            _flpOPList.Controls.AddRange(lstSearch.ToArray()); 
        }
        #endregion
    }
}
