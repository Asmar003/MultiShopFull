using Microsoft.AspNetCore.Mvc;
using MultiShopp.DAL;
using MultiShopp.Models;
using MultiShopp.ViewModels.Setting;

namespace MultiShopp.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class SettingController : Controller
    {
        private readonly AppDbContext _context;

        public SettingController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Settings.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Create(CreateSettingVM createSettingVM)
        {
            Setting setting = new Setting
            {
                Key = createSettingVM.Key,
                Value = createSettingVM.Value,
            };
            _context.Settings.Add(setting);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
