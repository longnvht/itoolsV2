namespace VinamiToolUser.Views
{
    partial class JobView
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
            this.tblSearch = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.grbJob = new System.Windows.Forms.GroupBox();
            this.lstJob = new VinamiToolUser.Views.Components.ListButton();
            this.tblSearch.SuspendLayout();
            this.grbJob.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblSearch
            // 
            this.tblSearch.ColumnCount = 2;
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblSearch.Controls.Add(this.txtSearch, 0, 0);
            this.tblSearch.Controls.Add(this.btnSearch, 1, 0);
            this.tblSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblSearch.Location = new System.Drawing.Point(0, 0);
            this.tblSearch.Name = "tblSearch";
            this.tblSearch.RowCount = 1;
            this.tblSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSearch.Size = new System.Drawing.Size(713, 60);
            this.tblSearch.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtSearch.BorderRadius = 8;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(3, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(607, 50);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearch.BorderRadius = 8;
            this.btnSearch.BorderThickness = 1;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Navy;
            this.btnSearch.Location = new System.Drawing.Point(616, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 50);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            // 
            // grbJob
            // 
            this.grbJob.Controls.Add(this.lstJob);
            this.grbJob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbJob.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbJob.Location = new System.Drawing.Point(0, 60);
            this.grbJob.Name = "grbJob";
            this.grbJob.Size = new System.Drawing.Size(713, 365);
            this.grbJob.TabIndex = 2;
            this.grbJob.TabStop = false;
            this.grbJob.Text = "Job List";
            // 
            // lstJob
            // 
            this.lstJob.AutoSpacing = true;
            this.lstJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(220)))), ((int)(((byte)(245)))));
            this.lstJob.DataSource = null;
            this.lstJob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstJob.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lstJob.ItemBorderRadius = 6;
            this.lstJob.ItemBorderThickness = 1;
            this.lstJob.ItemBottomDisplayMember = "";
            this.lstJob.ItemFillColor = System.Drawing.Color.WhiteSmoke;
            this.lstJob.ItemFont = new System.Drawing.Font("Segoe UI", 10F);
            this.lstJob.ItemForceColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.lstJob.ItemHeight = 100;
            this.lstJob.ItemSpace = 6;
            this.lstJob.ItemTopDisplayMember = "JobNumber";
            this.lstJob.ItemWidth = 100;
            this.lstJob.Location = new System.Drawing.Point(3, 21);
            this.lstJob.Margin = new System.Windows.Forms.Padding(4);
            this.lstJob.MinMargin = 5;
            this.lstJob.Name = "lstJob";
            this.lstJob.Size = new System.Drawing.Size(707, 341);
            this.lstJob.TabIndex = 1;
            // 
            // JobView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 425);
            this.Controls.Add(this.grbJob);
            this.Controls.Add(this.tblSearch);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "JobView";
            this.Text = "JobViewNew";
            this.tblSearch.ResumeLayout(false);
            this.grbJob.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private VinamiToolUser.Views.Components.ListButton lstJob;
        private System.Windows.Forms.GroupBox grbJob;
    }
}