namespace VinamiToolUser.Views
{
    partial class ManageToolView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.grbTrayInfo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetTool = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTrayNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtToolCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtQty = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnLog = new System.Windows.Forms.Panel();
            this.scrLog = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.rtbStatus = new System.Windows.Forms.RichTextBox();
            this.grbStockInfo = new System.Windows.Forms.GroupBox();
            this.tvStock = new VinamiToolUser.Views.Components.StockInfoTreeView();
            this.grbTrayList = new System.Windows.Forms.GroupBox();
            this.lstTray = new VinamiToolUser.Views.Components.ListButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.grbTrayInfo.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnLog.SuspendLayout();
            this.grbStockInfo.SuspendLayout();
            this.grbTrayList.SuspendLayout();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 60);
            this.tableLayoutPanel1.TabIndex = 7;
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
            this.btnSearch.Location = new System.Drawing.Point(683, 5);
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
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(4, 5);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(672, 50);
            this.txtSearch.TabIndex = 1;
            // 
            // grbTrayInfo
            // 
            this.grbTrayInfo.Controls.Add(this.tableLayoutPanel2);
            this.grbTrayInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbTrayInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTrayInfo.Location = new System.Drawing.Point(260, 60);
            this.grbTrayInfo.Name = "grbTrayInfo";
            this.grbTrayInfo.Size = new System.Drawing.Size(273, 390);
            this.grbTrayInfo.TabIndex = 6;
            this.grbTrayInfo.TabStop = false;
            this.grbTrayInfo.Text = "Tray Info";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnGetTool, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtTrayNumber, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtToolCode, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtQty, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.pnLog, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(267, 366);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tray Number";
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
            this.btnGetTool.Location = new System.Drawing.Point(73, 314);
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
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tool Code";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quantity";
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
            this.txtTrayNumber.Location = new System.Drawing.Point(104, 5);
            this.txtTrayNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTrayNumber.Name = "txtTrayNumber";
            this.txtTrayNumber.PasswordChar = '\0';
            this.txtTrayNumber.PlaceholderText = "";
            this.txtTrayNumber.ReadOnly = true;
            this.txtTrayNumber.SelectedText = "";
            this.txtTrayNumber.Size = new System.Drawing.Size(159, 35);
            this.txtTrayNumber.TabIndex = 1;
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
            this.txtToolCode.Location = new System.Drawing.Point(104, 50);
            this.txtToolCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtToolCode.Name = "txtToolCode";
            this.txtToolCode.PasswordChar = '\0';
            this.txtToolCode.PlaceholderText = "";
            this.txtToolCode.ReadOnly = true;
            this.txtToolCode.SelectedText = "";
            this.txtToolCode.Size = new System.Drawing.Size(159, 35);
            this.txtToolCode.TabIndex = 1;
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
            this.txtQty.Location = new System.Drawing.Point(104, 95);
            this.txtQty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQty.Name = "txtQty";
            this.txtQty.PasswordChar = '\0';
            this.txtQty.PlaceholderText = "";
            this.txtQty.ReadOnly = true;
            this.txtQty.SelectedText = "";
            this.txtQty.Size = new System.Drawing.Size(159, 35);
            this.txtQty.TabIndex = 1;
            // 
            // pnLog
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.pnLog, 2);
            this.pnLog.Controls.Add(this.scrLog);
            this.pnLog.Controls.Add(this.rtbStatus);
            this.pnLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLog.Location = new System.Drawing.Point(3, 138);
            this.pnLog.Name = "pnLog";
            this.pnLog.Size = new System.Drawing.Size(261, 165);
            this.pnLog.TabIndex = 3;
            // 
            // scrLog
            // 
            this.scrLog.AutoRoundedCorners = true;
            this.scrLog.BindingContainer = this.rtbStatus;
            this.scrLog.BorderRadius = 8;
            this.scrLog.InUpdate = false;
            this.scrLog.LargeChange = 10;
            this.scrLog.Location = new System.Drawing.Point(242, 1);
            this.scrLog.Name = "scrLog";
            this.scrLog.ScrollbarSize = 18;
            this.scrLog.Size = new System.Drawing.Size(18, 163);
            this.scrLog.TabIndex = 3;
            // 
            // rtbStatus
            // 
            this.rtbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbStatus.Location = new System.Drawing.Point(0, 0);
            this.rtbStatus.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.rtbStatus.Name = "rtbStatus";
            this.rtbStatus.ReadOnly = true;
            this.rtbStatus.Size = new System.Drawing.Size(261, 165);
            this.rtbStatus.TabIndex = 2;
            this.rtbStatus.Text = "";
            // 
            // grbStockInfo
            // 
            this.grbStockInfo.Controls.Add(this.tvStock);
            this.grbStockInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.grbStockInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbStockInfo.Location = new System.Drawing.Point(533, 60);
            this.grbStockInfo.Name = "grbStockInfo";
            this.grbStockInfo.Size = new System.Drawing.Size(267, 390);
            this.grbStockInfo.TabIndex = 8;
            this.grbStockInfo.TabStop = false;
            this.grbStockInfo.Text = "Stock Info";
            // 
            // tvStock
            // 
            this.tvStock.BackColor = System.Drawing.SystemColors.Control;
            this.tvStock.ChildNodeFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvStock.DataSource = null;
            this.tvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvStock.Location = new System.Drawing.Point(3, 21);
            this.tvStock.Margin = new System.Windows.Forms.Padding(4);
            this.tvStock.Name = "tvStock";
            this.tvStock.RootNodeFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvStock.Size = new System.Drawing.Size(261, 366);
            this.tvStock.TabIndex = 0;
            // 
            // grbTrayList
            // 
            this.grbTrayList.Controls.Add(this.lstTray);
            this.grbTrayList.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbTrayList.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTrayList.Location = new System.Drawing.Point(0, 60);
            this.grbTrayList.Name = "grbTrayList";
            this.grbTrayList.Size = new System.Drawing.Size(260, 390);
            this.grbTrayList.TabIndex = 5;
            this.grbTrayList.TabStop = false;
            this.grbTrayList.Text = "Tray List";
            // 
            // lstTray
            // 
            this.lstTray.AutoSpacing = true;
            this.lstTray.BackColor = System.Drawing.Color.Snow;
            this.lstTray.DataSource = null;
            this.lstTray.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTray.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(144)))), ((int)(((byte)(233)))));
            this.lstTray.ItemBorderRadius = 8;
            this.lstTray.ItemBorderThickness = 1;
            this.lstTray.ItemBottomDisplayMember = "TrayName";
            this.lstTray.ItemFillColor = System.Drawing.Color.WhiteSmoke;
            this.lstTray.ItemFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTray.ItemForceColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.lstTray.ItemHeight = 45;
            this.lstTray.ItemSpace = 5;
            this.lstTray.ItemTopDisplayMember = "ToolCode";
            this.lstTray.ItemWidth = 210;
            this.lstTray.Location = new System.Drawing.Point(3, 21);
            this.lstTray.Margin = new System.Windows.Forms.Padding(5);
            this.lstTray.MinMargin = 5;
            this.lstTray.Name = "lstTray";
            this.lstTray.Size = new System.Drawing.Size(254, 366);
            this.lstTray.TabIndex = 3;
            // 
            // ManageToolView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbTrayInfo);
            this.Controls.Add(this.grbStockInfo);
            this.Controls.Add(this.grbTrayList);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ManageToolView";
            this.Text = "ManageToolView";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grbTrayInfo.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.pnLog.ResumeLayout(false);
            this.grbStockInfo.ResumeLayout(false);
            this.grbTrayList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.GroupBox grbTrayInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnGetTool;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtToolCode;
        private Guna.UI2.WinForms.Guna2TextBox txtTrayNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtQty;
        private System.Windows.Forms.Panel pnLog;
        private Guna.UI2.WinForms.Guna2VScrollBar scrLog;
        private System.Windows.Forms.RichTextBox rtbStatus;
        private System.Windows.Forms.GroupBox grbStockInfo;
        private Components.StockInfoTreeView tvStock;
        private System.Windows.Forms.GroupBox grbTrayList;
        private Components.ListButton lstTray;
    }
}