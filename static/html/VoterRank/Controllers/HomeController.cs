using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VoterRank.Models;

namespace VoterRank.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetStarted()
        {
            return View();
        }        
        public IActionResult FAQ()
        {
            return View();
        }        
        public IActionResult SignIn()
        {
            return View();
        }        
        public IActionResult ThankYou()
        {
            return View();
        }


    }
}
