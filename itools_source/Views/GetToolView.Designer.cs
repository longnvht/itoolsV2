namespace VinamiToolUser.Views
{
    partial class GetToolView
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
            this.grbToolList = new System.Windows.Forms.GroupBox();
            this.lstTool = new VinamiToolUser.Views.Components.ListButton();
            this.grbToolInfo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetTool = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToolCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtToolName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTrayNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtQty = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnLog = new System.Windows.Forms.Panel();
            this.scrLog = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.rtbStatus = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnDesktop = new System.Windows.Forms.Panel();
            this.grbStockInfo = new System.Windows.Forms.GroupBox();
            this.tclStock = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tvStock = new VinamiToolUser.Views.Components.StockInfoTreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tvOtherStock = new VinamiToolUser.Views.Components.StockInfoTreeView();
            this.serialPortGetTool = new System.IO.Ports.SerialPort(this.components);
            this.tmGetTool = new System.Windows.Forms.Timer(this.components);
            this.grbToolList.SuspendLayout();
            this.grbToolInfo.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnLog.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnDesktop.SuspendLayout();
            this.grbStockInfo.SuspendLayout();
            this.tclStock.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbToolList
            // 
            this.grbToolList.Controls.Add(this.lstTool);
            this.grbToolList.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbToolList.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbToolList.Location = new System.Drawing.Point(0, 0);
            this.grbToolList.Name = "grbToolList";
            this.grbToolList.Size = new System.Drawing.Size(260, 390);
            this.grbToolList.TabIndex = 0;
            this.grbToolList.TabStop = false;
            this.grbToolList.Text = "ToolList";
            // 
            // lstTool
            // 
            this.lstTool.AutoSpacing = true;
            this.lstTool.BackColor = System.Drawing.Color.Snow;
            this.lstTool.DataSource = null;
            this.lstTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTool.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(144)))), ((int)(((byte)(233)))));
            this.lstTool.ItemBorderRadius = 8;
            this.lstTool.ItemBorderThickness = 1;
            this.lstTool.ItemBottomDisplayMember = "ToolName";
            this.lstTool.ItemFillColor = System.Drawing.Color.WhiteSmoke;
            this.lstTool.ItemFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTool.ItemForceColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.lstTool.ItemHeight = 45;
            this.lstTool.ItemSpace = 5;
            this.lstTool.ItemTopDisplayMember = "ToolCode";
            this.lstTool.ItemWidth = 210;
            this.lstTool.Location = new System.Drawing.Point(3, 21);
            this.lstTool.Margin = new System.Windows.Forms.Padding(5);
            this.lstTool.MinMargin = 5;
            this.lstTool.Name = "lstTool";
            this.lstTool.Size = new System.Drawing.Size(254, 366);
            this.lstTool.TabIndex = 3;
            // 
            // grbToolInfo
            // 
            this.grbToolInfo.Controls.Add(this.tableLayoutPanel2);
            this.grbToolInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbToolInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbToolInfo.Location = new System.Drawing.Point(540, 0);
            this.grbToolInfo.Name = "grbToolInfo";
            this.grbToolInfo.Size = new System.Drawing.Size(332, 390);
            this.grbToolInfo.TabIndex = 1;
            this.grbToolInfo.TabStop = false;
            this.grbToolInfo.Text = "Tool Info";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnGetTool, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtToolCode, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtToolName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtTrayNumber, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtQty, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.pnLog, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(326, 366);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tool Code";
            // 
            // btnGetTool
            // 
            this.btnGetTool.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGetTool.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(144)))), ((int)(((byte)(233)))));
            this.btnGetTool.BorderRadius = 8;
            this.btnGetTool.BorderThickness = 1;
            this.tableLayoutPanel2.SetColumnSpan(this.btnGetTool, 2);
            this.btnGetTool.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGetTool.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGetTool.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGetTool.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGetTool.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnGetTool.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetTool.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(38)))), ((int)(((byte)(113)))));
            this.btnGetTool.Location = new System.Drawing.Point(102, 314);
            this.btnGetTool.Name = "btnGetTool";
            this.btnGetTool.Size = new System.Drawing.Size(121, 44);
            this.btnGetTool.TabIndex = 0;
            this.btnGetTool.Text = "Get Tool";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tool Name";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tray Number";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quantity";
            // 
            // txtToolCode
            // 
            this.txtToolCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToolCode.BorderRadius = 8;
            this.txtToolCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtToolCode.DefaultText = "";
            this.txtToolCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtToolCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtToolCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtToolCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtToolCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtToolCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtToolCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtToolCode.Location = new System.Drawing.Point(104, 5);
            this.txtToolCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtToolCode.Name = "txtToolCode";
            this.txtToolCode.PasswordChar = '\0';
            this.txtToolCode.PlaceholderText = "";
            this.txtToolCode.ReadOnly = true;
            this.txtToolCode.SelectedText = "";
            this.txtToolCode.Size = new System.Drawing.Size(218, 35);
            this.txtToolCode.TabIndex = 1;
            // 
            // txtToolName
            // 
            this.txtToolName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToolName.BorderRadius = 8;
            this.txtToolName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtToolName.DefaultText = "";
            this.txtToolName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtToolName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtToolName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtToolName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtToolName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtToolName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtToolName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtToolName.Location = new System.Drawing.Point(104, 50);
            this.txtToolName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtToolName.Name = "txtToolName";
            this.txtToolName.PasswordChar = '\0';
            this.txtToolName.PlaceholderText = "";
            this.txtToolName.ReadOnly = true;
            this.txtToolName.SelectedText = "";
            this.txtToolName.Size = new System.Drawing.Size(218, 35);
            this.txtToolName.TabIndex = 1;
            // 
            // txtTrayNumber
            // 
            this.txtTrayNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTrayNumber.BorderRadius = 8;
            this.txtTrayNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTrayNumber.DefaultText = "";
            this.txtTrayNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTrayNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTrayNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTrayNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTrayNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTrayNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTrayNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTrayNumber.Location = new System.Drawing.Point(104, 95);
            this.txtTrayNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTrayNumber.Name = "txtTrayNumber";
            this.txtTrayNumber.PasswordChar = '\0';
            this.txtTrayNumber.PlaceholderText = "";
            this.txtTrayNumber.ReadOnly = true;
            this.txtTrayNumber.SelectedText = "";
            this.txtTrayNumber.Size = new System.Drawing.Size(218, 35);
            this.txtTrayNumber.TabIndex = 1;
            // 
            // txtQty
            // 
            this.txtQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQty.BorderRadius = 8;
            this.txtQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQty.DefaultText = "";
            this.txtQty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQty.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQty.Location = new System.Drawing.Point(104, 140);
            this.txtQty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQty.Name = "txtQty";
            this.txtQty.PasswordChar = '\0';
            this.txtQty.PlaceholderText = "";
            this.txtQty.ReadOnly = true;
            this.txtQty.SelectedText = "";
            this.txtQty.Size = new System.Drawing.Size(218, 35);
            this.txtQty.TabIndex = 1;
            // 
            // pnLog
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.pnLog, 2);
            this.pnLog.Controls.Add(this.scrLog);
            this.pnLog.Controls.Add(this.rtbStatus);
            this.pnLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLog.Location = new System.Drawing.Point(3, 183);
            this.pnLog.Name = "pnLog";
            this.pnLog.Size = new System.Drawing.Size(320, 120);
            this.pnLog.TabIndex = 3;
            // 
            // scrLog
            // 
            this.scrLog.AutoRoundedCorners = true;
            this.scrLog.BindingContainer = this.rtbStatus;
            this.scrLog.BorderRadius = 8;
            this.scrLog.InUpdate = false;
            this.scrLog.LargeChange = 10;
            this.scrLog.Location = new System.Drawing.Point(301, 1);
            this.scrLog.Name = "scrLog";
            this.scrLog.ScrollbarSize = 18;
            this.scrLog.Size = new System.Drawing.Size(18, 118);
            this.scrLog.TabIndex = 3;
            // 
            // rtbStatus
            // 
            this.rtbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbStatus.Location = new System.Drawing.Point(0, 0);
            this.rtbStatus.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.rtbStatus.Name = "rtbStatus";
            this.rtbStatus.ReadOnly = true;
            this.rtbStatus.Size = new System.Drawing.Size(320, 120);
            this.rtbStatus.TabIndex = 2;
            this.rtbStatus.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSearch, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(872, 60);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(144)))), ((int)(((byte)(233)))));
            this.btnSearch.BorderRadius = 8;
            this.btnSearch.BorderThickness = 1;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(38)))), ((int)(((byte)(113)))));
            this.btnSearch.Location = new System.Drawing.Point(755, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 50);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(144)))), ((int)(((byte)(233)))));
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
            this.txtSearch.Location = new System.Drawing.Point(4, 5);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(744, 50);
            this.txtSearch.TabIndex = 1;
            // 
            // pnDesktop
            // 
            this.pnDesktop.Controls.Add(this.grbToolInfo);
            this.pnDesktop.Controls.Add(this.grbStockInfo);
            this.pnDesktop.Controls.Add(this.grbToolList);
            this.pnDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDesktop.Location = new System.Drawing.Point(0, 60);
            this.pnDesktop.Name = "pnDesktop";
            this.pnDesktop.Size = new System.Drawing.Size(872, 390);
            this.pnDesktop.TabIndex = 4;
            // 
            // grbStockInfo
            // 
            this.grbStockInfo.Controls.Add(this.tclStock);
            this.grbStockInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbStockInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbStockInfo.Location = new System.Drawing.Point(260, 0);
            this.grbStockInfo.Name = "grbStockInfo";
            this.grbStockInfo.Size = new System.Drawing.Size(280, 390);
            this.grbStockInfo.TabIndex = 4;
            this.grbStockInfo.TabStop = false;
            this.grbStockInfo.Text = "Stock Info";
            // 
            // tclStock
            // 
            this.tclStock.Controls.Add(this.tabPage1);
            this.tclStock.Controls.Add(this.tabPage2);
            this.tclStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tclStock.ItemSize = new System.Drawing.Size(132, 40);
            this.tclStock.Location = new System.Drawing.Point(3, 21);
            this.tclStock.Name = "tclStock";
            this.tclStock.SelectedIndex = 0;
            this.tclStock.Size = new System.Drawing.Size(274, 366);
            this.tclStock.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tclStock.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tclStock.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tclStock.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tclStock.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tclStock.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tclStock.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(208)))), ((int)(((byte)(242)))));
            this.tclStock.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tclStock.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tclStock.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tclStock.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tclStock.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(225)))));
            this.tclStock.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tclStock.TabButtonSelectedState.ForeColor = System.Drawing.Color.Navy;
            this.tclStock.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tclStock.TabButtonSize = new System.Drawing.Size(132, 40);
            this.tclStock.TabIndex = 1;
            this.tclStock.TabMenuBackColor = System.Drawing.Color.Transparent;
            this.tclStock.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tvStock);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(266, 318);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Current Machine";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tvStock
            // 
            this.tvStock.BackColor = System.Drawing.SystemColors.Control;
            this.tvStock.ChildNodeFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvStock.DataSource = null;
            this.tvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvStock.Location = new System.Drawing.Point(3, 3);
            this.tvStock.Margin = new System.Windows.Forms.Padding(4);
            this.tvStock.Name = "tvStock";
            this.tvStock.RootNodeFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvStock.Size = new System.Drawing.Size(260, 312);
            this.tvStock.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tvOtherStock);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(266, 318);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Other Machine";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tvOtherStock
            // 
            this.tvOtherStock.BackColor = System.Drawing.SystemColors.Control;
            this.tvOtherStock.ChildNodeFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvOtherStock.DataSource = null;
            this.tvOtherStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvOtherStock.Location = new System.Drawing.Point(3, 3);
            this.tvOtherStock.Margin = new System.Windows.Forms.Padding(5);
            this.tvOtherStock.Name = "tvOtherStock";
            this.tvOtherStock.RootNodeFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvOtherStock.Size = new System.Drawing.Size(260, 312);
            this.tvOtherStock.TabIndex = 1;
            // 
            // tmGetTool
            // 
            this.tmGetTool.Interval = 500;
            // 
            // GetToolView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 450);
            this.Controls.Add(this.pnDesktop);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GetToolView";
            this.Text = "GetToolViewNew";
            this.grbToolList.ResumeLayout(false);
            this.grbToolInfo.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.pnLog.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnDesktop.ResumeLayout(false);
            this.grbStockInfo.ResumeLayout(false);
            this.tclStock.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbToolList;
        private System.Windows.Forms.GroupBox grbToolInfo;
        private Components.ListButton lstTool;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Panel pnDesktop;
        private System.Windows.Forms.GroupBox grbStockInfo;
        private Components.StockInfoTreeView tvStock;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtToolCode;
        private Guna.UI2.WinForms.Guna2TextBox txtToolName;
        private Guna.UI2.WinForms.Guna2TextBox txtTrayNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtQty;
        private Guna.UI2.WinForms.Guna2Button btnGetTool;
        private System.IO.Ports.SerialPort serialPortGetTool;
        private System.Windows.Forms.Timer tmGetTool;
        private System.Windows.Forms.RichTextBox rtbStatus;
        private System.Windows.Forms.Panel pnLog;
        private Guna.UI2.WinForms.Guna2VScrollBar scrLog;
        private Guna.UI2.WinForms.Guna2TabControl tclStock;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Components.StockInfoTreeView tvOtherStock;
    }
}