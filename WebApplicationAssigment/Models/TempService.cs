using Microsoft.AspNetCore.Mvc;

namespace WebApplicationAssigment.Models
{
    public class TempService
    {
        public int Temperature { get; set; }

        public static string CheckTemperature(int temperature)
        {
            if (temperature < 38)
            {
                return "Relax, you do not have Covid 19";
            }

            else
            {
                return "You have Covid 19. Please isolate for 2 weeks"; 
            }
        }
    }
}
