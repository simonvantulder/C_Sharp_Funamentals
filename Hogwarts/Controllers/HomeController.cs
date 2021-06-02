using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Hogwarts.Models;
using Microsoft.AspNetCore.Http;


namespace Hogwarts.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // other code ...

        [HttpPost("register")]
        public IActionResult RegisterWizard(string Name, string House, int CurrentYear)
        {
            // first Argument is the name of the Method (not the route) second is the name of the controller or the info passed if method is in the same controller  (optional) third is info passed if not in the same controller(optional)
            HttpContext.Session.SetString("Name", $"{Name}");
            HttpContext.Session.SetString("Location", $"{House}");
            HttpContext.Session.SetInt32("CurrentYear", CurrentYear);

            Console.WriteLine($"Name {Name}, House: {House},  Year: {CurrentYear}");
            return RedirectToAction("ContactDisp");
        }


                [HttpGet]
        [Route("contact")]
        public ViewResult Contact()
        {
            // Same logic for serving a view applies
            // if we provide the exact view name
            return View("Contact");
        }

        
        [HttpGet]
        [Route("contactdisp")]
        public ViewResult ContactDisp()
        {
            // ViewBag.Name = HttpContext.Session.GetString("Name");
            // ViewBag.Location = HttpContext.Session.GetString("Location");
            // ViewBag.Language = HttpContext.Session.GetString("Language");
            // ViewBag.Message = HttpContext.Session.GetString("Message");




            return View("ContactDisp");
        }

        
        [HttpPost("post")]
        public ViewResult ContactPost(Survey student1)
        // public ViewResult ContactPost(string name, string location, string language, string message)
        {

            // Survey student2 = new Survey()
            // {
            //     Name = name,
            //     Location = location,
            //     Language = language,
            //     Message = message,
            // };
            
            return View("ContactDisp");
        }
        // [HttpPost("post")]
        // public IActionResult ContactPost(string name, string location, string language, string message)
        // {
        //     // first Argument is the name of the Method (not the route) second is the name of the controller or the info passed if method is in the same controller  (optional) third is info passed if not in the same controller(optional)
        //     HttpContext.Session.SetString("Name", $"{name}");
        //     HttpContext.Session.SetString("Location", $"{location}");
        //     HttpContext.Session.SetString("Language", $"{language}");
        //     HttpContext.Session.SetString("Message", $"{message}");

        //     Console.WriteLine($"Name {name}, Location: {location},  Message: {message}");
        //     return RedirectToAction("ContactDisp");
        // }


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
