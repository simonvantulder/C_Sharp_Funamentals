using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using randomPass.Models;
using Microsoft.AspNetCore.Http;


namespace randomPass.Controllers
{
    public class HomeController : Controller
    {
        private string generatePasscode()
        {
            Random r = new Random();
            string values = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string result = "";
            for (var i = 0; i < 14; i++){
                result += values[r.Next(values.Length)];
            }
            return result;
        }


        [HttpGet("")]
        public IActionResult Index()
        {
            if(HttpContext.Session.GetString("passcode") == null)
            {
                HttpContext.Session.SetString("passcode", "Generate a Passcode.");
            }
            if(HttpContext.Session.GetString("times") == null)
            {
                HttpContext.Session.SetInt32("times", 0);
            }

            ViewBag.Passcode = HttpContext.Session.GetString("passcode");
            ViewBag.Times = HttpContext.Session.GetInt32("times");

            return View();
        }


        [HttpGet("new")]
        public IActionResult NewPasscode()
        {
            int? times = HttpContext.Session.GetInt32("times");
            times++;
            
            HttpContext.Session.SetInt32("times", (int) times);
            HttpContext.Session.SetString("passcode", generatePasscode());
            
            return RedirectToAction("Index");

        }


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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
