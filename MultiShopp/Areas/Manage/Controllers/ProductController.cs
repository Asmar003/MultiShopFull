using Microsoft.AspNetCore.Mvc;
using MultiShopp.DAL;

namespace MultiShopp.Areas.Manage.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Products.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
      
    }
}
