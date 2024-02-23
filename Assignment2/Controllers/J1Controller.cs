using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// Calculates the total calories for the 4 options the user enters
        /// </summary>
        /// <param name="burger">burger option </param>
        /// <param name="drink">drink option</param>
        /// <param name="side">side option</param>
        /// <param name="desert">desert option</param>
        /// <example> http://localhost:63047/api/J1/Menu/1/2/3/4 => 691 </example>
        /// <example> http://localhost:63047/api/J1/Menu/4/4/4/4 => 0 </example>
        /// <returns>Total calories for the 4 items</returns>
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{desert}")]

        public int Menu(int burger, int drink, int side, int desert)
        {
            int[] CaloriesOfBurger = { 461, 431, 420, 0 };
            int[] CaloriesOfDrink = { 130, 160, 118, 0 };
            int[] CaloriesOfSide = { 100, 57, 70, 0 };
            int[] CaloriesOfDesert = { 167, 266, 75, 0 };

            int totalCalories = CaloriesOfBurger[burger - 1] + CaloriesOfDrink[drink - 1] + CaloriesOfSide[side - 1] + CaloriesOfDesert[desert - 1];

            return totalCalories;
        }
    }
}
