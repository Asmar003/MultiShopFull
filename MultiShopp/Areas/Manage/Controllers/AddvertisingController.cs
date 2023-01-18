using Microsoft.AspNetCore.Mvc;
using MultiShopp.DAL;
using MultiShopp.Models;
using MultiShopp.ViewModels.Addvertising;

namespace MultiShopp.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class AddvertisingController : Controller
    {
        private readonly AppDbContext _context;
        public AddvertisingController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Addvertisings.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create (CreateAddvertisingVM addvertisingVM)
        {
            Addvertising addvertising = new Addvertising
            {
                ImageUrl = addvertisingVM.ImageUrl,
                Description= addvertisingVM.Description,
                Title= addvertisingVM.Title
            };
            _context.Addvertisings.Add(addvertising);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
