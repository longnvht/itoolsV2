using Guna.UI2.WinForms;

namespace itools_source.Views
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetToolView));
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this._btnSearch = new Guna.UI2.WinForms.Guna2GradientButton();
            this._txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.tlpContent = new System.Windows.Forms.TableLayoutPanel();
            this.pLeftContent = new System.Windows.Forms.Panel();
            this.guna2VScrollBar_flpToolList = new Guna.UI2.WinForms.Guna2VScrollBar();
            this._flpToolList = new System.Windows.Forms.FlowLayoutPanel();
            this.tlpRightContent = new System.Windows.Forms.TableLayoutPanel();
            this._txtToolCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._txtModel = new Guna.UI2.WinForms.Guna2TextBox();
            this._txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this._tlpToolSelect = new System.Windows.Forms.TableLayoutPanel();
            this._btnToolSelect = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Elipse_flpToolList = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse_tlpTooMachineList = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse_flpTrayMachineList = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.serialPort_GetTool = new System.IO.Ports.SerialPort(this.components);
            this.guna2Elipse_tlpToolMachineList = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this._tlpToolMachineList = new System.Windows.Forms.TableLayoutPanel();
            this.pToolContent = new System.Windows.Forms.Panel();
            this.guna2VScrollBar_flpToolMachineList = new Guna.UI2.WinForms.Guna2VScrollBar();
            this._flpTrayMachineList = new System.Windows.Forms.FlowLayoutPanel();
            this.tlpToolMachineFooter = new System.Windows.Forms.TableLayoutPanel();
            this._btnCancelSelectTray = new Guna.UI2.WinForms.Guna2GradientButton();
            this._btnGetTool = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pToolMachineHeader = new System.Windows.Forms.Panel();
            this.lblShowAllMachineTray = new System.Windows.Forms.Label();
            this._txtToolSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this._toggleShowAll = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.tlpHeader.SuspendLayout();
            this.tlpContent.SuspendLayout();
            this.pLeftContent.SuspendLayout();
            this.tlpRightContent.SuspendLayout();
            this._tlpToolSelect.SuspendLayout();
            this._tlpToolMachineList.SuspendLayout();
            this.pToolContent.SuspendLayout();
            this.tlpToolMachineFooter.SuspendLayout();
            this.pToolMachineHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpHeader
            // 
            this.tlpHeader.ColumnCount = 2;
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpHeader.Controls.Add(this._btnSearch, 1, 0);
            this.tlpHeader.Controls.Add(this._txtSearch, 0, 0);
            this.tlpHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpHeader.Location = new System.Drawing.Point(0, 0);
            this.tlpHeader.Margin = new System.Windows.Forms.Padding(5);
            this.tlpHeader.Name = "tlpHeader";
            this.tlpHeader.RowCount = 1;
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tlpHeader.Size = new System.Drawing.Size(900, 56);
            this.tlpHeader.TabIndex = 0;
            // 
            // _btnSearch
            // 
            this._btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSearch.BorderRadius = 10;
            this._btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this._btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this._btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this._btnSearch.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this._btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this._btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
            this._btnSearch.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
            this._btnSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this._btnSearch.ForeColor = System.Drawing.Color.White;
            this._btnSearch.Location = new System.Drawing.Point(755, 5);
            this._btnSearch.Margin = new System.Windows.Forms.Padding(5);
            this._btnSearch.Name = "_btnSearch";
            this._btnSearch.Size = new System.Drawing.Size(140, 46);
            this._btnSearch.TabIndex = 1;
            this._btnSearch.Text = "Tìm Kiếm";
            // 
            // _txtSearch
            // 
            this._txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._txtSearch.BorderRadius = 10;
            this._txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtSearch.DefaultText = "";
            this._txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this._txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this._txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this._txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtSearch.Location = new System.Drawing.Point(5, 6);
            this._txtSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this._txtSearch.Name = "_txtSearch";
            this._txtSearch.PasswordChar = '\0';
            this._txtSearch.PlaceholderText = "Tìm Kiếm Tool";
            this._txtSearch.SelectedText = "";
            this._txtSearch.Size = new System.Drawing.Size(740, 44);
            this._txtSearch.TabIndex = 0;
            this._txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tlpContent
            // 
            this.tlpContent.ColumnCount = 2;
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpContent.Controls.Add(this.pLeftContent, 0, 0);
            this.tlpContent.Controls.Add(this.tlpRightContent, 1, 0);
            this.tlpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContent.Location = new System.Drawing.Point(0, 56);
            this.tlpContent.Name = "tlpContent";
            this.tlpContent.RowCount = 1;
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContent.Size = new System.Drawing.Size(900, 400);
            this.tlpContent.TabIndex = 2;
            // 
            // pLeftContent
            // 
            this.pLeftContent.Controls.Add(this.guna2VScrollBar_flpToolList);
            this.pLeftContent.Controls.Add(this._flpToolList);
            this.pLeftContent.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLeftContent.Location = new System.Drawing.Point(3, 3);
            this.pLeftContent.Name = "pLeftContent";
            this.pLeftContent.Size = new System.Drawing.Size(264, 394);
            this.pLeftContent.TabIndex = 0;
            // 
            // guna2VScrollBar_flpToolList
            // 
            this.guna2VScrollBar_flpToolList.BindingContainer = this._flpToolList;
            this.guna2VScrollBar_flpToolList.BorderRadius = 10;
            this.guna2VScrollBar_flpToolList.InUpdate = false;
            this.guna2VScrollBar_flpToolList.LargeChange = 10;
            this.guna2VScrollBar_flpToolList.Location = new System.Drawing.Point(246, 0);
            this.guna2VScrollBar_flpToolList.Name = "guna2VScrollBar_flpToolList";
            this.guna2VScrollBar_flpToolList.ScrollbarSize = 18;
            this.guna2VScrollBar_flpToolList.Size = new System.Drawing.Size(18, 394);
            this.guna2VScrollBar_flpToolList.TabIndex = 0;
            this.guna2VScrollBar_flpToolList.ThumbSize = 100F;
            // 
            // _flpToolList
            // 
            this._flpToolList.AutoScroll = true;
            this._flpToolList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._flpToolList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(214)))), ((int)(((byte)(226)))));
            this._flpToolList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flpToolList.Location = new System.Drawing.Point(0, 0);
            this._flpToolList.Name = "_flpToolList";
            this._flpToolList.Size = new System.Drawing.Size(264, 394);
            this._flpToolList.TabIndex = 2;
            // 
            // tlpRightContent
            // 
            this.tlpRightContent.ColumnCount = 3;
            this.tlpRightContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tlpRightContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpRightContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46F));
            this.tlpRightContent.Controls.Add(this._txtToolCode, 1, 1);
            this.tlpRightContent.Controls.Add(this.label1, 0, 1);
            this.tlpRightContent.Controls.Add(this.label2, 0, 2);
            this.tlpRightContent.Controls.Add(this.label3, 0, 3);
            this.tlpRightContent.Controls.Add(this._txtModel, 1, 2);
            this.tlpRightContent.Controls.Add(this._txtDescription, 1, 3);
            this.tlpRightContent.Controls.Add(this._tlpToolSelect, 1, 4);
            this.tlpRightContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRightContent.Location = new System.Drawing.Point(273, 3);
            this.tlpRightContent.Name = "tlpRightContent";
            this.tlpRightContent.RowCount = 5;
            this.tlpRightContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpRightContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpRightContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpRightContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpRightContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpRightContent.Size = new System.Drawing.Size(624, 394);
            this.tlpRightContent.TabIndex = 1;
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
            this._txtToolCode.Location = new System.Drawing.Point(90, 82);
            this._txtToolCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtToolCode.Name = "_txtToolCode";
            this._txtToolCode.PasswordChar = '\0';
            this._txtToolCode.PlaceholderText = "";
            this._txtToolCode.SelectedText = "";
            this._txtToolCode.Size = new System.Drawing.Size(243, 36);
            this._txtToolCode.TabIndex = 0;
            this._txtToolCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(7, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 78);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tool Code";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(46, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 78);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mẫu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(25, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 78);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chi Tiết";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _txtModel
            // 
            this._txtModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtModel.BorderRadius = 8;
            this._txtModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtModel.DefaultText = "";
            this._txtModel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this._txtModel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this._txtModel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtModel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtModel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtModel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtModel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtModel.Location = new System.Drawing.Point(90, 160);
            this._txtModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtModel.Name = "_txtModel";
            this._txtModel.PasswordChar = '\0';
            this._txtModel.PlaceholderText = "";
            this._txtModel.SelectedText = "";
            this._txtModel.Size = new System.Drawing.Size(243, 36);
            this._txtModel.TabIndex = 4;
            this._txtModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _txtDescription
            // 
            this._txtDescription.BorderRadius = 8;
            this._txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtDescription.DefaultText = "";
            this._txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this._txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this._txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this._txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtDescription.Location = new System.Drawing.Point(90, 238);
            this._txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtDescription.Name = "_txtDescription";
            this._txtDescription.PasswordChar = '\0';
            this._txtDescription.PlaceholderText = "";
            this._txtDescription.SelectedText = "";
            this._txtDescription.Size = new System.Drawing.Size(243, 70);
            this._txtDescription.TabIndex = 5;
            // 
            // _tlpToolSelect
            // 
            this._tlpToolSelect.ColumnCount = 3;
            this._tlpToolSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tlpToolSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this._tlpToolSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tlpToolSelect.Controls.Add(this._btnToolSelect, 1, 0);
            this._tlpToolSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tlpToolSelect.Location = new System.Drawing.Point(90, 315);
            this._tlpToolSelect.Name = "_tlpToolSelect";
            this._tlpToolSelect.RowCount = 1;
            this._tlpToolSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tlpToolSelect.Size = new System.Drawing.Size(243, 76);
            this._tlpToolSelect.TabIndex = 6;
            // 
            // _btnToolSelect
            // 
            this._btnToolSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._btnToolSelect.Animated = true;
            this._btnToolSelect.BorderRadius = 10;
            this._btnToolSelect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this._btnToolSelect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this._btnToolSelect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this._btnToolSelect.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this._btnToolSelect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this._btnToolSelect.Enabled = false;
            this._btnToolSelect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
            this._btnToolSelect.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
            this._btnToolSelect.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this._btnToolSelect.ForeColor = System.Drawing.Color.White;
            this._btnToolSelect.Location = new System.Drawing.Point(34, 15);
            this._btnToolSelect.Name = "_btnToolSelect";
            this._btnToolSelect.Size = new System.Drawing.Size(174, 45);
            this._btnToolSelect.TabIndex = 31;
            this._btnToolSelect.Text = "Chọn Tool";
            // 
            // guna2Elipse_flpToolList
            // 
            this.guna2Elipse_flpToolList.BorderRadius = 20;
            this.guna2Elipse_flpToolList.TargetControl = this._flpToolList;
            // 
            // guna2Elipse_tlpTooMachineList
            // 
            this.guna2Elipse_tlpTooMachineList.BorderRadius = 20;
            // 
            // guna2Elipse_flpTrayMachineList
            // 
            this.guna2Elipse_flpTrayMachineList.BorderRadius = 20;
            // 
            // guna2Elipse_tlpToolMachineList
            // 
            this.guna2Elipse_tlpToolMachineList.BorderRadius = 10;
            this.guna2Elipse_tlpToolMachineList.TargetControl = this._tlpToolMachineList;
            // 
            // _tlpToolMachineList
            // 
            this._tlpToolMachineList.AutoScroll = true;
            this._tlpToolMachineList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(186)))), ((int)(((byte)(190)))));
            this._tlpToolMachineList.ColumnCount = 1;
            this._tlpToolMachineList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tlpToolMachineList.Controls.Add(this.pToolContent, 0, 1);
            this._tlpToolMachineList.Controls.Add(this.tlpToolMachineFooter, 0, 2);
            this._tlpToolMachineList.Controls.Add(this.pToolMachineHeader, 0, 0);
            this._tlpToolMachineList.Location = new System.Drawing.Point(611, 0);
            this._tlpToolMachineList.Name = "_tlpToolMachineList";
            this._tlpToolMachineList.RowCount = 3;
            this._tlpToolMachineList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._tlpToolMachineList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this._tlpToolMachineList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._tlpToolMachineList.Size = new System.Drawing.Size(282, 456);
            this._tlpToolMachineList.TabIndex = 4;
            // 
            // pToolContent
            // 
            this.pToolContent.Controls.Add(this.guna2VScrollBar_flpToolMachineList);
            this.pToolContent.Controls.Add(this._flpTrayMachineList);
            this.pToolContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pToolContent.Location = new System.Drawing.Point(3, 71);
            this.pToolContent.Name = "pToolContent";
            this.pToolContent.Size = new System.Drawing.Size(276, 313);
            this.pToolContent.TabIndex = 29;
            // 
            // guna2VScrollBar_flpToolMachineList
            // 
            this.guna2VScrollBar_flpToolMachineList.AutoRoundedCorners = true;
            this.guna2VScrollBar_flpToolMachineList.AutoSize = true;
            this.guna2VScrollBar_flpToolMachineList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.guna2VScrollBar_flpToolMachineList.BindingContainer = this._flpTrayMachineList;
            this.guna2VScrollBar_flpToolMachineList.BorderRadius = 8;
            this.guna2VScrollBar_flpToolMachineList.InUpdate = false;
            this.guna2VScrollBar_flpToolMachineList.LargeChange = 10;
            this.guna2VScrollBar_flpToolMachineList.Location = new System.Drawing.Point(258, 0);
            this.guna2VScrollBar_flpToolMachineList.Name = "guna2VScrollBar_flpToolMachineList";
            this.guna2VScrollBar_flpToolMachineList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.guna2VScrollBar_flpToolMachineList.ScrollbarSize = 18;
            this.guna2VScrollBar_flpToolMachineList.Size = new System.Drawing.Size(18, 313);
            this.guna2VScrollBar_flpToolMachineList.TabIndex = 28;
            this.guna2VScrollBar_flpToolMachineList.ThumbSize = 100F;
            // 
            // _flpTrayMachineList
            // 
            this._flpTrayMachineList.AutoScroll = true;
            this._flpTrayMachineList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(214)))), ((int)(((byte)(226)))));
            this._flpTrayMachineList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flpTrayMachineList.Location = new System.Drawing.Point(0, 0);
            this._flpTrayMachineList.Margin = new System.Windows.Forms.Padding(2);
            this._flpTrayMachineList.Name = "_flpTrayMachineList";
            this._flpTrayMachineList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._flpTrayMachineList.Size = new System.Drawing.Size(276, 313);
            this._flpTrayMachineList.TabIndex = 29;
            // 
            // tlpToolMachineFooter
            // 
            this.tlpToolMachineFooter.ColumnCount = 2;
            this.tlpToolMachineFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpToolMachineFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpToolMachineFooter.Controls.Add(this._btnCancelSelectTray, 1, 0);
            this.tlpToolMachineFooter.Controls.Add(this._btnGetTool, 0, 0);
            this.tlpToolMachineFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpToolMachineFooter.Location = new System.Drawing.Point(3, 390);
            this.tlpToolMachineFooter.Name = "tlpToolMachineFooter";
            this.tlpToolMachineFooter.RowCount = 1;
            this.tlpToolMachineFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpToolMachineFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tlpToolMachineFooter.Size = new System.Drawing.Size(276, 63);
            this.tlpToolMachineFooter.TabIndex = 30;
            // 
            // _btnCancelSelectTray
            // 
            this._btnCancelSelectTray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCancelSelectTray.Animated = true;
            this._btnCancelSelectTray.BorderRadius = 10;
            this._btnCancelSelectTray.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this._btnCancelSelectTray.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this._btnCancelSelectTray.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this._btnCancelSelectTray.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this._btnCancelSelectTray.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this._btnCancelSelectTray.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
            this._btnCancelSelectTray.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
            this._btnCancelSelectTray.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this._btnCancelSelectTray.ForeColor = System.Drawing.Color.White;
            this._btnCancelSelectTray.Location = new System.Drawing.Point(141, 9);
            this._btnCancelSelectTray.Name = "_btnCancelSelectTray";
            this._btnCancelSelectTray.Size = new System.Drawing.Size(132, 45);
            this._btnCancelSelectTray.TabIndex = 30;
            this._btnCancelSelectTray.Text = "Hủy";
            // 
            // _btnGetTool
            // 
            this._btnGetTool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._btnGetTool.Animated = true;
            this._btnGetTool.BorderRadius = 10;
            this._btnGetTool.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this._btnGetTool.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this._btnGetTool.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this._btnGetTool.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this._btnGetTool.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this._btnGetTool.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
            this._btnGetTool.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
            this._btnGetTool.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this._btnGetTool.ForeColor = System.Drawing.Color.White;
            this._btnGetTool.Location = new System.Drawing.Point(3, 9);
            this._btnGetTool.Name = "_btnGetTool";
            this._btnGetTool.Size = new System.Drawing.Size(132, 45);
            this._btnGetTool.TabIndex = 29;
            this._btnGetTool.Text = "Lấy Tool";
            // 
            // pToolMachineHeader
            // 
            this.pToolMachineHeader.Controls.Add(this.lblShowAllMachineTray);
            this.pToolMachineHeader.Controls.Add(this._txtToolSearch);
            this.pToolMachineHeader.Controls.Add(this._toggleShowAll);
            this.pToolMachineHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pToolMachineHeader.Location = new System.Drawing.Point(3, 3);
            this.pToolMachineHeader.Name = "pToolMachineHeader";
            this.pToolMachineHeader.Size = new System.Drawing.Size(276, 62);
            this.pToolMachineHeader.TabIndex = 31;
            // 
            // lblShowAllMachineTray
            // 
            this.lblShowAllMachineTray.AutoSize = true;
            this.lblShowAllMachineTray.Location = new System.Drawing.Point(224, 21);
            this.lblShowAllMachineTray.Name = "lblShowAllMachineTray";
            this.lblShowAllMachineTray.Size = new System.Drawing.Size(51, 20);
            this.lblShowAllMachineTray.TabIndex = 30;
            this.lblShowAllMachineTray.Text = "Tất Cả";
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
            this._txtToolSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtToolSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtToolSearch.Location = new System.Drawing.Point(2, 8);
            this._txtToolSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtToolSearch.Name = "_txtToolSearch";
            this._txtToolSearch.PasswordChar = '\0';
            this._txtToolSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this._txtToolSearch.PlaceholderText = "Tìm Kiếm Tray và Máy";
            this._txtToolSearch.SelectedText = "";
            this._txtToolSearch.Size = new System.Drawing.Size(182, 46);
            this._txtToolSearch.TabIndex = 29;
            this._txtToolSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _toggleShowAll
            // 
            this._toggleShowAll.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._toggleShowAll.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._toggleShowAll.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this._toggleShowAll.CheckedState.InnerColor = System.Drawing.Color.White;
            this._toggleShowAll.Location = new System.Drawing.Point(187, 20);
            this._toggleShowAll.Name = "_toggleShowAll";
            this._toggleShowAll.Size = new System.Drawing.Size(35, 20);
            this._toggleShowAll.TabIndex = 6;
            this._toggleShowAll.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this._toggleShowAll.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this._toggleShowAll.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this._toggleShowAll.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // GetToolView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 456);
            this.Controls.Add(this._tlpToolMachineList);
            this.Controls.Add(this.tlpContent);
            this.Controls.Add(this.tlpHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "GetToolView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToolView";
            this.tlpHeader.ResumeLayout(false);
            this.tlpContent.ResumeLayout(false);
            this.pLeftContent.ResumeLayout(false);
            this.tlpRightContent.ResumeLayout(false);
            this.tlpRightContent.PerformLayout();
            this._tlpToolSelect.ResumeLayout(false);
            this._tlpToolMachineList.ResumeLayout(false);
            this.pToolContent.ResumeLayout(false);
            this.pToolContent.PerformLayout();
            this.tlpToolMachineFooter.ResumeLayout(false);
            this.pToolMachineHeader.ResumeLayout(false);
            this.pToolMachineHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientButton _btnSearch;

        public Guna.UI2.WinForms.Guna2GradientButton btnSearch
        {
            get { return _btnSearch; }
            set { _btnSearch = value; }
        }

        private Guna.UI2.WinForms.Guna2TextBox _txtSearch;

        public Guna.UI2.WinForms.Guna2TextBox txtSearch
        {
            get { return _txtSearch; }
            set { _txtSearch = value; }
        }

        public System.Windows.Forms.FlowLayoutPanel flpToolList
        {
            get { return _flpToolList; }
            set { _flpToolList = value; }
        }

        public Guna.UI2.WinForms.Guna2TextBox txtToolCode
        {
            get { return _txtToolCode; }
            set { _txtToolCode = value; }
        }

        public Guna.UI2.WinForms.Guna2TextBox txtModel
        {
            get { return _txtModel; }
            set { _txtModel = value; }
        }

        public Guna.UI2.WinForms.Guna2TextBox txtDescription
        {
            get { return _txtDescription; }
            set { _txtDescription = value; }
        }

        public System.Windows.Forms.TableLayoutPanel tlpToolMachineList
        {
            get { return _tlpToolMachineList; }
            set { _tlpToolMachineList = value; }
        }

        public Guna.UI2.WinForms.Guna2TextBox txtToolSearch
        {
            get { return _txtToolSearch; }
            set { _txtToolSearch = value; }
        }

        public System.Windows.Forms.FlowLayoutPanel flpTrayMachineList
        {
            get { return _flpTrayMachineList; }
            set { _flpTrayMachineList = value; }
        }

        public Guna.UI2.WinForms.Guna2GradientButton btnCancelSelectTray
        {
            get { return _btnCancelSelectTray; }
            set { _btnCancelSelectTray = value; }
        }

        public Guna.UI2.WinForms.Guna2GradientButton btnGetTool
        {
            get { return _btnGetTool; }
            set { _btnGetTool = value; }
        }
        public Guna.UI2.WinForms.Guna2ToggleSwitch toggleShowAll
        {
            get { return _toggleShowAll; }
            set { _toggleShowAll = value; }
        }

        public Guna2GradientButton btnToolSelect { get => _btnToolSelect; set => _btnToolSelect = value; }

        private System.Windows.Forms.TableLayoutPanel tlpHeader;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_flpToolList;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_flpTrayMachineList;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_tlpTooMachineList;
        private System.IO.Ports.SerialPort serialPort_GetTool;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_tlpToolMachineList;
        private System.Windows.Forms.Panel pLeftContent;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar_flpToolList;
        private System.Windows.Forms.FlowLayoutPanel _flpToolList;
        private System.Windows.Forms.TableLayoutPanel tlpRightContent;
        private Guna.UI2.WinForms.Guna2TextBox _txtToolCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox _txtModel;
        private Guna.UI2.WinForms.Guna2TextBox _txtDescription;
        private System.Windows.Forms.TableLayoutPanel _tlpToolMachineList;
        private System.Windows.Forms.Panel pToolContent;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar_flpToolMachineList;
        private System.Windows.Forms.FlowLayoutPanel _flpTrayMachineList;
        private System.Windows.Forms.TableLayoutPanel tlpToolMachineFooter;
        private Guna.UI2.WinForms.Guna2GradientButton _btnCancelSelectTray;
        private Guna.UI2.WinForms.Guna2GradientButton _btnGetTool;
        private System.Windows.Forms.Panel pToolMachineHeader;
        private System.Windows.Forms.Label lblShowAllMachineTray;
        private Guna.UI2.WinForms.Guna2TextBox _txtToolSearch;
        private Guna.UI2.WinForms.Guna2ToggleSwitch _toggleShowAll;
        private System.Windows.Forms.TableLayoutPanel _tlpToolSelect;
        private Guna.UI2.WinForms.Guna2GradientButton _btnToolSelect;
    }
}