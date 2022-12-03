using ProductCampaignsMenager.Data.Enums;
using System.ComponentModel.DataAnnotations;
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

        public List<Town> Town { get; set; }

        public int Radius { get; set; }
    }
}
