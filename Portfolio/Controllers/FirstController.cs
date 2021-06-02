using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Http;



namespace Portfolio.Controllers
{
    public class FirstController : Controller 
    {
        [HttpGet("")]
        public ViewResult Time()
        {
            // will attempt to serve 
                // Views/Hello/Index.cshtml
            // or if that file isn't there:
                // Views/Shared/Index.cshtml
            DateTime CurrentDate = DateTime.Now;
            DateTime CurrentMilitaryTime = DateTime.Now;
            DateTime CurrentTime = DateTime.Now;

            string Date = CurrentDate.ToString("MMMM dd, yyyy");
            string MilitaryTime = CurrentMilitaryTime.ToString("HH:mm");
            string Time = CurrentTime.ToString("hh:mm tt");

            ViewBag.Date = Date;
            ViewBag.MilitaryTime = MilitaryTime;
            ViewBag.Time = Time;

            return View();
        }
        [HttpGet("home")]
        public ViewResult Index()
        {
            // will attempt to serve 
                // Views/Hello/Index.cshtml
            // or if that file isn't there:
                // Views/Shared/Index.cshtml
            ViewBag.Example = "Hello World!";

            return View();
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
            ViewBag.Name = HttpContext.Session.GetString("Name");
            ViewBag.Location = HttpContext.Session.GetString("Location");
            ViewBag.Language = HttpContext.Session.GetString("Language");
            ViewBag.Message = HttpContext.Session.GetString("Message");

            return View("ContactDisp");
        }

        
        [HttpPost("post")]
        public IActionResult ContactPost(string name, string location, string language, string message)
        {
            // first Argument is the name of the Method (not the route) second is the name of the controller or the info passed if method is in the same controller  (optional) third is info passed if not in the same controller(optional)
            HttpContext.Session.SetString("Name", $"{name}");
            HttpContext.Session.SetString("Location", $"{location}");
            HttpContext.Session.SetString("Language", $"{language}");
            HttpContext.Session.SetString("Message", $"{message}");

            Console.WriteLine($"Name {name}, Location: {location},  Message: {message}");
            return RedirectToAction("ContactDisp");
        }
        // You may also serve the same view twice from additional actions
        [HttpGet("projects")]
        public ViewResult Projects()
        {
            // This would be a case where we have to specify the file name
            return View("Projects");
        }
    }
}