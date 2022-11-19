namespace itools_source.Views
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobView));
            this.flpJobNumberList = new System.Windows.Forms.FlowLayoutPanel();
            this.tlpJobHeader = new System.Windows.Forms.TableLayoutPanel();
            this.btnJobNumberSearch = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtJobNumberSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.tlpJobHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpJobNumberList
            // 
            this.flpJobNumberList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flpJobNumberList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpJobNumberList.Location = new System.Drawing.Point(0, 43);
            this.flpJobNumberList.Margin = new System.Windows.Forms.Padding(2);
            this.flpJobNumberList.Name = "flpJobNumberList";
            this.flpJobNumberList.Size = new System.Drawing.Size(800, 407);
            this.flpJobNumberList.TabIndex = 5;
            // 
            // tlpJobHeader
            // 
            this.tlpJobHeader.ColumnCount = 3;
            this.tlpJobHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpJobHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tlpJobHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpJobHeader.Controls.Add(this.txtJobNumberSearch, 0, 0);
            this.tlpJobHeader.Controls.Add(this.btnJobNumberSearch, 2, 0);
            this.tlpJobHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpJobHeader.Location = new System.Drawing.Point(0, 0);
            this.tlpJobHeader.Name = "tlpJobHeader";
            this.tlpJobHeader.RowCount = 1;
            this.tlpJobHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpJobHeader.Size = new System.Drawing.Size(800, 43);
            this.tlpJobHeader.TabIndex = 7;
            // 
            // btnJobNumberSearch
            // 
            this.btnJobNumberSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJobNumberSearch.Animated = true;
            this.btnJobNumberSearch.AutoRoundedCorners = true;
            this.btnJobNumberSearch.BorderRadius = 17;
            this.btnJobNumberSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnJobNumberSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnJobNumberSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnJobNumberSearch.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnJobNumberSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnJobNumberSearch.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.btnJobNumberSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobNumberSearch.ForeColor = System.Drawing.Color.White;
            this.btnJobNumberSearch.Location = new System.Drawing.Point(528, 3);
            this.btnJobNumberSearch.Name = "btnJobNumberSearch";
            this.btnJobNumberSearch.Size = new System.Drawing.Size(269, 36);
            this.btnJobNumberSearch.TabIndex = 3;
            this.btnJobNumberSearch.Text = "Tìm Kiếm";
            // 
            // txtJobNumberSearch
            // 
            this.txtJobNumberSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJobNumberSearch.BorderRadius = 8;
            this.txtJobNumberSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJobNumberSearch.DefaultText = "";
            this.txtJobNumberSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtJobNumberSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtJobNumberSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJobNumberSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJobNumberSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJobNumberSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobNumberSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJobNumberSearch.Location = new System.Drawing.Point(3, 4);
            this.txtJobNumberSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtJobNumberSearch.Name = "txtJobNumberSearch";
            this.txtJobNumberSearch.PasswordChar = '\0';
            this.txtJobNumberSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.txtJobNumberSearch.PlaceholderText = "Tìm Kiếm";
            this.txtJobNumberSearch.SelectedText = "";
            this.txtJobNumberSearch.Size = new System.Drawing.Size(269, 35);
            this.txtJobNumberSearch.TabIndex = 4;
            this.txtJobNumberSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // JobView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flpJobNumberList);
            this.Controls.Add(this.tlpJobHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JobView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JobView";
            this.tlpJobHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpJobNumberList;
        private System.Windows.Forms.TableLayoutPanel tlpJobHeader;
        private Guna.UI2.WinForms.Guna2GradientButton btnJobNumberSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtJobNumberSearch;
    }
}