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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_User;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_User;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label_Captcha;
    }
}