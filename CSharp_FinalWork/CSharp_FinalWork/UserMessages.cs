using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CSharp_FinalWork
{
    public partial class UserMessages : Form
    {
        string username;
        string strFilePath = "";
        string s;

        public UserMessages(string u)
        {
            InitializeComponent();
            username = u;
            UserName.Text = u;
            btnSave.Enabled = false;
            txtSign.Text = AccessOperation.ExecuteScalar("Select Sign From Messages Where UserName='" + u + "'").ToString();
            try
            {
                s = AccessOperation.ExecuteScalar("Select Image From Messages Where UserName='" + u + "'").ToString();
            }
            catch
            {
                s = "";
            }
            try
            {
                
                Bitmap bmp = new Bitmap("D://image//" + s + ".bmp");
                pictureBox1.Image = bmp;
            }
            catch
            {
                Bitmap bmp = new Bitmap("timg.jpg");
                pictureBox1.Image = bmp;
            }
            txtSign2.Text = txtSign.Text;
            txtName.Text = AccessOperation.ExecuteScalar("Select RealName From Messages Where UserName='" + u + "'").ToString();
            txtOld.Text = AccessOperation.ExecuteScalar("Select Old From Messages Where UserName='" + u + "'").ToString();
            cbSex.Text = AccessOperation.ExecuteScalar("Select Sex From Messages Where UserName='" + u + "'").ToString();
            cbStyle.Text = AccessOperation.ExecuteScalar("Select Style From Messages Where UserName='" + u + "'").ToString();

            DataSet myDataSet = AccessOperation.Query("Select * From Record Where UserName='" + username + "'", "Record");
            dataGridView1.DataSource = myDataSet.Tables["Record"];
        }

        private void textChanged(object sender, EventArgs e)
        {
            if (sender.Equals(txtps1))
            {
                labelps1.Visible = txtps1.Text.Length < 1;
            }
            else if (sender.Equals(txtps2))
            {
                labelps2.Visible = txtps2.Text.Length < 1;
            }
            else if (sender.Equals(txtps3))
            {
                labelps3.Visible = txtps3.Text.Length < 1;
            }
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            
            new Main(username).Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg图片|*.JPG|gif图片|*.GIF|jpeg图片|*.JPEG";
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                Bitmap bmp = new Bitmap(ofd.FileName);
                strFilePath = ofd.FileName.Substring(ofd.FileName.LastIndexOf("\\") + 1, (ofd.FileName.LastIndexOf(".") - ofd.FileName.LastIndexOf("\\") - 1)); ;
                //MessageBox.Show(strFilePath);
                if (bmp == null)
                {
                    MessageBox.Show("加载图片失败！", "错误");
                    return;
                }
                btnSave.Enabled = true;
                pictureBox1.Image = bmp;
                ofd.Dispose();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image, pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);

            //检查是否存在文件夹
            string subPath = "D://image";
            if (false == System.IO.Directory.Exists(subPath))
            {
                //创建pic文件夹
                System.IO.Directory.CreateDirectory(subPath);
            }
            try { 
                bmp.Save("D://image//"+strFilePath+".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                Bitmap bmps = new Bitmap("D://image//" + strFilePath + ".bmp");
                pictureBox1.Image = bmps;
                AccessOperation.ExecuteNonQuery("Update [Messages] Set [Image]='" + strFilePath + "' Where [UserName]='" + username + "'");
            }
            catch
            {
                MessageBox.Show("保存失败(尝试更改文件名后上传)");
                return;
            }
            MessageBox.Show("保存成功！");
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            if (AccessOperation.Exists("Select * From Login where Password = '" + txtps1.Text + "' and UserName = '" + username + "'") == false)
            {
                MessageBox.Show("原密码错误！");
                txtps1.Text = "";
                txtps2.Text = "";
                txtps3.Text = "";
                return;
            }
            if(txtps1.Text == "" || txtps2.Text == "" || txtps3.Text == "")
            {
                MessageBox.Show("更改密码所需信息不能为空！");
                return;
            }
            Regex pattern_password = new Regex(@"[\da-zA-Z0-9]{6,15}");
            if(!pattern_password.IsMatch(txtps2.Text))
            {
                MessageBox.Show("密码应为6到15位字母或数字！");
                txtps2.Text = "";
                txtps3.Text = "";
                return;
            }
            if (!txtps2.Text.Equals(txtps3.Text))
            {
                MessageBox.Show("两次输入的新密码不同！");
                txtps2.Text = "";
                txtps3.Text = "";
                return;
            }
            try
            {
                AccessOperation.ExecuteNonQuery("Update [Login] Set [Password]='" + txtps2.Text + "' Where [UserName]='" + username + "'");
                MessageBox.Show("修改完成！");
            }catch
            {
                MessageBox.Show("修改失败！");
            }
        }

        private void btnSavemessage_Click(object sender, EventArgs e)
        {
            try
            {
                AccessOperation.ExecuteNonQuery("Update Messages Set Sex='" + cbSex.Text + "' Where UserName='" + username + "'");
                AccessOperation.ExecuteNonQuery("Update Messages Set Sign='" + txtSign2.Text + "' Where UserName='" + username + "'");
                AccessOperation.ExecuteNonQuery("Update Messages Set Old='" + txtOld.Text + "' Where UserName='" + username + "'");
                AccessOperation.ExecuteNonQuery("Update Messages Set RealName='" + txtName.Text + "' Where UserName='" + username + "'");
                AccessOperation.ExecuteNonQuery("Update Messages Set Style='" + cbStyle.Text + "' Where UserName='" + username + "'");
                MessageBox.Show("信息更新成功，界面主题会在下次开启本软件时更新!");
                
                skinEngine1.SkinFile = @"Skins\" + AccessOperation.ExecuteScalar("Select Style From Messages Where UserName='" + username + "'").ToString();
            }
            catch
            {
                MessageBox.Show("信息更新失败(未知错误)！");
            }
        }



        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        string movies = "";

        private void btnDelete_Click(object sender, EventArgs e)
        {
           if(movies != "")
            {
                AccessOperation.ExecuteNonQuery("Delete * From Record Where Movie = '" + movies + "' and UserName='"+username+"'");
                MessageBox.Show("删除成功！");
                DataSet myDataSet = AccessOperation.Query("Select * From Record Where UserName='" + username + "'", "Record");
                dataGridView1.DataSource = myDataSet.Tables["Record"];
            }
           else
            {
                MessageBox.Show("未选中行！");
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            movies = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            MessageBox.Show(movies);
        }
    }
}
