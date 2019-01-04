namespace CSharp_FinalWork
{
    partial class Forget
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
            this.labelFind = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnYes = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.labelPs1 = new System.Windows.Forms.Label();
            this.txtPs1 = new System.Windows.Forms.TextBox();
            this.labelPs2 = new System.Windows.Forms.Label();
            this.txtPs2 = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.labelCheck = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelFind
            // 
            this.labelFind.AutoSize = true;
            this.labelFind.Font = new System.Drawing.Font("宋体", 25F);
            this.labelFind.Location = new System.Drawing.Point(126, 21);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(151, 34);
            this.labelFind.TabIndex = 0;
            this.labelFind.Text = "密码找回";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("宋体", 15F);
            this.txtUser.Location = new System.Drawing.Point(86, 79);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(227, 30);
            this.txtUser.TabIndex = 1;
            this.txtUser.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("宋体", 15F);
            this.txtEmail.Location = new System.Drawing.Point(86, 130);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(227, 30);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // btnYes
            // 
            this.btnYes.Font = new System.Drawing.Font("宋体", 13F);
            this.btnYes.Location = new System.Drawing.Point(132, 335);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(128, 28);
            this.btnYes.TabIndex = 3;
            this.btnYes.Text = "确定";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelUser.Font = new System.Drawing.Font("宋体", 12F);
            this.labelUser.Location = new System.Drawing.Point(98, 86);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(56, 16);
            this.labelUser.TabIndex = 7;
            this.labelUser.Text = "用户名";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelEmail.Font = new System.Drawing.Font("宋体", 12F);
            this.labelEmail.Location = new System.Drawing.Point(98, 136);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(40, 16);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "邮箱";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("宋体", 13F);
            this.labelLogin.Location = new System.Drawing.Point(347, 342);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(44, 18);
            this.labelLogin.TabIndex = 9;
            this.labelLogin.Text = "登陆";
            this.labelLogin.Click += new System.EventHandler(this.labelLogin_Click);
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCode.Font = new System.Drawing.Font("宋体", 12F);
            this.labelCode.Location = new System.Drawing.Point(98, 189);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(56, 16);
            this.labelCode.TabIndex = 11;
            this.labelCode.Text = "验证码";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("宋体", 15F);
            this.txtCode.Location = new System.Drawing.Point(86, 183);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(227, 30);
            this.txtCode.TabIndex = 10;
            this.txtCode.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // labelPs1
            // 
            this.labelPs1.AutoSize = true;
            this.labelPs1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPs1.Font = new System.Drawing.Font("宋体", 12F);
            this.labelPs1.Location = new System.Drawing.Point(98, 241);
            this.labelPs1.Name = "labelPs1";
            this.labelPs1.Size = new System.Drawing.Size(56, 16);
            this.labelPs1.TabIndex = 13;
            this.labelPs1.Text = "新密码";
            // 
            // txtPs1
            // 
            this.txtPs1.Font = new System.Drawing.Font("宋体", 15F);
            this.txtPs1.Location = new System.Drawing.Point(86, 235);
            this.txtPs1.Name = "txtPs1";
            this.txtPs1.PasswordChar = '*';
            this.txtPs1.Size = new System.Drawing.Size(227, 30);
            this.txtPs1.TabIndex = 12;
            this.txtPs1.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // labelPs2
            // 
            this.labelPs2.AutoSize = true;
            this.labelPs2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPs2.Font = new System.Drawing.Font("宋体", 12F);
            this.labelPs2.Location = new System.Drawing.Point(98, 294);
            this.labelPs2.Name = "labelPs2";
            this.labelPs2.Size = new System.Drawing.Size(120, 16);
            this.labelPs2.TabIndex = 15;
            this.labelPs2.Text = "再次输入新密码";
            // 
            // txtPs2
            // 
            this.txtPs2.Font = new System.Drawing.Font("宋体", 15F);
            this.txtPs2.Location = new System.Drawing.Point(86, 288);
            this.txtPs2.Name = "txtPs2";
            this.txtPs2.PasswordChar = '*';
            this.txtPs2.Size = new System.Drawing.Size(227, 30);
            this.txtPs2.TabIndex = 14;
            this.txtPs2.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(319, 135);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 16;
            this.btnSend.Text = "发送验证码";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // labelCheck
            // 
            this.labelCheck.AutoSize = true;
            this.labelCheck.Location = new System.Drawing.Point(319, 193);
            this.labelCheck.Name = "labelCheck";
            this.labelCheck.Size = new System.Drawing.Size(77, 12);
            this.labelCheck.TabIndex = 17;
            this.labelCheck.Text = "验证码未通过";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Forget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(403, 373);
            this.Controls.Add(this.labelCheck);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.labelPs2);
            this.Controls.Add(this.txtPs2);
            this.Controls.Add(this.labelPs1);
            this.Controls.Add(this.txtPs1);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.labelFind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Forget";
            this.Text = "忘记密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFind;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label labelPs1;
        private System.Windows.Forms.TextBox txtPs1;
        private System.Windows.Forms.Label labelPs2;
        private System.Windows.Forms.TextBox txtPs2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label labelCheck;
        private System.Windows.Forms.Timer timer1;
    }
}