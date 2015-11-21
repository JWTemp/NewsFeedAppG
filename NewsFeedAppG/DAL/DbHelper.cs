using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NewsFeedAppG.Models;
using System.Threading.Tasks;
using System.Data.Entity;

namespace NewsFeedAppG.DAL
{
    public class DbHelper
    {
        public async Task<List<NewsItem>> GetNewsDataAsync()
        {
            NewsFeedContext db = new NewsFeedContext();
            var query = from n in db.NewsItems
                            orderby n.ID ascending
                            select n;
            List<NewsItem> data = await query.ToListAsync();
            return data;
        }
    }
}