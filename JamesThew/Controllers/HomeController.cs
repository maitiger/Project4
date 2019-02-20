using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JamesThew.Models;

namespace JamesThew.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.JameJob = " I 'm Jame Threw ";
            ViewBag.Infor = " 1/2/1988";
           
            return View();
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

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Recipe()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Forum()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Collection()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Video()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult GoldMember()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult CulinaryCompetition()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
