﻿using Microsoft.AspNetCore.Mvc;

namespace Shopping_cart.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Dashboard() 
        {
            return View();
        }
    }
}
