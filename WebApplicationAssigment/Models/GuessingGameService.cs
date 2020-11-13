using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApplicationAssigment.Models
{
    public class GuessingGameService
    {
        public static string CheckGuess(int guess, int numberToGuess)
        {                                              
            if (numberToGuess == guess)
            {
                Console.WriteLine("You have guessed correctly");
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

