using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_Csharp.model
{
    public class model_detail
    {
        private string type;
        private string language;
        private string date;
        private string describe;
        private string image;
        private string actor;
        private string duration;

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

        public string Language
        {
            get
            {
                return language;
            }
            set
            {
                language = value;
            }
        }

        public string Describe
        { 
            get
            {
                return describe;
            }
            set
            {
                describe = value;
            }
        }

        public string Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
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
    }
}