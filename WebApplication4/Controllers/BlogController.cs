﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult BlogDetails()
        {
            return View();
        }
    }
}
