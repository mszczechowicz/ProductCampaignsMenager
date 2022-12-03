using System.ComponentModel.DataAnnotations;

namespace ProductCampaignsMenager.Models
{
    public class Town
    {
        [Key]
        public int TownId { get; set; }

        public string TownName { get; set;}

    }
}
