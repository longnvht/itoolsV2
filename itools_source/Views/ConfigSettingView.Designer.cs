namespace itools_source.Views
{
    partial class ConfigSettingView
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
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblMachine = new System.Windows.Forms.Label();
            this.lblCOM = new System.Windows.Forms.Label();
            this._cmbCompany = new Guna.UI2.WinForms.Guna2ComboBox();
            this._cmbMachine = new Guna.UI2.WinForms.Guna2ComboBox();
            this._cmbSerialPort = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tlpFooter = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.tlpMain.SuspendLayout();
            this.tlpFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.tlpMain.ColumnCount = 4;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.76923F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.15385F));
            this.tlpMain.Controls.Add(this.lblCompany, 1, 1);
            this.tlpMain.Controls.Add(this.lblMachine, 1, 2);
            this.tlpMain.Controls.Add(this.lblCOM, 1, 3);
            this.tlpMain.Controls.Add(this._cmbCompany, 2, 1);
            this.tlpMain.Controls.Add(this._cmbMachine, 2, 2);
            this.tlpMain.Controls.Add(this._cmbSerialPort, 2, 3);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 5;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.Size = new System.Drawing.Size(800, 450);
            this.tlpMain.TabIndex = 0;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCompany.Location = new System.Drawing.Point(213, 112);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(63, 75);
            this.lblCompany.TabIndex = 0;
            this.lblCompany.Text = "Công ty:";
            this.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMachine
            // 
            this.lblMachine.AutoSize = true;
            this.lblMachine.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMachine.Location = new System.Drawing.Point(236, 187);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(40, 75);
            this.lblMachine.TabIndex = 1;
            this.lblMachine.Text = "Máy:";
            this.lblMachine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCOM
            // 
            this.lblCOM.AutoSize = true;
            this.lblCOM.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCOM.Location = new System.Drawing.Point(180, 262);
            this.lblCOM.Name = "lblCOM";
            this.lblCOM.Size = new System.Drawing.Size(96, 75);
            this.lblCOM.TabIndex = 2;
            this.lblCOM.Text = "Cổng kết nối:";
            this.lblCOM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _cmbCompany
            // 
            this._cmbCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._cmbCompany.BackColor = System.Drawing.Color.Transparent;
            this._cmbCompany.BorderRadius = 10;
            this._cmbCompany.BorderThickness = 0;
            this._cmbCompany.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this._cmbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbCompany.DropDownWidth = 280;
            this._cmbCompany.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._cmbCompany.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._cmbCompany.Font = new System.Drawing.Font("Segoe UI", 10F);
            this._cmbCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this._cmbCompany.ItemHeight = 30;
            this._cmbCompany.Location = new System.Drawing.Point(282, 131);
            this._cmbCompany.Name = "_cmbCompany";
            this._cmbCompany.ShadowDecoration.BorderRadius = 10;
            this._cmbCompany.ShadowDecoration.Depth = 6;
            this._cmbCompany.ShadowDecoration.Enabled = true;
            this._cmbCompany.Size = new System.Drawing.Size(274, 36);
            this._cmbCompany.TabIndex = 3;
            this._cmbCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _cmbMachine
            // 
            this._cmbMachine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._cmbMachine.BackColor = System.Drawing.Color.Transparent;
            this._cmbMachine.BorderRadius = 10;
            this._cmbMachine.BorderThickness = 0;
            this._cmbMachine.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this._cmbMachine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbMachine.DropDownWidth = 280;
            this._cmbMachine.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._cmbMachine.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._cmbMachine.Font = new System.Drawing.Font("Segoe UI", 10F);
            this._cmbMachine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this._cmbMachine.ItemHeight = 30;
            this._cmbMachine.Location = new System.Drawing.Point(282, 206);
            this._cmbMachine.Name = "_cmbMachine";
            this._cmbMachine.ShadowDecoration.BorderRadius = 10;
            this._cmbMachine.ShadowDecoration.CustomizableEdges.BottomLeft = false;
            this._cmbMachine.ShadowDecoration.CustomizableEdges.BottomRight = false;
            this._cmbMachine.ShadowDecoration.Depth = 6;
            this._cmbMachine.ShadowDecoration.Enabled = true;
            this._cmbMachine.Size = new System.Drawing.Size(274, 36);
            this._cmbMachine.TabIndex = 4;
            this._cmbMachine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _cmbSerialPort
            // 
            this._cmbSerialPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._cmbSerialPort.BackColor = System.Drawing.Color.Transparent;
            this._cmbSerialPort.BorderRadius = 10;
            this._cmbSerialPort.BorderThickness = 0;
            this._cmbSerialPort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this._cmbSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbSerialPort.DropDownWidth = 280;
            this._cmbSerialPort.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._cmbSerialPort.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._cmbSerialPort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this._cmbSerialPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this._cmbSerialPort.ItemHeight = 30;
            this._cmbSerialPort.Location = new System.Drawing.Point(282, 281);
            this._cmbSerialPort.Name = "_cmbSerialPort";
            this._cmbSerialPort.ShadowDecoration.BorderRadius = 10;
            this._cmbSerialPort.ShadowDecoration.CustomizableEdges.BottomLeft = false;
            this._cmbSerialPort.ShadowDecoration.CustomizableEdges.BottomRight = false;
            this._cmbSerialPort.ShadowDecoration.Depth = 6;
            this._cmbSerialPort.ShadowDecoration.Enabled = true;
            this._cmbSerialPort.Size = new System.Drawing.Size(274, 36);
            this._cmbSerialPort.TabIndex = 5;
            this._cmbSerialPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tlpFooter
            // 
            this.tlpFooter.ColumnCount = 3;
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpFooter.Controls.Add(this.btnSave, 1, 0);
            this.tlpFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpFooter.Location = new System.Drawing.Point(0, 404);
            this.tlpFooter.Name = "tlpFooter";
            this.tlpFooter.RowCount = 1;
            this.tlpFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFooter.Size = new System.Drawing.Size(800, 46);
            this.tlpFooter.TabIndex = 1;
            // 
            // btnSave
            // 
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
            this.btnSave.Location = new System.Drawing.Point(403, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.BorderRadius = 10;
            this.btnSave.ShadowDecoration.CustomizableEdges.BottomLeft = false;
            this.btnSave.ShadowDecoration.CustomizableEdges.BottomRight = false;
            this.btnSave.ShadowDecoration.Depth = 6;
            this.btnSave.ShadowDecoration.Enabled = true;
            this.btnSave.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSave.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.btnSave.Size = new System.Drawing.Size(154, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Lưu";
            // 
            // ConfigSettingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpFooter);
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConfigSettingView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfigSettingView";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox _cmbCompany;
        public Guna.UI2.WinForms.Guna2ComboBox cmbCompany
        {
            get { return _cmbCompany; }
            set { _cmbCompany = value; }
        }

        private Guna.UI2.WinForms.Guna2ComboBox _cmbMachine;
        public Guna.UI2.WinForms.Guna2ComboBox cmbMachine
        {
            get { return _cmbMachine; }
            set { _cmbMachine = value; }
        }

        private Guna.UI2.WinForms.Guna2ComboBox _cmbSerialPort;
        public Guna.UI2.WinForms.Guna2ComboBox cmbSerialPort
        {
            get { return _cmbSerialPort; }
            set { _cmbSerialPort = value; }
        }

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpFooter;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.Label lblCOM;
        private Guna.UI2.WinForms.Guna2Button btnSave;
    }
}