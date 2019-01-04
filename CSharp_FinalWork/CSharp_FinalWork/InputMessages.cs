using System;
using System.Windows.Forms;

namespace CSharp_FinalWork
{
    public partial class InputMessages : Form
    {
        string username;

        public InputMessages(string u)
        {
            InitializeComponent();
            username = u;
        }

        private void btnSavemessage_Click(object sender, EventArgs e)
        {
            try
            {
                AccessOperation.ExecuteNonQuery("Insert Into [Messages] ([UserName], [RealName], [Sign],[Sex],[Old],[Style]) VALUES('" + username + "', '" + txtName.Text + "', '" + txtSign2.Text + "','" + cbSex.Text + "','" + txtOld.Text + "','" + cbStyle.Text + "')");
                MessageBox.Show("信息插入成功！");
                this.Hide();
                new Login().Show();
            }
            catch
            {
                MessageBox.Show("信息插入失败(未知错误)！");
            }
        }
    }
}
