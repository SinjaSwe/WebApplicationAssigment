using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationAssigment.Models;

namespace WebApplicationAssigment.Controllers
{
    public class GuessController : Controller
    {
        public string SessionKeyNumberToGuess = "_NumberToGuess"; 
        public string SessionInfo_NumbertoGuess { get; private set; }

        

        public IActionResult GuessingGame()
        {
            ViewBag.Guess = HttpContext.Session.GetString("Guess");

            return View("GuessingGame");
        }

        [HttpGet]
        [Route("/guessGame")]
        public IActionResult EnterGuess()
        {
            if (HttpContext.Session.GetInt32("numberToGuess") == null)
            {
                HttpContext.Session.SetInt32("numberToGuess", new Random().Next(1, 101));
            }
            return View(); 
        }            

        [HttpPost] //get the info from the form                  
        [Route("/guessGame")]
        
        public IActionResult GuessingGame(int guess)

        {
            if (HttpContext.Session.GetInt32("numberToGuess") == null)
            {
                HttpContext.Session.SetInt32("guess", new Random().Next(1, 101));
            }

            int numberToGuess = (int)HttpContext.Session.GetInt32("numberToGuess");

            ViewBag.number = GuessingGameService.CheckGuess(guess, numberToGuess);

            if (numberToGuess == guess)
            {
                HttpContext.Session.SetInt32("numberToGuess", new Random().Next(1, 101));
            }

            return View();
        }
}
        






       
}
