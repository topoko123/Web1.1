using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web1._1.Models;

namespace Web1._1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Plus(int id)
        {
            int i = id + 10;
            ViewData["sum"] = i;

            return View();
        }
        [Route("Multiply/{a}")]
        public IActionResult Multiply(int a)
        {
            int i = a * 10;
            ViewData["sum"] = i;

            return View();
        }
        [Route("Minus/{a}/{b}")]
        public IActionResult Minus(int a, int b)
        {
            int re = a - b;
            ViewData["resualt"] = re;
            return View();
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

        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ContactPost(IFormCollection values)
        {
            ViewData["Name"] = values["name"];
            ViewData["Email"] = values["email"];
            ViewData["ShowAlert"] = true;
            return View("Index");
        }
        public IActionResult Contact2()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ContactPost2(Contact model)
        {
            ViewData["Name"] = model.Name;
            ViewData["Email"] = model.Email;
            ViewData["ShowAlert"] = true;
            return View("Index");
        }
    }

}
