using System;
using ThankGod4Kaitlyn.Models;
using Microsoft.AspNetCore.Mvc;
namespace ThankGod4Kaitlyn.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }
        [HttpPost("Home/process")]
        public IActionResult ProcessForm(Survey result)
        {
            if (ModelState.IsValid)
            {
                TempData["Name"]= result.Name;
                TempData["Location"] = result.Location;
                TempData["Language"] = result.Language;
                TempData["Comment"] = result.Comment;
                return RedirectToAction("Result");
            }
            else
            {
            // passing result as view model
            return View("Index");
            }
        }
        [HttpGet("result")]
        public ViewResult Result()
        {

            return View("Result");
        }
    }
}
