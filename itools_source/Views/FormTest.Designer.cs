namespace itools_source.Views
{
    partial class FormTest
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tlpTooList = new System.Windows.Forms.TableLayoutPanel();
            this.pToolFooter = new System.Windows.Forms.Panel();
            this.btnToolCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnToolSelect = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnToolSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pToolContent = new System.Windows.Forms.Panel();
            this.guna2VScrollBar2 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.flpListTool = new System.Windows.Forms.FlowLayoutPanel();
            this.tlpTooList.SuspendLayout();
            this.pToolFooter.SuspendLayout();
            this.pToolContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 20;
            // 
            // tlpTooList
            // 
            this.tlpTooList.AutoScroll = true;
            this.tlpTooList.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tlpTooList.ColumnCount = 1;
            this.tlpTooList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTooList.Controls.Add(this.pToolFooter, 0, 2);
            this.tlpTooList.Controls.Add(this.btnToolSearch, 0, 0);
            this.tlpTooList.Controls.Add(this.pToolContent, 0, 1);
            this.tlpTooList.Location = new System.Drawing.Point(661, 133);
            this.tlpTooList.Name = "tlpTooList";
            this.tlpTooList.RowCount = 3;
            this.tlpTooList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpTooList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76F));
            this.tlpTooList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpTooList.Size = new System.Drawing.Size(320, 350);
            this.tlpTooList.TabIndex = 28;
            // 
            // pToolFooter
            // 
            this.pToolFooter.Controls.Add(this.btnToolCancel);
            this.pToolFooter.Controls.Add(this.btnToolSelect);
            this.pToolFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pToolFooter.Location = new System.Drawing.Point(3, 311);
            this.pToolFooter.Name = "pToolFooter";
            this.pToolFooter.Size = new System.Drawing.Size(314, 36);
            this.pToolFooter.TabIndex = 29;
            // 
            // btnToolCancel
            // 
            this.btnToolCancel.Animated = true;
            this.btnToolCancel.AutoRoundedCorners = true;
            this.btnToolCancel.BorderRadius = 17;
            this.btnToolCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnToolCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnToolCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnToolCancel.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnToolCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnToolCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnToolCancel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.btnToolCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToolCancel.ForeColor = System.Drawing.Color.White;
            this.btnToolCancel.Location = new System.Drawing.Point(170, 0);
            this.btnToolCancel.Name = "btnToolCancel";
            this.btnToolCancel.Size = new System.Drawing.Size(144, 36);
            this.btnToolCancel.TabIndex = 28;
            this.btnToolCancel.Text = "Hủy";
            // 
            // btnToolSelect
            // 
            this.btnToolSelect.Animated = true;
            this.btnToolSelect.AutoRoundedCorners = true;
            this.btnToolSelect.BorderRadius = 17;
            this.btnToolSelect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnToolSelect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnToolSelect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnToolSelect.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnToolSelect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnToolSelect.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnToolSelect.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.btnToolSelect.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToolSelect.ForeColor = System.Drawing.Color.White;
            this.btnToolSelect.Location = new System.Drawing.Point(0, 0);
            this.btnToolSelect.Name = "btnToolSelect";
            this.btnToolSelect.Size = new System.Drawing.Size(144, 36);
            this.btnToolSelect.TabIndex = 7;
            this.btnToolSelect.Text = "Chọn";
            // 
            // btnToolSearch
            // 
            this.btnToolSearch.BorderRadius = 8;
            this.btnToolSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnToolSearch.DefaultText = "";
            this.btnToolSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnToolSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnToolSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btnToolSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btnToolSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnToolSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnToolSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToolSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnToolSearch.Location = new System.Drawing.Point(3, 4);
            this.btnToolSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnToolSearch.Name = "btnToolSearch";
            this.btnToolSearch.PasswordChar = '\0';
            this.btnToolSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.btnToolSearch.PlaceholderText = "Tìm Kiếm";
            this.btnToolSearch.SelectedText = "";
            this.btnToolSearch.Size = new System.Drawing.Size(314, 34);
            this.btnToolSearch.TabIndex = 28;
            this.btnToolSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pToolContent
            // 
            this.pToolContent.Controls.Add(this.guna2VScrollBar2);
            this.pToolContent.Controls.Add(this.flpListTool);
            this.pToolContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pToolContent.Location = new System.Drawing.Point(3, 45);
            this.pToolContent.Name = "pToolContent";
            this.pToolContent.Size = new System.Drawing.Size(314, 260);
            this.pToolContent.TabIndex = 29;
            // 
            // guna2VScrollBar2
            // 
            this.guna2VScrollBar2.AutoRoundedCorners = true;
            this.guna2VScrollBar2.AutoSize = true;
            this.guna2VScrollBar2.BindingContainer = this.flpListTool;
            this.guna2VScrollBar2.BorderRadius = 8;
            this.guna2VScrollBar2.InUpdate = false;
            this.guna2VScrollBar2.LargeChange = 10;
            this.guna2VScrollBar2.Location = new System.Drawing.Point(296, 0);
            this.guna2VScrollBar2.Name = "guna2VScrollBar2";
            this.guna2VScrollBar2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.guna2VScrollBar2.ScrollbarSize = 18;
            this.guna2VScrollBar2.Size = new System.Drawing.Size(18, 260);
            this.guna2VScrollBar2.TabIndex = 28;
            this.guna2VScrollBar2.ThumbSize = 100F;
            // 
            // flpListTool
            // 
            this.flpListTool.AutoScroll = true;
            this.flpListTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.flpListTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpListTool.Location = new System.Drawing.Point(0, 0);
            this.flpListTool.Margin = new System.Windows.Forms.Padding(2);
            this.flpListTool.Name = "flpListTool";
            this.flpListTool.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flpListTool.Size = new System.Drawing.Size(314, 260);
            this.flpListTool.TabIndex = 29;
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1018, 639);
            this.Controls.Add(this.tlpTooList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormTest";
            this.Load += new System.EventHandler(this.FormTest_Load);
            this.tlpTooList.ResumeLayout(false);
            this.pToolFooter.ResumeLayout(false);
            this.pToolContent.ResumeLayout(false);
            this.pToolContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.TableLayoutPanel tlpTooList;
        private System.Windows.Forms.Panel pToolFooter;
        private Guna.UI2.WinForms.Guna2GradientButton btnToolCancel;
        private Guna.UI2.WinForms.Guna2GradientButton btnToolSelect;
        private Guna.UI2.WinForms.Guna2TextBox btnToolSearch;
        private System.Windows.Forms.Panel pToolContent;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar2;
        private System.Windows.Forms.FlowLayoutPanel flpListTool;
    }
}