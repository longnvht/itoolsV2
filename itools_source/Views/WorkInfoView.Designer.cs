namespace VinamiToolUser.Views
{
    partial class WorkInfoView
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
            this.tblWorkInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblWorkCode = new System.Windows.Forms.Label();
            this.lblWorkMachineCode = new System.Windows.Forms.Label();
            this.txtWorkCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtWorkMachineCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.grbWorkInfo = new System.Windows.Forms.GroupBox();
            this.tblWorkInfo.SuspendLayout();
            this.grbWorkInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblWorkInfo
            // 
            this.tblWorkInfo.ColumnCount = 5;
            this.tblWorkInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblWorkInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tblWorkInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tblWorkInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tblWorkInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblWorkInfo.Controls.Add(this.lblWorkCode, 1, 1);
            this.tblWorkInfo.Controls.Add(this.lblWorkMachineCode, 1, 2);
            this.tblWorkInfo.Controls.Add(this.txtWorkCode, 2, 1);
            this.tblWorkInfo.Controls.Add(this.txtWorkMachineCode, 2, 2);
            this.tblWorkInfo.Controls.Add(this.btnEdit, 2, 3);
            this.tblWorkInfo.Controls.Add(this.btnConfirm, 3, 3);
            this.tblWorkInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblWorkInfo.Location = new System.Drawing.Point(3, 21);
            this.tblWorkInfo.Name = "tblWorkInfo";
            this.tblWorkInfo.RowCount = 4;
            this.tblWorkInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblWorkInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblWorkInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblWorkInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblWorkInfo.Size = new System.Drawing.Size(794, 426);
            this.tblWorkInfo.TabIndex = 0;
            // 
            // lblWorkCode
            // 
            this.lblWorkCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblWorkCode.AutoSize = true;
            this.lblWorkCode.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkCode.Location = new System.Drawing.Point(140, 141);
            this.lblWorkCode.Name = "lblWorkCode";
            this.lblWorkCode.Size = new System.Drawing.Size(118, 21);
            this.lblWorkCode.TabIndex = 0;
            this.lblWorkCode.Text = "Mã Công Đoạn";
            // 
            // lblWorkMachineCode
            // 
            this.lblWorkMachineCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblWorkMachineCode.AutoSize = true;
            this.lblWorkMachineCode.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkMachineCode.Location = new System.Drawing.Point(140, 201);
            this.lblWorkMachineCode.Name = "lblWorkMachineCode";
            this.lblWorkMachineCode.Size = new System.Drawing.Size(68, 21);
            this.lblWorkMachineCode.TabIndex = 0;
            this.lblWorkMachineCode.Text = "Mã Máy";
            // 
            // txtWorkCode
            // 
            this.txtWorkCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWorkCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(207)))), ((int)(((byte)(242)))));
            this.txtWorkCode.BorderRadius = 8;
            this.tblWorkInfo.SetColumnSpan(this.txtWorkCode, 2);
            this.txtWorkCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWorkCode.DefaultText = "";
            this.txtWorkCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtWorkCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtWorkCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWorkCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWorkCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWorkCode.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWorkCode.Location = new System.Drawing.Point(290, 134);
            this.txtWorkCode.Name = "txtWorkCode";
            this.txtWorkCode.PasswordChar = '\0';
            this.txtWorkCode.PlaceholderText = "";
            this.txtWorkCode.SelectedText = "";
            this.txtWorkCode.Size = new System.Drawing.Size(294, 36);
            this.txtWorkCode.TabIndex = 1;
            // 
            // txtWorkMachineCode
            // 
            this.txtWorkMachineCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWorkMachineCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(207)))), ((int)(((byte)(242)))));
            this.txtWorkMachineCode.BorderRadius = 8;
            this.tblWorkInfo.SetColumnSpan(this.txtWorkMachineCode, 2);
            this.txtWorkMachineCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWorkMachineCode.DefaultText = "";
            this.txtWorkMachineCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtWorkMachineCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtWorkMachineCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWorkMachineCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWorkMachineCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWorkMachineCode.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkMachineCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWorkMachineCode.Location = new System.Drawing.Point(290, 194);
            this.txtWorkMachineCode.Name = "txtWorkMachineCode";
            this.txtWorkMachineCode.PasswordChar = '\0';
            this.txtWorkMachineCode.PlaceholderText = "";
            this.txtWorkMachineCode.SelectedText = "";
            this.txtWorkMachineCode.Size = new System.Drawing.Size(294, 36);
            this.txtWorkMachineCode.TabIndex = 2;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEdit.BorderColor = System.Drawing.Color.Navy;
            this.btnEdit.BorderRadius = 6;
            this.btnEdit.BorderThickness = 1;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Navy;
            this.btnEdit.Image = global::VinamiToolUser.Properties.Resources.edit_text_file_100px;
            this.btnEdit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEdit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEdit.Location = new System.Drawing.Point(290, 245);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(144, 45);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Thay đổi";
            this.btnEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConfirm.BorderColor = System.Drawing.Color.Navy;
            this.btnConfirm.BorderRadius = 6;
            this.btnConfirm.BorderThickness = 1;
            this.btnConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirm.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Navy;
            this.btnConfirm.Image = global::VinamiToolUser.Properties.Resources.check_document_64px;
            this.btnConfirm.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnConfirm.ImageSize = new System.Drawing.Size(30, 30);
            this.btnConfirm.Location = new System.Drawing.Point(440, 245);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(144, 45);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // grbWorkInfo
            // 
            this.grbWorkInfo.Controls.Add(this.tblWorkInfo);
            this.grbWorkInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbWorkInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbWorkInfo.Location = new System.Drawing.Point(0, 0);
            this.grbWorkInfo.Name = "grbWorkInfo";
            this.grbWorkInfo.Size = new System.Drawing.Size(800, 450);
            this.grbWorkInfo.TabIndex = 1;
            this.grbWorkInfo.TabStop = false;
            this.grbWorkInfo.Text = "Thông tin công việc";
            // 
            // WorkInfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbWorkInfo);
            this.Name = "WorkInfoView";
            this.Text = "InputWorkView";
            this.tblWorkInfo.ResumeLayout(false);
            this.tblWorkInfo.PerformLayout();
            this.grbWorkInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblWorkInfo;
        private System.Windows.Forms.GroupBox grbWorkInfo;
        private System.Windows.Forms.Label lblWorkCode;
        private System.Windows.Forms.Label lblWorkMachineCode;
        private Guna.UI2.WinForms.Guna2TextBox txtWorkCode;
        private Guna.UI2.WinForms.Guna2TextBox txtWorkMachineCode;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
    }
}