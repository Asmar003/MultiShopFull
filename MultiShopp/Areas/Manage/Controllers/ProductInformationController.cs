using Microsoft.AspNetCore.Mvc;
using MultiShopp.DAL;
using MultiShopp.Models;
using MultiShopp.ViewModels.ProductInformation;

namespace MultiShopp.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class ProductInformationController : Controller
    {
        private readonly AppDbContext _context;

        public ProductInformationController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.ProductInformations.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateProductInformationVM productInformationVM)
        {
            ProductInformation productInformation = new ProductInformation
            {
                Information=productInformationVM.Information
            };
            return RedirectToAction(nameof(Index));
        }
    }
}
