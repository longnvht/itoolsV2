using System.Windows.Forms;

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
            this._lblOPIdDisplay = new System.Windows.Forms.Label();
            this._lblJobNumberDisplay = new System.Windows.Forms.Label();
            this._btnPrevious = new Guna.UI2.WinForms.Guna2Button();
            this._btnNext = new Guna.UI2.WinForms.Guna2Button();
            this._lblOPId = new System.Windows.Forms.Label();
            this._lblJobNumber = new System.Windows.Forms.Label();
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this._btnHome = new Guna.UI2.WinForms.Guna2Button();
            this._btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.tlpFooter.SuspendLayout();
            this.tlpHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpFooter
            // 
            this.tlpFooter.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tlpFooter, "tlpFooter");
            this.tlpFooter.Controls.Add(this._lblOPIdDisplay, 3, 0);
            this.tlpFooter.Controls.Add(this._lblJobNumberDisplay, 1, 0);
            this.tlpFooter.Controls.Add(this._btnPrevious, 0, 0);
            this.tlpFooter.Controls.Add(this._btnNext, 5, 0);
            this.tlpFooter.Controls.Add(this._lblOPId, 4, 0);
            this.tlpFooter.Controls.Add(this._lblJobNumber, 2, 0);
            this.tlpFooter.Name = "tlpFooter";
            // 
            // _lblOPIdDisplay
            // 
            resources.ApplyResources(this._lblOPIdDisplay, "_lblOPIdDisplay");
            this._lblOPIdDisplay.Name = "_lblOPIdDisplay";
            // 
            // _lblJobNumberDisplay
            // 
            resources.ApplyResources(this._lblJobNumberDisplay, "_lblJobNumberDisplay");
            this._lblJobNumberDisplay.Name = "_lblJobNumberDisplay";
            // 
            // _btnPrevious
            // 
            resources.ApplyResources(this._btnPrevious, "_btnPrevious");
            this._btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this._btnPrevious.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this._btnPrevious.BorderRadius = 10;
            this._btnPrevious.BorderThickness = 1;
            this._btnPrevious.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this._btnPrevious.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this._btnPrevious.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this._btnPrevious.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this._btnPrevious.FillColor = System.Drawing.Color.WhiteSmoke;
            this._btnPrevious.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this._btnPrevious.Name = "_btnPrevious";
            // 
            // _btnNext
            // 
            resources.ApplyResources(this._btnNext, "_btnNext");
            this._btnNext.BackColor = System.Drawing.Color.Transparent;
            this._btnNext.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this._btnNext.BorderRadius = 10;
            this._btnNext.BorderThickness = 1;
            this._btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this._btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this._btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this._btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this._btnNext.FillColor = System.Drawing.Color.WhiteSmoke;
            this._btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this._btnNext.Name = "_btnNext";
            // 
            // _lblOPId
            // 
            resources.ApplyResources(this._lblOPId, "_lblOPId");
            this._lblOPId.Name = "_lblOPId";
            // 
            // _lblJobNumber
            // 
            resources.ApplyResources(this._lblJobNumber, "_lblJobNumber");
            this._lblJobNumber.Name = "_lblJobNumber";
            // 
            // tlpHeader
            // 
            this.tlpHeader.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tlpHeader, "tlpHeader");
            this.tlpHeader.Controls.Add(this._btnHome, 0, 0);
            this.tlpHeader.Controls.Add(this.lblName, 3, 0);
            this.tlpHeader.Controls.Add(this.label13, 2, 0);
            this.tlpHeader.Controls.Add(this._btnLogOut, 4, 0);
            this.tlpHeader.Name = "tlpHeader";
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // _btnHome
            // 
            this._btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this._btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this._btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this._btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this._btnHome.FillColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this._btnHome, "_btnHome");
            this._btnHome.ForeColor = System.Drawing.Color.White;
            this._btnHome.HoverState.Image = global::VinamiToolUser.Properties.Resources.home_96spx;
            this._btnHome.Image = global::VinamiToolUser.Properties.Resources.home_96px;
            this._btnHome.ImageSize = new System.Drawing.Size(30, 30);
            this._btnHome.Name = "_btnHome";
            // 
            // _btnLogOut
            // 
            this._btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this._btnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this._btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this._btnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this._btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this._btnLogOut, "_btnLogOut");
            this._btnLogOut.FillColor = System.Drawing.Color.White;
            this._btnLogOut.ForeColor = System.Drawing.Color.Black;
            this._btnLogOut.HoverState.Image = global::VinamiToolUser.Properties.Resources.close_500pxc;
            this._btnLogOut.Image = global::VinamiToolUser.Properties.Resources.close_500px;
            this._btnLogOut.ImageSize = new System.Drawing.Size(30, 30);
            this._btnLogOut.Name = "_btnLogOut";
            // 
            // MainView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.tlpHeader);
            this.Controls.Add(this.tlpFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "MainView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlpFooter.ResumeLayout(false);
            this.tlpFooter.PerformLayout();
            this.tlpHeader.ResumeLayout(false);
            this.tlpHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label _lblOPId;
        public System.Windows.Forms.Label lblOPId
        {
            get { return _lblOPId; }
            set { _lblOPId = value; }
        }

        private System.Windows.Forms.Label _lblJobNumber;
        public System.Windows.Forms.Label lblJobNumber
        {
            get { return _lblJobNumber; }
            set { _lblJobNumber = value; }
        }

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

        public Label lblJobNumberDisplay { get => _lblJobNumberDisplay; set => _lblJobNumberDisplay = value; }
        public Label lblOPIdDisplay { get => _lblOPIdDisplay; set => _lblOPIdDisplay = value; }

        private System.Windows.Forms.TableLayoutPanel tlpFooter;
        private System.Windows.Forms.TableLayoutPanel tlpHeader;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label _lblJobNumberDisplay;
        private System.Windows.Forms.Label _lblOPIdDisplay;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2Button _btnLogOut;
        private Guna.UI2.WinForms.Guna2Button _btnHome;
    }
}