using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductCampaignsMenager.Data;

namespace ProductCampaignsMenager.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context= context;
        }


        public async Task<IActionResult> Index()
        {
            var data = await _context.Products.ToListAsync(); 

            return View(data);
        }
    }
}
