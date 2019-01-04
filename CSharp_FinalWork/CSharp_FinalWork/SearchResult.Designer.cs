namespace CSharp_FinalWork
{
    partial class SearchResult
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.LvTitle = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("宋体", 15F);
            this.BtnBack.Location = new System.Drawing.Point(329, 317);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(133, 32);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "返回";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // LvTitle
            // 
            this.LvTitle.Location = new System.Drawing.Point(12, 12);
            this.LvTitle.Name = "LvTitle";
            this.LvTitle.Size = new System.Drawing.Size(751, 280);
            this.LvTitle.TabIndex = 1;
            this.LvTitle.UseCompatibleStateImageBehavior = false;
            this.LvTitle.View = System.Windows.Forms.View.Details;
            this.LvTitle.SelectedIndexChanged += new System.EventHandler(this.LvTitle_SelectedIndexChanged);
            // 
            // SearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(775, 361);
            this.Controls.Add(this.LvTitle);
            this.Controls.Add(this.BtnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchResult";
            this.Text = "搜索结果";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.ListView LvTitle;
    }
}