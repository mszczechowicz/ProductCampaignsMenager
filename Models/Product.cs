using System.ComponentModel.DataAnnotations;

namespace ProductCampaignsMenager.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Display(Name ="Product name")]
        public string ProductName { get; set; }
		[Display(Name = "Number of Campaigns")]
		public int CampaignCount { get; set; }

        //Relationships

        public List<Campaign> Campaign { get; set;}

    }
}
