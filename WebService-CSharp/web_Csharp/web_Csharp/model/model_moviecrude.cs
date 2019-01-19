using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_Csharp.model
{
    public class model_moviecrude
    {
        private string link;
        private string name;
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