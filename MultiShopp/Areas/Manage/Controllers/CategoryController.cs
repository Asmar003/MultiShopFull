using Microsoft.AspNetCore.Mvc;

namespace MultiShopp.Areas.Manage.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
