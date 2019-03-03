using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class Post
    {
        public int PostID { get; set; }
        public DateTime DatePublished { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{Title} ({PostID})";
            }
        }

    }
}
