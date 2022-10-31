using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Riode.DAL;
using Riode.ViewModels;

namespace Riode.Controllers
{
    public class HomeController : Controller
    {
        RiodeContext _context;

        public HomeController(RiodeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM home = new HomeVM();
            home.Sliders = _context.Sliders.OrderBy(x => x.Order);
            home.Services = _context.Services.Where(x => x.IsActive);
            home.Categories = _context.Categories;
            home.News = _context.News;
            home.SeasonSales = _context.SeasonSales;
            home.Badges = _context.Badges;

            return View(home);
        }
    }
}