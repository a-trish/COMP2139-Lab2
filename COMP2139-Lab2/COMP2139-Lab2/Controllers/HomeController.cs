using COMP2139_Lab2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP2139_Lab2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Fifteen = 0;
            ViewBag.Twenty = 0;
            ViewBag.TwentyFive = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(TipCalculator tip)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Fifteen = tip.CalculateTip(0.15);
                ViewBag.Twenty = tip.CalculateTip(0.20);
                ViewBag.TwentyFive = tip.CalculateTip(0.25);
            }
            else
            {
                ViewBag.Fifteen = 0;
                ViewBag.Twenty = 0;
                ViewBag.TwentyFive = 0;
            }
            return View(tip);


        }
    }
}
