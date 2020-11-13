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

        public IActionResult GuessGame()
        {
            return View();
        }

        [HttpGet]
        [Route("/guessGame")]
        public IActionResult GuessingGame(int guess)
        {
            int? numberToGuess = HttpContext.Session.GetInt32("_NumbertoGuess"); //must have ? https://stackoverflow.com/questions/16798269/cannot-implicitly-convert-type-int-to-int

            GuessingGame guessingGame = GuessingGameService.CheckGuess(guess, numberToGuess);

            HttpContext.Session.SetInt32("_NumbertoGuess", guessingGame.NumberToGuess);
        }                       


        [HttpPost] //get the info from the form                  
        [Route("/guessGame")]
        
        public IActionResult GuessingGame(int guess)
        {
            ViewBag.TempResult = GuessingGameService.CheckGuess(numberToGuess);
            return View();
        }
}
        






       
}
