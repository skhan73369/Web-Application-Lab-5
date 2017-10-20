using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var Time = DateTime.Now.ToShortTimeString();
            var Date = DateTime.Today.ToString("D");
            var now = DateTime.Now;
            DateTime noon = new DateTime(now.Year, now.Month, now.Day, 12, 0, 0);
            DateTime afterNoon = new DateTime(now.Year, now.Month, now.Day, 18, 0, 0);

            if (DateTime.Now <= noon)
            {
                ViewData["Name"] = "Good Morning";
            }
            else if (DateTime.Now <= afterNoon)
            {
                ViewData["Name"] = "Good Afternoon";
            }
            else
            {
                ViewData["Name"] = "Good Evening";
            }

            DateTime date = DateTime.Today;
            int totalDays = DateTime.IsLeapYear(date.Year) ? 366 : 365;
            int daysLeft = totalDays - date.DayOfYear;

            ViewData["Time"] = Time;
            ViewData["Date"] = Date;
            ViewData["Year"] = DateTime.Now.Year;
            ViewData["daysLeft"] = daysLeft;
            return View();
        }

        public IActionResult PageTwo(int id)
        {
            ViewData["Count"] = id;
            string[] items = new string[] { "1", "2", "3", "4", "5" };
            return View(items);
        }
    }
}