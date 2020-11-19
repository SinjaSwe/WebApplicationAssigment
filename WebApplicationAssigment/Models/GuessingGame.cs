using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApplicationAssigment.Models
{
    public class GuessingGame
    {
        public int Guess { get; set; }

        public static int CreateRandomNumber()
        {
            int numberToGuess = 0;

            Random random = new Random();
            numberToGuess = random.Next(1, 100);

            return numberToGuess;
        }
    }
}

