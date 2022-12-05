using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductCampaignsMenager.Data;
using ProductCampaignsMenager.Data.Services;
using ProductCampaignsMenager.Models;

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

        public IActionResult Create()
        { 
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProductName","CampaignCount")]Product product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }

            _service.Add(product);
            return RedirectToAction(nameof(Index));

        }

        

    }
}
