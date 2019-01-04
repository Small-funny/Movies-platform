using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CSharp_FinalWork
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.skinEngine1.SkinFile = @"Skins\Calmness.ssk";
            try
            {
                OleDbDataReader reader = AccessOperation.ExecuteReader("Select UserName From UsedUser");
                List<string> list = new List<string>();
                while (reader.Read())
                {
                    list.Add(reader.GetString(0));
                }
                cbUser.DataSource = list;
            }
            catch
            {
                MessageBox.Show("数据库无法打开！");
                Application.Exit();
            }
        }

        string username = "";

        private void textChanged(object sender, EventArgs e)
        {
            if (sender.Equals(cbUser))
            {
                labelUser.Visible = cbUser.Text.Length < 1;
                string s = "";
                try
                {
                    s = AccessOperation.ExecuteScalar("Select Image From Messages where UserName = '" + cbUser.Text + "'").ToString();
                }
                catch
                {
                    Bitmap bmp = new Bitmap("timg.jpg");
                    pictureBox1.Image = bmp;
                }
                if (s != "")
                {
                    if (File.Exists("D://image//" + s + ".bmp"))
                    {
                        Bitmap bmp = new Bitmap("D://image//" + s + ".bmp");
                        pictureBox1.Image = bmp;
                    }
                    else
                    {
                        Bitmap bmp = new Bitmap("timg.jpg");
                        pictureBox1.Image = bmp;
                    }
                }
            }
            else if (sender.Equals(txtPwd))
            {
                labelPwd.Visible = txtPwd.Text.Length < 1;
            }
        }

        private void labelRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Register().Show();
        }

        private void labelForget_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Forget().Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtPwd.Text.Length == 0 || cbUser.Text.Length == 0)
            {
                MessageBox.Show("用户名或密码不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (AccessOperation.Exists("Select * From Login where UserName='" + cbUser.Text + "'") == false)
            {
                MessageBox.Show("用户不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(AccessOperation.Exists("Select * From Login where Password = '" + txtPwd.Text + "' and UserName = '"+cbUser.Text+"'") == false)
            {
                MessageBox.Show("密码错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (AccessOperation.Exists("Select * From Login where Password = '" + txtPwd.Text + "' and UserName = '" + cbUser.Text + "'" ))
            {
                username = cbUser.Text;
                MessageBox.Show("欢迎使用电影爱好者平台！");
                if(!AccessOperation.Exists("Select * From UsedUser where UserName = '" + cbUser.Text + "'"))
                {
                    try
                    {
                        AccessOperation.ExecuteNonQuery("Insert Into [UsedUser] VALUES('" + cbUser.Text + "')");
                    }catch
                    {
                        MessageBox.Show("未能插入本次登陆记录");
                    }
                }
                this.Hide();
                this.skinEngine1.SkinFile = @"Skins\"+AccessOperation.ExecuteScalar("Select Style From Messages where UserName = '" + cbUser.Text + "'");
                new Main(username).Show();
                return;
            }
        }
    }
}
