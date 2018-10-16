namespace SearchTicketTool
{
    partial class Login
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
<<<<<<< HEAD
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_User = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.pictureBox_Verification = new System.Windows.Forms.PictureBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.checkBox_ShowPassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Verification)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "密码:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "验证码:";
            // 
            // textBox_User
            // 
            this.textBox_User.Location = new System.Drawing.Point(79, 10);
            this.textBox_User.Name = "textBox_User";
            this.textBox_User.Size = new System.Drawing.Size(196, 25);
            this.textBox_User.TabIndex = 1;
            this.textBox_User.Text = "dihuiyuan1";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(79, 41);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(196, 25);
            this.textBox_Password.TabIndex = 1;
            this.textBox_Password.Text = "duolaameng123";
            // 
            // pictureBox_Verification
            // 
            this.pictureBox_Verification.Location = new System.Drawing.Point(79, 81);
            this.pictureBox_Verification.Name = "pictureBox_Verification";
            this.pictureBox_Verification.Size = new System.Drawing.Size(400, 220);
            this.pictureBox_Verification.TabIndex = 2;
            this.pictureBox_Verification.TabStop = false;
            this.pictureBox_Verification.Click += new System.EventHandler(this.pictureBox_Verification_Click);
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(100, 367);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(130, 33);
            this.button_Login.TabIndex = 3;
            this.button_Login.Text = "登录";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(326, 367);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(130, 33);
            this.button_Cancel.TabIndex = 3;
            this.button_Cancel.Text = "取消";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(376, 48);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(103, 25);
            this.button_Refresh.TabIndex = 4;
            this.button_Refresh.Text = "刷新验证码";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // checkBox_ShowPassword
            // 
            this.checkBox_ShowPassword.AutoSize = true;
            this.checkBox_ShowPassword.Location = new System.Drawing.Point(281, 48);
            this.checkBox_ShowPassword.Name = "checkBox_ShowPassword";
            this.checkBox_ShowPassword.Size = new System.Drawing.Size(89, 19);
            this.checkBox_ShowPassword.TabIndex = 5;
            this.checkBox_ShowPassword.Text = "显示密码";
            this.checkBox_ShowPassword.UseVisualStyleBackColor = true;
            this.checkBox_ShowPassword.CheckedChanged += new System.EventHandler(this.checkBox_ShowPassword_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 438);
            this.Controls.Add(this.checkBox_ShowPassword);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.pictureBox_Verification);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_User);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Verification)).EndInit();
=======
            this.label_User = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_User = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label_Captcha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_User
            // 
            this.label_User.AutoSize = true;
            this.label_User.Location = new System.Drawing.Point(13, 13);
            this.label_User.Name = "label_User";
            this.label_User.Size = new System.Drawing.Size(47, 12);
            this.label_User.TabIndex = 0;
            this.label_User.Text = "用户名:";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(12, 42);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(35, 12);
            this.label_Password.TabIndex = 0;
            this.label_Password.Text = "密码:";
            // 
            // textBox_User
            // 
            this.textBox_User.Location = new System.Drawing.Point(66, 10);
            this.textBox_User.Name = "textBox_User";
            this.textBox_User.Size = new System.Drawing.Size(100, 21);
            this.textBox_User.TabIndex = 1;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(66, 37);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(100, 21);
            this.textBox_Password.TabIndex = 1;
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(66, 237);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(75, 23);
            this.button_Login.TabIndex = 2;
            this.button_Login.Text = "登录";
            this.button_Login.UseVisualStyleBackColor = true;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(234, 237);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 2;
            this.button_Cancel.Text = "取消";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // label_Captcha
            // 
            this.label_Captcha.AutoSize = true;
            this.label_Captcha.Location = new System.Drawing.Point(13, 70);
            this.label_Captcha.Name = "label_Captcha";
            this.label_Captcha.Size = new System.Drawing.Size(47, 12);
            this.label_Captcha.TabIndex = 0;
            this.label_Captcha.Text = "验证码:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 283);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_User);
            this.Controls.Add(this.label_Captcha);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_User);
            this.Name = "Login";
            this.Text = "Login";
>>>>>>> bb0db9e839499adfba5590fe2e62e96ae5d4cd9a
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_User;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.PictureBox pictureBox_Verification;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.CheckBox checkBox_ShowPassword;
=======
        private System.Windows.Forms.Label label_User;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_User;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label_Captcha;
>>>>>>> bb0db9e839499adfba5590fe2e62e96ae5d4cd9a
    }
}