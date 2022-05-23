using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class Product_Controller : Controller
    {
        public IActionResult Product()
        {
            return View();
        }
    }
}
