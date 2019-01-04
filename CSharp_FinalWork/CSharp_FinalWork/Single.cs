using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace CSharp_FinalWork
{
    public partial class Single_DYTT : Form
    {
        string username;
        string messages;
        string links;
        string MovieName;

        public Single_DYTT(string u , string m)
        {
            InitializeComponent();
            username = u;
            //MessageBox.Show(username);
            try
            {
                messages = HttpGet("http://127.0.0.1:5000/MoviesDetail/" + m.Replace("/", "'"));
                JArray messages_jar = JArray.Parse(messages);

                JObject x;
                x = JObject.Parse(messages_jar[0].ToString());
                if (x["name"].ToString().Replace("'", "").Length == 0)
                    labelName.Text += '/';
                else
                    labelName.Text += x["name"].ToString().Replace("'", "");

                MovieName = x["name"].ToString().Replace("'", "");

                if (x["place"].ToString().Replace("'", "").Length == 0)
                    labelName.Text += '/';
                else
                    labelPlace.Text += x["place"].ToString().Replace("'", "");

                if (x["type"].ToString().Replace("'", "").Length == 0)
                    labelType.Text += '/';
                else
                    labelType.Text += x["type"].ToString().Replace("'", "");

                if (x["language"].ToString().Replace("'", "").Length == 0)
                    labelLanguage.Text += '/';
                else
                    labelLanguage.Text += x["language"].ToString().Replace("'", "");

                if (x["date"].ToString().Replace("'", "").Length == 0)
                    labelDate.Text += '/';
                else
                    labelDate.Text += x["date"].ToString().Replace("'", "");

                if (x["rate_db"].ToString().Replace("'", "").Length == 0)
                    labelDouban.Text += '/';
                else
                    labelDouban.Text += x["rate_db"].ToString().Replace("'", "");

                if (x["rate_IMDb"].ToString().Replace("'", "").Length == 0)
                    labelIMDb.Text += '/';
                else
                    labelIMDb.Text += x["rate_IMDb"].ToString().Replace("'", "");

                if (x["describe"].ToString().Replace("'", "").Length == 0)
                    labelDescribe.Text += '/';
                else
                    labelDescribe.Text += x["describe"].ToString().Replace("'", "").Replace("ldquo","").Replace("rdquo","").Replace("mdash","");

                if (x["actors"].ToString().Replace("'", "").Length == 0)
                    labelActor.Text += '/';
                else
                    labelActor.Text += x["actors"].ToString().Replace("'", "");

                if (x["duration"].ToString().Replace("'", "").Length == 0)
                    labelDuration.Text += '/';
                else
                    labelDuration.Text += x["duration"].ToString().Replace("'", "");
            }
            catch
            {
                MessageBox.Show("连接出错！");
                this.Hide();
                new Main(username).Show();
            }
            try
            {
                links = HttpGet("http://127.0.0.1:5000/MoviesLink/" + m.Replace("/", "'"));
                JArray links_jar = JArray.Parse(links);
                JObject y = JObject.Parse(links_jar[0].ToString());
                textBox1.Text += y["1"].ToString();
                    
            }
            catch
            {
                textBox1.Text = "无";
            }
        }

        public static string HttpGet(string url)
        {
            string result = string.Empty;
            try
            {
                HttpWebRequest wbRequest = (HttpWebRequest)WebRequest.Create(url);
                wbRequest.Method = "GET";
                HttpWebResponse wbResponse = (HttpWebResponse)wbRequest.GetResponse();
                using (Stream responseStream = wbResponse.GetResponseStream())
                {
                    using (StreamReader sReader = new StreamReader(responseStream))
                    {
                        result = sReader.ReadToEnd();
                    }
                }
            }
            catch
            {

            }
            return result;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show("");
                AccessOperation.ExecuteNonQuery("Insert Into [Record] ([Movie], [UserName], [Link]) VALUES('" + MovieName + "', '" + username + "', '" + textBox1.Text + "')");
                MessageBox.Show("收藏成功！");
            }
            catch
            {
                MessageBox.Show("收藏失败！");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            new Main(username).Show();
        }
    }
}
