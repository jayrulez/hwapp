﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace hwapp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Ip()
        {
            return Ok(Request.Headers);
        }

        public IActionResult Index()
        {
            return Ok(Request.Headers);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
