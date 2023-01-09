using Guna.UI2.WinForms;

namespace itools_source.Views
{
    partial class LoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this._txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this._txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse_LoginView = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(232, 9);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(125, 34);
            this.guna2HtmlLabel1.TabIndex = 8;
            this.guna2HtmlLabel1.Text = "Đăng Nhập";
            // 
            // btnCancel
            // 
            this.btnCancel.Animated = true;
            this.btnCancel.AutoRoundedCorners = true;
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(318, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 45);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Thoát";
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.AutoRoundedCorners = true;
            this.btnLogin.BorderRadius = 10;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(87, 230);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(180, 45);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Đăng Nhập";
            // 
            // _txtPassword
            // 
            this._txtPassword.Animated = true;
            this._txtPassword.AutoRoundedCorners = true;
            this._txtPassword.BorderRadius = 16;
            this._txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtPassword.DefaultText = "123456";
            this._txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this._txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this._txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtPassword.IconLeft = global::itools_source.Properties.Resources.password_24px;
            this._txtPassword.IconLeftOffset = new System.Drawing.Point(12, 0);
            this._txtPassword.IconLeftSize = new System.Drawing.Size(24, 24);
            this._txtPassword.IconRight = global::itools_source.Properties.Resources.pass_show_24px;
            this._txtPassword.IconRightOffset = new System.Drawing.Point(12, 0);
            this._txtPassword.IconRightSize = new System.Drawing.Size(24, 24);
            this._txtPassword.Location = new System.Drawing.Point(97, 143);
            this._txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtPassword.Name = "_txtPassword";
            this._txtPassword.PasswordChar = '●';
            this._txtPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this._txtPassword.PlaceholderText = "Mật Khẩu";
            this._txtPassword.SelectedText = "";
            this._txtPassword.Size = new System.Drawing.Size(385, 50);
            this._txtPassword.TabIndex = 1;
            this._txtPassword.UseSystemPasswordChar = true;
            // 
            // _txtUserName
            // 
            this._txtUserName.Animated = true;
            this._txtUserName.AutoRoundedCorners = true;
            this._txtUserName.BorderRadius = 16;
            this._txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtUserName.DefaultText = "181119";
            this._txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this._txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this._txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtUserName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtUserName.IconLeft = global::itools_source.Properties.Resources.user_name_24px;
            this._txtUserName.IconLeftOffset = new System.Drawing.Point(12, 0);
            this._txtUserName.IconLeftSize = new System.Drawing.Size(24, 24);
            this._txtUserName.Location = new System.Drawing.Point(101, 62);
            this._txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtUserName.Name = "_txtUserName";
            this._txtUserName.PasswordChar = '\0';
            this._txtUserName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this._txtUserName.PlaceholderText = "Tài Khoản";
            this._txtUserName.SelectedText = "";
            this._txtUserName.Size = new System.Drawing.Size(385, 50);
            this._txtUserName.TabIndex = 0;
            // 
            // guna2Elipse_LoginView
            // 
            this.guna2Elipse_LoginView.TargetControl = this;
            // 
            // LoginView
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(578, 304);
            this.Controls.Add(this._txtPassword);
            this.Controls.Add(this._txtUserName);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnCancel;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogin;
        private Guna.UI2.WinForms.Guna2TextBox _txtUserName;
        private Guna.UI2.WinForms.Guna2TextBox _txtPassword;
        private Guna2Elipse guna2Elipse_LoginView;

        public Guna2TextBox txtPassword { get => _txtPassword; set => _txtPassword = value; }
        public Guna2TextBox txtUserName { get => _txtUserName; set => _txtUserName = value; }
    }
}