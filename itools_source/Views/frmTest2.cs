using Guna.UI2.WinForms;
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
    public partial class frmTest2 : Form
    {
        public frmTest2()
        {
            InitializeComponent();

            tlpRightContent.Visible = false;
            tlpDetailTray.Visible = true;
            tlpDetailTray.Location = new Point(312, 3);
            txtSearch.Text = tlpContent.Controls.Count.ToString();
            tlpContent.Controls.Add(tlpDetailTray);
            tlpDetailTray.Dock = DockStyle.Fill;
            txtTrayIndex.Text = tlpContent.Controls.Count.ToString();
            CreateButtonTool();
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
                //btn.Click += btnTest_Click;
                this.flpListTray.Controls.Add(btn);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (tlpRightContent.Visible == false)
            {
                if (tlpContent.Controls.Count == 2)
                {
                    tlpContent.Controls.Remove(tlpDetailTray);
                }
                tlpRightContent.Visible = true;
                tlpDetailTray.Visible = false;
                tlpRightContent.Location = new Point(312, 3);
                tlpContent.Controls.Add(tlpRightContent);
                tlpRightContent.Dock = DockStyle.Fill;
            }
        }

        private void btnAddPlugin_Click(object sender, EventArgs e)
        {
            if (tlpRightContent.Visible == true)
            {
                if (tlpContent.Controls.Count == 2)
                {
                    tlpContent.Controls.Remove(tlpRightContent);
                }
                tlpRightContent.Visible = false;
                tlpDetailTray.Visible = true;
                tlpDetailTray.Location = new Point(312, 3);
                tlpContent.Controls.Add(tlpDetailTray);
                tlpDetailTray.Dock = DockStyle.Fill;
                txtToolAddNewSearch.Text = tlpContent.Controls.Count.ToString();
            }
        }

        private void btnToolAddNewCancel_Click(object sender, EventArgs e)
        {
            if (tlpRightContent.Visible == true)
            {
                if (tlpContent.Controls.Count == 2)
                {
                    tlpContent.Controls.Remove(tlpRightContent);
                }
                tlpRightContent.Visible = false;
                tlpDetailTray.Visible = true;
                tlpDetailTray.Location = new Point(312, 3);
                tlpContent.Controls.Add(tlpDetailTray);
                tlpDetailTray.Dock = DockStyle.Fill;
                txtToolAddNewSearch.Text = tlpContent.Controls.Count.ToString();
            }
        }
    }
}
