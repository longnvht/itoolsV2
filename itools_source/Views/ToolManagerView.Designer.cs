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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlpFooter = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnTakeOut = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAddPlugin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAddNew = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.notifiTakeout = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.notifiAddPlugin = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.notifiAddNew = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.flpListTray = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.tlpDetailTray = new System.Windows.Forms.TableLayoutPanel();
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tlpTooList = new System.Windows.Forms.TableLayoutPanel();
            this.pToolFooter = new System.Windows.Forms.Panel();
            this.btnToolCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnToolSelect = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnToolSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pToolContent = new System.Windows.Forms.Panel();
            this.guna2VScrollBar2 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.flpListTool = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.tlpFooter.SuspendLayout();
            this.tlpHeader.SuspendLayout();
            this.tlpDetailTray.SuspendLayout();
            this.tlpTooList.SuspendLayout();
            this.pToolFooter.SuspendLayout();
            this.pToolContent.SuspendLayout();
            this.SuspendLayout();
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
            this.tlpFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
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
            // notifiAddPlugin
            // 
            this.notifiAddPlugin.Alignment = Guna.UI2.WinForms.Enums.CustomContentAlignment.BottomRight;
            this.notifiAddPlugin.Location = new System.Drawing.Point(100, 14);
            this.notifiAddPlugin.Offset = new System.Drawing.Point(-19, -15);
            this.notifiAddPlugin.Size = new System.Drawing.Size(25, 18);
            this.notifiAddPlugin.TargetControl = this.btnAddPlugin;
            this.notifiAddPlugin.Text = "Off";
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
            // flpListTray
            // 
            this.flpListTray.AutoScroll = true;
            this.flpListTray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.flpListTray.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpListTray.Location = new System.Drawing.Point(0, 50);
            this.flpListTray.Margin = new System.Windows.Forms.Padding(2);
            this.flpListTray.Name = "flpListTray";
            this.flpListTray.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flpListTray.Size = new System.Drawing.Size(310, 350);
            this.flpListTray.TabIndex = 2;
            // 
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.AutoRoundedCorners = true;
            this.guna2VScrollBar1.AutoSize = true;
            this.guna2VScrollBar1.BindingContainer = this.flpListTray;
            this.guna2VScrollBar1.BorderRadius = 8;
            this.guna2VScrollBar1.InUpdate = false;
            this.guna2VScrollBar1.LargeChange = 10;
            this.guna2VScrollBar1.Location = new System.Drawing.Point(292, 50);
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.guna2VScrollBar1.ScrollbarSize = 18;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(18, 350);
            this.guna2VScrollBar1.TabIndex = 20;
            this.guna2VScrollBar1.ThumbSize = 100F;
            // 
            // tlpDetailTray
            // 
            this.tlpDetailTray.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpDetailTray.ColumnCount = 4;
            this.tlpDetailTray.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpDetailTray.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpDetailTray.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpDetailTray.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDetailTray.Controls.Add(this.txtTrayIndex, 2, 1);
            this.tlpDetailTray.Controls.Add(this.txtToolCode, 2, 2);
            this.tlpDetailTray.Controls.Add(this.txtCurrentQuantity, 2, 3);
            this.tlpDetailTray.Controls.Add(this.txtOperateQuantity, 2, 4);
            this.tlpDetailTray.Controls.Add(this.guna2HtmlLabel2, 1, 2);
            this.tlpDetailTray.Controls.Add(this.guna2HtmlLabel1, 1, 1);
            this.tlpDetailTray.Controls.Add(this.guna2HtmlLabel3, 1, 3);
            this.tlpDetailTray.Controls.Add(this.guna2HtmlLabel4, 1, 4);
            this.tlpDetailTray.Controls.Add(this.txtTotalQuantity, 2, 5);
            this.tlpDetailTray.Controls.Add(this.guna2HtmlLabel5, 1, 5);
            this.tlpDetailTray.Location = new System.Drawing.Point(310, 50);
            this.tlpDetailTray.Name = "tlpDetailTray";
            this.tlpDetailTray.RowCount = 6;
            this.tlpDetailTray.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpDetailTray.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpDetailTray.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpDetailTray.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpDetailTray.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpDetailTray.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpDetailTray.Size = new System.Drawing.Size(590, 350);
            this.tlpDetailTray.TabIndex = 22;
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
            this.txtTrayIndex.Location = new System.Drawing.Point(239, 74);
            this.txtTrayIndex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTrayIndex.Name = "txtTrayIndex";
            this.txtTrayIndex.PasswordChar = '\0';
            this.txtTrayIndex.PlaceholderText = "";
            this.txtTrayIndex.SelectedText = "";
            this.txtTrayIndex.Size = new System.Drawing.Size(200, 36);
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
            this.txtToolCode.Location = new System.Drawing.Point(239, 126);
            this.txtToolCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtToolCode.Name = "txtToolCode";
            this.txtToolCode.PasswordChar = '\0';
            this.txtToolCode.PlaceholderText = "";
            this.txtToolCode.SelectedText = "";
            this.txtToolCode.Size = new System.Drawing.Size(200, 36);
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
            this.txtCurrentQuantity.Location = new System.Drawing.Point(239, 178);
            this.txtCurrentQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCurrentQuantity.Name = "txtCurrentQuantity";
            this.txtCurrentQuantity.PasswordChar = '\0';
            this.txtCurrentQuantity.PlaceholderText = "";
            this.txtCurrentQuantity.SelectedText = "";
            this.txtCurrentQuantity.Size = new System.Drawing.Size(200, 36);
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
            this.txtOperateQuantity.Location = new System.Drawing.Point(239, 230);
            this.txtOperateQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOperateQuantity.Name = "txtOperateQuantity";
            this.txtOperateQuantity.PasswordChar = '\0';
            this.txtOperateQuantity.PlaceholderText = "";
            this.txtOperateQuantity.SelectedText = "";
            this.txtOperateQuantity.Size = new System.Drawing.Size(200, 36);
            this.txtOperateQuantity.TabIndex = 7;
            this.txtOperateQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(200, 125);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(33, 46);
            this.guna2HtmlLabel2.TabIndex = 5;
            this.guna2HtmlLabel2.Text = "Tool";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(200, 73);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(33, 46);
            this.guna2HtmlLabel1.TabIndex = 6;
            this.guna2HtmlLabel1.Text = "Tray";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(100, 177);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(133, 46);
            this.guna2HtmlLabel3.TabIndex = 7;
            this.guna2HtmlLabel3.Text = "Số Lượng Hiện Có";
            this.guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(91, 229);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(142, 46);
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
            this.txtTotalQuantity.Location = new System.Drawing.Point(239, 282);
            this.txtTotalQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalQuantity.Name = "txtTotalQuantity";
            this.txtTotalQuantity.PasswordChar = '\0';
            this.txtTotalQuantity.PlaceholderText = "";
            this.txtTotalQuantity.SelectedText = "";
            this.txtTotalQuantity.Size = new System.Drawing.Size(200, 36);
            this.txtTotalQuantity.TabIndex = 12;
            this.txtTotalQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(121, 281);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(112, 66);
            this.guna2HtmlLabel5.TabIndex = 11;
            this.guna2HtmlLabel5.Text = "Số Lượng Tổng";
            this.guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.flpListTray;
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
            this.tlpTooList.Location = new System.Drawing.Point(560, 50);
            this.tlpTooList.Name = "tlpTooList";
            this.tlpTooList.RowCount = 3;
            this.tlpTooList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpTooList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76F));
            this.tlpTooList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpTooList.Size = new System.Drawing.Size(320, 350);
            this.tlpTooList.TabIndex = 27;
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
            // ToolManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 453);
            this.Controls.Add(this.tlpDetailTray);
            this.Controls.Add(this.guna2VScrollBar1);
            this.Controls.Add(this.flpListTray);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tlpHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ToolManagerView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Và Lấy Công Cụ";
            this.panel1.ResumeLayout(false);
            this.tlpFooter.ResumeLayout(false);
            this.tlpHeader.ResumeLayout(false);
            this.tlpDetailTray.ResumeLayout(false);
            this.tlpDetailTray.PerformLayout();
            this.tlpTooList.ResumeLayout(false);
            this.pToolFooter.ResumeLayout(false);
            this.pToolContent.ResumeLayout(false);
            this.pToolContent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tlpFooter;
        private System.Windows.Forms.TableLayoutPanel tlpHeader;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddNew;
        private Guna.UI2.WinForms.Guna2GradientButton btnTakeOut;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddPlugin;
        private Guna.UI2.WinForms.Guna2GradientButton btnSearch;
        private Guna.UI2.WinForms.Guna2NotificationPaint notifiTakeout;
        private Guna.UI2.WinForms.Guna2NotificationPaint notifiAddPlugin;
        private Guna.UI2.WinForms.Guna2NotificationPaint notifiAddNew;
        private System.Windows.Forms.FlowLayoutPanel flpListTray;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
        private System.Windows.Forms.TableLayoutPanel tlpDetailTray;
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
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;

        private System.Windows.Forms.TableLayoutPanel tlpTooList;
        // Header
        private Guna.UI2.WinForms.Guna2TextBox btnToolSearch;

        // Content
        private System.Windows.Forms.Panel pToolContent;
        private System.Windows.Forms.FlowLayoutPanel flpListTool;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar2;

        // Footer
        private System.Windows.Forms.Panel pToolFooter;
        private Guna.UI2.WinForms.Guna2GradientButton btnToolSelect;
        private Guna.UI2.WinForms.Guna2GradientButton btnToolCancel;
    }
}