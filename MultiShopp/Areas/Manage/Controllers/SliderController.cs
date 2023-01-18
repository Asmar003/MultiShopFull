using Microsoft.AspNetCore.Mvc;
using MultiShopp.DAL;
using MultiShopp.Models;
using MultiShopp.ViewModels.Slider;

namespace MultiShopp.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;

        public SliderController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Sliders.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateSliderVM createSliderVM)
        {
            Slider slider = new Slider
            {
                PrimaryTitle=createSliderVM.PrimaryTitle,
                SecondaryTitle=createSliderVM.SecondaryTitle,
                Order= createSliderVM.Order,
                ImageUrl=createSliderVM.ImageUrl
            };
            _context.Sliders.Add(slider);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
