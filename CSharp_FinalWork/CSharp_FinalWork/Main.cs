using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Threading;
using System.Drawing;

namespace CSharp_FinalWork
{
    public partial class Main : Form
    {
        string username = "";
        WebService.WebServiceSoapClient Movies = new WebService.WebServiceSoapClient();
        bool[] flag = new bool[6] { false, false, false, false, false, false };
        string[] HotLinks = new string[100];
        string[] ComingLinks = new string[100];
        string[] NewDownloadLinks = new string[100];
        string[] ChineseLinks = new string[100];
        string[] WesternLinks = new string[100];
        string[] RihanLinks = new string[100];

        public Main(string u)
        {
            InitializeComponent();
            //MessageBox.Show(skin);
            //MessageBox.Show(skinEngine1.SkinFile);
            this.username = u;
            UserName.Text = u;
            
            try
            {
                txtSign.Text = AccessOperation.ExecuteScalar("Select Sign From Messages Where UserName='" + u + "'").ToString();
            }catch(Exception ex){
                MessageBox.Show(ex.ToString());
            }
            try
            {
                string s = AccessOperation.ExecuteScalar("Select Image From Messages Where UserName='" + u + "'").ToString();
                Bitmap bmp = new Bitmap("D://image//" + s + ".bmp");
                pictureBox1.Image = bmp;
            }
            catch
            {
                Bitmap bmp = new Bitmap("timg.jpg");
                pictureBox1.Image = bmp;
            }

            LvHot.Columns.Add("片名", 178, HorizontalAlignment.Center);
            LvHot.Columns.Add("时间", 65, HorizontalAlignment.Center);
            LvHot.Columns.Add("评分", 65, HorizontalAlignment.Center);
            LvHot.Columns.Add("时长", 114, HorizontalAlignment.Center);
            LvHot.Columns.Add("产地", 94, HorizontalAlignment.Center);
            LvHot.Columns.Add("演员", 315, HorizontalAlignment.Center);

            LvHot.BeginUpdate();

            WebService.model_movies[] HotMovies = null;

            try
            {
                HotMovies = Movies.Message().ToArray();
            }
            catch
            {
                MessageBox.Show("初始化失败！");
                this.Hide();
                new Login().Show();
                return;
            }

            for (int i = 0; i < HotMovies.Length; i++)
            {
                ListViewItem item = new ListViewItem();
                HotLinks[i] = HotMovies[i].Link;
                item.Text = HotMovies[i].Name;
                item.SubItems.Add(HotMovies[i].Times);
                item.SubItems.Add(HotMovies[i].Rate);
                item.SubItems.Add(HotMovies[i].Duration);
                item.SubItems.Add(HotMovies[i].Place);
                item.SubItems.Add(HotMovies[i].Actor);
                LvHot.Items.Add(item);
            }

            LvHot.EndUpdate();
        }

        private void textChanged(object sender, EventArgs e)
        {
            if (sender.Equals(txtSearch))
            {
                labelSearch.Visible = txtSearch.Text.Length < 1;
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

        private void tabCtree_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == Coming && flag[1] == false)
            {
                //MessageBox.Show(skinEngine1.SkinFile);
                LvComing.Columns.Add("片名", 251, HorizontalAlignment.Center);
                LvComing.Columns.Add("时间", 200, HorizontalAlignment.Center);
                LvComing.Columns.Add("产地", 150, HorizontalAlignment.Center);
                LvComing.Columns.Add("类型", 230, HorizontalAlignment.Center);

                LvComing.BeginUpdate();

                WebService.model_movies_coming[] ComingMovies = null;
                try
                {
                    ComingMovies = Movies.Message_coming().ToArray();
                }
                catch
                {
                    MessageBox.Show("列表加载出错！");
                }

                for (int i = 0; i < ComingMovies.Length; i++)
                {
                    ListViewItem item = new ListViewItem();
                    ComingLinks[i] = ComingMovies[i].Link;
                    item.Text = ComingMovies[i].Name;
                    item.SubItems.Add(ComingMovies[i].Times);
                    item.SubItems.Add(ComingMovies[i].Place);
                    item.SubItems.Add(ComingMovies[i].Type);
                    LvComing.Items.Add(item);
                }

                LvComing.EndUpdate();
                flag[1] = true;
            
            }
            if (e.TabPage == NewDownload && flag[2] == false)
            {
                LvDownload.Columns.Add("片名", 200, HorizontalAlignment.Center);
                LvDownload.Columns.Add("资源", 230, HorizontalAlignment.Center);
                LvDownload.Columns.Add("产地", 100, HorizontalAlignment.Center);
                LvDownload.Columns.Add("语言", 100, HorizontalAlignment.Center);
                LvDownload.Columns.Add("类型", 201, HorizontalAlignment.Center);

                LvDownload.BeginUpdate();

                string NewDownload = "";
                try
                {
                    NewDownload = HttpGet("http://127.0.0.1:5000/NewMovies/");
                    
                }
                catch
                {
                    MessageBox.Show("列表加载失败！");
                    return;
                }

                JArray NewDownload_jar = null;
                try
                {
                    NewDownload_jar = JArray.Parse(NewDownload);
                }
                catch
                {
                    MessageBox.Show("列表加载失败！");
                    return;
                }
                for (int i = 0; i < NewDownload_jar.Count; i++)
                {
                    JObject j = JObject.Parse(NewDownload_jar[i].ToString());
                    ListViewItem item = new ListViewItem();
                    NewDownloadLinks[i] = j["link"].ToString();
                    //MessageBox.Show(j["link"].ToString());
                    item.Text = j["name"].ToString();
                    if (j["quality"].ToString().Length != 0)
                        item.SubItems.Add(j["quality"].ToString());
                    else
                        item.SubItems.Add("/");
                    if (j["place"].ToString().Length != 0 && !j["place"].ToString().Contains(","))
                        item.SubItems.Add(j["place"].ToString());
                    else if (j["place"].ToString().Length == 0)
                        item.SubItems.Add("/");
                    else if (j["place"].ToString().Contains(","))
                        item.SubItems.Add(j["place"].ToString().Substring(0, j["place"].ToString().IndexOf(",")));
                    if (j["language"].ToString().Length != 0 && !j["language"].ToString().Contains(","))
                        item.SubItems.Add(j["language"].ToString());
                    else if (j["language"].ToString().Length == 0)
                        item.SubItems.Add("/");
                    else if (j["language"].ToString().Contains(","))
                        item.SubItems.Add(j["language"].ToString().Substring(0, j["language"].ToString().IndexOf(",")));
                    if (j["type"].ToString().Length != 0 && !j["type"].ToString().Contains(","))
                        item.SubItems.Add(j["type"].ToString());
                    else if (j["type"].ToString().Length == 0)
                        item.SubItems.Add("/");
                    else if (j["type"].ToString().Contains(","))
                        item.SubItems.Add(j["type"].ToString().Substring(0, j["type"].ToString().IndexOf(",")));
                    LvDownload.Items.Add(item);
                }

                LvDownload.EndUpdate();
                flag[2] = true;
            }
            if (e.TabPage == Chinese && flag[3] == false)
            {
                LvChinese.Columns.Add("片名", 220, HorizontalAlignment.Center);
                LvChinese.Columns.Add("资源", 260, HorizontalAlignment.Center);
                LvChinese.Columns.Add("语言", 120, HorizontalAlignment.Center);
                LvChinese.Columns.Add("类型", 230, HorizontalAlignment.Center);

                LvChinese.BeginUpdate();

                string ChineseMovies = "";
                try
                {
                    ChineseMovies = HttpGet("http://127.0.0.1:5000/ChineseMovies/");
                }
                catch
                {
                    MessageBox.Show("列表加载失败！");
                }

                JArray ChineseMovies_jar = JArray.Parse(ChineseMovies);

                for (int i = 0; i < ChineseMovies_jar.Count; i++)
                {
                    JObject j = JObject.Parse(ChineseMovies_jar[i].ToString());
                    ListViewItem item = new ListViewItem();
                    ChineseLinks[i] = j["link"].ToString();
                    item.Text = j["name"].ToString();
                    if (j["quality"].ToString().Length != 0)
                        item.SubItems.Add(j["quality"].ToString());
                    else
                        item.SubItems.Add("/");
                    if (j["language"].ToString().Length != 0 && !j["language"].ToString().Contains(","))
                        item.SubItems.Add(j["language"].ToString());
                    else if (j["language"].ToString().Length == 0)
                        item.SubItems.Add("/");
                    else if (j["language"].ToString().Contains(","))
                        item.SubItems.Add(j["language"].ToString().Substring(0, j["language"].ToString().IndexOf(",")));
                    if (j["type"].ToString().Length != 0 && !j["type"].ToString().Contains(","))
                        item.SubItems.Add(j["type"].ToString());
                    else if (j["type"].ToString().Length == 0)
                        item.SubItems.Add("/");
                    else if (j["type"].ToString().Contains(","))
                        item.SubItems.Add(j["type"].ToString().Substring(0, j["type"].ToString().IndexOf(",")));
                    LvChinese.Items.Add(item);
                }

                LvChinese.EndUpdate();
                flag[3] = true;
            }
            if (e.TabPage == Western && flag[4] == false)
            {
                LvWestern.BeginUpdate();

                LvWestern.Columns.Add("片名", 220, HorizontalAlignment.Center);
                LvWestern.Columns.Add("资源", 260, HorizontalAlignment.Center);
                LvWestern.Columns.Add("语言", 120, HorizontalAlignment.Center);
                LvWestern.Columns.Add("类型", 220, HorizontalAlignment.Center);

                string WesternMovies = "";
                try
                {
                    WesternMovies = HttpGet("http://127.0.0.1:5000/WesternMovies/");
                }
                catch
                {
                    MessageBox.Show("列表加载出错！");
                }

                JArray WesternMovies_jar = JArray.Parse(WesternMovies);

                for (int i = 0; i < WesternMovies_jar.Count; i++)
                {
                    JObject j = JObject.Parse(WesternMovies_jar[i].ToString());
                    ListViewItem item = new ListViewItem();
                    WesternLinks[i] = j["link"].ToString();
                    item.Text = j["name"].ToString();
                    if (j["quality"].ToString().Length != 0)
                        item.SubItems.Add(j["quality"].ToString());
                    else
                        item.SubItems.Add("/");
                    if (j["language"].ToString().Length != 0 && !j["language"].ToString().Contains(","))
                        item.SubItems.Add(j["language"].ToString());
                    else if (j["language"].ToString().Length == 0)
                        item.SubItems.Add("/");
                    else if (j["language"].ToString().Contains(","))
                        item.SubItems.Add(j["language"].ToString().Substring(0, j["language"].ToString().IndexOf(",")));
                    if (j["type"].ToString().Length != 0 && !j["type"].ToString().Contains(","))
                        item.SubItems.Add(j["type"].ToString());
                    else if (j["type"].ToString().Length == 0)
                        item.SubItems.Add("/");
                    else if (j["type"].ToString().Contains(","))
                        item.SubItems.Add(j["type"].ToString().Substring(0, j["type"].ToString().IndexOf(",")));
                    LvWestern.Items.Add(item);
                }

                LvWestern.EndUpdate();
                flag[4] = true;
            }
            if (e.TabPage == Rihan && flag[5] == false)
            {
                LvRihan.Columns.Add("片名", 220, HorizontalAlignment.Center);
                LvRihan.Columns.Add("资源", 260, HorizontalAlignment.Center);
                LvRihan.Columns.Add("语言", 120, HorizontalAlignment.Center);
                LvRihan.Columns.Add("类型", 220, HorizontalAlignment.Center);

                LvRihan.BeginUpdate();

                string RihanMovies = "";
                try
                {
                    RihanMovies = HttpGet("http://127.0.0.1:5000/RihanMovies/");
                }
                catch
                {
                    MessageBox.Show("列表加载失败！");
                }
                JArray RihanMovies_jar = null;
                try
                {
                    RihanMovies_jar = JArray.Parse(RihanMovies);
                }
                catch
                {
                    MessageBox.Show("列表加载失败！");
                    return;
                }
                for (int i = 0; i < RihanMovies_jar.Count; i++)
                {
                    JObject j = JObject.Parse(RihanMovies_jar[i].ToString());
                    ListViewItem item = new ListViewItem();
                    RihanLinks[i] = j["link"].ToString();
                    item.Text = j["name"].ToString();
                    if (j["quality"].ToString().Length != 0)
                        item.SubItems.Add(j["quality"].ToString());
                    else
                        item.SubItems.Add("/");
                    if (j["language"].ToString().Length != 0 && !j["language"].ToString().Contains(","))
                        item.SubItems.Add(j["language"].ToString());
                    else if (j["language"].ToString().Length == 0)
                        item.SubItems.Add("/");
                    else if (j["language"].ToString().Contains(","))
                        item.SubItems.Add(j["language"].ToString().Substring(0, j["language"].ToString().IndexOf(",")));
                    if (j["type"].ToString().Length != 0 && !j["type"].ToString().Contains(","))
                        item.SubItems.Add(j["type"].ToString());
                    else if (j["type"].ToString().Length == 0)
                        item.SubItems.Add("/");
                    else if (j["type"].ToString().Contains(","))
                        item.SubItems.Add(j["type"].ToString().Substring(0, j["type"].ToString().IndexOf(",")));
                    LvRihan.Items.Add(item);
                }

                LvRihan.EndUpdate();
                flag[5] = true;
            }
        }

        private void LvHot_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListView.SelectedIndexCollection indexes = this.LvHot.SelectedIndices;
                if (indexes.Count > 0)
                {
                    int index = indexes[0];
                    this.Hide();
                    //MessageBox.Show(HotLinks[index].ToString());
                    new singleDB(username , HotLinks[index] , LvHot.Items[index].SubItems[0].Text , LvHot.Items[index].SubItems[2].Text , LvHot.Items[index].SubItems[3].Text , LvHot.Items[index].SubItems[4].Text , LvHot.Items[index].SubItems[5].Text , 1).Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作失败！\n" + ex.Message, "提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void LvComing_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListView.SelectedIndexCollection indexes = this.LvComing.SelectedIndices;
                if (indexes.Count > 0)
                {
                    int index = indexes[0];
                    this.Hide();
                    //MessageBox.Show(HotLinks[index].ToString());
                    new singleDB(username, ComingLinks[index], LvComing.Items[index].SubItems[0].Text, LvComing.Items[index].SubItems[1].Text, LvComing.Items[index].SubItems[2].Text,LvComing.Items[index].SubItems[3].Text , "/", 2).Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作失败！\n" + ex.Message, "提示", MessageBoxButtons.OK,
                                  MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void LvDownload_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListView.SelectedIndexCollection indexes = this.LvDownload.SelectedIndices;
                if (indexes.Count > 0)
                {
                    int index = indexes[0];
                    this.Hide();
                    //MessageBox.Show(NewDownloadLinks[index]);
                    
                    new Single_DYTT(username, NewDownloadLinks[index]).Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作失败！\n" + ex.Message, "提示", MessageBoxButtons.OK,
                                  MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void LvChineseMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListView.SelectedIndexCollection indexes = this.LvChinese.SelectedIndices;
                if (indexes.Count > 0)
                {
                    int index = indexes[0];
                    this.Hide();
                    // MessageBox.Show(LvChinese.Items[index].SubItems[0].Text);
                    
                    new Single_DYTT(username, ChineseLinks[index]).Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作失败！\n" + ex.Message, "提示", MessageBoxButtons.OK,
                                  MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }

        }

        private void LvWestern_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListView.SelectedIndexCollection indexes = this.LvWestern.SelectedIndices;
                if (indexes.Count > 0)
                {
                    int index = indexes[0];
                    this.Hide();
                    //MessageBox.Show(HotLinks[index].ToString());
                    
                    new Single_DYTT(username, WesternLinks[index]).Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作失败！\n" + ex.Message, "提示", MessageBoxButtons.OK,
                                  MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void LvRihan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListView.SelectedIndexCollection indexes = this.LvRihan.SelectedIndices;
                if (indexes.Count > 0)
                {
                    int index = indexes[0];
                    this.Hide();
                    //MessageBox.Show(HotLinks[index].ToString());
                    
                    new Single_DYTT(username, RihanLinks[index]).Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作失败！\n" + ex.Message, "提示", MessageBoxButtons.OK,
                                  MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();

            new Login().Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text.Length > 0)
            {
                this.Hide();
                new SearchResult(username, txtSearch.Text).Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
           
            new UserMessages(username).Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            new About().Show();
        }
    }
}
