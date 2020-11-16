using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApplicationAssigment.Models
{
    public class GuessingGameService
    {
        public static string CheckGuess(int guess, int numberToGuess)
        {                                              
            if (numberToGuess == guess)
            {
                return "You have guessed correctly";
            }

            else if (numberToGuess > guess)
            {
                return "Try a lower number"; 
            }

            else
            {
                return "Try a higher number"; 
            }
        }
    }
}

