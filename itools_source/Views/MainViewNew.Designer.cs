namespace VinamiToolUser.Views
{
    partial class MainViewNew
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainViewNew));
            this.tlpFooter = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrev = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.txtUserName = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.txtStatus = new System.Windows.Forms.Label();
            this.txtCurrentView = new System.Windows.Forms.Label();
            this.tlpFooter.SuspendLayout();
            this.tlpHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpFooter
            // 
            this.tlpFooter.BackColor = System.Drawing.Color.White;
            this.tlpFooter.ColumnCount = 3;
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFooter.Controls.Add(this.btnPrev, 0, 0);
            this.tlpFooter.Controls.Add(this.btnNext, 2, 0);
            this.tlpFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpFooter.Location = new System.Drawing.Point(0, 390);
            this.tlpFooter.Margin = new System.Windows.Forms.Padding(4);
            this.tlpFooter.Name = "tlpFooter";
            this.tlpFooter.RowCount = 1;
            this.tlpFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFooter.Size = new System.Drawing.Size(800, 60);
            this.tlpFooter.TabIndex = 5;
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrev.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btnPrev.BorderRadius = 10;
            this.btnPrev.BorderThickness = 1;
            this.btnPrev.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrev.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrev.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrev.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrev.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnPrev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPrev.Location = new System.Drawing.Point(4, 5);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(142, 50);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.Text = "Quay Lại";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btnNext.BorderRadius = 10;
            this.btnNext.BorderThickness = 1;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnNext.Location = new System.Drawing.Point(654, 5);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(142, 50);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Tiếp Theo";
            // 
            // tlpHeader
            // 
            this.tlpHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(96)))));
            this.tlpHeader.ColumnCount = 5;
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpHeader.Controls.Add(this.btnHome, 0, 0);
            this.tlpHeader.Controls.Add(this.txtUserName, 3, 0);
            this.tlpHeader.Controls.Add(this.btnClose, 4, 0);
            this.tlpHeader.Controls.Add(this.txtStatus, 2, 0);
            this.tlpHeader.Controls.Add(this.txtCurrentView, 1, 0);
            this.tlpHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpHeader.Location = new System.Drawing.Point(0, 0);
            this.tlpHeader.Margin = new System.Windows.Forms.Padding(4);
            this.tlpHeader.Name = "tlpHeader";
            this.tlpHeader.RowCount = 1;
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.Size = new System.Drawing.Size(800, 50);
            this.tlpHeader.TabIndex = 6;
            // 
            // btnHome
            // 
            this.btnHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.Transparent;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.Image = global::VinamiToolUser.Properties.Resources.home_500px;
            this.btnHome.Image = global::VinamiToolUser.Properties.Resources.home_512px;
            this.btnHome.ImageSize = new System.Drawing.Size(30, 30);
            this.btnHome.Location = new System.Drawing.Point(6, 6);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(37, 37);
            this.btnHome.TabIndex = 0;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtUserName.AutoSize = true;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtUserName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtUserName.Location = new System.Drawing.Point(698, 15);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(49, 20);
            this.txtUserName.TabIndex = 9;
            this.txtUserName.Text = "Name";
            this.txtUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.HoverState.Image = global::VinamiToolUser.Properties.Resources.close_500pxr;
            this.btnClose.Image = global::VinamiToolUser.Properties.Resources.close_500px1;
            this.btnClose.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.Location = new System.Drawing.Point(753, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 44);
            this.btnClose.TabIndex = 6;
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtStatus.AutoSize = true;
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtStatus.Location = new System.Drawing.Point(203, 14);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(22, 21);
            this.txtStatus.TabIndex = 10;
            this.txtStatus.Text = "...";
            // 
            // txtCurrentView
            // 
            this.txtCurrentView.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCurrentView.AutoSize = true;
            this.txtCurrentView.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentView.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCurrentView.Location = new System.Drawing.Point(53, 10);
            this.txtCurrentView.Name = "txtCurrentView";
            this.txtCurrentView.Size = new System.Drawing.Size(31, 30);
            this.txtCurrentView.TabIndex = 11;
            this.txtCurrentView.Text = "...";
            // 
            // MainViewNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpFooter);
            this.Controls.Add(this.tlpHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainViewNew";
            this.Text = "MainViewNew";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlpFooter.ResumeLayout(false);
            this.tlpHeader.ResumeLayout(false);
            this.tlpHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnHome;
        private System.Windows.Forms.TableLayoutPanel tlpFooter;
        private Guna.UI2.WinForms.Guna2Button btnPrev;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private System.Windows.Forms.TableLayoutPanel tlpHeader;
        private System.Windows.Forms.Label txtUserName;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.Label txtCurrentView;
    }
}