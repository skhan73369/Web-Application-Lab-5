using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab4.Models;

namespace Lab4.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult PersonIndex(Person p)
        {
           return View(p);
        }

        public IActionResult AddPerson()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPerson(Person p)
        {
            if (ModelState.IsValid)
            {
                return View("PersonIndex", p);
            }
            else
            {
                return View();
            }
        }
    }
}