using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApplicationAssigment.Models
{
    public class GuessingGame
    {
        public int Guess { get; set; }

    }

    public class GuessingGameService
    {
        public static int CreateRandomNumber()
        {
            int numberToGuess = 0;

            Random random = new Random();
            numberToGuess = random.Next(1, 100);

            return numberToGuess;
        }

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

