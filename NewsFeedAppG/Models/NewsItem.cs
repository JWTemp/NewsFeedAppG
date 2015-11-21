using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsFeedAppG.Models
{
    public class NewsItem
    {
        public int ID { get; set; }
        public string title { get; set; }
        public string link { get; set; }
        public string description { get; set; }
        public string author { get; set; }
        public string image { get; set; }
        public string caption { get; set; }
        public DateTime published_date { get; set; }



    }
}