namespace itools_source.Views
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.tlpFooter = new System.Windows.Forms.TableLayoutPanel();
            this._btnPrevious = new Guna.UI2.WinForms.Guna2Button();
            this._btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tlpFooter.SuspendLayout();
            this.tlpHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpFooter
            // 
            this.tlpFooter.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tlpFooter, "tlpFooter");
            this.tlpFooter.Controls.Add(this._btnPrevious, 0, 0);
            this.tlpFooter.Controls.Add(this._btnNext, 2, 0);
            this.tlpFooter.Name = "tlpFooter";
            // 
            // _btnPrevious
            // 
            this._btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this._btnPrevious.BorderRadius = 15;
            this._btnPrevious.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this._btnPrevious.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this._btnPrevious.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this._btnPrevious.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this._btnPrevious, "_btnPrevious");
            this._btnPrevious.ForeColor = System.Drawing.Color.White;
            this._btnPrevious.Name = "_btnPrevious";
            // 
            // _btnNext
            // 
            this._btnNext.BackColor = System.Drawing.Color.Transparent;
            this._btnNext.BorderRadius = 15;
            this._btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this._btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this._btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this._btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this._btnNext, "_btnNext");
            this._btnNext.ForeColor = System.Drawing.Color.White;
            this._btnNext.Name = "_btnNext";
            // 
            // tlpHeader
            // 
            this.tlpHeader.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tlpHeader, "tlpHeader");
            this.tlpHeader.Controls.Add(this.lblRole, 1, 0);
            this.tlpHeader.Controls.Add(this.lblName, 0, 0);
            this.tlpHeader.Name = "tlpHeader";
            // 
            // lblRole
            // 
            resources.ApplyResources(this.lblRole, "lblRole");
            this.lblRole.Name = "lblRole";
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // MainView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpHeader);
            this.Controls.Add(this.tlpFooter);
            this.IsMdiContainer = true;
            this.Name = "MainView";
            this.tlpFooter.ResumeLayout(false);
            this.tlpHeader.ResumeLayout(false);
            this.tlpHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpFooter;
        private System.Windows.Forms.TableLayoutPanel tlpHeader;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRole;

        private Guna.UI2.WinForms.Guna2Button _btnPrevious;
        
        public Guna.UI2.WinForms.Guna2Button btnPrevious
        {
            get { return _btnPrevious; }
            set { _btnPrevious = value; }
        }

        private Guna.UI2.WinForms.Guna2Button _btnNext;

        public Guna.UI2.WinForms.Guna2Button btnNext
        {
            get { return _btnNext; }
            set { _btnNext = value; }
        }
    }
}