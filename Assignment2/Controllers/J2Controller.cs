using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// a program which determines how many ways you can roll 2 dices and get the sum of 10.
        /// </summary>
        /// <param name="m">value on dice 1</param>
        /// <param name="n">value on dice 1</param>
        /// <example> http://localhost:54227/api/J2/DiceGame/6/8 => There is 5 total ways to get the sum of 10 </example>
        /// <example>http://localhost:54227/api/J2/DiceGame/12/4 => There is 4 total ways to get the sum of 10</example>
        /// <returns>The number of times you can get the sum of 10</returns>
        /// 

        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]

        public string DiceGame(int m, int n)
        {
            int count = 0;

            for (int InitialValue = 1; InitialValue <= n; InitialValue++)
            {
                int sum = 10 - InitialValue;
                if (sum >= 1 && sum <= m)
                {
                    count++;
                }
            }
            return "There is " + count + " total ways to get the sum of 10 ";
        }


    }
}
