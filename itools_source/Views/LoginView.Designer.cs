namespace itools_source.Views
{
    partial class frmLoginView
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
            this.lblTest = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnDencrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.lblLogger = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(83, 117);
            this.lblTest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(80, 39);
            this.lblTest.TabIndex = 0;
            this.lblTest.Text = "Test";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(389, 65);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(323, 32);
            this.txtUserName.TabIndex = 1;
            // 
            // txtRePassword
            // 
            this.txtRePassword.Location = new System.Drawing.Point(389, 210);
            this.txtRePassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.Size = new System.Drawing.Size(323, 32);
            this.txtRePassword.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(389, 133);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(323, 32);
            this.txtPassword.TabIndex = 4;
            // 
            // btnDencrypt
            // 
            this.btnDencrypt.Location = new System.Drawing.Point(574, 303);
            this.btnDencrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btnDencrypt.Name = "btnDencrypt";
            this.btnDencrypt.Size = new System.Drawing.Size(162, 45);
            this.btnDencrypt.TabIndex = 5;
            this.btnDencrypt.Text = "Dencrypt";
            this.btnDencrypt.UseVisualStyleBackColor = true;
            this.btnDencrypt.Click += new System.EventHandler(this.btnDencrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(389, 303);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(162, 45);
            this.btnEncrypt.TabIndex = 6;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // lblLogger
            // 
            this.lblLogger.AutoSize = true;
            this.lblLogger.Location = new System.Drawing.Point(83, 198);
            this.lblLogger.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogger.Name = "lblLogger";
            this.lblLogger.Size = new System.Drawing.Size(53, 26);
            this.lblLogger.TabIndex = 7;
            this.lblLogger.Text = "Test";
            // 
            // frmLoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 604);
            this.Controls.Add(this.lblLogger);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnDencrypt);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtRePassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblTest);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnDencrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label lblLogger;
    }
}