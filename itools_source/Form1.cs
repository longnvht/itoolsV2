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
        private bool _bActive = true;

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

            tlpTooList.Visible = false;
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
            tlpTooList.Enabled = false;            

            FlowLayoutPanel flpListTool = new FlowLayoutPanel();

            flpListTool.AutoScroll = true;
            flpListTool.BackColor = Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            flpListTool.Location = new Point(480, 30);
            flpListTool.Margin = new Padding(2);
            flpListTool.RightToLeft = RightToLeft.No;
            flpListTool.Size = new Size(310, 450);

            // 
            // guna2VScrollBar
            // 
            Guna2VScrollBar guna2VScrollBar = new Guna2VScrollBar();

            guna2VScrollBar.BindingContainer = flpListTool;
            guna2VScrollBar.AutoRoundedCorners = true;
            guna2VScrollBar.LargeChange = 10;
            flpListTool.PerformLayout();
            guna2VScrollBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            guna2VScrollBar.ScrollbarSize = 30;
            guna2VScrollBar.Size = new System.Drawing.Size(30, flpListTool.Height);
            guna2VScrollBar.ThumbSize = 100F;
            guna2VScrollBar.BackColor = this.BackColor;

            Controls.Add(flpListTool);
            Controls.Add(guna2VScrollBar);
            //flpListTool.Controls.Add(guna2VScrollBar);

            Guna2Elipse guna2Elipse = new Guna2Elipse();
            guna2Elipse.BorderRadius = 20;
            guna2Elipse.TargetControl = flpListTool;

            flpListTool.BringToFront();

            for (int i = 1; i < 61; i++)
            {
                Guna2GradientButton btn = new Guna2GradientButton();
                if (i < 10)
                {
                    btn.Text = "TRAY 0" + i.ToString();
                }
                else
                {
                    btn.Text = "TRAY " + i.ToString();
                }

                btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
                btn.Animated = true;
                btn.AutoRoundedCorners = true;
                btn.BorderRadius = 22;
                btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
                btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
                btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
                btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
                btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
                btn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
                btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.ForeColor = System.Drawing.Color.White;
                btn.Location = new System.Drawing.Point(3, 3);
                btn.Size = new System.Drawing.Size(280, 46);
                btn.Text = "Lưu";

                //btn.Click += (s, e) => ClickBtnFlowPanel?.Invoke(s, e);
                //flpListTool.Controls.Add(btn);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tlpTooList.Visible == true)
            {
                _bActive = false;
                tlpTooList.Visible = false;
            }
            else
            {
                _bActive = true;
                tlpTooList.Visible = true;
            }
        }
    }
}
