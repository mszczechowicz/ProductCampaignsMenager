using ProductCampaignsMenager.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Tracing;

namespace ProductCampaignsMenager.Models
{
    public class Campaign
    {
        [Key]
        public int CampaignId { get; set; }
        
        public string CampaignName { get; set; }

        public CampaignKeywords CampaignKeywords{ get; set; }

        public int BidAmount { get; set; }

        public int CampaignFund { get; set; }

        public bool Status { get; set; }

       

        public int Radius { get; set; }

        //Relationships

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        public int TownId { get; set; }
        [ForeignKey(" TownId")]
        public Town Town { get; set; }
    }
}
