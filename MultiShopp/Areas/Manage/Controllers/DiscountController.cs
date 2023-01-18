using Microsoft.AspNetCore.Mvc;
using MultiShopp.DAL;
using MultiShopp.Models;
using MultiShopp.ViewModels.Discount;

namespace MultiShopp.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class DiscountController : Controller
    {
        private readonly AppDbContext _context;

        public DiscountController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Discounts.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateDiscountVM discountVM)
        {
            Discount discount = new Discount
            {
                Name=discountVM.Name,
                Percent=discountVM.Percent
            };
            _context.Discounts.Add(discount);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
