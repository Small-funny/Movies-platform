namespace CSharp_FinalWork
{
    partial class Register
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtTittle = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPwd = new System.Windows.Forms.Label();
            this.txtRepeat = new System.Windows.Forms.TextBox();
            this.labelRepeat = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("宋体", 15F);
            this.txtUser.Location = new System.Drawing.Point(100, 105);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(232, 30);
            this.txtUser.TabIndex = 0;
            this.txtUser.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("宋体", 15F);
            this.txtEmail.Location = new System.Drawing.Point(100, 165);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(232, 30);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("宋体", 15F);
            this.txtPwd.Location = new System.Drawing.Point(100, 226);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(232, 30);
            this.txtPwd.TabIndex = 3;
            this.txtPwd.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // txtTittle
            // 
            this.txtTittle.AutoSize = true;
            this.txtTittle.Font = new System.Drawing.Font("宋体", 25F);
            this.txtTittle.Location = new System.Drawing.Point(140, 34);
            this.txtTittle.Name = "txtTittle";
            this.txtTittle.Size = new System.Drawing.Size(151, 34);
            this.txtTittle.TabIndex = 4;
            this.txtTittle.Text = "平台注册";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("宋体", 13F);
            this.btnRegister.Location = new System.Drawing.Point(137, 342);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(164, 30);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "注册";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelUser.Font = new System.Drawing.Font("宋体", 12F);
            this.labelUser.Location = new System.Drawing.Point(116, 111);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(56, 16);
            this.labelUser.TabIndex = 6;
            this.labelUser.Text = "用户名";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelEmail.Font = new System.Drawing.Font("宋体", 12F);
            this.labelEmail.Location = new System.Drawing.Point(116, 171);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(40, 16);
            this.labelEmail.TabIndex = 7;
            this.labelEmail.Text = "邮箱";
            // 
            // labelPwd
            // 
            this.labelPwd.AutoSize = true;
            this.labelPwd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPwd.Font = new System.Drawing.Font("宋体", 12F);
            this.labelPwd.Location = new System.Drawing.Point(116, 232);
            this.labelPwd.Name = "labelPwd";
            this.labelPwd.Size = new System.Drawing.Size(40, 16);
            this.labelPwd.TabIndex = 8;
            this.labelPwd.Text = "密码";
            // 
            // txtRepeat
            // 
            this.txtRepeat.Font = new System.Drawing.Font("宋体", 15F);
            this.txtRepeat.Location = new System.Drawing.Point(100, 285);
            this.txtRepeat.Name = "txtRepeat";
            this.txtRepeat.PasswordChar = '*';
            this.txtRepeat.Size = new System.Drawing.Size(232, 30);
            this.txtRepeat.TabIndex = 9;
            this.txtRepeat.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // labelRepeat
            // 
            this.labelRepeat.AutoSize = true;
            this.labelRepeat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelRepeat.Font = new System.Drawing.Font("宋体", 12F);
            this.labelRepeat.Location = new System.Drawing.Point(116, 291);
            this.labelRepeat.Name = "labelRepeat";
            this.labelRepeat.Size = new System.Drawing.Size(104, 16);
            this.labelRepeat.TabIndex = 10;
            this.labelRepeat.Text = "再次输入密码";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("宋体", 13F);
            this.labelLogin.Location = new System.Drawing.Point(373, 389);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(44, 18);
            this.labelLogin.TabIndex = 15;
            this.labelLogin.Text = "登陆";
            this.labelLogin.Click += new System.EventHandler(this.labelLogin_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 416);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelRepeat);
            this.Controls.Add(this.txtRepeat);
            this.Controls.Add(this.labelPwd);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtTittle);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUser);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Register";
            this.Text = "注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label txtTittle;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPwd;
        private System.Windows.Forms.TextBox txtRepeat;
        private System.Windows.Forms.Label labelRepeat;
        private System.Windows.Forms.Label labelLogin;
    }
}