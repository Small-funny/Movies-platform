using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace web_Csharp.Spider
{
    public class Movies_Detail:Spider
    {
        Spider spider = null;
        string html;

        public Movies_Detail(string link)
        {
            spider = new Spider(link, "get");
            html = spider.getHtml();
        }

        public Dictionary<string,string> messages(int tag)
        {
            string pattern;
            if (tag == 1)
            {
                pattern = @"nbgnbg"" href=[\s\S]+?img src=""([\s\S]+?)""[\s\S]+?v:genre"">([\s\S]+?)<br[\s\S]+?语言:</span>([\s\S]+?)<br[\s\S]+?content=""([\s\S]+?)[(][\s\S]+?summary"" class="""">([\s\S]+?)</span>";
                Dictionary<string, string> dic = new Dictionary<string, string>();
                foreach (Match match in Regex.Matches(html, pattern))
                {
                    dic["海报"] = match.Groups[1].Value;
                    dic["类型"] = match.Groups[2].Value.Replace("</span>", "").Replace(@"<span property=""v:genre"">", "");
                    dic["语言"] = match.Groups[3].Value;
                    dic["日期"] = match.Groups[4].Value;
                    dic["简介"] = match.Groups[5].Value.Replace("<br />", "%%%%%");
                }
                return dic;
            }
            else
            {
                pattern = @"nbgnbg"" href=[\s\S]+?img src=""([\s\S]+?)""[\s\S]+?v:starring"">([\s\S]+?)</a[\s\S]+?v:runtime[\s\S]+?>([\s\S]+?)<[\s\S]+?v:summary"" class="""">([\s\S]+?)</span>";
                Dictionary<string, string> dic = new Dictionary<string, string>();
                foreach (Match match in Regex.Matches(html, pattern))
                {
                    dic["海报"] = match.Groups[1].Value;
                    dic["主演"] = match.Groups[2].Value;
                    dic["时长"] = match.Groups[3].Value;
                    dic["简介"] = match.Groups[4].Value.Replace("<br />", "%%%%%");
                }
                return dic;
            }
        }

        public List<Dictionary<string,string>> related()
        {
            string pattern = @"<dt>[\s\S]+?img src=""([\s\S]+?)""[\s\S]+?<dd>[\s\S]+?href=""([\s\S]+?)"" class="""" >([\s\S]+?)<";
            List<Dictionary<string,string>> list = new List<Dictionary<string, string>>();
            foreach (Match match in Regex.Matches(html, pattern))
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic["海报"] = match.Groups[1].Value;
                dic["链接"] = match.Groups[2].Value;
                dic["片名"] = match.Groups[3].Value;
                list.Add(dic);
            }
            return list;
        }

        public List<string> assess()
        {
            string pattern1 = @"""short"">([\s\S]+?)<";
            string pattern2 = @"hide-item[\s\S]+?>([\s\S]+?)<";
            List<string> list = new List<string>();
            foreach (Match match in Regex.Matches(html, pattern1))
            {
                list.Add(match.Groups[1].Value);
            }
            foreach (Match match in Regex.Matches(html, pattern2))
            {
                foreach(string str in list)
                {
                    if(match.Groups[1].Value.Substring(0,10) == str.Substring(0,10))
                    {
                        list.Remove(str);
                        list.Add(match.Groups[1].Value);
                        break;
                    }
                }
            }
            return list;
        }
    }
}