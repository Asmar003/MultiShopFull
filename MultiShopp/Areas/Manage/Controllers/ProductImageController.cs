using Microsoft.AspNetCore.Mvc;
using MultiShopp.DAL;
using MultiShopp.Models;
using MultiShopp.ViewModels.ProductImage;

namespace MultiShopp.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class ProductImageController : Controller
    {
        private readonly AppDbContext _context;
        public ProductImageController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.ProductImages.ToList());
        }
        public IActionResult Create ()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create (CreateProductImageVM productImageVM)
        {
            ProductImage productImage = new ProductImage
            {
                ImageUrl = productImageVM.ImageUrl
            };
            _context.ProductImages.Add(productImage);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
