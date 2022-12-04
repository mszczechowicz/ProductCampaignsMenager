using Microsoft.EntityFrameworkCore;
using ProductCampaignsMenager.Models;

namespace ProductCampaignsMenager.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Product> Products { get; set; }

        public DbSet<Town> Towns { get; set; }

        public DbSet<Campaign> Campaigns { get; set; }

     





    }
}
