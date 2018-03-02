using Microsoft.EntityFrameworkCore;
using QueryExample.Entities;

namespace QueryExample.EntityFramework
{
    public class QueryExampleContext : DbContext
    {
        public DbSet<ShopOffer> ShopOffers { get; set; }

        public QueryExampleContext(DbContextOptions<QueryExampleContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShopOffer>()
                .ToTable("ShopOffers");
        }
    }
}
