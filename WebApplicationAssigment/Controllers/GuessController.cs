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
        [HttpGet]
        [Route("/guessGame")]
        public IActionResult GuessingGame()
        {
            if (HttpContext.Session.GetString("NumberToGuess") == null)
            {
                int numberToGuess = GuessingGameService.CreateRandomNumber();
                HttpContext.Session.SetInt32("NumberToGuess", numberToGuess);
            }

            return View();
        }

        [HttpPost] //get the info from the form                  
        [Route("/guessGame")]

        public IActionResult GuessingGame(int guess)
        {
            int numberToGuess = Convert.ToInt32(HttpContext.Session.GetInt32("NumberToGuess"));

            if (numberToGuess == 0)
            {
                return RedirectToAction(nameof(GuessingGame)); //Gen a new no
            }

            String result = GuessingGameService.CheckGuess(guess, numberToGuess);

            ViewBag.Result = result;
            ViewBag.Guess = guess;
            ViewBag.NumberToGuess = numberToGuess;

            return View();

        }



    }



}
