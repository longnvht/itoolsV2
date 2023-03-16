namespace itools_source.Views
{
    partial class StockView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this._dgvStock = new Guna.UI2.WinForms.Guna2DataGridView();
            this._colTrayIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._colToolId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this._colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._colUpdateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // _dgvStock
            // 
            this._dgvStock.AllowUserToAddRows = false;
            this._dgvStock.AllowUserToDeleteRows = false;
            this._dgvStock.AllowUserToResizeColumns = false;
            this._dgvStock.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this._dgvStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this._dgvStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this._dgvStock.ColumnHeadersHeight = 40;
            this._dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this._dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._colTrayIndex,
            this._colToolId,
            this._colQuantity,
            this._colUpdateDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dgvStock.DefaultCellStyle = dataGridViewCellStyle3;
            this._dgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dgvStock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this._dgvStock.Location = new System.Drawing.Point(0, 0);
            this._dgvStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._dgvStock.MultiSelect = false;
            this._dgvStock.Name = "_dgvStock";
            this._dgvStock.ReadOnly = true;
            this._dgvStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dgvStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this._dgvStock.RowHeadersVisible = false;
            this._dgvStock.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this._dgvStock.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this._dgvStock.RowTemplate.DividerHeight = 5;
            this._dgvStock.RowTemplate.Height = 50;
            this._dgvStock.Size = new System.Drawing.Size(800, 450);
            this._dgvStock.TabIndex = 0;
            this._dgvStock.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Teal;
            this._dgvStock.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this._dgvStock.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this._dgvStock.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this._dgvStock.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this._dgvStock.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this._dgvStock.ThemeStyle.BackColor = System.Drawing.Color.White;
            this._dgvStock.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this._dgvStock.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(145)))));
            this._dgvStock.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this._dgvStock.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dgvStock.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this._dgvStock.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this._dgvStock.ThemeStyle.HeaderStyle.Height = 40;
            this._dgvStock.ThemeStyle.ReadOnly = true;
            this._dgvStock.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this._dgvStock.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this._dgvStock.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dgvStock.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this._dgvStock.ThemeStyle.RowsStyle.Height = 50;
            this._dgvStock.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this._dgvStock.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // _colTrayIndex
            // 
            this._colTrayIndex.DataPropertyName = "strTrayIndex";
            this._colTrayIndex.HeaderText = "TrayIndex";
            this._colTrayIndex.Name = "_colTrayIndex";
            this._colTrayIndex.ReadOnly = true;
            // 
            // _colToolId
            // 
            this._colToolId.DataPropertyName = "iToolId";
            this._colToolId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this._colToolId.FillWeight = 140F;
            this._colToolId.HeaderText = "Tool";
            this._colToolId.MaxDropDownItems = 10;
            this._colToolId.Name = "_colToolId";
            this._colToolId.ReadOnly = true;
            this._colToolId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._colToolId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // _colQuantity
            // 
            this._colQuantity.DataPropertyName = "iQuantity";
            this._colQuantity.FillWeight = 60F;
            this._colQuantity.HeaderText = "Số Lượng";
            this._colQuantity.Name = "_colQuantity";
            this._colQuantity.ReadOnly = true;
            // 
            // _colUpdateDate
            // 
            this._colUpdateDate.DataPropertyName = "dtUpdateDate";
            this._colUpdateDate.FillWeight = 180F;
            this._colUpdateDate.HeaderText = "Ngày";
            this._colUpdateDate.Name = "_colUpdateDate";
            this._colUpdateDate.ReadOnly = true;
            // 
            // StockView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._dgvStock);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StockView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockView";
            ((System.ComponentModel.ISupportInitialize)(this._dgvStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView _dgvStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn _colTrayIndex;
        private System.Windows.Forms.DataGridViewComboBoxColumn _colToolId;
        private System.Windows.Forms.DataGridViewTextBoxColumn _colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn _colUpdateDate;

        public Guna.UI2.WinForms.Guna2DataGridView dgvStock
        {
            get { return _dgvStock; }
            set { _dgvStock = value; }
        }
        public System.Windows.Forms.DataGridViewComboBoxColumn colToolId
        {
            get { return _colToolId; }
            set { _colToolId = value; }
        }
    }
}