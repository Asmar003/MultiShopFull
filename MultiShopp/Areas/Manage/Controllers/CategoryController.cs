using Microsoft.AspNetCore.Mvc;
using MultiShopp.DAL;
using MultiShopp.Models;
using MultiShopp.ViewModels.Category;

namespace MultiShopp.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;
        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Categories.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateCategoryVM categoryVM)
        {
            Category category = new Category
            {
                ImageUrl = categoryVM.ImageUrl,
                Name = categoryVM.Name,
            };
            _context.Categories.Add(category);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
