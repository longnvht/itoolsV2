namespace itools_source.Views
{
    partial class SettingView
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.cbxComPort = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbxMachine = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbxCompany = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblMachine = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblSerialMachine = new System.Windows.Forms.Label();
            this.lblCOM = new System.Windows.Forms.Label();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.txtHardDiskSerial = new Guna.UI2.WinForms.Guna2TextBox();
            this.tlpFooter = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.grbSetting = new System.Windows.Forms.GroupBox();
            this.tlpMain.SuspendLayout();
            this.tlpFooter.SuspendLayout();
            this.grbSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.tlpMain.ColumnCount = 4;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.lblCompany, 0, 1);
            this.tlpMain.Controls.Add(this.lblMachine, 0, 2);
            this.tlpMain.Controls.Add(this.lblCOM, 0, 3);
            this.tlpMain.Controls.Add(this.lblSerialMachine, 0, 4);
            this.tlpMain.Controls.Add(this.cbxCompany, 1, 1);
            this.tlpMain.Controls.Add(this.cbxMachine, 1, 2);
            this.tlpMain.Controls.Add(this.txtHardDiskSerial, 1, 3);
            this.tlpMain.Controls.Add(this.cbxComPort, 1, 4);
            this.tlpMain.Controls.Add(this.btnEdit, 1, 5);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(3, 23);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 7;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Size = new System.Drawing.Size(794, 378);
            this.tlpMain.TabIndex = 0;
            // 
            // cbxComPort
            // 
            this.cbxComPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxComPort.BackColor = System.Drawing.Color.Transparent;
            this.cbxComPort.BorderRadius = 8;
            this.cbxComPort.BorderThickness = 0;
            this.cbxComPort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxComPort.DropDownHeight = 200;
            this.cbxComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxComPort.DropDownWidth = 240;
            this.cbxComPort.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxComPort.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxComPort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxComPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxComPort.IntegralHeight = false;
            this.cbxComPort.ItemHeight = 30;
            this.cbxComPort.Location = new System.Drawing.Point(153, 226);
            this.cbxComPort.Name = "cbxComPort";
            this.cbxComPort.ShadowDecoration.BorderRadius = 10;
            this.cbxComPort.ShadowDecoration.CustomizableEdges.BottomLeft = false;
            this.cbxComPort.ShadowDecoration.CustomizableEdges.BottomRight = false;
            this.cbxComPort.ShadowDecoration.Depth = 6;
            this.cbxComPort.ShadowDecoration.Enabled = true;
            this.cbxComPort.Size = new System.Drawing.Size(274, 36);
            this.cbxComPort.TabIndex = 5;
            this.cbxComPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxMachine
            // 
            this.cbxMachine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMachine.BackColor = System.Drawing.Color.Transparent;
            this.cbxMachine.BorderRadius = 8;
            this.cbxMachine.BorderThickness = 0;
            this.cbxMachine.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxMachine.DropDownHeight = 200;
            this.cbxMachine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMachine.DropDownWidth = 240;
            this.cbxMachine.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxMachine.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxMachine.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxMachine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxMachine.IntegralHeight = false;
            this.cbxMachine.ItemHeight = 30;
            this.cbxMachine.Location = new System.Drawing.Point(153, 126);
            this.cbxMachine.Name = "cbxMachine";
            this.cbxMachine.ShadowDecoration.BorderRadius = 10;
            this.cbxMachine.ShadowDecoration.CustomizableEdges.BottomLeft = false;
            this.cbxMachine.ShadowDecoration.CustomizableEdges.BottomRight = false;
            this.cbxMachine.ShadowDecoration.Depth = 6;
            this.cbxMachine.ShadowDecoration.Enabled = true;
            this.cbxMachine.Size = new System.Drawing.Size(274, 36);
            this.cbxMachine.TabIndex = 4;
            this.cbxMachine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxCompany
            // 
            this.cbxCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCompany.BackColor = System.Drawing.Color.Transparent;
            this.cbxCompany.BorderRadius = 8;
            this.cbxCompany.BorderThickness = 0;
            this.cbxCompany.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxCompany.DropDownHeight = 200;
            this.cbxCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCompany.DropDownWidth = 240;
            this.cbxCompany.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxCompany.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxCompany.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxCompany.IntegralHeight = false;
            this.cbxCompany.ItemHeight = 30;
            this.cbxCompany.Location = new System.Drawing.Point(153, 76);
            this.cbxCompany.Name = "cbxCompany";
            this.cbxCompany.ShadowDecoration.BorderRadius = 10;
            this.cbxCompany.ShadowDecoration.Depth = 6;
            this.cbxCompany.ShadowDecoration.Enabled = true;
            this.cbxCompany.Size = new System.Drawing.Size(274, 36);
            this.cbxCompany.TabIndex = 3;
            this.cbxCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMachine
            // 
            this.lblMachine.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMachine.AutoSize = true;
            this.lblMachine.Location = new System.Drawing.Point(3, 134);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(68, 20);
            this.lblMachine.TabIndex = 1;
            this.lblMachine.Text = "Machine";
            this.lblMachine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCompany
            // 
            this.lblCompany.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(3, 84);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(74, 20);
            this.lblCompany.TabIndex = 0;
            this.lblCompany.Text = "Company";
            this.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSerialMachine
            // 
            this.lblSerialMachine.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSerialMachine.AutoSize = true;
            this.lblSerialMachine.Location = new System.Drawing.Point(3, 234);
            this.lblSerialMachine.Name = "lblSerialMachine";
            this.lblSerialMachine.Size = new System.Drawing.Size(79, 20);
            this.lblSerialMachine.TabIndex = 2;
            this.lblSerialMachine.Text = "Serial Port";
            this.lblSerialMachine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCOM
            // 
            this.lblCOM.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCOM.AutoSize = true;
            this.lblCOM.Location = new System.Drawing.Point(3, 184);
            this.lblCOM.Name = "lblCOM";
            this.lblCOM.Size = new System.Drawing.Size(114, 20);
            this.lblCOM.TabIndex = 2;
            this.lblCOM.Text = "HardDisk Serial";
            this.lblCOM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(116)))), ((int)(((byte)(226)))));
            this.btnEdit.BorderRadius = 6;
            this.btnEdit.BorderThickness = 1;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.Navy;
            this.btnEdit.Image = global::VinamiToolUser.Properties.Resources.edit_property_48px;
            this.btnEdit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEdit.Location = new System.Drawing.Point(342, 272);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 34);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtHardDiskSerial
            // 
            this.txtHardDiskSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHardDiskSerial.BorderRadius = 8;
            this.txtHardDiskSerial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHardDiskSerial.DefaultText = "";
            this.txtHardDiskSerial.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHardDiskSerial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHardDiskSerial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHardDiskSerial.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHardDiskSerial.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHardDiskSerial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHardDiskSerial.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHardDiskSerial.Location = new System.Drawing.Point(154, 176);
            this.txtHardDiskSerial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHardDiskSerial.Name = "txtHardDiskSerial";
            this.txtHardDiskSerial.PasswordChar = '\0';
            this.txtHardDiskSerial.PlaceholderText = "";
            this.txtHardDiskSerial.SelectedText = "";
            this.txtHardDiskSerial.Size = new System.Drawing.Size(272, 36);
            this.txtHardDiskSerial.TabIndex = 8;
            // 
            // tlpFooter
            // 
            this.tlpFooter.ColumnCount = 4;
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFooter.Controls.Add(this.btnCancel, 1, 0);
            this.tlpFooter.Controls.Add(this.btnSave, 2, 0);
            this.tlpFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpFooter.Location = new System.Drawing.Point(0, 404);
            this.tlpFooter.Name = "tlpFooter";
            this.tlpFooter.RowCount = 1;
            this.tlpFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFooter.Size = new System.Drawing.Size(800, 46);
            this.tlpFooter.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.BorderThickness = 1;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancel.Location = new System.Drawing.Point(268, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.BorderRadius = 10;
            this.btnCancel.ShadowDecoration.CustomizableEdges.BottomLeft = false;
            this.btnCancel.ShadowDecoration.CustomizableEdges.BottomRight = false;
            this.btnCancel.ShadowDecoration.Depth = 6;
            this.btnCancel.ShadowDecoration.Enabled = true;
            this.btnCancel.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnCancel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.btnCancel.Size = new System.Drawing.Size(114, 40);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btnSave.BorderRadius = 10;
            this.btnSave.BorderThickness = 1;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSave.Location = new System.Drawing.Point(418, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.BorderRadius = 10;
            this.btnSave.ShadowDecoration.CustomizableEdges.BottomLeft = false;
            this.btnSave.ShadowDecoration.CustomizableEdges.BottomRight = false;
            this.btnSave.ShadowDecoration.Depth = 6;
            this.btnSave.ShadowDecoration.Enabled = true;
            this.btnSave.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSave.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.btnSave.Size = new System.Drawing.Size(114, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            // 
            // grbSetting
            // 
            this.grbSetting.Controls.Add(this.tlpMain);
            this.grbSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbSetting.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSetting.Location = new System.Drawing.Point(0, 0);
            this.grbSetting.Name = "grbSetting";
            this.grbSetting.Size = new System.Drawing.Size(800, 404);
            this.grbSetting.TabIndex = 2;
            this.grbSetting.TabStop = false;
            this.grbSetting.Text = "Machine Configuration Information";
            // 
            // SettingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbSetting);
            this.Controls.Add(this.tlpFooter);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SettingView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfigSettingView";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpFooter.ResumeLayout(false);
            this.grbSetting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbxCompany;
        private Guna.UI2.WinForms.Guna2ComboBox cbxMachine;
        private Guna.UI2.WinForms.Guna2ComboBox cbxComPort;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpFooter;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.Label lblCOM;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.Label lblSerialMachine;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private System.Windows.Forms.GroupBox grbSetting;
        private Guna.UI2.WinForms.Guna2TextBox txtHardDiskSerial;
    }
}