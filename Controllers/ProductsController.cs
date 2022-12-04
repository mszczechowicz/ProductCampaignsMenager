using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductCampaignsMenager.Data;
using ProductCampaignsMenager.Data.Services;

namespace ProductCampaignsMenager.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductsService _service;

        public ProductsController(IProductsService service)
        {
            _service= service;
        }


        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();

            return View(data);
        }

        public async Task<IActionResult> Create()
        { 
            return View();
        }
    }
}
