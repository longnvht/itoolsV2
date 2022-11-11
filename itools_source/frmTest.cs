using Guna.UI2.WinForms;
using itools_source.Views;
using Org.BouncyCastle.Crypto.Engines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itools_source
{
    public partial class frmTest : Form
    {
        //private bool _bActive = true;

        public frmTest()
        {
            InitializeComponent();
            this.flpListTray.PerformLayout();
            this.guna2VScrollBar1.Size = new Size(30, flpListTray.Height);
            this.PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //flpListTray.PerformLayout();
            //CreateButtonTool();

            //MessageBox.Show(tlpTooList.Visible.ToString());
            //tlpTooList.Visible = false;
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

                //btn.Click += (s, e) => this.ClickBtnFlowPanel?.Invoke(s, e);
                btn.Click += btnTest_Click;
                this.flpListTray.Controls.Add(btn);
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void btnToolCancel_Click(object sender, EventArgs e)
        {
            tlpHeader.Enabled = true;
            tlpFooter.Enabled = true;
            tlpContent.Enabled = true;

            if (tlpTooList.Visible == true)
            {
                //_bActive = false;
                tlpTooList.Visible = false;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            
        }

        private void txtCurrentQuantity_MouseClick(object sender, MouseEventArgs e)
        {
            tlpHeader.Enabled = false;
            tlpFooter.Enabled = false;
            tlpContent.Enabled = false;

            if (tlpTooList.Visible == false)
            {
                //_bActive = true;
                tlpTooList.Visible = true;
            }
        }
    }
}
