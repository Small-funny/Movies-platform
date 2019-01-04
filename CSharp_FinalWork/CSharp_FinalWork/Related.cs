using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_FinalWork
{
    public partial class Related : Form
    {
        string username;
        WebService.WebServiceSoapClient Movies = new WebService.WebServiceSoapClient();
        WebService.model_moviecrude[] RelatedMovies = null;

        public Related(string u , string Link)
        {
            InitializeComponent();
            username = u;

            try
            {
                RelatedMovies = Movies.RelatedMovies(Link).ToArray();
            }
            catch
            {
                MessageBox.Show("加载失败！");
                this.Hide();
                new Main(username);
            }

            try
            {
                textBox1.Text = RelatedMovies[0].Name;
                textBox2.Text = RelatedMovies[1].Name;
                textBox3.Text = RelatedMovies[2].Name;
                textBox4.Text = RelatedMovies[3].Name;
                textBox5.Text = RelatedMovies[4].Name;
                textBox6.Text = RelatedMovies[5].Name;
                textBox7.Text = RelatedMovies[6].Name;
                textBox8.Text = RelatedMovies[7].Name;
                textBox9.Text = RelatedMovies[8].Name;
                textBox10.Text = RelatedMovies[9].Name;

                setpicture(RelatedMovies[0].Image, pictureBox1);
                setpicture(RelatedMovies[1].Image, pictureBox2);
                setpicture(RelatedMovies[2].Image, pictureBox3);
                setpicture(RelatedMovies[3].Image, pictureBox4);
                setpicture(RelatedMovies[4].Image, pictureBox5);
                setpicture(RelatedMovies[5].Image, pictureBox6);
                setpicture(RelatedMovies[6].Image, pictureBox7);
                setpicture(RelatedMovies[7].Image, pictureBox8);
                setpicture(RelatedMovies[8].Image, pictureBox9);
                setpicture(RelatedMovies[9].Image, pictureBox10);
            }
            catch
            {
                MessageBox.Show("暂无相关影片推荐！");
                this.Hide();
            }
        }

        private void setpicture(string url , PictureBox pictureBox)
        {
            WebRequest webreq = WebRequest.Create(url);
            WebResponse webres = webreq.GetResponse();
            using (Stream stream = webres.GetResponseStream())
            {
                pictureBox.Image = Image.FromStream(stream);
            }
        }
    }
}
