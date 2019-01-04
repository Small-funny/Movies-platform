using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_FinalWork
{
    public partial class SearchResult : Form
    {
        string moviesname;
        string username;
        string[] Links = new string[20];

        public SearchResult(string u , string m)
        {
            InitializeComponent();
            //MessageBox.Show(u);
            this.username = u;
            this.moviesname = m;
            JArray SearchMovies_jar = null;
            try
            {
                string SearchMovies = HttpGet("http://127.0.0.1:5000/MoviesTitle/" + m);
                SearchMovies_jar = JArray.Parse(SearchMovies);
            }catch
            {
                MessageBox.Show("资源加载失败");
                this.Hide();
                new Main(username).Show();
            }
            LvTitle.Columns.Add("资源", 290, HorizontalAlignment.Center);
            LvTitle.Columns.Add("评分", 80, HorizontalAlignment.Center);
            LvTitle.Columns.Add("语言", 150, HorizontalAlignment.Center);
            LvTitle.Columns.Add("产地", 80, HorizontalAlignment.Center);
            LvTitle.Columns.Add("类型", 150, HorizontalAlignment.Center);

            LvTitle.BeginUpdate();

            for (int i = 1; i < SearchMovies_jar.Count; i++)
            {
                JObject j = JObject.Parse(SearchMovies_jar[i].ToString());
                ListViewItem item = new ListViewItem();
                Links[i] = j["link"].ToString();
                //MessageBox.Show(Links[i]);
                item.Text = j["name"].ToString();
                if (j["rate"].ToString().Length != 0 && !j["rate"].ToString().Contains(","))
                    item.SubItems.Add(j["rate"].ToString());
                else if (j["rate"].ToString().Length == 0)
                    item.SubItems.Add("/");
                else if (j["rate"].ToString().Contains(","))
                    item.SubItems.Add(j["rate"].ToString().Substring(0, j["rate"].ToString().IndexOf(",")));
                if (j["language"].ToString().Length != 0 && !j["language"].ToString().Contains(","))
                    item.SubItems.Add(j["language"].ToString());
                else if (j["language"].ToString().Length == 0)
                    item.SubItems.Add("/");
                else if (j["language"].ToString().Contains(","))
                    item.SubItems.Add(j["language"].ToString().Substring(0, j["language"].ToString().IndexOf(",")));
                if (j["place"].ToString().Length != 0 && !j["place"].ToString().Contains(","))
                    item.SubItems.Add(j["place"].ToString());
                else if (j["place"].ToString().Length == 0)
                    item.SubItems.Add("/");
                else if (j["place"].ToString().Contains(","))
                    item.SubItems.Add(j["place"].ToString().Substring(0, j["place"].ToString().IndexOf(",")));
                if (j["type"].ToString().Length != 0 && !j["type"].ToString().Contains(","))
                    item.SubItems.Add(j["type"].ToString());
                else if (j["type"].ToString().Length == 0)
                    item.SubItems.Add("/");
                else if (j["type"].ToString().Contains(","))
                    item.SubItems.Add(j["type"].ToString().Substring(0, j["type"].ToString().IndexOf(",")));
                LvTitle.Items.Add(item);
            }

            LvTitle.EndUpdate();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Main(username).Show();
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
                MessageBox.Show("连接中断！");
            }
            return result;
        }

        private void LvTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListView.SelectedIndexCollection indexes = this.LvTitle.SelectedIndices;
                if (indexes.Count > 0)
                {
                    int index = indexes[0];
                    this.Hide();
                    //MessageBox.Show(Links[index+1]);
                    //MessageBox.Show(username);
                    new Single_DYTT(username, Links[index+1]).Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作失败！\n" + ex.Message, "提示", MessageBoxButtons.OK,
                                  MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
