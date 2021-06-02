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
    public class DachiController : Controller
    {
        private int generateChance()
        {
            int result = 0;
            Random r = new Random();
            result = r.Next(0, 3);

            return result;
        }
        // public Dachi myDachi { get; set; } = new Dachi();
        public JsonResult Example(Dachi Tugboat)
        {
            // The Json method converts the object passed to it into JSON
            return Json(Tugboat);
            // Tugboat can be a simple variable like a number or a string
            // it can also be something more complicated like a User Object or 
            // a list of Product
        }

        [HttpGet("Dachi")]
        public IActionResult DachiIndex()
        {
            if (HttpContext.Session.GetString("DachiInSess") == null)
            {
                Dachi myDachi = new Dachi();
                HttpContext.Session.SetString("DachiInSess", "Alive");
                var Tugboat = Example(myDachi);
                HttpContext.Session.SetObjectAsJson("TugBoat", myDachi);
            }
            else{
            Dachi myDachi = HttpContext.Session.GetObjectFromJson<Dachi>("Tugboat");
            }
            return View("Dachi");
        }
        
            


        // [HttpGet("Dachi")]
        // public IActionResult DachiIndex()
        // {
        //     if( HttpContext.Session.GetString("DachiInSess") == null)
        //     {
        //         Dachi myDachi = new Dachi();
        //         HttpContext.Session.SetString("DachiInSess", "Alive");
        //         var Tugboat = Example(myDachi);

        //         HttpContext.Session.SetInt32("Happiness", myDachi.Happiness);
        //         HttpContext.Session.SetInt32("Fullness", myDachi.Fullness);
        //         HttpContext.Session.SetInt32("Energy", myDachi.Energy);
        //         HttpContext.Session.SetInt32("Meals", myDachi.Meals);

        //     }
        //         ViewBag.Happiness = HttpContext.Session.GetInt32("Happiness");
        //         ViewBag.Fullness = HttpContext.Session.GetInt32("Fullness");
        //         ViewBag.Energy = HttpContext.Session.GetInt32("Energy");
        //         ViewBag.Meals = HttpContext.Session.GetInt32("Meals");


        //     return View("Dachi");
        // }


        [HttpGet("Feed")]
        public IActionResult Feed()
        {



            return View("DachiIndex");
        }

        [HttpGet("Feed")]
        public IActionResult Feed2()
        {
            // bool Alive = true;
            int? Fullness = HttpContext.Session.GetInt32("Fullness");
            int? Meals = HttpContext.Session.GetInt32("Meals");

            ViewBag.Fullness = HttpContext.Session.GetInt32("Fullness");
            Random r = new Random(); //add chance dont want to that food
            Fullness +=  r.Next(5,11); // add cant feed without meals
            Meals -= 1;
            
            if (Meals <= 0){
                // Alive = false;
            } 

            ViewBag.Happiness = HttpContext.Session.GetInt32("Happiness");
            ViewBag.Meals = HttpContext.Session.GetInt32("Meals");

            return View("DachiIndex");
        }


        [HttpGet("new")]
        public IActionResult NewPasscode()
        {
            int? times = HttpContext.Session.GetInt32("times");
            times++;
            HttpContext.Session.SetInt32("times", (int)times);

            return RedirectToAction("Index");

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
