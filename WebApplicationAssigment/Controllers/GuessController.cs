﻿using System;
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
            if (HttpContext.Session.GetString("View") != null && (HttpContext.Session.GetString("View")).CompareTo("Guess/CreateRandomNumber/Post") == 0)
            {
                ViewBag.Result = HttpContext.Session.GetString("Result");
                ViewBag.UserGuess = HttpContext.Session.GetInt32("Guess");
                ViewBag.GeneratedNumber = HttpContext.Session.GetInt32("NumberToGuess");
            }

            else
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
            String result = GuessingGameService.CheckGuess(guess, numberToGuess);

            HttpContext.Session.SetString("Result", result);
            HttpContext.Session.SetInt32("Guess", guess);
            HttpContext.Session.SetString("View", "Guess/NumberToGuess/Post");

            return RedirectToAction(nameof(GuessingGame));
        }

        

}
        

          
}
