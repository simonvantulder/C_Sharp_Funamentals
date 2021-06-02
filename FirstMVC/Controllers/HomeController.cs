using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FirstMVC.Models;

namespace FirstMVC.Controllers
{

    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            string[] message = new string[]{
                "News Flash: You're a chump"
                };

            return View(message);
        }    
            
        [HttpGet("names")]
        public IActionResult Names()
        {
            // to a View that has defined a model as @model string[]
            // User someUser = new User();
            User someUser = new User()
            {
                FirstName = "Sally",
                LastName = "Billys",
            };
            User someUser1 = new User()
            {
                FirstName = "John",
                LastName = "Billys",
            };
            User someUser2 = new User()
            {
                FirstName = "Moose",
                LastName = "Billys",
            };
            List<User> users = new List<User>()
            {
                someUser,
                someUser1,
                someUser2
            };

            return View(users);
        }

        [HttpGet("nums")]
        public IActionResult Nums()
        {
            // to a View that has defined a model as @model string[]
            // User someUser = new User();
            int[] nums = new int[]
            {
                1,
                2,
                3,
                5,
                8,
                13
            };
            return View(nums);
        }
        

        [HttpGet("person")]
        public IActionResult Person()
        {
            // to a View that has defined a model as @model string[]
            // User someUser = new User();
            User someUser1 = new User()
            {
                FirstName = "John",
                LastName = "Billys",
            };

            return View(someUser1);
        }
        
        
        [HttpGet("userinfo")]
        public IActionResult UserInfo()
        {
            // to a View that has defined a model as @model string[]
            // User someUser = new User();

            return View();
        }


        }
    }

