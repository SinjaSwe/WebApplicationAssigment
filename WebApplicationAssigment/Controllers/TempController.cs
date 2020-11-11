using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationAssigment.Models;

namespace WebApplicationAssigment.Controllers
{
    public class TempController : Controller
    {
        TempService _tempService = new TempService(); 

        [Route("/tempCheck")]
        public ActionResult TempChecker()
        {
            return View();
        }

        [HttpGet] 
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost] //get the info from the form
        //[ValidateAntiForgeryToken] // to protect against hackers
        [Route ("/tempCheck")]
        public IActionResult TempChecker (int temperature)
        {
           
        }


       
       
    }
}
