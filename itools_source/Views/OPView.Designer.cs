namespace itools_source.Views
{
    partial class OPView
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
            this._flpOPList = new System.Windows.Forms.FlowLayoutPanel();
            this._tlpJobHeader = new System.Windows.Forms.TableLayoutPanel();
            this._txtOPSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this._btnOPNumberSearch = new Guna.UI2.WinForms.Guna2GradientButton();
            this._guna2VScrollBar_flpJobNumberList = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.guna2Elipse_flpOPList = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this._tlpJobHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // _flpOPList
            // 
            this._flpOPList.AutoScroll = true;
            this._flpOPList.AutoSize = true;
            this._flpOPList.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this._flpOPList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flpOPList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._flpOPList.Location = new System.Drawing.Point(0, 43);
            this._flpOPList.Margin = new System.Windows.Forms.Padding(2);
            this._flpOPList.Name = "_flpOPList";
            this._flpOPList.Size = new System.Drawing.Size(800, 407);
            this._flpOPList.TabIndex = 9;
            // 
            // _tlpJobHeader
            // 
            this._tlpJobHeader.ColumnCount = 2;
            this._tlpJobHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tlpJobHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this._tlpJobHeader.Controls.Add(this._txtOPSearch, 0, 0);
            this._tlpJobHeader.Controls.Add(this._btnOPNumberSearch, 1, 0);
            this._tlpJobHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this._tlpJobHeader.Location = new System.Drawing.Point(0, 0);
            this._tlpJobHeader.Name = "_tlpJobHeader";
            this._tlpJobHeader.RowCount = 1;
            this._tlpJobHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tlpJobHeader.Size = new System.Drawing.Size(800, 43);
            this._tlpJobHeader.TabIndex = 10;
            // 
            // _txtOPSearch
            // 
            this._txtOPSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._txtOPSearch.BorderRadius = 8;
            this._txtOPSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtOPSearch.DefaultText = "";
            this._txtOPSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this._txtOPSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this._txtOPSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtOPSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtOPSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtOPSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtOPSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtOPSearch.Location = new System.Drawing.Point(3, 4);
            this._txtOPSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtOPSearch.Name = "_txtOPSearch";
            this._txtOPSearch.PasswordChar = '\0';
            this._txtOPSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this._txtOPSearch.PlaceholderText = "Tìm Kiếm";
            this._txtOPSearch.SelectedText = "";
            this._txtOPSearch.Size = new System.Drawing.Size(674, 35);
            this._txtOPSearch.TabIndex = 0;
            this._txtOPSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _btnOPNumberSearch
            // 
            this._btnOPNumberSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._btnOPNumberSearch.Animated = true;
            this._btnOPNumberSearch.AutoRoundedCorners = true;
            this._btnOPNumberSearch.BorderRadius = 17;
            this._btnOPNumberSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this._btnOPNumberSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this._btnOPNumberSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this._btnOPNumberSearch.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this._btnOPNumberSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this._btnOPNumberSearch.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this._btnOPNumberSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this._btnOPNumberSearch.ForeColor = System.Drawing.Color.White;
            this._btnOPNumberSearch.Location = new System.Drawing.Point(683, 3);
            this._btnOPNumberSearch.Name = "_btnOPNumberSearch";
            this._btnOPNumberSearch.Size = new System.Drawing.Size(114, 36);
            this._btnOPNumberSearch.TabIndex = 1;
            this._btnOPNumberSearch.Text = "Tìm Kiếm";
            // 
            // _guna2VScrollBar_flpJobNumberList
            // 
            this._guna2VScrollBar_flpJobNumberList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._guna2VScrollBar_flpJobNumberList.AutoScroll = true;
            this._guna2VScrollBar_flpJobNumberList.AutoSize = true;
            this._guna2VScrollBar_flpJobNumberList.BindingContainer = this._flpOPList;
            this._guna2VScrollBar_flpJobNumberList.InUpdate = false;
            this._guna2VScrollBar_flpJobNumberList.LargeChange = 10;
            this._guna2VScrollBar_flpJobNumberList.Location = new System.Drawing.Point(782, 43);
            this._guna2VScrollBar_flpJobNumberList.Name = "_guna2VScrollBar_flpJobNumberList";
            this._guna2VScrollBar_flpJobNumberList.ScrollbarSize = 18;
            this._guna2VScrollBar_flpJobNumberList.Size = new System.Drawing.Size(18, 407);
            this._guna2VScrollBar_flpJobNumberList.TabIndex = 8;
            this._guna2VScrollBar_flpJobNumberList.ThumbSize = 100F;
            // 
            // guna2Elipse_flpOPList
            // 
            this.guna2Elipse_flpOPList.BorderRadius = 20;
            this.guna2Elipse_flpOPList.TargetControl = this._flpOPList;
            // 
            // OPView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._guna2VScrollBar_flpJobNumberList);
            this.Controls.Add(this._flpOPList);
            this.Controls.Add(this._tlpJobHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OPView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OPView";
            this._tlpJobHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel _flpOPList;
        private System.Windows.Forms.TableLayoutPanel _tlpJobHeader;
        private Guna.UI2.WinForms.Guna2TextBox _txtOPSearch;
        private Guna.UI2.WinForms.Guna2GradientButton _btnOPNumberSearch;
        private Guna.UI2.WinForms.Guna2VScrollBar _guna2VScrollBar_flpJobNumberList;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_flpOPList;
    }
}