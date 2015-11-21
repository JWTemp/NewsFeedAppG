using NewsFeedAppG.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace NewsFeedAppG.DAL
{
    public class NewsFeedContext : DbContext
    {
               
        public NewsFeedContext() : base("NewsFeedContext")
        {
        }

        public DbSet<NewsItem> NewsItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}