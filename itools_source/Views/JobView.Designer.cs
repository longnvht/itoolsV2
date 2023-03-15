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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobView));
            this._flpJobNumberList = new System.Windows.Forms.FlowLayoutPanel();
            this._tlpJobHeader = new System.Windows.Forms.TableLayoutPanel();
            this._txtJobNumberSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this._btnJobNumberSearch = new Guna.UI2.WinForms.Guna2GradientButton();
            this._guna2VScrollBar_flpJobNumberList = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.guna2Elipse_flpJobNumberList = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this._tlpJobHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // _flpJobNumberList
            // 
            this._flpJobNumberList.AutoScroll = true;
            this._flpJobNumberList.AutoSize = true;
            this._flpJobNumberList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(214)))), ((int)(((byte)(226)))));
            this._flpJobNumberList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flpJobNumberList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._flpJobNumberList.Location = new System.Drawing.Point(0, 43);
            this._flpJobNumberList.Margin = new System.Windows.Forms.Padding(2);
            this._flpJobNumberList.Name = "_flpJobNumberList";
            this._flpJobNumberList.Padding = new System.Windows.Forms.Padding(10);
            this._flpJobNumberList.Size = new System.Drawing.Size(800, 407);
            this._flpJobNumberList.TabIndex = 2;
            // 
            // _tlpJobHeader
            // 
            this._tlpJobHeader.ColumnCount = 2;
            this._tlpJobHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tlpJobHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this._tlpJobHeader.Controls.Add(this._txtJobNumberSearch, 0, 0);
            this._tlpJobHeader.Controls.Add(this._btnJobNumberSearch, 1, 0);
            this._tlpJobHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this._tlpJobHeader.Location = new System.Drawing.Point(0, 0);
            this._tlpJobHeader.Name = "_tlpJobHeader";
            this._tlpJobHeader.RowCount = 1;
            this._tlpJobHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tlpJobHeader.Size = new System.Drawing.Size(800, 43);
            this._tlpJobHeader.TabIndex = 7;
            // 
            // _txtJobNumberSearch
            // 
            this._txtJobNumberSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._txtJobNumberSearch.BorderRadius = 10;
            this._txtJobNumberSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtJobNumberSearch.DefaultText = "";
            this._txtJobNumberSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this._txtJobNumberSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this._txtJobNumberSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtJobNumberSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtJobNumberSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtJobNumberSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this._txtJobNumberSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtJobNumberSearch.Location = new System.Drawing.Point(3, 4);
            this._txtJobNumberSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtJobNumberSearch.Name = "_txtJobNumberSearch";
            this._txtJobNumberSearch.PasswordChar = '\0';
            this._txtJobNumberSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this._txtJobNumberSearch.PlaceholderText = "Tìm Kiếm Job Number";
            this._txtJobNumberSearch.SelectedText = "";
            this._txtJobNumberSearch.Size = new System.Drawing.Size(674, 35);
            this._txtJobNumberSearch.TabIndex = 0;
            this._txtJobNumberSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _btnJobNumberSearch
            // 
            this._btnJobNumberSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._btnJobNumberSearch.BorderRadius = 10;
            this._btnJobNumberSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this._btnJobNumberSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this._btnJobNumberSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this._btnJobNumberSearch.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this._btnJobNumberSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this._btnJobNumberSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
            this._btnJobNumberSearch.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
            this._btnJobNumberSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this._btnJobNumberSearch.ForeColor = System.Drawing.Color.White;
            this._btnJobNumberSearch.Location = new System.Drawing.Point(683, 3);
            this._btnJobNumberSearch.Name = "_btnJobNumberSearch";
            this._btnJobNumberSearch.Size = new System.Drawing.Size(114, 36);
            this._btnJobNumberSearch.TabIndex = 1;
            this._btnJobNumberSearch.Text = "Tìm Kiếm";
            // 
            // _guna2VScrollBar_flpJobNumberList
            // 
            this._guna2VScrollBar_flpJobNumberList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._guna2VScrollBar_flpJobNumberList.AutoScroll = true;
            this._guna2VScrollBar_flpJobNumberList.AutoSize = true;
            this._guna2VScrollBar_flpJobNumberList.BindingContainer = this._flpJobNumberList;
            this._guna2VScrollBar_flpJobNumberList.BorderRadius = 10;
            this._guna2VScrollBar_flpJobNumberList.InUpdate = false;
            this._guna2VScrollBar_flpJobNumberList.LargeChange = 10;
            this._guna2VScrollBar_flpJobNumberList.Location = new System.Drawing.Point(782, 43);
            this._guna2VScrollBar_flpJobNumberList.Name = "_guna2VScrollBar_flpJobNumberList";
            this._guna2VScrollBar_flpJobNumberList.ScrollbarSize = 18;
            this._guna2VScrollBar_flpJobNumberList.Size = new System.Drawing.Size(18, 407);
            this._guna2VScrollBar_flpJobNumberList.TabIndex = 0;
            this._guna2VScrollBar_flpJobNumberList.ThumbSize = 100F;
            // 
            // guna2Elipse_flpJobNumberList
            // 
            this.guna2Elipse_flpJobNumberList.BorderRadius = 20;
            this.guna2Elipse_flpJobNumberList.TargetControl = this._flpJobNumberList;
            // 
            // JobView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._guna2VScrollBar_flpJobNumberList);
            this.Controls.Add(this._flpJobNumberList);
            this.Controls.Add(this._tlpJobHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JobView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JobView";
            this._tlpJobHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel _flpJobNumberList;

        public System.Windows.Forms.FlowLayoutPanel flpJobNumberList
        {
            get { return _flpJobNumberList; }
            set { _flpJobNumberList = value; }
        }

        private System.Windows.Forms.TableLayoutPanel _tlpJobHeader;

        public System.Windows.Forms.TableLayoutPanel tlpJobHeader
        {
            get { return _tlpJobHeader; }
            set { _tlpJobHeader = value; }
        }


        private Guna.UI2.WinForms.Guna2GradientButton _btnJobNumberSearch;

        public Guna.UI2.WinForms.Guna2GradientButton btnJobNumberSearch
        {
            get { return _btnJobNumberSearch; }
            set { _btnJobNumberSearch = value; }
        }

        private Guna.UI2.WinForms.Guna2TextBox _txtJobNumberSearch;

        public Guna.UI2.WinForms.Guna2TextBox txtJobNumberSearch
        {
            get { return _txtJobNumberSearch; }
            set { _txtJobNumberSearch = value; }
        }

        private Guna.UI2.WinForms.Guna2VScrollBar _guna2VScrollBar_flpJobNumberList;

        public Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar_flpJobNumberList
        {
            get { return _guna2VScrollBar_flpJobNumberList; }
            set { _guna2VScrollBar_flpJobNumberList = value; }
        }

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_flpJobNumberList;
    }
}