using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApplication4.DAL;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _contexct { get;  }
        public HomeController(AppDbContext context)
        {
            _contexct = context;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = _contexct.Sliders.ToList();
            return View(sliders);
            //return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Category()
        {
            return View();
        }

    }
}
