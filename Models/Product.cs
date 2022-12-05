using System.ComponentModel.DataAnnotations;

namespace ProductCampaignsMenager.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Display(Name ="Product name")]
        [Required(ErrorMessage ="This field is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product name must be between 3 and 50 chars")]
        public string ProductName { get; set; }

		[Display(Name = "Number of Campaigns")]
		public int CampaignCount { get; set; }

        //Relationships

        public List<Campaign>? Campaign { get; set;}

    }
}
