namespace VinamiToolUser.Views.Components
{
    partial class StockInfoTreeView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockInfoTreeView));
            this.tvStock = new System.Windows.Forms.TreeView();
            this.imTrayList = new System.Windows.Forms.ImageList(this.components);
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.SuspendLayout();
            // 
            // tvStock
            // 
            this.tvStock.BackColor = System.Drawing.Color.White;
            this.tvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvStock.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvStock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tvStock.ImageIndex = 0;
            this.tvStock.ImageList = this.imTrayList;
            this.tvStock.ItemHeight = 40;
            this.tvStock.Location = new System.Drawing.Point(0, 0);
            this.tvStock.Name = "tvStock";
            this.tvStock.SelectedImageIndex = 2;
            this.tvStock.Size = new System.Drawing.Size(470, 309);
            this.tvStock.TabIndex = 0;
            // 
            // imTrayList
            // 
            this.imTrayList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imTrayList.ImageStream")));
            this.imTrayList.TransparentColor = System.Drawing.Color.Transparent;
            this.imTrayList.Images.SetKeyName(0, "sliding_door_closet_100px.png");
            this.imTrayList.Images.SetKeyName(1, "stack_60px.png");
            this.imTrayList.Images.SetKeyName(2, "ok_60px.png");
            // 
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.BindingContainer = this.tvStock;
            this.guna2VScrollBar1.BorderRadius = 6;
            this.guna2VScrollBar1.InUpdate = false;
            this.guna2VScrollBar1.LargeChange = 10;
            this.guna2VScrollBar1.Location = new System.Drawing.Point(451, 1);
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.ScrollbarSize = 18;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(18, 307);
            this.guna2VScrollBar1.TabIndex = 1;
            // 
            // StockInfoTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2VScrollBar1);
            this.Controls.Add(this.tvStock);
            this.Name = "StockInfoTreeView";
            this.Size = new System.Drawing.Size(470, 309);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvStock;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
        private System.Windows.Forms.ImageList imTrayList;
    }
}
