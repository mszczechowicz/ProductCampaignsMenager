using ProductCampaignsMenager.Models;

namespace ProductCampaignsMenager.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                
                if (!context.Towns.Any())
                {
                    context.Towns.AddRange(new List<Town>()
                    {

                        new Town()
                        {
                            TownName = "Warsaw"

                        },
                        new Town()
                        {
                            TownName = "Cracow"
                        },
                    });
                    context.SaveChanges();
                }

                if (!context.Products.Any())
                {
                    context.Products.AddRange(new List<Product>()
                    {
                        new Product()
                        {
                            ProductName = "ProductTest1",
                            CampaignCount= context.Campaigns.Count()
                        },
                        new Product()
                        {
                            ProductName = "ProductTest2",
                            CampaignCount= context.Campaigns.Count()
                        },


                    });
                     
                    context.SaveChanges();
                }

                context.SaveChanges();
            }
                    
        }
    }
}
