using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace web_Csharp
{
    /// <summary>
    /// WebService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod(Description = "获取热映电影基本信息")]
        public model.model_movies[] Message()
        {
            List<model.model_movies> movie = new List<model.model_movies>();
            List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();
            Spider.movies m = new Spider.movies("https://movie.douban.com/", @"data-title=""([\s\S]+?)"" data-release=""([\s\S]+?)"" data-rate=""([\s\S]+?)""[\s\S]+?data-duration=""([\s\S]+?)"" data-region=""([\s\S]+?)""[\s\S]+?data-actors=""([\s\S]+?)""[\s\S]+?href=""([\s\S]+?)""");
            list = m.message();
            foreach (Dictionary<string, string> dic in list)
            {
                model.model_movies mm = new model.model_movies();
                mm.Name = dic["片名"];
                mm.Place = dic["产地"];
                mm.Rate = dic["评分"];
                mm.Times = dic["时间"];
                mm.Actor = dic["主演"];
                mm.Duration = dic["片长"];
                mm.Link = dic["链接"];
                movie.Add(mm);
            }
            return movie.ToArray();
        }

        [WebMethod(Description = "获取电影详细信息")]
        public model.model_detail MessageDetail(string link , int tag)
        {
            if (tag == 1)
            {
                Spider.Movies_Detail m = new Spider.Movies_Detail(link);
                model.model_detail mm = new model.model_detail();
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic = m.messages(tag);
                mm.Image = dic["海报"];
                mm.Describe = dic["简介"];
                mm.Type = dic["类型"];
                mm.Date = dic["日期"];
                mm.Language = dic["语言"];
                return mm;
            }
            else
            {
                Spider.Movies_Detail m = new Spider.Movies_Detail(link);
                model.model_detail mm = new model.model_detail();
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic = m.messages(tag);
                mm.Image = dic["海报"];
                mm.Describe = dic["简介"];
                mm.Duration = dic["时长"];
                mm.Actor = dic["主演"];
                return mm;
            }
        }

        [WebMethod(Description = "获取相关电影")]
        public model.model_moviecrude[] RelatedMovies(string link)
        {
            Spider.Movies_Detail m = new Spider.Movies_Detail(link);
            List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();
            List<model.model_moviecrude> related_movies = new List<model.model_moviecrude>();
            list = m.related();
            foreach (Dictionary<string, string> dic in list)
            {
                model.model_moviecrude mm = new model.model_moviecrude();
                mm.Name = dic["片名"];
                mm.Link = dic["链接"];
                mm.Image = dic["海报"];
                related_movies.Add(mm);
            }
            return related_movies.ToArray();
        }

        [WebMethod(Description = "获取电影短评")]
        public string[] MovieAssess(string link)
        {
            List<string> list = new List<string>();
            Spider.Movies_Detail spider = new Spider.Movies_Detail(link);
            list = spider.assess();
            return list.ToArray();
        }

        [WebMethod(Description = "获取即将上映的电影基本信息")]
        public model.model_movies_coming[] Message_coming()
        {
            List<model.model_movies_coming> movie = new List<model.model_movies_coming>();
            List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();
            Spider.movies m = new Spider.movies("https://movie.douban.com/coming", @"tr class="""">[\s\S]+?>([\s\S]+?)<[\s\S]+?href=""([\s\S]+?)"" class="""">([\s\S]+?)<[\s\S]+?"">([\s\S]+?)<[\s\S]+?"">([\s\S]+?)<");
            list = m.message_comingmovies();
            foreach (Dictionary<string, string> dic in list)
            {
                model.model_movies_coming mm = new model.model_movies_coming();
                mm.Name = dic["片名"].Replace(" " , "");
                mm.Place = dic["产地"].Replace(" ", "");
                mm.Times = dic["时间"].Replace(" ", "");
                mm.Link = dic["链接"].Replace(" ", "");
                mm.Type = dic["类型"].Replace(" ", "");
                movie.Add(mm);
            }
            return movie.ToArray();
        }
    }
}
