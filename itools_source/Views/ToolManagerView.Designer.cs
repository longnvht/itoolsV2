namespace itools_source.Views
{
    partial class ToolManagerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolManagerView));
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.notifiTakeout = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.btnTakeOut = new Guna.UI2.WinForms.Guna2GradientButton();
            this.notifiAddPlugin = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.btnAddPlugin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.notifiAddNew = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.btnAddNew = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2VScrollBar_flpTrayList = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.flpTrayList = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Elipse_pLeftContent = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pLeftContent = new System.Windows.Forms.Panel();
            this.tlpTooList = new System.Windows.Forms.TableLayoutPanel();
            this.txtToolSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pToolContent = new System.Windows.Forms.Panel();
            this.guna2VScrollBar2 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.flpToolList = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnToolCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnToolSelect = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tlpContent = new System.Windows.Forms.TableLayoutPanel();
            this.pRightContent = new System.Windows.Forms.Panel();
            this.tlpTrayDetail = new System.Windows.Forms.TableLayoutPanel();
            this.txtTrayIndex = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtToolCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCurrentQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtOperateQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTotalQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlpFooter = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Elipse_tlpToolList = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse_tlpTrayDetail = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse_pToolContent = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tlpHeader.SuspendLayout();
            this.pLeftContent.SuspendLayout();
            this.tlpTooList.SuspendLayout();
            this.pToolContent.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpContent.SuspendLayout();
            this.pRightContent.SuspendLayout();
            this.tlpTrayDetail.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tlpFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpHeader
            // 
            this.tlpHeader.ColumnCount = 3;
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHeader.Controls.Add(this.btnSearch, 2, 0);
            this.tlpHeader.Controls.Add(this.txtSearch, 0, 0);
            this.tlpHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpHeader.Location = new System.Drawing.Point(0, 0);
            this.tlpHeader.Name = "tlpHeader";
            this.tlpHeader.RowCount = 1;
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.Size = new System.Drawing.Size(900, 50);
            this.tlpHeader.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Animated = true;
            this.btnSearch.AutoRoundedCorners = true;
            this.btnSearch.BorderRadius = 17;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(578, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(319, 36);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm Kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderRadius = 8;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(3, 7);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.txtSearch.PlaceholderText = "Tìm Kiếm";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(319, 36);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // notifiTakeout
            // 
            this.notifiTakeout.Alignment = Guna.UI2.WinForms.Enums.CustomContentAlignment.BottomRight;
            this.notifiTakeout.Location = new System.Drawing.Point(95, 14);
            this.notifiTakeout.Offset = new System.Drawing.Point(-24, -15);
            this.notifiTakeout.Size = new System.Drawing.Size(25, 18);
            this.notifiTakeout.TargetControl = this.btnTakeOut;
            this.notifiTakeout.Text = "Off";
            // 
            // btnTakeOut
            // 
            this.btnTakeOut.Animated = true;
            this.btnTakeOut.AutoRoundedCorners = true;
            this.btnTakeOut.BorderRadius = 22;
            this.btnTakeOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTakeOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTakeOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTakeOut.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTakeOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTakeOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTakeOut.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.btnTakeOut.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnTakeOut.ForeColor = System.Drawing.Color.White;
            this.btnTakeOut.Location = new System.Drawing.Point(153, 3);
            this.btnTakeOut.Name = "btnTakeOut";
            this.btnTakeOut.Size = new System.Drawing.Size(144, 47);
            this.btnTakeOut.TabIndex = 3;
            this.btnTakeOut.Text = "Lấy Ra";
            // 
            // notifiAddPlugin
            // 
            this.notifiAddPlugin.Alignment = Guna.UI2.WinForms.Enums.CustomContentAlignment.BottomRight;
            this.notifiAddPlugin.Location = new System.Drawing.Point(100, 14);
            this.notifiAddPlugin.Offset = new System.Drawing.Point(-19, -15);
            this.notifiAddPlugin.Size = new System.Drawing.Size(25, 18);
            this.notifiAddPlugin.TargetControl = this.btnAddPlugin;
            this.notifiAddPlugin.Text = "Off";
            // 
            // btnAddPlugin
            // 
            this.btnAddPlugin.Animated = true;
            this.btnAddPlugin.AutoRoundedCorners = true;
            this.btnAddPlugin.BorderRadius = 22;
            this.btnAddPlugin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPlugin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPlugin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPlugin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPlugin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddPlugin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddPlugin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.btnAddPlugin.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnAddPlugin.ForeColor = System.Drawing.Color.White;
            this.btnAddPlugin.Location = new System.Drawing.Point(303, 3);
            this.btnAddPlugin.Name = "btnAddPlugin";
            this.btnAddPlugin.Size = new System.Drawing.Size(144, 47);
            this.btnAddPlugin.TabIndex = 4;
            this.btnAddPlugin.Text = "Bổ Sung";
            // 
            // notifiAddNew
            // 
            this.notifiAddNew.Alignment = Guna.UI2.WinForms.Enums.CustomContentAlignment.BottomRight;
            this.notifiAddNew.Location = new System.Drawing.Point(106, 14);
            this.notifiAddNew.Offset = new System.Drawing.Point(-13, -15);
            this.notifiAddNew.Size = new System.Drawing.Size(25, 18);
            this.notifiAddNew.TargetControl = this.btnAddNew;
            this.notifiAddNew.Text = "Off";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Animated = true;
            this.btnAddNew.AutoRoundedCorners = true;
            this.btnAddNew.BorderRadius = 22;
            this.btnAddNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNew.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddNew.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.btnAddNew.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Location = new System.Drawing.Point(453, 3);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(144, 47);
            this.btnAddNew.TabIndex = 5;
            this.btnAddNew.Text = "Thêm Mới";
            // 
            // guna2VScrollBar_flpTrayList
            // 
            this.guna2VScrollBar_flpTrayList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2VScrollBar_flpTrayList.AutoRoundedCorners = true;
            this.guna2VScrollBar_flpTrayList.AutoSize = true;
            this.guna2VScrollBar_flpTrayList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.guna2VScrollBar_flpTrayList.BindingContainer = this.flpTrayList;
            this.guna2VScrollBar_flpTrayList.BorderRadius = 8;
            this.guna2VScrollBar_flpTrayList.InUpdate = false;
            this.guna2VScrollBar_flpTrayList.LargeChange = 10;
            this.guna2VScrollBar_flpTrayList.Location = new System.Drawing.Point(285, 0);
            this.guna2VScrollBar_flpTrayList.Name = "guna2VScrollBar_flpTrayList";
            this.guna2VScrollBar_flpTrayList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.guna2VScrollBar_flpTrayList.ScrollbarSize = 18;
            this.guna2VScrollBar_flpTrayList.Size = new System.Drawing.Size(18, 344);
            this.guna2VScrollBar_flpTrayList.TabIndex = 20;
            this.guna2VScrollBar_flpTrayList.ThumbSize = 100F;
            // 
            // flpTrayList
            // 
            this.flpTrayList.AutoScroll = true;
            this.flpTrayList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.flpTrayList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTrayList.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpTrayList.Location = new System.Drawing.Point(0, 0);
            this.flpTrayList.Margin = new System.Windows.Forms.Padding(2);
            this.flpTrayList.Name = "flpTrayList";
            this.flpTrayList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flpTrayList.Size = new System.Drawing.Size(303, 344);
            this.flpTrayList.TabIndex = 33;
            // 
            // guna2Elipse_pLeftContent
            // 
            this.guna2Elipse_pLeftContent.BorderRadius = 20;
            this.guna2Elipse_pLeftContent.TargetControl = this.pLeftContent;
            // 
            // pLeftContent
            // 
            this.pLeftContent.Controls.Add(this.guna2VScrollBar_flpTrayList);
            this.pLeftContent.Controls.Add(this.flpTrayList);
            this.pLeftContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLeftContent.Location = new System.Drawing.Point(3, 3);
            this.pLeftContent.Name = "pLeftContent";
            this.pLeftContent.Size = new System.Drawing.Size(303, 344);
            this.pLeftContent.TabIndex = 0;
            // 
            // tlpTooList
            // 
            this.tlpTooList.AutoScroll = true;
            this.tlpTooList.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tlpTooList.ColumnCount = 1;
            this.tlpTooList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTooList.Controls.Add(this.txtToolSearch, 0, 0);
            this.tlpTooList.Controls.Add(this.pToolContent, 0, 1);
            this.tlpTooList.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tlpTooList.Location = new System.Drawing.Point(262, 3);
            this.tlpTooList.Name = "tlpTooList";
            this.tlpTooList.RowCount = 3;
            this.tlpTooList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpTooList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpTooList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpTooList.Size = new System.Drawing.Size(320, 340);
            this.tlpTooList.TabIndex = 0;
            // 
            // txtToolSearch
            // 
            this.txtToolSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToolSearch.BorderRadius = 8;
            this.txtToolSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtToolSearch.DefaultText = "";
            this.txtToolSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtToolSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtToolSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtToolSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtToolSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtToolSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToolSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtToolSearch.Location = new System.Drawing.Point(3, 8);
            this.txtToolSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtToolSearch.Name = "txtToolSearch";
            this.txtToolSearch.PasswordChar = '\0';
            this.txtToolSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.txtToolSearch.PlaceholderText = "Tìm Kiếm";
            this.txtToolSearch.SelectedText = "";
            this.txtToolSearch.Size = new System.Drawing.Size(314, 34);
            this.txtToolSearch.TabIndex = 28;
            this.txtToolSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pToolContent
            // 
            this.pToolContent.Controls.Add(this.guna2VScrollBar2);
            this.pToolContent.Controls.Add(this.flpToolList);
            this.pToolContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pToolContent.Location = new System.Drawing.Point(3, 54);
            this.pToolContent.Name = "pToolContent";
            this.pToolContent.Size = new System.Drawing.Size(314, 232);
            this.pToolContent.TabIndex = 29;
            // 
            // guna2VScrollBar2
            // 
            this.guna2VScrollBar2.AutoRoundedCorners = true;
            this.guna2VScrollBar2.AutoSize = true;
            this.guna2VScrollBar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.guna2VScrollBar2.BindingContainer = this.flpToolList;
            this.guna2VScrollBar2.BorderRadius = 8;
            this.guna2VScrollBar2.InUpdate = false;
            this.guna2VScrollBar2.LargeChange = 10;
            this.guna2VScrollBar2.Location = new System.Drawing.Point(296, 1);
            this.guna2VScrollBar2.Name = "guna2VScrollBar2";
            this.guna2VScrollBar2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.guna2VScrollBar2.ScrollbarSize = 18;
            this.guna2VScrollBar2.Size = new System.Drawing.Size(18, 232);
            this.guna2VScrollBar2.TabIndex = 28;
            this.guna2VScrollBar2.ThumbSize = 100F;
            // 
            // flpToolList
            // 
            this.flpToolList.AutoScroll = true;
            this.flpToolList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.flpToolList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpToolList.Location = new System.Drawing.Point(0, 0);
            this.flpToolList.Margin = new System.Windows.Forms.Padding(2);
            this.flpToolList.Name = "flpToolList";
            this.flpToolList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flpToolList.Size = new System.Drawing.Size(314, 232);
            this.flpToolList.TabIndex = 29;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnToolCancel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnToolSelect, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 292);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(314, 45);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // btnToolCancel
            // 
            this.btnToolCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToolCancel.Animated = true;
            this.btnToolCancel.AutoRoundedCorners = true;
            this.btnToolCancel.BorderRadius = 17;
            this.btnToolCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnToolCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnToolCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnToolCancel.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnToolCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnToolCancel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.btnToolCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToolCancel.ForeColor = System.Drawing.Color.White;
            this.btnToolCancel.Location = new System.Drawing.Point(160, 4);
            this.btnToolCancel.Name = "btnToolCancel";
            this.btnToolCancel.Size = new System.Drawing.Size(151, 36);
            this.btnToolCancel.TabIndex = 30;
            this.btnToolCancel.Text = "Hủy";
            // 
            // btnToolSelect
            // 
            this.btnToolSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToolSelect.Animated = true;
            this.btnToolSelect.AutoRoundedCorners = true;
            this.btnToolSelect.BorderRadius = 17;
            this.btnToolSelect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnToolSelect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnToolSelect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnToolSelect.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnToolSelect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnToolSelect.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.btnToolSelect.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToolSelect.ForeColor = System.Drawing.Color.White;
            this.btnToolSelect.Location = new System.Drawing.Point(3, 4);
            this.btnToolSelect.Name = "btnToolSelect";
            this.btnToolSelect.Size = new System.Drawing.Size(151, 36);
            this.btnToolSelect.TabIndex = 29;
            this.btnToolSelect.Text = "Chọn";
            // 
            // tlpContent
            // 
            this.tlpContent.ColumnCount = 2;
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.4F));
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.6F));
            this.tlpContent.Controls.Add(this.pLeftContent, 0, 0);
            this.tlpContent.Controls.Add(this.pRightContent, 1, 0);
            this.tlpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContent.Location = new System.Drawing.Point(0, 50);
            this.tlpContent.Name = "tlpContent";
            this.tlpContent.RowCount = 1;
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tlpContent.Size = new System.Drawing.Size(900, 350);
            this.tlpContent.TabIndex = 12;
            // 
            // pRightContent
            // 
            this.pRightContent.Controls.Add(this.tlpTooList);
            this.pRightContent.Controls.Add(this.tlpTrayDetail);
            this.pRightContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pRightContent.Location = new System.Drawing.Point(312, 3);
            this.pRightContent.Name = "pRightContent";
            this.pRightContent.Size = new System.Drawing.Size(585, 344);
            this.pRightContent.TabIndex = 1;
            // 
            // tlpTrayDetail
            // 
            this.tlpTrayDetail.ColumnCount = 4;
            this.tlpTrayDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpTrayDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpTrayDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpTrayDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTrayDetail.Controls.Add(this.txtTrayIndex, 2, 1);
            this.tlpTrayDetail.Controls.Add(this.txtToolCode, 2, 2);
            this.tlpTrayDetail.Controls.Add(this.txtCurrentQuantity, 2, 3);
            this.tlpTrayDetail.Controls.Add(this.txtOperateQuantity, 2, 4);
            this.tlpTrayDetail.Controls.Add(this.guna2HtmlLabel2, 1, 2);
            this.tlpTrayDetail.Controls.Add(this.guna2HtmlLabel1, 1, 1);
            this.tlpTrayDetail.Controls.Add(this.guna2HtmlLabel3, 1, 3);
            this.tlpTrayDetail.Controls.Add(this.guna2HtmlLabel4, 1, 4);
            this.tlpTrayDetail.Controls.Add(this.txtTotalQuantity, 2, 5);
            this.tlpTrayDetail.Controls.Add(this.guna2HtmlLabel5, 1, 5);
            this.tlpTrayDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTrayDetail.Location = new System.Drawing.Point(0, 0);
            this.tlpTrayDetail.Name = "tlpTrayDetail";
            this.tlpTrayDetail.RowCount = 6;
            this.tlpTrayDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpTrayDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpTrayDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpTrayDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpTrayDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpTrayDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpTrayDetail.Size = new System.Drawing.Size(585, 344);
            this.tlpTrayDetail.TabIndex = 26;
            // 
            // txtTrayIndex
            // 
            this.txtTrayIndex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTrayIndex.BorderRadius = 8;
            this.txtTrayIndex.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTrayIndex.DefaultText = "";
            this.txtTrayIndex.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTrayIndex.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTrayIndex.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTrayIndex.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTrayIndex.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTrayIndex.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrayIndex.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTrayIndex.Location = new System.Drawing.Point(236, 72);
            this.txtTrayIndex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTrayIndex.Name = "txtTrayIndex";
            this.txtTrayIndex.PasswordChar = '\0';
            this.txtTrayIndex.PlaceholderText = "";
            this.txtTrayIndex.SelectedText = "";
            this.txtTrayIndex.Size = new System.Drawing.Size(198, 36);
            this.txtTrayIndex.TabIndex = 10;
            this.txtTrayIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtToolCode
            // 
            this.txtToolCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToolCode.BorderRadius = 8;
            this.txtToolCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtToolCode.DefaultText = "";
            this.txtToolCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtToolCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtToolCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtToolCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtToolCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtToolCode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToolCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtToolCode.Location = new System.Drawing.Point(236, 123);
            this.txtToolCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtToolCode.Name = "txtToolCode";
            this.txtToolCode.PasswordChar = '\0';
            this.txtToolCode.PlaceholderText = "";
            this.txtToolCode.SelectedText = "";
            this.txtToolCode.Size = new System.Drawing.Size(198, 36);
            this.txtToolCode.TabIndex = 9;
            this.txtToolCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCurrentQuantity
            // 
            this.txtCurrentQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrentQuantity.BorderRadius = 8;
            this.txtCurrentQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurrentQuantity.DefaultText = "";
            this.txtCurrentQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCurrentQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCurrentQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrentQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrentQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCurrentQuantity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCurrentQuantity.Location = new System.Drawing.Point(236, 174);
            this.txtCurrentQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCurrentQuantity.Name = "txtCurrentQuantity";
            this.txtCurrentQuantity.PasswordChar = '\0';
            this.txtCurrentQuantity.PlaceholderText = "";
            this.txtCurrentQuantity.SelectedText = "";
            this.txtCurrentQuantity.Size = new System.Drawing.Size(198, 36);
            this.txtCurrentQuantity.TabIndex = 8;
            this.txtCurrentQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOperateQuantity
            // 
            this.txtOperateQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOperateQuantity.BorderRadius = 8;
            this.txtOperateQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOperateQuantity.DefaultText = "";
            this.txtOperateQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOperateQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOperateQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOperateQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOperateQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOperateQuantity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperateQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOperateQuantity.Location = new System.Drawing.Point(236, 225);
            this.txtOperateQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOperateQuantity.Name = "txtOperateQuantity";
            this.txtOperateQuantity.PasswordChar = '\0';
            this.txtOperateQuantity.PlaceholderText = "";
            this.txtOperateQuantity.SelectedText = "";
            this.txtOperateQuantity.Size = new System.Drawing.Size(198, 36);
            this.txtOperateQuantity.TabIndex = 7;
            this.txtOperateQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(197, 122);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(33, 45);
            this.guna2HtmlLabel2.TabIndex = 5;
            this.guna2HtmlLabel2.Text = "Tool";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(197, 71);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(33, 45);
            this.guna2HtmlLabel1.TabIndex = 6;
            this.guna2HtmlLabel1.Text = "Tray";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(97, 173);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(133, 45);
            this.guna2HtmlLabel3.TabIndex = 7;
            this.guna2HtmlLabel3.Text = "Số Lượng Hiện Có";
            this.guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(88, 224);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(142, 45);
            this.guna2HtmlLabel4.TabIndex = 8;
            this.guna2HtmlLabel4.Text = "Số Lượng Thao Tác";
            this.guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotalQuantity
            // 
            this.txtTotalQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalQuantity.BorderRadius = 8;
            this.txtTotalQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalQuantity.DefaultText = "";
            this.txtTotalQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalQuantity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalQuantity.Location = new System.Drawing.Point(236, 276);
            this.txtTotalQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalQuantity.Name = "txtTotalQuantity";
            this.txtTotalQuantity.PasswordChar = '\0';
            this.txtTotalQuantity.PlaceholderText = "";
            this.txtTotalQuantity.SelectedText = "";
            this.txtTotalQuantity.Size = new System.Drawing.Size(198, 36);
            this.txtTotalQuantity.TabIndex = 12;
            this.txtTotalQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(118, 275);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(112, 66);
            this.guna2HtmlLabel5.TabIndex = 11;
            this.guna2HtmlLabel5.Text = "Số Lượng Tổng";
            this.guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tlpFooter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 400);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 53);
            this.panel1.TabIndex = 10;
            // 
            // tlpFooter
            // 
            this.tlpFooter.ColumnCount = 6;
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpFooter.Controls.Add(this.btnSave, 4, 0);
            this.tlpFooter.Controls.Add(this.btnTakeOut, 1, 0);
            this.tlpFooter.Controls.Add(this.btnAddPlugin, 2, 0);
            this.tlpFooter.Controls.Add(this.btnAddNew, 3, 0);
            this.tlpFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFooter.Location = new System.Drawing.Point(0, 0);
            this.tlpFooter.Margin = new System.Windows.Forms.Padding(2);
            this.tlpFooter.Name = "tlpFooter";
            this.tlpFooter.RowCount = 1;
            this.tlpFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFooter.Size = new System.Drawing.Size(900, 53);
            this.tlpFooter.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BorderRadius = 22;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(603, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 47);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Lưu";
            // 
            // guna2Elipse_tlpToolList
            // 
            this.guna2Elipse_tlpToolList.BorderRadius = 20;
            this.guna2Elipse_tlpToolList.TargetControl = this.tlpTooList;
            // 
            // guna2Elipse_tlpTrayDetail
            // 
            this.guna2Elipse_tlpTrayDetail.BorderRadius = 20;
            this.guna2Elipse_tlpTrayDetail.TargetControl = this.tlpTrayDetail;
            // 
            // guna2Elipse_pToolContent
            // 
            this.guna2Elipse_pToolContent.BorderRadius = 20;
            this.guna2Elipse_pToolContent.TargetControl = this.pToolContent;
            // 
            // ToolManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 453);
            this.Controls.Add(this.tlpContent);
            this.Controls.Add(this.tlpHeader);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ToolManagerView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Công Cụ";
            this.tlpHeader.ResumeLayout(false);
            this.pLeftContent.ResumeLayout(false);
            this.pLeftContent.PerformLayout();
            this.tlpTooList.ResumeLayout(false);
            this.pToolContent.ResumeLayout(false);
            this.pToolContent.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlpContent.ResumeLayout(false);
            this.pRightContent.ResumeLayout(false);
            this.tlpTrayDetail.ResumeLayout(false);
            this.tlpTrayDetail.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tlpFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpHeader;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2GradientButton btnSearch;
        private Guna.UI2.WinForms.Guna2NotificationPaint notifiTakeout;
        private Guna.UI2.WinForms.Guna2NotificationPaint notifiAddPlugin;
        private Guna.UI2.WinForms.Guna2NotificationPaint notifiAddNew;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar_flpTrayList;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_pLeftContent;

        private System.Windows.Forms.TableLayoutPanel tlpTooList;
        // Header
        private Guna.UI2.WinForms.Guna2TextBox txtToolSearch;

        // Content
        private System.Windows.Forms.Panel pToolContent;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private System.Windows.Forms.Panel pLeftContent;
        private Guna.UI2.WinForms.Guna2GradientButton btnTakeOut;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddPlugin;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddNew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tlpFooter;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
        private System.Windows.Forms.Panel pRightContent;
        private System.Windows.Forms.TableLayoutPanel tlpTrayDetail;
        private Guna.UI2.WinForms.Guna2TextBox txtTrayIndex;
        private Guna.UI2.WinForms.Guna2TextBox txtToolCode;
        private Guna.UI2.WinForms.Guna2TextBox txtCurrentQuantity;
        private Guna.UI2.WinForms.Guna2TextBox txtOperateQuantity;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalQuantity;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2GradientButton btnToolCancel;
        private Guna.UI2.WinForms.Guna2GradientButton btnToolSelect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_tlpToolList;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_tlpTrayDetail;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_pToolContent;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar2;
        private System.Windows.Forms.FlowLayoutPanel flpToolList;
        private System.Windows.Forms.FlowLayoutPanel flpTrayList;
    }
}