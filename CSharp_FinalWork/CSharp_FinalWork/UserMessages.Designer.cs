namespace CSharp_FinalWork
{
    partial class UserMessages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMessages));
            this.btnLogout = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.GbMessages = new System.Windows.Forms.GroupBox();
            this.btnSavemessage = new System.Windows.Forms.Button();
            this.cbStyle = new System.Windows.Forms.ComboBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.labelLike = new System.Windows.Forms.Label();
            this.txtOld = new System.Windows.Forms.TextBox();
            this.labelOld = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.Sign = new System.Windows.Forms.Label();
            this.txtSign2 = new System.Windows.Forms.TextBox();
            this.GbPassword = new System.Windows.Forms.GroupBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.labelps3 = new System.Windows.Forms.Label();
            this.txtps3 = new System.Windows.Forms.TextBox();
            this.labelps2 = new System.Windows.Forms.Label();
            this.labelps1 = new System.Windows.Forms.Label();
            this.txtps2 = new System.Windows.Forms.TextBox();
            this.txtps1 = new System.Windows.Forms.TextBox();
            this.txtSign = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GbMessages.SuspendLayout();
            this.GbPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(136, 110);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(62, 23);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "注销";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("幼圆", 23F, System.Drawing.FontStyle.Bold);
            this.UserName.Location = new System.Drawing.Point(130, 12);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(150, 31);
            this.UserName.TabIndex = 13;
            this.UserName.Text = "UserName";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("宋体", 9F);
            this.btnBack.Location = new System.Drawing.Point(136, 141);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "返回主界面";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // GbMessages
            // 
            this.GbMessages.Controls.Add(this.btnSavemessage);
            this.GbMessages.Controls.Add(this.cbStyle);
            this.GbMessages.Controls.Add(this.cbSex);
            this.GbMessages.Controls.Add(this.labelLike);
            this.GbMessages.Controls.Add(this.txtOld);
            this.GbMessages.Controls.Add(this.labelOld);
            this.GbMessages.Controls.Add(this.labelSex);
            this.GbMessages.Controls.Add(this.txtName);
            this.GbMessages.Controls.Add(this.labelName);
            this.GbMessages.Controls.Add(this.Sign);
            this.GbMessages.Controls.Add(this.txtSign2);
            this.GbMessages.Font = new System.Drawing.Font("宋体", 12F);
            this.GbMessages.Location = new System.Drawing.Point(286, 12);
            this.GbMessages.Name = "GbMessages";
            this.GbMessages.Size = new System.Drawing.Size(462, 353);
            this.GbMessages.TabIndex = 17;
            this.GbMessages.TabStop = false;
            this.GbMessages.Text = "信息与设置";
            // 
            // btnSavemessage
            // 
            this.btnSavemessage.Font = new System.Drawing.Font("宋体", 10F);
            this.btnSavemessage.Location = new System.Drawing.Point(196, 314);
            this.btnSavemessage.Name = "btnSavemessage";
            this.btnSavemessage.Size = new System.Drawing.Size(75, 23);
            this.btnSavemessage.TabIndex = 22;
            this.btnSavemessage.Text = "保存";
            this.btnSavemessage.UseVisualStyleBackColor = true;
            this.btnSavemessage.Click += new System.EventHandler(this.btnSavemessage_Click);
            // 
            // cbStyle
            // 
            this.cbStyle.Font = new System.Drawing.Font("宋体", 12F);
            this.cbStyle.FormattingEnabled = true;
            this.cbStyle.Items.AddRange(new object[] {
            "Calmness.ssk",
            "CalmnessColor1.ssk",
            "CalmnessColor2.ssk",
            "DeepCyan.ssk",
            "DeepGreen.ssk",
            "DeepOrange.ssk",
            "DiamondBlue.ssk",
            "DiamondGreen.ssk",
            "DiamondOlive.ssk",
            "DiamondPurple.ssk",
            "DiamondRed.ssk",
            "Eighteen.ssk",
            "EighteenColor1.ssk",
            "EighteenColor2.ssk",
            "Emerald.ssk",
            "EmeraldColor1.ssk",
            "EmeraldColor2.ssk",
            "EmeraldColor3.ssk",
            "GlassBrown.ssk",
            "GlassGreen.ssk",
            "GlassOrange.ssk",
            "Longhorn.ssk",
            "MacOS.ssk",
            "Midsummer.ssk",
            "MidsummerColor1.ssk",
            "MidsummerColor2.ssk",
            "MidsummerColor3.ssk",
            "mp10.ssk",
            "mp10green.ssk",
            "mp10maroon.ssk",
            "mp10mulberry.ssk",
            "mp10pink.ssk",
            "mp10purple.ssk",
            "MSN.ssk",
            "office2007.ssk",
            "OneBlue.ssk",
            "OneCyan.ssk",
            "OneGreen.ssk",
            "OneOrange.ssk",
            "Page.ssk",
            "PageColor1.ssk",
            "PageColor2.ssk",
            "RealOne.ssk",
            "Silver.ssk",
            "SilverColor1.ssk",
            "SilverColor2.ssk",
            "SportsBlack.ssk",
            "SportsBlue.ssk",
            "SportsCyan.ssk",
            "SportsGreen.ssk",
            "SportsOrange.ssk",
            "SteelBlack.ssk",
            "SteelBlue.ssk",
            "vista1.ssk",
            "vista1_green.ssk",
            "Vista2_color1.ssk",
            "Vista2_color2.ssk",
            "Vista2_color3.ssk",
            "Vista2_color4.ssk",
            "Vista2_color5.ssk",
            "Vista2_color6.ssk",
            "Vista2_color7.ssk",
            "Warm.ssk"});
            this.cbStyle.Location = new System.Drawing.Point(304, 64);
            this.cbStyle.Name = "cbStyle";
            this.cbStyle.Size = new System.Drawing.Size(133, 24);
            this.cbStyle.TabIndex = 11;
            // 
            // cbSex
            // 
            this.cbSex.Font = new System.Drawing.Font("宋体", 12F);
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbSex.Location = new System.Drawing.Point(304, 25);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(133, 24);
            this.cbSex.TabIndex = 10;
            // 
            // labelLike
            // 
            this.labelLike.AutoSize = true;
            this.labelLike.Font = new System.Drawing.Font("宋体", 12F);
            this.labelLike.Location = new System.Drawing.Point(239, 67);
            this.labelLike.Name = "labelLike";
            this.labelLike.Size = new System.Drawing.Size(56, 16);
            this.labelLike.TabIndex = 8;
            this.labelLike.Text = "主题：";
            // 
            // txtOld
            // 
            this.txtOld.Font = new System.Drawing.Font("宋体", 12F);
            this.txtOld.Location = new System.Drawing.Point(86, 64);
            this.txtOld.Name = "txtOld";
            this.txtOld.Size = new System.Drawing.Size(129, 26);
            this.txtOld.TabIndex = 7;
            // 
            // labelOld
            // 
            this.labelOld.AutoSize = true;
            this.labelOld.Font = new System.Drawing.Font("宋体", 12F);
            this.labelOld.Location = new System.Drawing.Point(21, 67);
            this.labelOld.Name = "labelOld";
            this.labelOld.Size = new System.Drawing.Size(56, 16);
            this.labelOld.TabIndex = 6;
            this.labelOld.Text = "年龄：";
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Font = new System.Drawing.Font("宋体", 12F);
            this.labelSex.Location = new System.Drawing.Point(239, 28);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(56, 16);
            this.labelSex.TabIndex = 4;
            this.labelSex.Text = "性别：";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("宋体", 12F);
            this.txtName.Location = new System.Drawing.Point(86, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(129, 26);
            this.txtName.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("宋体", 12F);
            this.labelName.Location = new System.Drawing.Point(21, 28);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(56, 16);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "姓名：";
            // 
            // Sign
            // 
            this.Sign.AutoSize = true;
            this.Sign.Font = new System.Drawing.Font("宋体", 12F);
            this.Sign.Location = new System.Drawing.Point(11, 100);
            this.Sign.Name = "Sign";
            this.Sign.Size = new System.Drawing.Size(56, 16);
            this.Sign.TabIndex = 1;
            this.Sign.Text = "签名：";
            // 
            // txtSign2
            // 
            this.txtSign2.Location = new System.Drawing.Point(6, 119);
            this.txtSign2.Multiline = true;
            this.txtSign2.Name = "txtSign2";
            this.txtSign2.Size = new System.Drawing.Size(450, 179);
            this.txtSign2.TabIndex = 0;
            // 
            // GbPassword
            // 
            this.GbPassword.Controls.Add(this.btnPost);
            this.GbPassword.Controls.Add(this.labelps3);
            this.GbPassword.Controls.Add(this.txtps3);
            this.GbPassword.Controls.Add(this.labelps2);
            this.GbPassword.Controls.Add(this.labelps1);
            this.GbPassword.Controls.Add(this.txtps2);
            this.GbPassword.Controls.Add(this.txtps1);
            this.GbPassword.Font = new System.Drawing.Font("宋体", 12F);
            this.GbPassword.Location = new System.Drawing.Point(12, 170);
            this.GbPassword.Name = "GbPassword";
            this.GbPassword.Size = new System.Drawing.Size(268, 195);
            this.GbPassword.TabIndex = 18;
            this.GbPassword.TabStop = false;
            this.GbPassword.Text = "修改密码";
            // 
            // btnPost
            // 
            this.btnPost.Font = new System.Drawing.Font("宋体", 10F);
            this.btnPost.Location = new System.Drawing.Point(85, 154);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 21;
            this.btnPost.Text = "确定";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // labelps3
            // 
            this.labelps3.AutoSize = true;
            this.labelps3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelps3.Location = new System.Drawing.Point(56, 120);
            this.labelps3.Name = "labelps3";
            this.labelps3.Size = new System.Drawing.Size(136, 16);
            this.labelps3.TabIndex = 5;
            this.labelps3.Text = "请再次输入新密码";
            // 
            // txtps3
            // 
            this.txtps3.Location = new System.Drawing.Point(19, 117);
            this.txtps3.Name = "txtps3";
            this.txtps3.PasswordChar = '*';
            this.txtps3.Size = new System.Drawing.Size(233, 26);
            this.txtps3.TabIndex = 4;
            this.txtps3.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // labelps2
            // 
            this.labelps2.AutoSize = true;
            this.labelps2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelps2.Location = new System.Drawing.Point(56, 75);
            this.labelps2.Name = "labelps2";
            this.labelps2.Size = new System.Drawing.Size(104, 16);
            this.labelps2.TabIndex = 3;
            this.labelps2.Text = "请输入新密码";
            // 
            // labelps1
            // 
            this.labelps1.AutoSize = true;
            this.labelps1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelps1.Location = new System.Drawing.Point(56, 30);
            this.labelps1.Name = "labelps1";
            this.labelps1.Size = new System.Drawing.Size(120, 16);
            this.labelps1.TabIndex = 2;
            this.labelps1.Text = "请输入原先密码";
            // 
            // txtps2
            // 
            this.txtps2.Location = new System.Drawing.Point(19, 72);
            this.txtps2.Name = "txtps2";
            this.txtps2.PasswordChar = '*';
            this.txtps2.Size = new System.Drawing.Size(233, 26);
            this.txtps2.TabIndex = 1;
            this.txtps2.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // txtps1
            // 
            this.txtps1.Location = new System.Drawing.Point(19, 25);
            this.txtps1.Name = "txtps1";
            this.txtps1.PasswordChar = '*';
            this.txtps1.Size = new System.Drawing.Size(233, 26);
            this.txtps1.TabIndex = 0;
            this.txtps1.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // txtSign
            // 
            this.txtSign.Font = new System.Drawing.Font("宋体", 12F);
            this.txtSign.Location = new System.Drawing.Point(136, 70);
            this.txtSign.Name = "txtSign";
            this.txtSign.ReadOnly = true;
            this.txtSign.Size = new System.Drawing.Size(144, 26);
            this.txtSign.TabIndex = 19;
            this.txtSign.Text = "sign";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(31, 141);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(766, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(246, 251);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(853, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "收藏夹";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(857, 324);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            // UserMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 377);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSign);
            this.Controls.Add(this.GbPassword);
            this.Controls.Add(this.GbMessages);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "UserMessages";
            this.Text = "个人主页";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GbMessages.ResumeLayout(false);
            this.GbMessages.PerformLayout();
            this.GbPassword.ResumeLayout(false);
            this.GbPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox GbMessages;
        private System.Windows.Forms.GroupBox GbPassword;
        private System.Windows.Forms.TextBox txtps2;
        private System.Windows.Forms.TextBox txtps1;
        private System.Windows.Forms.Label labelps3;
        private System.Windows.Forms.TextBox txtps3;
        private System.Windows.Forms.Label labelps2;
        private System.Windows.Forms.Label labelps1;
        private System.Windows.Forms.TextBox txtSign2;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.Label labelLike;
        private System.Windows.Forms.TextBox txtOld;
        private System.Windows.Forms.Label labelOld;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label Sign;
        private System.Windows.Forms.TextBox txtSign;
        private System.Windows.Forms.ComboBox cbStyle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSavemessage;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}