using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace CSharp_FinalWork
{
    public partial class singleDB : Form
    {
        string username = "";
        string Link = "";

        public singleDB(string username , string Link , string a,string b , string c , string d , string e , int x)
        {
            InitializeComponent();
            this.Link = Link;
            this.username = username;
            cn.smallfunny.web.WebService Movies = new cn.smallfunny.web.WebService();

            cn.smallfunny.web.model_detail messages = null;
            try
            {
                messages = Movies.MessageDetail(Link ,x);
            }
            catch
            {
                MessageBox.Show("列表加载出错！");
            }
            if (x == 1)
            {
                labelName.Text += a;
                labelRate.Text += b;
                labelDuration.Text += c;
                labelPlace.Text += d;
                labelActor.Text += e;
                labelType.Text += messages.Type;
                labelLanguage.Text += messages.Language;
                labelDate.Text += messages.Date;
            }
            else
            {
                labelName.Text += a;
                labelRate.Text += "/";
                labelDate.Text += b.Replace("\n" , "");
                labelPlace.Text += c.Replace("\n","");
                labelType.Text += d.Replace("\n" , "");
                labelActor.Text += messages.Actor;
                labelDuration.Text += messages.Duration;
                labelLanguage.Text += "/";
            }
            txtDescribe.Text += messages.Describe.Replace(" ", "");
            setpicture(messages.Image);

            if(e == "/")
            {
                btnAssess.Enabled = false;
            }
            else
            {
                btnAssess.Enabled = true;
            }
        }

        private void setpicture(string url)
        {
            WebRequest webreq = WebRequest.Create(url);
            WebResponse webres = webreq.GetResponse();
            using (Stream stream = webres.GetResponseStream())
            {
                pictureBox.Image = Image.FromStream(stream);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Main(username).Show();
        }

        private void btnAssess_Click(object sender, EventArgs e)
        {

            new Assess(Link).Show();
        }

        private void btnSimliar_Click(object sender, EventArgs e)
        {
            
            new Related(username , Link).Show();
        }
    }
}
