namespace CSharp_FinalWork
{
    partial class singleDB
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelRate = new System.Windows.Forms.Label();
            this.labelPlace = new System.Windows.Forms.Label();
            this.labelActor = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelDescribe = new System.Windows.Forms.Label();
            this.txtDescribe = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAssess = new System.Windows.Forms.Button();
            this.btnSimliar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Location = new System.Drawing.Point(25, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(175, 224);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("宋体", 12F);
            this.labelName.Location = new System.Drawing.Point(286, 42);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(56, 16);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "片名：";
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Font = new System.Drawing.Font("宋体", 12F);
            this.labelRate.Location = new System.Drawing.Point(22, 250);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(56, 16);
            this.labelRate.TabIndex = 3;
            this.labelRate.Text = "评分：";
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Font = new System.Drawing.Font("宋体", 12F);
            this.labelPlace.Location = new System.Drawing.Point(22, 412);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(56, 16);
            this.labelPlace.TabIndex = 4;
            this.labelPlace.Text = "产地：";
            // 
            // labelActor
            // 
            this.labelActor.AutoSize = true;
            this.labelActor.Font = new System.Drawing.Font("宋体", 12F);
            this.labelActor.Location = new System.Drawing.Point(286, 99);
            this.labelActor.Name = "labelActor";
            this.labelActor.Size = new System.Drawing.Size(56, 16);
            this.labelActor.TabIndex = 5;
            this.labelActor.Text = "主演：";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("宋体", 12F);
            this.labelType.Location = new System.Drawing.Point(22, 304);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(56, 16);
            this.labelType.TabIndex = 6;
            this.labelType.Text = "类型：";
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Font = new System.Drawing.Font("宋体", 12F);
            this.labelLanguage.Location = new System.Drawing.Point(22, 361);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(56, 16);
            this.labelLanguage.TabIndex = 7;
            this.labelLanguage.Text = "语言：";
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Font = new System.Drawing.Font("宋体", 12F);
            this.labelDuration.Location = new System.Drawing.Point(286, 157);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(56, 16);
            this.labelDuration.TabIndex = 8;
            this.labelDuration.Text = "片长：";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("宋体", 12F);
            this.labelDate.Location = new System.Drawing.Point(286, 220);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(88, 16);
            this.labelDate.TabIndex = 9;
            this.labelDate.Text = "上映日期：";
            // 
            // labelDescribe
            // 
            this.labelDescribe.AutoSize = true;
            this.labelDescribe.Font = new System.Drawing.Font("宋体", 12F);
            this.labelDescribe.Location = new System.Drawing.Point(286, 285);
            this.labelDescribe.Name = "labelDescribe";
            this.labelDescribe.Size = new System.Drawing.Size(88, 16);
            this.labelDescribe.TabIndex = 10;
            this.labelDescribe.Text = "剧情简述：";
            // 
            // txtDescribe
            // 
            this.txtDescribe.Font = new System.Drawing.Font("宋体", 11F);
            this.txtDescribe.Location = new System.Drawing.Point(289, 315);
            this.txtDescribe.Multiline = true;
            this.txtDescribe.Name = "txtDescribe";
            this.txtDescribe.ReadOnly = true;
            this.txtDescribe.Size = new System.Drawing.Size(469, 218);
            this.txtDescribe.TabIndex = 11;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("宋体", 10F);
            this.btnBack.Location = new System.Drawing.Point(189, 506);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 27);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "返回";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAssess
            // 
            this.btnAssess.Font = new System.Drawing.Font("宋体", 10F);
            this.btnAssess.Location = new System.Drawing.Point(101, 473);
            this.btnAssess.Name = "btnAssess";
            this.btnAssess.Size = new System.Drawing.Size(76, 27);
            this.btnAssess.TabIndex = 13;
            this.btnAssess.Text = "查看评论";
            this.btnAssess.UseVisualStyleBackColor = true;
            this.btnAssess.Click += new System.EventHandler(this.btnAssess_Click);
            // 
            // btnSimliar
            // 
            this.btnSimliar.Font = new System.Drawing.Font("宋体", 10F);
            this.btnSimliar.Location = new System.Drawing.Point(12, 442);
            this.btnSimliar.Name = "btnSimliar";
            this.btnSimliar.Size = new System.Drawing.Size(76, 27);
            this.btnSimliar.TabIndex = 14;
            this.btnSimliar.Text = "相似电影";
            this.btnSimliar.UseVisualStyleBackColor = true;
            this.btnSimliar.Click += new System.EventHandler(this.btnSimliar_Click);
            // 
            // singleDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(770, 545);
            this.Controls.Add(this.btnSimliar);
            this.Controls.Add(this.btnAssess);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtDescribe);
            this.Controls.Add(this.labelDescribe);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.labelLanguage);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelActor);
            this.Controls.Add(this.labelPlace);
            this.Controls.Add(this.labelRate);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "singleDB";
            this.Text = "电影";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Label labelActor;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelDescribe;
        private System.Windows.Forms.TextBox txtDescribe;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAssess;
        private System.Windows.Forms.Button btnSimliar;
    }
}