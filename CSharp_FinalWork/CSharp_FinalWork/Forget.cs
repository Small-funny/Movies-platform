using System;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CSharp_FinalWork
{
    public partial class Forget : Form
    {
        int code1;
        int t = 0;

        public Forget()
        {
            InitializeComponent();
            this.txtPs1.ReadOnly = true;
            this.txtPs2.ReadOnly = true;
            timer1.Enabled = true;
            timer1.Stop();
        }

        private void textChanged(object sender, EventArgs e)
        {
            if (sender.Equals(txtUser))
            {
                labelUser.Visible = txtUser.Text.Length < 1;
            }
            else if (sender.Equals(txtEmail))
            {
                labelEmail.Visible = txtEmail.Text.Length < 1;
            }
            else if (sender.Equals(txtCode))
            {
                labelCode.Visible = txtCode.Text.Length < 1;
            }
            else if(sender.Equals(txtPs1))
            {
                labelPs1.Visible = txtPs1.Text.Length < 1;
            }
            else if (sender.Equals(txtPs2))
            {
                labelPs2.Visible = txtPs2.Text.Length < 1;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(AccessOperation.Exists("Select * From Login where UserName = '" + txtUser.Text + "'") == false)
            {
                MessageBox.Show("该用户不存在！");
                txtUser.Text = "";
                txtEmail.Text = "";
                return;
            }
            if(AccessOperation.Exists("Select * From Login where UserName = '" + txtUser.Text + "' and Email = '" + txtEmail.Text + "'") == false)
            {
                MessageBox.Show("邮箱未与该用户绑定！");
                txtEmail.Text = "";
                return;
            }
            try
            {
                string sendName = "876398710@qq.com";
                string sendPass = "zxhzflglfxsebbjf";
                string reciveName = txtEmail.Text;
                string title = "电影爱好者平台验证码";
                Random rd = new Random();
                code1 = rd.Next(100000, 999999);
                string content = code1.ToString();
                SendEmail(sendName, sendPass, reciveName, title, content, "smtp.qq.com");
                timer1.Start();
                t = 60;
            }
            catch
            {
                MessageBox.Show("验证码发送失败！");
            }
            
        }

        private static void SendEmail(string sendName, string sendPass, string reciveName, string title, string content, string smtp)
        {
            MailAddress from = new MailAddress(sendName);//发件人
            MailAddress to = new MailAddress(reciveName);//收件人
            MailMessage message = new MailMessage(from, to);
            message.Subject = title;//主题
            message.Body = content;//邮件内容      
            SmtpClient client = new SmtpClient(smtp);//发件邮箱的SMTP服务器
            client.Credentials = new NetworkCredential(sendName, sendPass);
            client.Send(message);
            MessageBox.Show("验证码已发送，请在一分钟内输入验证码！");
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Regex pattern_password = new Regex(@"[\da-zA-Z0-9]{6,15}");
            if (!pattern_password.IsMatch(txtUser.Text))
            {
                MessageBox.Show("密码应为6到15位字母或数字！");
                txtPs1.Text = "";
                txtPs2.Text = "";
                return;
            }
            if(!txtPs1.Text.Equals(txtPs2.Text))
            {
                MessageBox.Show("两次输入的新密码不同！");
                txtPs1.Text = "";
                txtPs2.Text = "";
                return;
            }
            try
            {
                AccessOperation.ExecuteNonQuery("Update [Login] Set [Password]='" + txtPs1.Text + "' Where [UserName]='" + txtUser.Text + "'");
                MessageBox.Show("密码更改成功！");
                this.Hide();
                new Login().Show();
            }
            catch
            {
                MessageBox.Show("未知错误未能更新密码！");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelCheck.Text = (t--).ToString() + " s";
            if (t == -1)
            {
                timer1.Stop();
                labelCode.Text = "验证码未通过";
            }
            if (txtCode.Text.Equals(code1.ToString()) && t != -1)
            {
                labelCheck.Text = "验证通过！";
                timer1.Stop();
                txtPs1.ReadOnly = false;
                txtPs2.ReadOnly = false;
                return;
            }
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}
