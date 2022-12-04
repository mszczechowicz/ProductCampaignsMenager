using Microsoft.AspNetCore.Mvc;
using ProductCampaignsMenager.Data;

namespace ProductCampaignsMenager.Controllers
{
    public class CampaignController : Controller
    {
        private readonly AppDbContext _context;

        public CampaignController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Campaigns.ToList();

            return View();
        }
    }
}
