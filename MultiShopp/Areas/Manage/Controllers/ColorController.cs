using Microsoft.AspNetCore.Mvc;
using MultiShopp.DAL;
using MultiShopp.Models;
using MultiShopp.ViewModels.Color;

namespace MultiShopp.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class ColorController : Controller
    {
        private readonly AppDbContext _context;

        public ColorController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Colors.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateColorVM colorVM)
        {
            Color color = new Color
            {
                Name = colorVM.Name,
            };
            _context.Colors.Add(color);
            _context.SaveChanges();
           return RedirectToAction(nameof(Index));
        }
    }
}
