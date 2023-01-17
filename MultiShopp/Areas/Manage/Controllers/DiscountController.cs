using Microsoft.AspNetCore.Mvc;

namespace MultiShopp.Areas.Manage.Controllers
{
    public class DiscountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
