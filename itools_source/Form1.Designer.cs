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
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.flpListTool = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
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
            // guna2Panel1
            // 
            this.guna2Panel1.AutoRoundedCorners = true;
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Location = new System.Drawing.Point(404, 32);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(285, 453);
            this.guna2Panel1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 497);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2VScrollBar1);
            this.Controls.Add(this.flpListTool);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Search Job";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
        private System.Windows.Forms.FlowLayoutPanel flpListTool;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}

