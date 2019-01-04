namespace CSharp_FinalWork
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.labelRegister = new System.Windows.Forms.Label();
            this.labelForget = new System.Windows.Forms.Label();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPwd = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("宋体", 13F);
            this.btnLogin.Location = new System.Drawing.Point(257, 206);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(163, 34);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "登陆";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 25F);
            this.label1.Location = new System.Drawing.Point(111, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "电影爱好者平台";
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("宋体", 15F);
            this.txtPwd.Location = new System.Drawing.Point(228, 147);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(216, 30);
            this.txtPwd.TabIndex = 6;
            this.txtPwd.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.Font = new System.Drawing.Font("宋体", 13F);
            this.labelRegister.Location = new System.Drawing.Point(12, 260);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(44, 18);
            this.labelRegister.TabIndex = 7;
            this.labelRegister.Text = "注册";
            this.labelRegister.Click += new System.EventHandler(this.labelRegister_Click);
            // 
            // labelForget
            // 
            this.labelForget.AutoSize = true;
            this.labelForget.Font = new System.Drawing.Font("宋体", 13F);
            this.labelForget.Location = new System.Drawing.Point(387, 260);
            this.labelForget.Name = "labelForget";
            this.labelForget.Size = new System.Drawing.Size(98, 18);
            this.labelForget.TabIndex = 8;
            this.labelForget.Text = "忘记密码？";
            this.labelForget.Click += new System.EventHandler(this.labelForget_Click);
            // 
            // cbUser
            // 
            this.cbUser.Font = new System.Drawing.Font("宋体", 15F);
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(228, 96);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(216, 28);
            this.cbUser.TabIndex = 9;
            this.cbUser.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelUser.Font = new System.Drawing.Font("宋体", 12F);
            this.labelUser.Location = new System.Drawing.Point(241, 102);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(56, 16);
            this.labelUser.TabIndex = 10;
            this.labelUser.Text = "用户名";
            // 
            // labelPwd
            // 
            this.labelPwd.AutoSize = true;
            this.labelPwd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPwd.Font = new System.Drawing.Font("宋体", 12F);
            this.labelPwd.Location = new System.Drawing.Point(241, 153);
            this.labelPwd.Name = "labelPwd";
            this.labelPwd.Size = new System.Drawing.Size(40, 16);
            this.labelPwd.TabIndex = 11;
            this.labelPwd.Text = "密码";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(497, 287);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelPwd);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.cbUser);
            this.Controls.Add(this.labelForget);
            this.Controls.Add(this.labelRegister);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "登陆";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label labelRegister;
        private System.Windows.Forms.Label labelForget;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPwd;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

