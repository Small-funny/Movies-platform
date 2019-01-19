using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_Csharp.model
{
    public class model_movies_coming
    {
        private string name;
        private string times;
        private string link;
        private string place;
        private string type;
        private string image;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Times
        {
            get
            {
                return times;
            }
            set
            {
                times = value;
            }
        }

        public string Place
        {
            get
            {
                return place;
            }
            set
            {
                place = value;
            }
        }
        public string Link
        {
            get
            {
                return link;
            }
            set
            {
                link = value;
            }
        }
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
        public string Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
            }
        }
    }
}