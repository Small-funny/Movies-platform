namespace CSharp_FinalWork
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserName = new System.Windows.Forms.Label();
            this.LvHot = new System.Windows.Forms.ListView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.MoviesMessages = new System.Windows.Forms.TabControl();
            this.Hot = new System.Windows.Forms.TabPage();
            this.Coming = new System.Windows.Forms.TabPage();
            this.LvComing = new System.Windows.Forms.ListView();
            this.NewDownload = new System.Windows.Forms.TabPage();
            this.LvDownload = new System.Windows.Forms.ListView();
            this.Chinese = new System.Windows.Forms.TabPage();
            this.LvChinese = new System.Windows.Forms.ListView();
            this.Western = new System.Windows.Forms.TabPage();
            this.LvWestern = new System.Windows.Forms.ListView();
            this.Rihan = new System.Windows.Forms.TabPage();
            this.LvRihan = new System.Windows.Forms.ListView();
            this.labelSearch = new System.Windows.Forms.Label();
            this.txtSign = new System.Windows.Forms.TextBox();
            this.btnAbout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MoviesMessages.SuspendLayout();
            this.Hot.SuspendLayout();
            this.Coming.SuspendLayout();
            this.NewDownload.SuspendLayout();
            this.Chinese.SuspendLayout();
            this.Western.SuspendLayout();
            this.Rihan.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("幼圆", 23F, System.Drawing.FontStyle.Bold);
            this.UserName.Location = new System.Drawing.Point(130, 12);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(150, 31);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "UserName";
            // 
            // LvHot
            // 
            this.LvHot.Font = new System.Drawing.Font("宋体", 10F);
            this.LvHot.Location = new System.Drawing.Point(3, 3);
            this.LvHot.Name = "LvHot";
            this.LvHot.Size = new System.Drawing.Size(849, 310);
            this.LvHot.TabIndex = 3;
            this.LvHot.UseCompatibleStateImageBehavior = false;
            this.LvHot.View = System.Windows.Forms.View.Details;
            this.LvHot.SelectedIndexChanged += new System.EventHandler(this.LvHot_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("宋体", 18F);
            this.txtSearch.Location = new System.Drawing.Point(539, 83);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(244, 35);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("宋体", 12F);
            this.btnSearch.Location = new System.Drawing.Point(789, 83);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(63, 32);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "确定";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(133, 112);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(62, 23);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "注销";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MoviesMessages
            // 
            this.MoviesMessages.Controls.Add(this.Hot);
            this.MoviesMessages.Controls.Add(this.Coming);
            this.MoviesMessages.Controls.Add(this.NewDownload);
            this.MoviesMessages.Controls.Add(this.Chinese);
            this.MoviesMessages.Controls.Add(this.Western);
            this.MoviesMessages.Controls.Add(this.Rihan);
            this.MoviesMessages.Font = new System.Drawing.Font("宋体", 15F);
            this.MoviesMessages.Location = new System.Drawing.Point(0, 141);
            this.MoviesMessages.Name = "MoviesMessages";
            this.MoviesMessages.SelectedIndex = 0;
            this.MoviesMessages.Size = new System.Drawing.Size(863, 350);
            this.MoviesMessages.TabIndex = 13;
            this.MoviesMessages.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabCtree_Selected);
            // 
            // Hot
            // 
            this.Hot.Controls.Add(this.LvHot);
            this.Hot.Font = new System.Drawing.Font("宋体", 9F);
            this.Hot.Location = new System.Drawing.Point(4, 30);
            this.Hot.Name = "Hot";
            this.Hot.Padding = new System.Windows.Forms.Padding(3);
            this.Hot.Size = new System.Drawing.Size(855, 316);
            this.Hot.TabIndex = 0;
            this.Hot.Text = "正在热映";
            this.Hot.UseVisualStyleBackColor = true;
            // 
            // Coming
            // 
            this.Coming.Controls.Add(this.LvComing);
            this.Coming.Font = new System.Drawing.Font("宋体", 9F);
            this.Coming.Location = new System.Drawing.Point(4, 30);
            this.Coming.Name = "Coming";
            this.Coming.Padding = new System.Windows.Forms.Padding(3);
            this.Coming.Size = new System.Drawing.Size(855, 316);
            this.Coming.TabIndex = 1;
            this.Coming.Text = "即将上映";
            this.Coming.UseVisualStyleBackColor = true;
            // 
            // LvComing
            // 
            this.LvComing.Font = new System.Drawing.Font("宋体", 10F);
            this.LvComing.Location = new System.Drawing.Point(3, 3);
            this.LvComing.Name = "LvComing";
            this.LvComing.Size = new System.Drawing.Size(852, 310);
            this.LvComing.TabIndex = 13;
            this.LvComing.UseCompatibleStateImageBehavior = false;
            this.LvComing.View = System.Windows.Forms.View.Details;
            this.LvComing.SelectedIndexChanged += new System.EventHandler(this.LvComing_SelectedIndexChanged);
            // 
            // NewDownload
            // 
            this.NewDownload.Controls.Add(this.LvDownload);
            this.NewDownload.Location = new System.Drawing.Point(4, 30);
            this.NewDownload.Name = "NewDownload";
            this.NewDownload.Padding = new System.Windows.Forms.Padding(3);
            this.NewDownload.Size = new System.Drawing.Size(855, 316);
            this.NewDownload.TabIndex = 2;
            this.NewDownload.Text = "最新资源";
            this.NewDownload.UseVisualStyleBackColor = true;
            // 
            // LvDownload
            // 
            this.LvDownload.Font = new System.Drawing.Font("宋体", 10F);
            this.LvDownload.Location = new System.Drawing.Point(3, 3);
            this.LvDownload.Name = "LvDownload";
            this.LvDownload.Size = new System.Drawing.Size(849, 313);
            this.LvDownload.TabIndex = 18;
            this.LvDownload.UseCompatibleStateImageBehavior = false;
            this.LvDownload.View = System.Windows.Forms.View.Details;
            this.LvDownload.SelectedIndexChanged += new System.EventHandler(this.LvDownload_SelectedIndexChanged);
            // 
            // Chinese
            // 
            this.Chinese.Controls.Add(this.LvChinese);
            this.Chinese.Location = new System.Drawing.Point(4, 30);
            this.Chinese.Name = "Chinese";
            this.Chinese.Padding = new System.Windows.Forms.Padding(3);
            this.Chinese.Size = new System.Drawing.Size(855, 316);
            this.Chinese.TabIndex = 3;
            this.Chinese.Text = "国内资源";
            this.Chinese.UseVisualStyleBackColor = true;
            // 
            // LvChinese
            // 
            this.LvChinese.Font = new System.Drawing.Font("宋体", 10F);
            this.LvChinese.Location = new System.Drawing.Point(3, 3);
            this.LvChinese.Name = "LvChinese";
            this.LvChinese.Size = new System.Drawing.Size(849, 313);
            this.LvChinese.TabIndex = 19;
            this.LvChinese.UseCompatibleStateImageBehavior = false;
            this.LvChinese.View = System.Windows.Forms.View.Details;
            this.LvChinese.SelectedIndexChanged += new System.EventHandler(this.LvChineseMovies_SelectedIndexChanged);
            // 
            // Western
            // 
            this.Western.Controls.Add(this.LvWestern);
            this.Western.Location = new System.Drawing.Point(4, 30);
            this.Western.Name = "Western";
            this.Western.Padding = new System.Windows.Forms.Padding(3);
            this.Western.Size = new System.Drawing.Size(855, 316);
            this.Western.TabIndex = 4;
            this.Western.Text = "欧美资源";
            this.Western.UseVisualStyleBackColor = true;
            // 
            // LvWestern
            // 
            this.LvWestern.Font = new System.Drawing.Font("宋体", 10F);
            this.LvWestern.Location = new System.Drawing.Point(3, 3);
            this.LvWestern.Name = "LvWestern";
            this.LvWestern.Size = new System.Drawing.Size(849, 313);
            this.LvWestern.TabIndex = 19;
            this.LvWestern.UseCompatibleStateImageBehavior = false;
            this.LvWestern.View = System.Windows.Forms.View.Details;
            this.LvWestern.SelectedIndexChanged += new System.EventHandler(this.LvWestern_SelectedIndexChanged);
            // 
            // Rihan
            // 
            this.Rihan.Controls.Add(this.LvRihan);
            this.Rihan.Location = new System.Drawing.Point(4, 30);
            this.Rihan.Name = "Rihan";
            this.Rihan.Padding = new System.Windows.Forms.Padding(3);
            this.Rihan.Size = new System.Drawing.Size(855, 316);
            this.Rihan.TabIndex = 5;
            this.Rihan.Text = "日韩资源";
            this.Rihan.UseVisualStyleBackColor = true;
            // 
            // LvRihan
            // 
            this.LvRihan.Font = new System.Drawing.Font("宋体", 10F);
            this.LvRihan.Location = new System.Drawing.Point(3, 3);
            this.LvRihan.Name = "LvRihan";
            this.LvRihan.Size = new System.Drawing.Size(849, 313);
            this.LvRihan.TabIndex = 19;
            this.LvRihan.UseCompatibleStateImageBehavior = false;
            this.LvRihan.View = System.Windows.Forms.View.Details;
            this.LvRihan.SelectedIndexChanged += new System.EventHandler(this.LvRihan_SelectedIndexChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSearch.Font = new System.Drawing.Font("宋体", 13F);
            this.labelSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSearch.Location = new System.Drawing.Point(548, 92);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(80, 18);
            this.labelSearch.TabIndex = 14;
            this.labelSearch.Text = "搜索电影";
            // 
            // txtSign
            // 
            this.txtSign.Font = new System.Drawing.Font("宋体", 12F);
            this.txtSign.Location = new System.Drawing.Point(136, 66);
            this.txtSign.Name = "txtSign";
            this.txtSign.ReadOnly = true;
            this.txtSign.Size = new System.Drawing.Size(135, 26);
            this.txtSign.TabIndex = 15;
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(209, 112);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(62, 23);
            this.btnAbout.TabIndex = 16;
            this.btnAbout.Text = "关于";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(864, 492);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.txtSign);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.MoviesMessages);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "主页";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MoviesMessages.ResumeLayout(false);
            this.Hot.ResumeLayout(false);
            this.Coming.ResumeLayout(false);
            this.NewDownload.ResumeLayout(false);
            this.Chinese.ResumeLayout(false);
            this.Western.ResumeLayout(false);
            this.Rihan.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.ListView LvHot;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabControl MoviesMessages;
        private System.Windows.Forms.TabPage Hot;
        private System.Windows.Forms.TabPage Coming;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.ListView LvComing;
        private System.Windows.Forms.TabPage NewDownload;
        private System.Windows.Forms.ListView LvDownload;
        private System.Windows.Forms.TabPage Chinese;
        private System.Windows.Forms.TabPage Western;
        private System.Windows.Forms.TabPage Rihan;
        private System.Windows.Forms.ListView LvChinese;
        private System.Windows.Forms.ListView LvWestern;
        private System.Windows.Forms.ListView LvRihan;
        private System.Windows.Forms.TextBox txtSign;
        private System.Windows.Forms.Button btnAbout;
    }
}