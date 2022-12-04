using System.ComponentModel.DataAnnotations;

namespace ProductCampaignsMenager.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public int CampaignCount { get; set; }

        //Relationships

        public List<Campaign> Campaign { get; set;}

    }
}
