namespace itools_source
{
    partial class Form1
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
            this.txtOperateQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCurrentQuantity = new System.Windows.Forms.TextBox();
            this.txtTrayId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtToolId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.flpListTool = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // txtOperateQuantity
            // 
            this.txtOperateQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperateQuantity.Location = new System.Drawing.Point(479, 324);
            this.txtOperateQuantity.Name = "txtOperateQuantity";
            this.txtOperateQuantity.Size = new System.Drawing.Size(221, 24);
            this.txtOperateQuantity.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(404, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Mã Tool";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(405, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mã Tray";
            // 
            // txtCurrentQuantity
            // 
            this.txtCurrentQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentQuantity.Location = new System.Drawing.Point(479, 262);
            this.txtCurrentQuantity.Name = "txtCurrentQuantity";
            this.txtCurrentQuantity.Size = new System.Drawing.Size(221, 24);
            this.txtCurrentQuantity.TabIndex = 13;
            // 
            // txtTrayId
            // 
            this.txtTrayId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrayId.Location = new System.Drawing.Point(479, 149);
            this.txtTrayId.Name = "txtTrayId";
            this.txtTrayId.Size = new System.Drawing.Size(221, 24);
            this.txtTrayId.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Số Lượng Thao Tác";
            // 
            // txtToolId
            // 
            this.txtToolId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToolId.Location = new System.Drawing.Point(479, 206);
            this.txtToolId.Name = "txtToolId";
            this.txtToolId.Size = new System.Drawing.Size(221, 24);
            this.txtToolId.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số Lượng Hiện Có";
            // 
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.AutoRoundedCorners = true;
            this.guna2VScrollBar1.AutoSize = true;
            this.guna2VScrollBar1.BindingContainer = this.flpListTool;
            this.guna2VScrollBar1.BorderRadius = 8;
            this.guna2VScrollBar1.InUpdate = false;
            this.guna2VScrollBar1.LargeChange = 10;
            this.guna2VScrollBar1.Location = new System.Drawing.Point(287, 0);
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.guna2VScrollBar1.ScrollbarSize = 18;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(18, 497);
            this.guna2VScrollBar1.TabIndex = 18;
            this.guna2VScrollBar1.ThumbSize = 100F;
            // 
            // flpListTool
            // 
            this.flpListTool.AutoScroll = true;
            this.flpListTool.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flpListTool.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpListTool.Location = new System.Drawing.Point(0, 0);
            this.flpListTool.Margin = new System.Windows.Forms.Padding(2);
            this.flpListTool.Name = "flpListTool";
            this.flpListTool.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flpListTool.Size = new System.Drawing.Size(305, 497);
            this.flpListTool.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 497);
            this.Controls.Add(this.guna2VScrollBar1);
            this.Controls.Add(this.flpListTool);
            this.Controls.Add(this.txtOperateQuantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCurrentQuantity);
            this.Controls.Add(this.txtTrayId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtToolId);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Search Job";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOperateQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCurrentQuantity;
        private System.Windows.Forms.TextBox txtTrayId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtToolId;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
        private System.Windows.Forms.FlowLayoutPanel flpListTool;
    }
}

