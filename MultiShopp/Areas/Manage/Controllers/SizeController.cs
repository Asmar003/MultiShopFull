using Microsoft.AspNetCore.Mvc;
using MultiShopp.DAL;
using MultiShopp.Models;
using MultiShopp.ViewModels.Size;

namespace MultiShopp.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class SizeController : Controller
    {
        private readonly AppDbContext _context;

        public SizeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Sizes.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateSizeVM createSizeVM)
        {
            Size size = new Size
            {
                Name = createSizeVM.Name
            };
            _context.Sizes.Add(size);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
