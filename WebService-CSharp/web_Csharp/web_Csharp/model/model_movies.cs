using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_Csharp.model
{
    public class model_movies
    {
        private string name;
        private string times;
        private string rate;
        private string duration;
        private string place;
        private string actor;
        private string link;

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
        public string Rate
        {
            get
            {
                return rate;
            }
            set
            {
                rate = value;
            }
        }
        public string Duration
        {
            get
            {
                return duration;
            }
            set
            {
                duration = value;
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
        public string Actor
        {
            get
            {
                return actor;
            }
            set
            {
                actor = value;
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
    }
}