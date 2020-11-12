using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationAssigment.Controllers
{
    public class GuessController : Controller
    {
        public IActionResult GuessGame()
        {
            return View();
        }

        [HttpPost] //get the info from the form
        //[ValidateAntiForgeryToken] // to protect against hackers
        [Route("/guessGame")]
        public IActionResult TempChecker(int temperature)
        {
            ViewBag.TempResult = GuessGame.CheckTemperature(temperature);
            return View();
        }
    }
}
