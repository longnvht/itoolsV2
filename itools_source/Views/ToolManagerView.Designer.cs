using System.Windows.Forms;

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
            this._tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.btnTraySearch = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtTrayToolSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.notifiTakeout = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.btnTakeOut = new Guna.UI2.WinForms.Guna2GradientButton();
            this.notifiAddPlugin = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.btnAddPlugin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.notifiAddNew = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.btnAddNew = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2VScrollBar_flpTrayList = new Guna.UI2.WinForms.Guna2VScrollBar();
            this._flpTrayList = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Elipse_pLeftContent = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this._pLeftContent = new System.Windows.Forms.Panel();
            this.tlpToolList = new System.Windows.Forms.TableLayoutPanel();
            this.txtToolSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pToolContent = new System.Windows.Forms.Panel();
            this.guna2VScrollBar2 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.flpToolList = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnToolCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnToolSelect = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tlpContent = new System.Windows.Forms.TableLayoutPanel();
            this.pRightContent = new System.Windows.Forms.Panel();
            this._tlpTrayDetail = new System.Windows.Forms.TableLayoutPanel();
            this._txtTrayIndex = new Guna.UI2.WinForms.Guna2TextBox();
            this._txtToolCode = new Guna.UI2.WinForms.Guna2TextBox();
            this._txtCurrentQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this._txtOperateQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this._txtTotalQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Elipse_tlpToolList = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse_tlpTrayDetail = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse_pToolContent = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pFooter = new System.Windows.Forms.Panel();
            this._tlpFooter = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this._tlpHeader.SuspendLayout();
            this._pLeftContent.SuspendLayout();
            this.tlpToolList.SuspendLayout();
            this.pToolContent.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpContent.SuspendLayout();
            this.pRightContent.SuspendLayout();
            this._tlpTrayDetail.SuspendLayout();
            this.pFooter.SuspendLayout();
            this._tlpFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tlpHeader
            // 
            this._tlpHeader.ColumnCount = 2;
            this._tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.76768F));
            this._tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.23232F));
            this._tlpHeader.Controls.Add(this.btnTraySearch, 1, 0);
            this._tlpHeader.Controls.Add(this.txtTrayToolSearch, 0, 0);
            this._tlpHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this._tlpHeader.Location = new System.Drawing.Point(0, 0);
            this._tlpHeader.Name = "_tlpHeader";
            this._tlpHeader.RowCount = 1;
            this._tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tlpHeader.Size = new System.Drawing.Size(900, 50);
            this._tlpHeader.TabIndex = 11;
            // 
            // btnTraySearch
            // 
            this.btnTraySearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraySearch.Animated = true;
            this.btnTraySearch.AutoRoundedCorners = true;
            this.btnTraySearch.BorderRadius = 18;
            this.btnTraySearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTraySearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTraySearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTraySearch.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTraySearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTraySearch.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.btnTraySearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraySearch.ForeColor = System.Drawing.Color.White;
            this.btnTraySearch.Location = new System.Drawing.Point(693, 5);
            this.btnTraySearch.Name = "btnTraySearch";
            this.btnTraySearch.Size = new System.Drawing.Size(204, 39);
            this.btnTraySearch.TabIndex = 1;
            this.btnTraySearch.Text = "Tìm Kiếm Tray and Tool";
            // 
            // txtTrayToolSearch
            // 
            this.txtTrayToolSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTrayToolSearch.BorderRadius = 8;
            this.txtTrayToolSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTrayToolSearch.DefaultText = "";
            this.txtTrayToolSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTrayToolSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTrayToolSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTrayToolSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTrayToolSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTrayToolSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrayToolSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTrayToolSearch.Location = new System.Drawing.Point(3, 5);
            this.txtTrayToolSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTrayToolSearch.Name = "txtTrayToolSearch";
            this.txtTrayToolSearch.PasswordChar = '\0';
            this.txtTrayToolSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.txtTrayToolSearch.PlaceholderText = "Tìm Kiếm Tray and Tool";
            this.txtTrayToolSearch.SelectedText = "";
            this.txtTrayToolSearch.Size = new System.Drawing.Size(684, 39);
            this.txtTrayToolSearch.TabIndex = 0;
            this.txtTrayToolSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // notifiTakeout
            // 
            this.notifiTakeout.Alignment = Guna.UI2.WinForms.Enums.CustomContentAlignment.BottomRight;
            this.notifiTakeout.Location = new System.Drawing.Point(95, 9);
            this.notifiTakeout.Offset = new System.Drawing.Point(-24, -15);
            this.notifiTakeout.Size = new System.Drawing.Size(25, 18);
            this.notifiTakeout.TargetControl = this.btnTakeOut;
            this.notifiTakeout.Text = "Off";
            // 
            // btnTakeOut
            // 
            this.btnTakeOut.Animated = true;
            this.btnTakeOut.AutoRoundedCorners = true;
            this.btnTakeOut.BorderRadius = 20;
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
            this.btnTakeOut.Size = new System.Drawing.Size(144, 42);
            this.btnTakeOut.TabIndex = 3;
            this.btnTakeOut.Text = "Lấy Ra";
            // 
            // notifiAddPlugin
            // 
            this.notifiAddPlugin.Alignment = Guna.UI2.WinForms.Enums.CustomContentAlignment.BottomRight;
            this.notifiAddPlugin.Location = new System.Drawing.Point(100, 9);
            this.notifiAddPlugin.Offset = new System.Drawing.Point(-19, -15);
            this.notifiAddPlugin.Size = new System.Drawing.Size(25, 18);
            this.notifiAddPlugin.TargetControl = this.btnAddPlugin;
            this.notifiAddPlugin.Text = "Off";
            // 
            // btnAddPlugin
            // 
            this.btnAddPlugin.Animated = true;
            this.btnAddPlugin.AutoRoundedCorners = true;
            this.btnAddPlugin.BorderRadius = 20;
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
            this.btnAddPlugin.Size = new System.Drawing.Size(144, 42);
            this.btnAddPlugin.TabIndex = 4;
            this.btnAddPlugin.Text = "Bổ Sung";
            // 
            // notifiAddNew
            // 
            this.notifiAddNew.Alignment = Guna.UI2.WinForms.Enums.CustomContentAlignment.BottomRight;
            this.notifiAddNew.Location = new System.Drawing.Point(106, 9);
            this.notifiAddNew.Offset = new System.Drawing.Point(-13, -15);
            this.notifiAddNew.Size = new System.Drawing.Size(25, 18);
            this.notifiAddNew.TargetControl = this.btnAddNew;
            this.notifiAddNew.Text = "Off";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Animated = true;
            this.btnAddNew.AutoRoundedCorners = true;
            this.btnAddNew.BorderRadius = 20;
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
            this.btnAddNew.Size = new System.Drawing.Size(144, 42);
            this.btnAddNew.TabIndex = 5;
            this.btnAddNew.Text = "Thêm Mới";
            // 
            // guna2VScrollBar_flpTrayList
            // 
            this.guna2VScrollBar_flpTrayList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2VScrollBar_flpTrayList.AutoRoundedCorners = true;
            this.guna2VScrollBar_flpTrayList.AutoSize = true;
            this.guna2VScrollBar_flpTrayList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.guna2VScrollBar_flpTrayList.BindingContainer = this._flpTrayList;
            this.guna2VScrollBar_flpTrayList.BorderRadius = 8;
            this.guna2VScrollBar_flpTrayList.InUpdate = false;
            this.guna2VScrollBar_flpTrayList.LargeChange = 10;
            this.guna2VScrollBar_flpTrayList.Location = new System.Drawing.Point(285, 0);
            this.guna2VScrollBar_flpTrayList.Name = "guna2VScrollBar_flpTrayList";
            this.guna2VScrollBar_flpTrayList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.guna2VScrollBar_flpTrayList.ScrollbarSize = 18;
            this.guna2VScrollBar_flpTrayList.Size = new System.Drawing.Size(18, 349);
            this.guna2VScrollBar_flpTrayList.TabIndex = 20;
            this.guna2VScrollBar_flpTrayList.ThumbSize = 100F;
            // 
            // _flpTrayList
            // 
            this._flpTrayList.AutoScroll = true;
            this._flpTrayList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this._flpTrayList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flpTrayList.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this._flpTrayList.Location = new System.Drawing.Point(0, 0);
            this._flpTrayList.Margin = new System.Windows.Forms.Padding(2);
            this._flpTrayList.Name = "_flpTrayList";
            this._flpTrayList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._flpTrayList.Size = new System.Drawing.Size(303, 349);
            this._flpTrayList.TabIndex = 33;
            // 
            // guna2Elipse_pLeftContent
            // 
            this.guna2Elipse_pLeftContent.BorderRadius = 20;
            this.guna2Elipse_pLeftContent.TargetControl = this._pLeftContent;
            // 
            // _pLeftContent
            // 
            this._pLeftContent.Controls.Add(this.guna2VScrollBar_flpTrayList);
            this._pLeftContent.Controls.Add(this._flpTrayList);
            this._pLeftContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pLeftContent.Location = new System.Drawing.Point(3, 3);
            this._pLeftContent.Name = "_pLeftContent";
            this._pLeftContent.Size = new System.Drawing.Size(303, 349);
            this._pLeftContent.TabIndex = 0;
            // 
            // tlpToolList
            // 
            this.tlpToolList.AutoScroll = true;
            this.tlpToolList.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tlpToolList.ColumnCount = 1;
            this.tlpToolList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpToolList.Controls.Add(this.txtToolSearch, 0, 0);
            this.tlpToolList.Controls.Add(this.pToolContent, 0, 1);
            this.tlpToolList.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tlpToolList.Location = new System.Drawing.Point(262, 3);
            this.tlpToolList.Name = "tlpToolList";
            this.tlpToolList.RowCount = 3;
            this.tlpToolList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpToolList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpToolList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpToolList.Size = new System.Drawing.Size(320, 340);
            this.tlpToolList.TabIndex = 0;
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
            this.txtToolSearch.Location = new System.Drawing.Point(3, 6);
            this.txtToolSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtToolSearch.Name = "txtToolSearch";
            this.txtToolSearch.PasswordChar = '\0';
            this.txtToolSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.txtToolSearch.PlaceholderText = "Tìm Kiếm Tool";
            this.txtToolSearch.SelectedText = "";
            this.txtToolSearch.Size = new System.Drawing.Size(314, 39);
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
            this.guna2VScrollBar2.Location = new System.Drawing.Point(296, 0);
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
            this.btnToolSelect.Font = new System.Drawing.Font("Segoe UI", 11.25F);
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
            this.tlpContent.Controls.Add(this._pLeftContent, 0, 0);
            this.tlpContent.Controls.Add(this.pRightContent, 1, 0);
            this.tlpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContent.Location = new System.Drawing.Point(0, 50);
            this.tlpContent.Name = "tlpContent";
            this.tlpContent.RowCount = 1;
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 355F));
            this.tlpContent.Size = new System.Drawing.Size(900, 355);
            this.tlpContent.TabIndex = 12;
            // 
            // pRightContent
            // 
            this.pRightContent.Controls.Add(this.tlpToolList);
            this.pRightContent.Controls.Add(this._tlpTrayDetail);
            this.pRightContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pRightContent.Location = new System.Drawing.Point(312, 3);
            this.pRightContent.Name = "pRightContent";
            this.pRightContent.Size = new System.Drawing.Size(585, 349);
            this.pRightContent.TabIndex = 1;
            // 
            // _tlpTrayDetail
            // 
            this._tlpTrayDetail.ColumnCount = 4;
            this._tlpTrayDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._tlpTrayDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._tlpTrayDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this._tlpTrayDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._tlpTrayDetail.Controls.Add(this._txtTrayIndex, 2, 1);
            this._tlpTrayDetail.Controls.Add(this._txtToolCode, 2, 2);
            this._tlpTrayDetail.Controls.Add(this._txtCurrentQuantity, 2, 3);
            this._tlpTrayDetail.Controls.Add(this._txtOperateQuantity, 2, 4);
            this._tlpTrayDetail.Controls.Add(this.guna2HtmlLabel2, 1, 2);
            this._tlpTrayDetail.Controls.Add(this.guna2HtmlLabel1, 1, 1);
            this._tlpTrayDetail.Controls.Add(this.guna2HtmlLabel3, 1, 3);
            this._tlpTrayDetail.Controls.Add(this.guna2HtmlLabel4, 1, 4);
            this._tlpTrayDetail.Controls.Add(this._txtTotalQuantity, 2, 5);
            this._tlpTrayDetail.Controls.Add(this.guna2HtmlLabel5, 1, 5);
            this._tlpTrayDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tlpTrayDetail.Location = new System.Drawing.Point(0, 0);
            this._tlpTrayDetail.Name = "_tlpTrayDetail";
            this._tlpTrayDetail.RowCount = 6;
            this._tlpTrayDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this._tlpTrayDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._tlpTrayDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._tlpTrayDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._tlpTrayDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._tlpTrayDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this._tlpTrayDetail.Size = new System.Drawing.Size(585, 349);
            this._tlpTrayDetail.TabIndex = 26;
            // 
            // _txtTrayIndex
            // 
            this._txtTrayIndex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtTrayIndex.BorderRadius = 8;
            this._txtTrayIndex.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtTrayIndex.DefaultText = "";
            this._txtTrayIndex.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this._txtTrayIndex.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this._txtTrayIndex.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtTrayIndex.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtTrayIndex.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtTrayIndex.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtTrayIndex.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtTrayIndex.Location = new System.Drawing.Point(236, 45);
            this._txtTrayIndex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtTrayIndex.Name = "_txtTrayIndex";
            this._txtTrayIndex.PasswordChar = '\0';
            this._txtTrayIndex.PlaceholderText = "";
            this._txtTrayIndex.SelectedText = "";
            this._txtTrayIndex.Size = new System.Drawing.Size(257, 36);
            this._txtTrayIndex.TabIndex = 10;
            this._txtTrayIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _txtToolCode
            // 
            this._txtToolCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtToolCode.BorderRadius = 8;
            this._txtToolCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtToolCode.DefaultText = "";
            this._txtToolCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this._txtToolCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this._txtToolCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtToolCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtToolCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtToolCode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtToolCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtToolCode.Location = new System.Drawing.Point(236, 97);
            this._txtToolCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtToolCode.Name = "_txtToolCode";
            this._txtToolCode.PasswordChar = '\0';
            this._txtToolCode.PlaceholderText = "";
            this._txtToolCode.SelectedText = "";
            this._txtToolCode.Size = new System.Drawing.Size(257, 36);
            this._txtToolCode.TabIndex = 9;
            this._txtToolCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _txtCurrentQuantity
            // 
            this._txtCurrentQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtCurrentQuantity.BorderRadius = 8;
            this._txtCurrentQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtCurrentQuantity.DefaultText = "";
            this._txtCurrentQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this._txtCurrentQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this._txtCurrentQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtCurrentQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtCurrentQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtCurrentQuantity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtCurrentQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtCurrentQuantity.Location = new System.Drawing.Point(236, 149);
            this._txtCurrentQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtCurrentQuantity.Name = "_txtCurrentQuantity";
            this._txtCurrentQuantity.PasswordChar = '\0';
            this._txtCurrentQuantity.PlaceholderText = "";
            this._txtCurrentQuantity.SelectedText = "";
            this._txtCurrentQuantity.Size = new System.Drawing.Size(257, 36);
            this._txtCurrentQuantity.TabIndex = 8;
            this._txtCurrentQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _txtOperateQuantity
            // 
            this._txtOperateQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtOperateQuantity.BorderRadius = 8;
            this._txtOperateQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtOperateQuantity.DefaultText = "";
            this._txtOperateQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this._txtOperateQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this._txtOperateQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtOperateQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtOperateQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtOperateQuantity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtOperateQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtOperateQuantity.Location = new System.Drawing.Point(236, 201);
            this._txtOperateQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtOperateQuantity.Name = "_txtOperateQuantity";
            this._txtOperateQuantity.PasswordChar = '\0';
            this._txtOperateQuantity.PlaceholderText = "";
            this._txtOperateQuantity.SelectedText = "";
            this._txtOperateQuantity.Size = new System.Drawing.Size(257, 36);
            this._txtOperateQuantity.TabIndex = 7;
            this._txtOperateQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(197, 96);
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
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(197, 44);
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
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(97, 148);
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
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(88, 200);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(142, 46);
            this.guna2HtmlLabel4.TabIndex = 8;
            this.guna2HtmlLabel4.Text = "Số Lượng Thao Tác";
            this.guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _txtTotalQuantity
            // 
            this._txtTotalQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtTotalQuantity.BorderRadius = 8;
            this._txtTotalQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtTotalQuantity.DefaultText = "";
            this._txtTotalQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this._txtTotalQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this._txtTotalQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtTotalQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtTotalQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtTotalQuantity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtTotalQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtTotalQuantity.Location = new System.Drawing.Point(236, 253);
            this._txtTotalQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtTotalQuantity.Name = "_txtTotalQuantity";
            this._txtTotalQuantity.PasswordChar = '\0';
            this._txtTotalQuantity.PlaceholderText = "";
            this._txtTotalQuantity.SelectedText = "";
            this._txtTotalQuantity.Size = new System.Drawing.Size(257, 36);
            this._txtTotalQuantity.TabIndex = 12;
            this._txtTotalQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(118, 252);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(112, 94);
            this.guna2HtmlLabel5.TabIndex = 11;
            this.guna2HtmlLabel5.Text = "Số Lượng Tổng";
            this.guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse_tlpToolList
            // 
            this.guna2Elipse_tlpToolList.BorderRadius = 20;
            this.guna2Elipse_tlpToolList.TargetControl = this.tlpToolList;
            // 
            // guna2Elipse_tlpTrayDetail
            // 
            this.guna2Elipse_tlpTrayDetail.BorderRadius = 20;
            this.guna2Elipse_tlpTrayDetail.TargetControl = this._tlpTrayDetail;
            // 
            // guna2Elipse_pToolContent
            // 
            this.guna2Elipse_pToolContent.BorderRadius = 20;
            this.guna2Elipse_pToolContent.TargetControl = this.pToolContent;
            // 
            // pFooter
            // 
            this.pFooter.Controls.Add(this._tlpFooter);
            this.pFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pFooter.Location = new System.Drawing.Point(0, 405);
            this.pFooter.Margin = new System.Windows.Forms.Padding(2);
            this.pFooter.Name = "pFooter";
            this.pFooter.Size = new System.Drawing.Size(900, 48);
            this.pFooter.TabIndex = 10;
            // 
            // _tlpFooter
            // 
            this._tlpFooter.ColumnCount = 6;
            this._tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._tlpFooter.Controls.Add(this.btnSave, 4, 0);
            this._tlpFooter.Controls.Add(this.btnTakeOut, 1, 0);
            this._tlpFooter.Controls.Add(this.btnAddPlugin, 2, 0);
            this._tlpFooter.Controls.Add(this.btnAddNew, 3, 0);
            this._tlpFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tlpFooter.Location = new System.Drawing.Point(0, 0);
            this._tlpFooter.Margin = new System.Windows.Forms.Padding(2);
            this._tlpFooter.Name = "_tlpFooter";
            this._tlpFooter.RowCount = 1;
            this._tlpFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tlpFooter.Size = new System.Drawing.Size(900, 48);
            this._tlpFooter.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BorderRadius = 20;
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
            this.btnSave.Size = new System.Drawing.Size(144, 42);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Lưu";
            // 
            // ToolManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 453);
            this.Controls.Add(this.tlpContent);
            this.Controls.Add(this._tlpHeader);
            this.Controls.Add(this.pFooter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ToolManagerView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Công Cụ";
            this._tlpHeader.ResumeLayout(false);
            this._pLeftContent.ResumeLayout(false);
            this._pLeftContent.PerformLayout();
            this.tlpToolList.ResumeLayout(false);
            this.pToolContent.ResumeLayout(false);
            this.pToolContent.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlpContent.ResumeLayout(false);
            this.pRightContent.ResumeLayout(false);
            this._tlpTrayDetail.ResumeLayout(false);
            this._tlpTrayDetail.PerformLayout();
            this.pFooter.ResumeLayout(false);
            this._tlpFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel _flpTrayList;
        public FlowLayoutPanel flpTrayList
        {
            get { return _flpTrayList; }
            set { _flpTrayList = value; }
        }

        private Guna.UI2.WinForms.Guna2TextBox _txtTrayIndex;
        public Guna.UI2.WinForms.Guna2TextBox txtTrayIndex
        {
            get { return _txtTrayIndex; }
            set { _txtTrayIndex = value; }
        }

        private Guna.UI2.WinForms.Guna2TextBox _txtToolCode;
        public Guna.UI2.WinForms.Guna2TextBox txtToolCode
        {
            get { return _txtToolCode; }
            set { _txtToolCode = value; }
        }

        private Guna.UI2.WinForms.Guna2TextBox _txtCurrentQuantity;
        public Guna.UI2.WinForms.Guna2TextBox txtCurrentQuantity
        {
            get { return _txtCurrentQuantity; }
            set { _txtCurrentQuantity = value; }
        }

        private Guna.UI2.WinForms.Guna2TextBox _txtOperateQuantity;
        public Guna.UI2.WinForms.Guna2TextBox txtOperateQuantity
        {
            get { return _txtOperateQuantity; }
            set { _txtOperateQuantity = value; }
        }

        private System.Windows.Forms.TableLayoutPanel _tlpHeader;
        public System.Windows.Forms.TableLayoutPanel tlpHeader
        {
            get { return _tlpHeader; }
            set { _tlpHeader = value; }
        }

        private TableLayoutPanel _tlpFooter;
        public TableLayoutPanel tlpFooter
        {
            get { return _tlpFooter; }
            set { _tlpFooter = value; }
        }

        private System.Windows.Forms.Panel _pLeftContent;
        public System.Windows.Forms.Panel pLeftContent
        {
            get { return _pLeftContent; }
            set { _pLeftContent = value; }
        }

        private System.Windows.Forms.TableLayoutPanel _tlpTrayDetail;
        public System.Windows.Forms.TableLayoutPanel tlpTrayDetail
        {
            get { return _tlpTrayDetail; }
            set { _tlpTrayDetail = value; }
        }

        private Guna.UI2.WinForms.Guna2TextBox txtTrayToolSearch;
        private Guna.UI2.WinForms.Guna2GradientButton btnTraySearch;
        private Guna.UI2.WinForms.Guna2NotificationPaint notifiTakeout;
        private Guna.UI2.WinForms.Guna2NotificationPaint notifiAddPlugin;
        private Guna.UI2.WinForms.Guna2NotificationPaint notifiAddNew;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar_flpTrayList;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_pLeftContent;
        private System.Windows.Forms.TableLayoutPanel tlpToolList;
        private Guna.UI2.WinForms.Guna2TextBox txtToolSearch;
        private System.Windows.Forms.Panel pToolContent;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private System.Windows.Forms.Panel pRightContent;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox _txtTotalQuantity;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2GradientButton btnToolCancel;
        private Guna.UI2.WinForms.Guna2GradientButton btnToolSelect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_tlpToolList;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_tlpTrayDetail;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_pToolContent;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar2;
        private System.Windows.Forms.FlowLayoutPanel flpToolList;
        private Panel pFooter;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
        private Guna.UI2.WinForms.Guna2GradientButton btnTakeOut;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddPlugin;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddNew;
    }
}