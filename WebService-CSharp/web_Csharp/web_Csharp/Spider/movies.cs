using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace web_Csharp.Spider
{
    public class movies
    {
        Spider spider = null;
        string pattern;
        string html;

        public movies(string link, string pattern)
        {
            this.spider = new Spider(link, "get");
            this.pattern = pattern;
            html = spider.getHtml();
        }

        public List<Dictionary<string , string>> message()
        {
            List<Dictionary<string, string>> movies = new List<Dictionary<string, string>>();
            foreach (Match match in Regex.Matches(html, pattern))
            {
                Dictionary<string, string> m = new Dictionary<string, string>();
                m["片名"] = match.Groups[1].Value;
                m["时间"] = match.Groups[2].Value;
                m["评分"] = match.Groups[3].Value;
                if (m["评分"].StartsWith("\""))
                    m["评分"] = "暂无";
                m["片长"] = match.Groups[4].Value;
                m["产地"] = match.Groups[5].Value;
                m["主演"] = match.Groups[6].Value;
                m["链接"] = match.Groups[7].Value;
                movies.Add(m);
            }
            return movies;
        }

        public List<Dictionary<string, string>> message_comingmovies()
        {
            List<Dictionary<string, string>> movies = new List<Dictionary<string, string>>();
            foreach (Match match in Regex.Matches(html, pattern))
            {
                Dictionary<string, string> m = new Dictionary<string, string>();
                m["时间"] = match.Groups[1].Value;
                m["链接"] = match.Groups[2].Value;
                m["片名"] = match.Groups[3].Value;
                m["类型"] = match.Groups[4].Value;
                m["产地"] = match.Groups[5].Value;
                movies.Add(m);
            }
            return movies;
        }

        public List<Dictionary<string,string>> message_searchmovies(string name)
        {
            List<Dictionary<string, string>> movies = new List<Dictionary<string, string>>();
            foreach (Match match in Regex.Matches(html, pattern))
            {
                Dictionary<string, string> m = new Dictionary<string, string>();
                m["片名"] = match.Groups[1].Value;

                m["链接"] = match.Groups[2].Value;
                m["片名"] = match.Groups[3].Value;
                m["类型"] = match.Groups[4].Value;
                m["产地"] = match.Groups[5].Value;
                movies.Add(m);
            }
            return movies;
        }
    }
}