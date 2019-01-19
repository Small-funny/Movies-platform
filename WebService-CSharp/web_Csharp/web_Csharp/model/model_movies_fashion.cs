using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_Csharp.model
{
    public class model_movies_fashion
    {
        private string name;
        private string link;
        private string rate;

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