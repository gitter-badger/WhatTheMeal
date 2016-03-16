using Microsoft.AspNet.Mvc;

namespace WhatTheMeal.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
