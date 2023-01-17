using Microsoft.AspNetCore.Mvc;
using MultiShopp.DAL;

namespace MultiShopp.Areas.Manage.Controllers
{
  [Area("Manage")]

        public class DashboardController : Controller
        {
            private readonly AppDbContext _context;

            public DashboardController(AppDbContext context)
            {
                _context = context;
            }
            public IActionResult Index()
            {
                return View();
            }
        }
}
