using DataEntry.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DataEntry.Controllers
{
    public class HomeController : Controller
    {
   
        [HttpGet]
        public ActionResult Index()
        {
            return View("DataForm");
        }

        [HttpPost]
        public IActionResult DataForm(DataModel data)
        {
            if (ModelState.IsValid)
            {
                return View("Display", data);
            }
            else
            {
                return View("Display");
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
