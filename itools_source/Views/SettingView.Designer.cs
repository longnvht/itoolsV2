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
            this.lblMachine = new System.Windows.Forms.Label();
            this.lblSaveMessage = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSerialMachine = new System.Windows.Forms.Label();
            this.cbxComPort = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblSerial = new System.Windows.Forms.Label();
            this.txtHardDiskSerial = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMachine = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCompany = new Guna.UI2.WinForms.Guna2TextBox();
            this.tlpFooter = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.grbSetting = new System.Windows.Forms.GroupBox();
            this.grbMachineList = new System.Windows.Forms.GroupBox();
            this.tlpMachineSelect = new System.Windows.Forms.TableLayoutPanel();
            this.lstMachine = new VinamiToolUser.Views.Components.ListButton();
            this.grbCompanyList = new System.Windows.Forms.GroupBox();
            this.tlpCompanySelect = new System.Windows.Forms.TableLayoutPanel();
            this.lstCompany = new VinamiToolUser.Views.Components.ListButton();
            this.btnCompanyCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnCompanySelect = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnMachineSelect = new Guna.UI2.WinForms.Guna2Button();
            this.btnMachineCancel = new Guna.UI2.WinForms.Guna2Button();
            this.tlpMain.SuspendLayout();
            this.tlpFooter.SuspendLayout();
            this.grbSetting.SuspendLayout();
            this.grbMachineList.SuspendLayout();
            this.tlpMachineSelect.SuspendLayout();
            this.grbCompanyList.SuspendLayout();
            this.tlpCompanySelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.lblMachine, 0, 1);
            this.tlpMain.Controls.Add(this.btnEdit, 1, 5);
            this.tlpMain.Controls.Add(this.lblSaveMessage, 1, 4);
            this.tlpMain.Controls.Add(this.lblSerialMachine, 0, 3);
            this.tlpMain.Controls.Add(this.cbxComPort, 1, 3);
            this.tlpMain.Controls.Add(this.lblSerial, 0, 2);
            this.tlpMain.Controls.Add(this.txtHardDiskSerial, 1, 2);
            this.tlpMain.Controls.Add(this.label1, 0, 0);
            this.tlpMain.Controls.Add(this.txtMachine, 1, 1);
            this.tlpMain.Controls.Add(this.txtCompany, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(3, 23);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 6;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(794, 378);
            this.tlpMain.TabIndex = 0;
            // 
            // lblMachine
            // 
            this.lblMachine.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMachine.AutoSize = true;
            this.lblMachine.Location = new System.Drawing.Point(3, 65);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(68, 20);
            this.lblMachine.TabIndex = 1;
            this.lblMachine.Text = "Machine";
            this.lblMachine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSaveMessage
            // 
            this.lblSaveMessage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSaveMessage.BackColor = System.Drawing.Color.Transparent;
            this.tlpMain.SetColumnSpan(this.lblSaveMessage, 2);
            this.lblSaveMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveMessage.Location = new System.Drawing.Point(153, 210);
            this.lblSaveMessage.Name = "lblSaveMessage";
            this.lblSaveMessage.Size = new System.Drawing.Size(12, 19);
            this.lblSaveMessage.TabIndex = 9;
            this.lblSaveMessage.Text = "...";
            // 
            // lblSerialMachine
            // 
            this.lblSerialMachine.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSerialMachine.AutoSize = true;
            this.lblSerialMachine.Location = new System.Drawing.Point(3, 165);
            this.lblSerialMachine.Name = "lblSerialMachine";
            this.lblSerialMachine.Size = new System.Drawing.Size(79, 20);
            this.lblSerialMachine.TabIndex = 2;
            this.lblSerialMachine.Text = "Serial Port";
            this.lblSerialMachine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.cbxComPort.Location = new System.Drawing.Point(153, 157);
            this.cbxComPort.Name = "cbxComPort";
            this.cbxComPort.ShadowDecoration.BorderRadius = 10;
            this.cbxComPort.ShadowDecoration.CustomizableEdges.BottomLeft = false;
            this.cbxComPort.ShadowDecoration.CustomizableEdges.BottomRight = false;
            this.cbxComPort.ShadowDecoration.Depth = 6;
            this.cbxComPort.ShadowDecoration.Enabled = true;
            this.cbxComPort.Size = new System.Drawing.Size(294, 36);
            this.cbxComPort.TabIndex = 5;
            // 
            // lblSerial
            // 
            this.lblSerial.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSerial.AutoSize = true;
            this.lblSerial.Location = new System.Drawing.Point(3, 115);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(118, 20);
            this.lblSerial.TabIndex = 2;
            this.lblSerial.Text = "Hard Disk Serial";
            this.lblSerial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.txtHardDiskSerial.Location = new System.Drawing.Point(154, 107);
            this.txtHardDiskSerial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHardDiskSerial.Name = "txtHardDiskSerial";
            this.txtHardDiskSerial.PasswordChar = '\0';
            this.txtHardDiskSerial.PlaceholderText = "";
            this.txtHardDiskSerial.SelectedText = "";
            this.txtHardDiskSerial.Size = new System.Drawing.Size(292, 36);
            this.txtHardDiskSerial.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Company";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMachine
            // 
            this.txtMachine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMachine.BorderRadius = 8;
            this.txtMachine.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMachine.DefaultText = "";
            this.txtMachine.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMachine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMachine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMachine.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMachine.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMachine.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMachine.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMachine.Location = new System.Drawing.Point(154, 57);
            this.txtMachine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMachine.Name = "txtMachine";
            this.txtMachine.PasswordChar = '\0';
            this.txtMachine.PlaceholderText = "";
            this.txtMachine.SelectedText = "";
            this.txtMachine.Size = new System.Drawing.Size(292, 36);
            this.txtMachine.TabIndex = 8;
            // 
            // txtCompany
            // 
            this.txtCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompany.BorderRadius = 8;
            this.txtCompany.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCompany.DefaultText = "";
            this.txtCompany.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCompany.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCompany.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCompany.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCompany.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCompany.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCompany.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCompany.Location = new System.Drawing.Point(154, 7);
            this.txtCompany.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.PasswordChar = '\0';
            this.txtCompany.PlaceholderText = "";
            this.txtCompany.SelectedText = "";
            this.txtCompany.Size = new System.Drawing.Size(292, 36);
            this.txtCompany.TabIndex = 8;
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
            // grbMachineList
            // 
            this.grbMachineList.Controls.Add(this.lstMachine);
            this.grbMachineList.Controls.Add(this.tlpMachineSelect);
            this.grbMachineList.Dock = System.Windows.Forms.DockStyle.Right;
            this.grbMachineList.Location = new System.Drawing.Point(550, 0);
            this.grbMachineList.Name = "grbMachineList";
            this.grbMachineList.Size = new System.Drawing.Size(250, 404);
            this.grbMachineList.TabIndex = 3;
            this.grbMachineList.TabStop = false;
            this.grbMachineList.Text = "Machine List";
            // 
            // tlpMachineSelect
            // 
            this.tlpMachineSelect.ColumnCount = 2;
            this.tlpMachineSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMachineSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMachineSelect.Controls.Add(this.btnMachineCancel, 0, 0);
            this.tlpMachineSelect.Controls.Add(this.btnMachineSelect, 1, 0);
            this.tlpMachineSelect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpMachineSelect.Location = new System.Drawing.Point(3, 351);
            this.tlpMachineSelect.Name = "tlpMachineSelect";
            this.tlpMachineSelect.RowCount = 1;
            this.tlpMachineSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMachineSelect.Size = new System.Drawing.Size(244, 50);
            this.tlpMachineSelect.TabIndex = 2;
            // 
            // lstMachine
            // 
            this.lstMachine.AutoSpacing = true;
            this.lstMachine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(220)))), ((int)(((byte)(245)))));
            this.lstMachine.DataSource = null;
            this.lstMachine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMachine.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lstMachine.ItemBorderRadius = 8;
            this.lstMachine.ItemBorderThickness = 1;
            this.lstMachine.ItemBottomDisplayMember = "MachineName";
            this.lstMachine.ItemFillColor = System.Drawing.Color.WhiteSmoke;
            this.lstMachine.ItemFont = new System.Drawing.Font("Segoe UI", 10F);
            this.lstMachine.ItemForceColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.lstMachine.ItemHeight = 50;
            this.lstMachine.ItemSpace = 7;
            this.lstMachine.ItemTopDisplayMember = "MachineCode";
            this.lstMachine.ItemWidth = 200;
            this.lstMachine.Location = new System.Drawing.Point(3, 23);
            this.lstMachine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstMachine.MinMargin = 5;
            this.lstMachine.Name = "lstMachine";
            this.lstMachine.Size = new System.Drawing.Size(244, 328);
            this.lstMachine.TabIndex = 0;
            // 
            // grbCompanyList
            // 
            this.grbCompanyList.Controls.Add(this.lstCompany);
            this.grbCompanyList.Controls.Add(this.tlpCompanySelect);
            this.grbCompanyList.Dock = System.Windows.Forms.DockStyle.Right;
            this.grbCompanyList.Location = new System.Drawing.Point(300, 0);
            this.grbCompanyList.Name = "grbCompanyList";
            this.grbCompanyList.Size = new System.Drawing.Size(250, 404);
            this.grbCompanyList.TabIndex = 3;
            this.grbCompanyList.TabStop = false;
            this.grbCompanyList.Text = "CompanyList";
            // 
            // tlpCompanySelect
            // 
            this.tlpCompanySelect.ColumnCount = 2;
            this.tlpCompanySelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCompanySelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCompanySelect.Controls.Add(this.btnCompanyCancel, 0, 0);
            this.tlpCompanySelect.Controls.Add(this.btnCompanySelect, 1, 0);
            this.tlpCompanySelect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpCompanySelect.Location = new System.Drawing.Point(3, 351);
            this.tlpCompanySelect.Name = "tlpCompanySelect";
            this.tlpCompanySelect.RowCount = 1;
            this.tlpCompanySelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCompanySelect.Size = new System.Drawing.Size(244, 50);
            this.tlpCompanySelect.TabIndex = 1;
            // 
            // lstCompany
            // 
            this.lstCompany.AutoSpacing = true;
            this.lstCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(220)))), ((int)(((byte)(245)))));
            this.lstCompany.DataSource = null;
            this.lstCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCompany.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lstCompany.ItemBorderRadius = 8;
            this.lstCompany.ItemBorderThickness = 1;
            this.lstCompany.ItemBottomDisplayMember = "CompanyName";
            this.lstCompany.ItemFillColor = System.Drawing.Color.WhiteSmoke;
            this.lstCompany.ItemFont = new System.Drawing.Font("Segoe UI", 10F);
            this.lstCompany.ItemForceColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.lstCompany.ItemHeight = 50;
            this.lstCompany.ItemSpace = 7;
            this.lstCompany.ItemTopDisplayMember = "CompanyCode";
            this.lstCompany.ItemWidth = 200;
            this.lstCompany.Location = new System.Drawing.Point(3, 23);
            this.lstCompany.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.lstCompany.MinMargin = 5;
            this.lstCompany.Name = "lstCompany";
            this.lstCompany.Size = new System.Drawing.Size(244, 328);
            this.lstCompany.TabIndex = 0;
            // 
            // btnCompanyCancel
            // 
            this.btnCompanyCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCompanyCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCompanyCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCompanyCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCompanyCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCompanyCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(207)))), ((int)(((byte)(242)))));
            this.btnCompanyCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompanyCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(38)))), ((int)(((byte)(113)))));
            this.btnCompanyCancel.Image = global::VinamiToolUser.Properties.Resources.Cancel_Order_60px;
            this.btnCompanyCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCompanyCancel.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCompanyCancel.Location = new System.Drawing.Point(3, 3);
            this.btnCompanyCancel.Name = "btnCompanyCancel";
            this.btnCompanyCancel.Size = new System.Drawing.Size(116, 44);
            this.btnCompanyCancel.TabIndex = 0;
            this.btnCompanyCancel.Text = "Cancel";
            this.btnCompanyCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnCompanySelect
            // 
            this.btnCompanySelect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCompanySelect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCompanySelect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCompanySelect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCompanySelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCompanySelect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(207)))), ((int)(((byte)(242)))));
            this.btnCompanySelect.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompanySelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(38)))), ((int)(((byte)(113)))));
            this.btnCompanySelect.Image = global::VinamiToolUser.Properties.Resources.new_copy_60px;
            this.btnCompanySelect.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCompanySelect.Location = new System.Drawing.Point(125, 3);
            this.btnCompanySelect.Name = "btnCompanySelect";
            this.btnCompanySelect.Size = new System.Drawing.Size(116, 44);
            this.btnCompanySelect.TabIndex = 0;
            this.btnCompanySelect.Text = "Select";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnEdit.Location = new System.Drawing.Point(362, 243);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 34);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnMachineSelect
            // 
            this.btnMachineSelect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMachineSelect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMachineSelect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMachineSelect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMachineSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMachineSelect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(207)))), ((int)(((byte)(242)))));
            this.btnMachineSelect.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMachineSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(38)))), ((int)(((byte)(113)))));
            this.btnMachineSelect.Image = global::VinamiToolUser.Properties.Resources.new_copy_60px;
            this.btnMachineSelect.ImageSize = new System.Drawing.Size(25, 25);
            this.btnMachineSelect.Location = new System.Drawing.Point(125, 3);
            this.btnMachineSelect.Name = "btnMachineSelect";
            this.btnMachineSelect.Size = new System.Drawing.Size(116, 44);
            this.btnMachineSelect.TabIndex = 0;
            this.btnMachineSelect.Text = "Select";
            // 
            // btnMachineCancel
            // 
            this.btnMachineCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMachineCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMachineCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMachineCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMachineCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMachineCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(207)))), ((int)(((byte)(242)))));
            this.btnMachineCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMachineCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(38)))), ((int)(((byte)(113)))));
            this.btnMachineCancel.Image = global::VinamiToolUser.Properties.Resources.Cancel_Order_60px;
            this.btnMachineCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMachineCancel.ImageSize = new System.Drawing.Size(25, 25);
            this.btnMachineCancel.Location = new System.Drawing.Point(3, 3);
            this.btnMachineCancel.Name = "btnMachineCancel";
            this.btnMachineCancel.Size = new System.Drawing.Size(116, 44);
            this.btnMachineCancel.TabIndex = 0;
            this.btnMachineCancel.Text = "Cancel";
            this.btnMachineCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // SettingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbCompanyList);
            this.Controls.Add(this.grbMachineList);
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
            this.grbMachineList.ResumeLayout(false);
            this.tlpMachineSelect.ResumeLayout(false);
            this.grbCompanyList.ResumeLayout(false);
            this.tlpCompanySelect.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox cbxComPort;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpFooter;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.Label lblSerial;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.Label lblSerialMachine;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private System.Windows.Forms.GroupBox grbSetting;
        private Guna.UI2.WinForms.Guna2TextBox txtHardDiskSerial;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSaveMessage;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtMachine;
        private Guna.UI2.WinForms.Guna2TextBox txtCompany;
        private System.Windows.Forms.GroupBox grbMachineList;
        private VinamiToolUser.Views.Components.ListButton lstMachine;
        private System.Windows.Forms.GroupBox grbCompanyList;
        private VinamiToolUser.Views.Components.ListButton lstCompany;
        private System.Windows.Forms.TableLayoutPanel tlpMachineSelect;
        private System.Windows.Forms.TableLayoutPanel tlpCompanySelect;
        private Guna.UI2.WinForms.Guna2Button btnCompanyCancel;
        private Guna.UI2.WinForms.Guna2Button btnCompanySelect;
        private Guna.UI2.WinForms.Guna2Button btnMachineCancel;
        private Guna.UI2.WinForms.Guna2Button btnMachineSelect;
    }
}