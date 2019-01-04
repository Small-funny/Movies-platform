using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CSharp_FinalWork
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void textChanged(object sender, EventArgs e)
        {
            if (sender.Equals(txtUser))
            {
                labelUser.Visible = txtUser.Text.Length < 1;
            }
            else if (sender.Equals(txtPwd))
            {
                labelPwd.Visible = txtPwd.Text.Length < 1;
            }
            else if (sender.Equals(txtRepeat))
            {
                labelRepeat.Visible = txtRepeat.Text.Length < 1;
            }
            else if (sender.Equals(txtEmail))
            {
                labelEmail.Visible = txtEmail.Text.Length < 1;
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Regex pattern_email = new Regex(@"^[A-Za-z\d]+([-_.][A-Za-z\d]+)*@([A-Za-z\d]+[-.])+[A-Za-z\d]{2,4}$");
            Regex pattern_username = new Regex(@"[\da-zA-Z0-9]{2,10}");
            Regex pattern_password = new Regex(@"[\da-zA-Z0-9]{6,15}");
            if(txtUser.Text.Length == 0)
            {
                MessageBox.Show("用户名不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtEmail.Text.Length == 0)
            {
                MessageBox.Show("邮箱不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPwd.Text.Length == 0)
            {
                MessageBox.Show("密码不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (AccessOperation.Exists("Select * From Login where UserName='" + txtUser.Text + "'") != false)
            {
                MessageBox.Show("用户名重复！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Text = "";
                return;
            }
            if(!pattern_username.IsMatch(txtUser.Text))
            {
                MessageBox.Show("用户名应为2到10位字母或数字！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Text = "";
                return;
            }
            if (AccessOperation.Exists("Select * From Login where Email='" + txtEmail.Text + "'"))
            {
                MessageBox.Show("邮箱已使用！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Text = "";
                return;
            }
            if (!pattern_email.IsMatch(txtEmail.Text))
            {
                MessageBox.Show("邮箱格式错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Text = "";
                return;
            }
            if(!pattern_password.IsMatch(txtUser.Text))
            {
                MessageBox.Show("密码应为6到15位字母或数字！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPwd.Text = "";
                txtRepeat.Text = "";
                return;
            }
            if(txtRepeat.Text.Equals(txtPwd.Text) == false)
            {
                MessageBox.Show("密码两次输入不相同！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPwd.Text = "";
                txtRepeat.Text = "";
                return;
            }
            AccessOperation.ExecuteNonQuery("Insert Into [Login] ([UserName], [Password], [Email]) VALUES('"+txtUser.Text+"', '"+txtPwd.Text+"', '"+txtEmail.Text+"')");
            MessageBox.Show("注册成功！");
            this.Hide();
            new InputMessages(txtUser.Text).Show();
            return;
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
            return;
        }
    }
}
