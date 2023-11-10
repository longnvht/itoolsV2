namespace VinamiToolUser.Views
{
    partial class MainView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.tlpFooter = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrev = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.txtUserName = new System.Windows.Forms.Label();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.txtStatus = new System.Windows.Forms.Label();
            this.txtCurrentView = new System.Windows.Forms.Label();
            this.tsInfo = new System.Windows.Forms.ToolStrip();
            this.tslMessage = new System.Windows.Forms.ToolStripLabel();
            this.tmLogin = new System.Windows.Forms.Timer(this.components);
            this.tmSync = new System.Windows.Forms.Timer(this.components);
            this.tlpFooter.SuspendLayout();
            this.tlpHeader.SuspendLayout();
            this.tsInfo.SuspendLayout();
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
            this.tlpFooter.Location = new System.Drawing.Point(0, 355);
            this.tlpFooter.Margin = new System.Windows.Forms.Padding(4);
            this.tlpFooter.Name = "tlpFooter";
            this.tlpFooter.RowCount = 1;
            this.tlpFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFooter.Size = new System.Drawing.Size(800, 70);
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
            this.btnPrev.Size = new System.Drawing.Size(142, 60);
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
            this.btnNext.Size = new System.Drawing.Size(142, 60);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Tiếp Theo";
            // 
            // tlpHeader
            // 
            this.tlpHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(96)))));
            this.tlpHeader.ColumnCount = 5;
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tlpHeader.Controls.Add(this.btnHome, 0, 0);
            this.tlpHeader.Controls.Add(this.txtUserName, 3, 0);
            this.tlpHeader.Controls.Add(this.btnLogOut, 4, 0);
            this.tlpHeader.Controls.Add(this.txtStatus, 2, 0);
            this.tlpHeader.Controls.Add(this.txtCurrentView, 1, 0);
            this.tlpHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpHeader.Location = new System.Drawing.Point(0, 0);
            this.tlpHeader.Margin = new System.Windows.Forms.Padding(4);
            this.tlpHeader.Name = "tlpHeader";
            this.tlpHeader.RowCount = 1;
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.Size = new System.Drawing.Size(800, 60);
            this.tlpHeader.TabIndex = 6;
            // 
            // btnHome
            // 
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.FillColor = System.Drawing.Color.Transparent;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.Image = global::VinamiToolUser.Properties.Resources.home_500px;
            this.btnHome.Image = global::VinamiToolUser.Properties.Resources.home_512px;
            this.btnHome.ImageSize = new System.Drawing.Size(30, 30);
            this.btnHome.Location = new System.Drawing.Point(3, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(54, 54);
            this.btnHome.TabIndex = 0;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtUserName.AutoSize = true;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtUserName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtUserName.Location = new System.Drawing.Point(683, 20);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(49, 20);
            this.txtUserName.TabIndex = 9;
            this.txtUserName.Text = "Name";
            this.txtUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogOut.FillColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.HoverState.Image = global::VinamiToolUser.Properties.Resources.Logout_Rounded_48pxr;
            this.btnLogOut.Image = global::VinamiToolUser.Properties.Resources.Logout_Rounded_48px;
            this.btnLogOut.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLogOut.Location = new System.Drawing.Point(738, 3);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(59, 54);
            this.btnLogOut.TabIndex = 6;
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtStatus.AutoSize = true;
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtStatus.Location = new System.Drawing.Point(213, 19);
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
            this.txtCurrentView.Location = new System.Drawing.Point(63, 15);
            this.txtCurrentView.Name = "txtCurrentView";
            this.txtCurrentView.Size = new System.Drawing.Size(31, 30);
            this.txtCurrentView.TabIndex = 11;
            this.txtCurrentView.Text = "...";
            // 
            // tsInfo
            // 
            this.tsInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(96)))));
            this.tsInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslMessage});
            this.tsInfo.Location = new System.Drawing.Point(0, 425);
            this.tsInfo.Name = "tsInfo";
            this.tsInfo.Size = new System.Drawing.Size(800, 25);
            this.tsInfo.TabIndex = 8;
            this.tsInfo.Text = "toolStrip1";
            // 
            // tslMessage
            // 
            this.tslMessage.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tslMessage.Name = "tslMessage";
            this.tslMessage.Size = new System.Drawing.Size(65, 22);
            this.tslMessage.Text = "tslMessage";
            // 
            // tmLogin
            // 
            this.tmLogin.Interval = 5000;
            // 
            // tmSync
            // 
            this.tmSync.Interval = 30000;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpFooter);
            this.Controls.Add(this.tlpHeader);
            this.Controls.Add(this.tsInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainView";
            this.Text = "MainViewNew";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlpFooter.ResumeLayout(false);
            this.tlpHeader.ResumeLayout(false);
            this.tlpHeader.PerformLayout();
            this.tsInfo.ResumeLayout(false);
            this.tsInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnHome;
        private System.Windows.Forms.TableLayoutPanel tlpFooter;
        private Guna.UI2.WinForms.Guna2Button btnPrev;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private System.Windows.Forms.TableLayoutPanel tlpHeader;
        private System.Windows.Forms.Label txtUserName;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.Label txtCurrentView;
        private System.Windows.Forms.ToolStrip tsInfo;
        private System.Windows.Forms.ToolStripLabel tslMessage;
        private System.Windows.Forms.Timer tmLogin;
        private System.Windows.Forms.Timer tmSync;
    }
}