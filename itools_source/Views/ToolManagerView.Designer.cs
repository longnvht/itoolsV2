using Guna.UI2.WinForms;
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
            this._txtTrayToolSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.notifiTakeout = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.btnTakeOut = new Guna.UI2.WinForms.Guna2GradientButton();
            this.notifiAddPlugin = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.btnAddPlugin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.notifiAddNew = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.btnAddNew = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2VScrollBar_flpTrayList = new Guna.UI2.WinForms.Guna2VScrollBar();
            this._flpTrayList = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Elipse_pLeftContent = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this._tlpTrayDetail = new System.Windows.Forms.TableLayoutPanel();
            this._txtTrayIndex = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this._txtTotalQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this._txtOperateQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this._txtCurrentQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this._txtToolCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Elipse_tlpToolList = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this._tlpToolList = new System.Windows.Forms.TableLayoutPanel();
            this._txtToolSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pToolContent = new System.Windows.Forms.Panel();
            this.guna2VScrollBar2 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.flpToolList = new System.Windows.Forms.FlowLayoutPanel();
            this.tlpFooterToolList = new System.Windows.Forms.TableLayoutPanel();
            this.btnToolCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnToolSelect = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Elipse_tlpTrayDetail = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse_pToolContent = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pFooter = new System.Windows.Forms.Panel();
            this._tlpFooter = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this._grbLeftContent = new System.Windows.Forms.GroupBox();
            this._grbToolList = new System.Windows.Forms.GroupBox();
            this._tlpHeader.SuspendLayout();
            this._tlpTrayDetail.SuspendLayout();
            this._tlpToolList.SuspendLayout();
            this.pToolContent.SuspendLayout();
            this.tlpFooterToolList.SuspendLayout();
            this.pFooter.SuspendLayout();
            this._tlpFooter.SuspendLayout();
            this._grbLeftContent.SuspendLayout();
            this._grbToolList.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tlpHeader
            // 
            this._tlpHeader.ColumnCount = 2;
            this._tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.76768F));
            this._tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.23232F));
            this._tlpHeader.Controls.Add(this.btnTraySearch, 1, 0);
            this._tlpHeader.Controls.Add(this._txtTrayToolSearch, 0, 0);
            this._tlpHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this._tlpHeader.Location = new System.Drawing.Point(0, 0);
            this._tlpHeader.Name = "_tlpHeader";
            this._tlpHeader.RowCount = 1;
            this._tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tlpHeader.Size = new System.Drawing.Size(1173, 50);
            this._tlpHeader.TabIndex = 11;
            // 
            // btnTraySearch
            // 
            this.btnTraySearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraySearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btnTraySearch.BorderRadius = 10;
            this.btnTraySearch.BorderThickness = 1;
            this.btnTraySearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTraySearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTraySearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTraySearch.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTraySearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTraySearch.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnTraySearch.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.btnTraySearch.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnTraySearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTraySearch.Location = new System.Drawing.Point(903, 5);
            this.btnTraySearch.Name = "btnTraySearch";
            this.btnTraySearch.Size = new System.Drawing.Size(267, 39);
            this.btnTraySearch.TabIndex = 1;
            this.btnTraySearch.Text = "Tìm Kiếm Tray and Tool";
            // 
            // _txtTrayToolSearch
            // 
            this._txtTrayToolSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._txtTrayToolSearch.BorderRadius = 10;
            this._txtTrayToolSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtTrayToolSearch.DefaultText = "";
            this._txtTrayToolSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this._txtTrayToolSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this._txtTrayToolSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtTrayToolSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtTrayToolSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtTrayToolSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this._txtTrayToolSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtTrayToolSearch.Location = new System.Drawing.Point(3, 5);
            this._txtTrayToolSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtTrayToolSearch.Name = "_txtTrayToolSearch";
            this._txtTrayToolSearch.PasswordChar = '\0';
            this._txtTrayToolSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this._txtTrayToolSearch.PlaceholderText = "Tìm Kiếm Tray and Tool";
            this._txtTrayToolSearch.SelectedText = "";
            this._txtTrayToolSearch.Size = new System.Drawing.Size(894, 39);
            this._txtTrayToolSearch.TabIndex = 0;
            this._txtTrayToolSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnTakeOut.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btnTakeOut.BorderRadius = 10;
            this.btnTakeOut.BorderThickness = 1;
            this.btnTakeOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTakeOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTakeOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTakeOut.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTakeOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTakeOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTakeOut.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnTakeOut.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.btnTakeOut.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnTakeOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTakeOut.Location = new System.Drawing.Point(289, 3);
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
            this.btnAddPlugin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btnAddPlugin.BorderRadius = 10;
            this.btnAddPlugin.BorderThickness = 1;
            this.btnAddPlugin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPlugin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPlugin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPlugin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPlugin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddPlugin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddPlugin.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddPlugin.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.btnAddPlugin.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnAddPlugin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAddPlugin.Location = new System.Drawing.Point(439, 3);
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
            this.btnAddNew.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btnAddNew.BorderRadius = 10;
            this.btnAddNew.BorderThickness = 1;
            this.btnAddNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNew.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddNew.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddNew.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.btnAddNew.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnAddNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAddNew.Location = new System.Drawing.Point(589, 3);
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
            this.guna2VScrollBar_flpTrayList.Location = new System.Drawing.Point(302, 20);
            this.guna2VScrollBar_flpTrayList.Name = "guna2VScrollBar_flpTrayList";
            this.guna2VScrollBar_flpTrayList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.guna2VScrollBar_flpTrayList.ScrollbarSize = 18;
            this.guna2VScrollBar_flpTrayList.Size = new System.Drawing.Size(18, 387);
            this.guna2VScrollBar_flpTrayList.TabIndex = 20;
            this.guna2VScrollBar_flpTrayList.ThumbSize = 100F;
            // 
            // _flpTrayList
            // 
            this._flpTrayList.AutoScroll = true;
            this._flpTrayList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this._flpTrayList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flpTrayList.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this._flpTrayList.Location = new System.Drawing.Point(3, 20);
            this._flpTrayList.Margin = new System.Windows.Forms.Padding(2);
            this._flpTrayList.Name = "_flpTrayList";
            this._flpTrayList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._flpTrayList.Size = new System.Drawing.Size(317, 387);
            this._flpTrayList.TabIndex = 34;
            // 
            // guna2Elipse_pLeftContent
            // 
            this.guna2Elipse_pLeftContent.BorderRadius = 20;
            // 
            // _tlpTrayDetail
            // 
            this._tlpTrayDetail.ColumnCount = 3;
            this._tlpTrayDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tlpTrayDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this._tlpTrayDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tlpTrayDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._tlpTrayDetail.Controls.Add(this._txtTrayIndex, 1, 2);
            this._tlpTrayDetail.Controls.Add(this.guna2HtmlLabel1, 1, 1);
            this._tlpTrayDetail.Controls.Add(this._txtTotalQuantity, 1, 10);
            this._tlpTrayDetail.Controls.Add(this.guna2HtmlLabel5, 1, 9);
            this._tlpTrayDetail.Controls.Add(this._txtOperateQuantity, 1, 8);
            this._tlpTrayDetail.Controls.Add(this.guna2HtmlLabel4, 1, 7);
            this._tlpTrayDetail.Controls.Add(this._txtCurrentQuantity, 1, 6);
            this._tlpTrayDetail.Controls.Add(this.guna2HtmlLabel3, 1, 5);
            this._tlpTrayDetail.Controls.Add(this._txtToolCode, 1, 4);
            this._tlpTrayDetail.Controls.Add(this.guna2HtmlLabel2, 1, 3);
            this._tlpTrayDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tlpTrayDetail.Location = new System.Drawing.Point(323, 50);
            this._tlpTrayDetail.Name = "_tlpTrayDetail";
            this._tlpTrayDetail.RowCount = 12;
            this._tlpTrayDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tlpTrayDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this._tlpTrayDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this._tlpTrayDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this._tlpTrayDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this._tlpTrayDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this._tlpTrayDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this._tlpTrayDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this._tlpTrayDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this._tlpTrayDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this._tlpTrayDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this._tlpTrayDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tlpTrayDetail.Size = new System.Drawing.Size(850, 410);
            this._tlpTrayDetail.TabIndex = 27;
            // 
            // _txtTrayIndex
            // 
            this._txtTrayIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this._txtTrayIndex.Location = new System.Drawing.Point(303, 51);
            this._txtTrayIndex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtTrayIndex.Name = "_txtTrayIndex";
            this._txtTrayIndex.PasswordChar = '\0';
            this._txtTrayIndex.PlaceholderText = "";
            this._txtTrayIndex.SelectedText = "";
            this._txtTrayIndex.Size = new System.Drawing.Size(244, 36);
            this._txtTrayIndex.TabIndex = 10;
            this._txtTrayIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(303, 20);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(33, 22);
            this.guna2HtmlLabel1.TabIndex = 6;
            this.guna2HtmlLabel1.Text = "Tray";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _txtTotalQuantity
            // 
            this._txtTotalQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this._txtTotalQuantity.Location = new System.Drawing.Point(303, 351);
            this._txtTotalQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtTotalQuantity.Name = "_txtTotalQuantity";
            this._txtTotalQuantity.PasswordChar = '\0';
            this._txtTotalQuantity.PlaceholderText = "";
            this._txtTotalQuantity.SelectedText = "";
            this._txtTotalQuantity.Size = new System.Drawing.Size(244, 36);
            this._txtTotalQuantity.TabIndex = 12;
            this._txtTotalQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(303, 320);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(112, 22);
            this.guna2HtmlLabel5.TabIndex = 11;
            this.guna2HtmlLabel5.Text = "Số Lượng Tổng";
            this.guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _txtOperateQuantity
            // 
            this._txtOperateQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this._txtOperateQuantity.Location = new System.Drawing.Point(303, 276);
            this._txtOperateQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtOperateQuantity.Name = "_txtOperateQuantity";
            this._txtOperateQuantity.PasswordChar = '\0';
            this._txtOperateQuantity.PlaceholderText = "";
            this._txtOperateQuantity.SelectedText = "";
            this._txtOperateQuantity.Size = new System.Drawing.Size(244, 36);
            this._txtOperateQuantity.TabIndex = 7;
            this._txtOperateQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(303, 245);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(142, 22);
            this.guna2HtmlLabel4.TabIndex = 8;
            this.guna2HtmlLabel4.Text = "Số Lượng Thao Tác";
            this.guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _txtCurrentQuantity
            // 
            this._txtCurrentQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this._txtCurrentQuantity.Location = new System.Drawing.Point(303, 201);
            this._txtCurrentQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtCurrentQuantity.Name = "_txtCurrentQuantity";
            this._txtCurrentQuantity.PasswordChar = '\0';
            this._txtCurrentQuantity.PlaceholderText = "";
            this._txtCurrentQuantity.SelectedText = "";
            this._txtCurrentQuantity.Size = new System.Drawing.Size(244, 36);
            this._txtCurrentQuantity.TabIndex = 8;
            this._txtCurrentQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(303, 170);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(133, 22);
            this.guna2HtmlLabel3.TabIndex = 7;
            this.guna2HtmlLabel3.Text = "Số Lượng Hiện Có";
            this.guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _txtToolCode
            // 
            this._txtToolCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this._txtToolCode.Location = new System.Drawing.Point(303, 126);
            this._txtToolCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtToolCode.Name = "_txtToolCode";
            this._txtToolCode.PasswordChar = '\0';
            this._txtToolCode.PlaceholderText = "";
            this._txtToolCode.SelectedText = "";
            this._txtToolCode.Size = new System.Drawing.Size(244, 36);
            this._txtToolCode.TabIndex = 9;
            this._txtToolCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(303, 95);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(33, 22);
            this.guna2HtmlLabel2.TabIndex = 5;
            this.guna2HtmlLabel2.Text = "Tool";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse_tlpToolList
            // 
            this.guna2Elipse_tlpToolList.BorderRadius = 20;
            this.guna2Elipse_tlpToolList.TargetControl = this._tlpToolList;
            // 
            // _tlpToolList
            // 
            this._tlpToolList.AutoScroll = true;
            this._tlpToolList.BackColor = System.Drawing.SystemColors.ScrollBar;
            this._tlpToolList.ColumnCount = 1;
            this._tlpToolList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tlpToolList.Controls.Add(this._txtToolSearch, 0, 0);
            this._tlpToolList.Controls.Add(this.pToolContent, 0, 1);
            this._tlpToolList.Controls.Add(this.tlpFooterToolList, 0, 2);
            this._tlpToolList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tlpToolList.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tlpToolList.Location = new System.Drawing.Point(3, 20);
            this._tlpToolList.Name = "_tlpToolList";
            this._tlpToolList.RowCount = 3;
            this._tlpToolList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._tlpToolList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this._tlpToolList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._tlpToolList.Size = new System.Drawing.Size(355, 387);
            this._tlpToolList.TabIndex = 13;
            // 
            // _txtToolSearch
            // 
            this._txtToolSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._txtToolSearch.BorderRadius = 8;
            this._txtToolSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtToolSearch.DefaultText = "";
            this._txtToolSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this._txtToolSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this._txtToolSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtToolSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtToolSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtToolSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this._txtToolSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtToolSearch.Location = new System.Drawing.Point(3, 9);
            this._txtToolSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtToolSearch.Name = "_txtToolSearch";
            this._txtToolSearch.PasswordChar = '\0';
            this._txtToolSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this._txtToolSearch.PlaceholderText = "Tìm Kiếm Tool";
            this._txtToolSearch.SelectedText = "";
            this._txtToolSearch.Size = new System.Drawing.Size(349, 39);
            this._txtToolSearch.TabIndex = 28;
            this._txtToolSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pToolContent
            // 
            this.pToolContent.Controls.Add(this.guna2VScrollBar2);
            this.pToolContent.Controls.Add(this.flpToolList);
            this.pToolContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pToolContent.Location = new System.Drawing.Point(3, 61);
            this.pToolContent.Name = "pToolContent";
            this.pToolContent.Size = new System.Drawing.Size(349, 264);
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
            this.guna2VScrollBar2.Location = new System.Drawing.Point(331, 0);
            this.guna2VScrollBar2.Name = "guna2VScrollBar2";
            this.guna2VScrollBar2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.guna2VScrollBar2.ScrollbarSize = 18;
            this.guna2VScrollBar2.Size = new System.Drawing.Size(18, 264);
            this.guna2VScrollBar2.TabIndex = 28;
            this.guna2VScrollBar2.ThumbSize = 100F;
            // 
            // flpToolList
            // 
            this.flpToolList.AutoScroll = true;
            this.flpToolList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.flpToolList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpToolList.Location = new System.Drawing.Point(0, 0);
            this.flpToolList.Margin = new System.Windows.Forms.Padding(2);
            this.flpToolList.Name = "flpToolList";
            this.flpToolList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flpToolList.Size = new System.Drawing.Size(349, 264);
            this.flpToolList.TabIndex = 29;
            // 
            // tlpFooterToolList
            // 
            this.tlpFooterToolList.ColumnCount = 2;
            this.tlpFooterToolList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFooterToolList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFooterToolList.Controls.Add(this.btnToolCancel, 1, 0);
            this.tlpFooterToolList.Controls.Add(this.btnToolSelect, 0, 0);
            this.tlpFooterToolList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFooterToolList.Location = new System.Drawing.Point(3, 331);
            this.tlpFooterToolList.Name = "tlpFooterToolList";
            this.tlpFooterToolList.RowCount = 1;
            this.tlpFooterToolList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFooterToolList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tlpFooterToolList.Size = new System.Drawing.Size(349, 53);
            this.tlpFooterToolList.TabIndex = 30;
            // 
            // btnToolCancel
            // 
            this.btnToolCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToolCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btnToolCancel.BorderRadius = 10;
            this.btnToolCancel.BorderThickness = 1;
            this.btnToolCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnToolCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnToolCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnToolCancel.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnToolCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnToolCancel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnToolCancel.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.btnToolCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnToolCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnToolCancel.Location = new System.Drawing.Point(177, 8);
            this.btnToolCancel.Name = "btnToolCancel";
            this.btnToolCancel.Size = new System.Drawing.Size(169, 36);
            this.btnToolCancel.TabIndex = 30;
            this.btnToolCancel.Text = "Hủy";
            // 
            // btnToolSelect
            // 
            this.btnToolSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToolSelect.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btnToolSelect.BorderRadius = 10;
            this.btnToolSelect.BorderThickness = 1;
            this.btnToolSelect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnToolSelect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnToolSelect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnToolSelect.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnToolSelect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnToolSelect.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnToolSelect.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.btnToolSelect.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnToolSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnToolSelect.Location = new System.Drawing.Point(3, 8);
            this.btnToolSelect.Name = "btnToolSelect";
            this.btnToolSelect.Size = new System.Drawing.Size(168, 36);
            this.btnToolSelect.TabIndex = 29;
            this.btnToolSelect.Text = "Chọn";
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
            this.pFooter.Location = new System.Drawing.Point(0, 460);
            this.pFooter.Margin = new System.Windows.Forms.Padding(2);
            this.pFooter.Name = "pFooter";
            this.pFooter.Size = new System.Drawing.Size(1173, 48);
            this.pFooter.TabIndex = 10;
            // 
            // _tlpFooter
            // 
            this._tlpFooter.ColumnCount = 6;
            this._tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this._tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this._tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this._tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this._tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
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
            this._tlpFooter.Size = new System.Drawing.Size(1173, 48);
            this._tlpFooter.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btnSave.BorderRadius = 10;
            this.btnSave.BorderThickness = 1;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSave.Location = new System.Drawing.Point(739, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 42);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Lưu";
            // 
            // _grbLeftContent
            // 
            this._grbLeftContent.Controls.Add(this.guna2VScrollBar_flpTrayList);
            this._grbLeftContent.Controls.Add(this._flpTrayList);
            this._grbLeftContent.Dock = System.Windows.Forms.DockStyle.Left;
            this._grbLeftContent.Location = new System.Drawing.Point(0, 50);
            this._grbLeftContent.Name = "_grbLeftContent";
            this._grbLeftContent.Size = new System.Drawing.Size(323, 410);
            this._grbLeftContent.TabIndex = 14;
            this._grbLeftContent.TabStop = false;
            this._grbLeftContent.Text = "Tool on machine";
            // 
            // _grbToolList
            // 
            this._grbToolList.Controls.Add(this._tlpToolList);
            this._grbToolList.Dock = System.Windows.Forms.DockStyle.Right;
            this._grbToolList.Location = new System.Drawing.Point(812, 50);
            this._grbToolList.Name = "_grbToolList";
            this._grbToolList.Size = new System.Drawing.Size(361, 410);
            this._grbToolList.TabIndex = 28;
            this._grbToolList.TabStop = false;
            this._grbToolList.Text = "Tool List";
            // 
            // ToolManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1173, 508);
            this.Controls.Add(this._grbToolList);
            this.Controls.Add(this._tlpTrayDetail);
            this.Controls.Add(this._grbLeftContent);
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
            this._tlpTrayDetail.ResumeLayout(false);
            this._tlpTrayDetail.PerformLayout();
            this._tlpToolList.ResumeLayout(false);
            this.pToolContent.ResumeLayout(false);
            this.pToolContent.PerformLayout();
            this.tlpFooterToolList.ResumeLayout(false);
            this.pFooter.ResumeLayout(false);
            this._tlpFooter.ResumeLayout(false);
            this._grbLeftContent.ResumeLayout(false);
            this._grbLeftContent.PerformLayout();
            this._grbToolList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public FlowLayoutPanel flpTrayList
        {
            get { return _flpTrayList; }
            set { _flpTrayList = value; }
        }
        public Guna.UI2.WinForms.Guna2TextBox txtTrayIndex
        {
            get { return _txtTrayIndex; }
            set { _txtTrayIndex = value; }
        }
        public Guna.UI2.WinForms.Guna2TextBox txtToolCode
        {
            get { return _txtToolCode; }
            set { _txtToolCode = value; }
        }
        public Guna.UI2.WinForms.Guna2TextBox txtCurrentQuantity
        {
            get { return _txtCurrentQuantity; }
            set { _txtCurrentQuantity = value; }
        }
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
        public TableLayoutPanel tlpFooter
        {
            get { return _tlpFooter; }
            set { _tlpFooter = value; }
        }
        public System.Windows.Forms.GroupBox grbLeftContent
        {
            get { return _grbLeftContent; }
            set { _grbLeftContent = value; }
        }
        public System.Windows.Forms.TableLayoutPanel tlpTrayDetail
        {
            get { return _tlpTrayDetail; }
            set { _tlpTrayDetail = value; }
        }

        public Guna2TextBox txtToolSearch { get => _txtToolSearch; set => _txtToolSearch = value; }
        public Guna2TextBox txtTrayToolSearch { get => _txtTrayToolSearch; set => _txtTrayToolSearch = value; }
        public GroupBox grbToolList { get => _grbToolList; set => _grbToolList = value; }

        private Guna.UI2.WinForms.Guna2TextBox _txtTrayToolSearch;
        private Guna.UI2.WinForms.Guna2GradientButton btnTraySearch;
        private Guna.UI2.WinForms.Guna2NotificationPaint notifiTakeout;
        private Guna.UI2.WinForms.Guna2NotificationPaint notifiAddPlugin;
        private Guna.UI2.WinForms.Guna2NotificationPaint notifiAddNew;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar_flpTrayList;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_pLeftContent;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_tlpToolList;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_tlpTrayDetail;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_pToolContent;
        private FlowLayoutPanel _flpTrayList;
        private Panel pFooter;
        private Guna2GradientButton btnTakeOut;
        private Guna2GradientButton btnAddPlugin;
        private Guna2GradientButton btnAddNew;
        private TableLayoutPanel _tlpFooter;
        private Guna2GradientButton btnSave;
        private TableLayoutPanel _tlpTrayDetail;
        private Guna2TextBox _txtTrayIndex;
        private Guna2TextBox _txtToolCode;
        private Guna2TextBox _txtCurrentQuantity;
        private Guna2TextBox _txtOperateQuantity;
        private Guna2HtmlLabel guna2HtmlLabel2;
        private Guna2HtmlLabel guna2HtmlLabel1;
        private Guna2HtmlLabel guna2HtmlLabel3;
        private Guna2HtmlLabel guna2HtmlLabel4;
        private Guna2TextBox _txtTotalQuantity;
        private Guna2HtmlLabel guna2HtmlLabel5;
        private TableLayoutPanel _tlpToolList;
        private Guna2TextBox _txtToolSearch;
        private Panel pToolContent;
        private Guna2VScrollBar guna2VScrollBar2;
        private FlowLayoutPanel flpToolList;
        private TableLayoutPanel tlpFooterToolList;
        private Guna2GradientButton btnToolCancel;
        private Guna2GradientButton btnToolSelect;
        private GroupBox _grbLeftContent;
        private GroupBox _grbToolList;
    }
}