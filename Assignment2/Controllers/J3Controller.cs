using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J3Controller : ApiController
    {
        /// <summary>
        /// simile Write a program to input  adjectives and  nouns provided by, and print out all possible similes.  
        /// The first two lines of input will provide the values of adjectives and nouns, in that order followed, one per line, by adjectives  and nouns. 
        /// </summary>
        /// <param name="adjectives"> Value of the adjectives </param>
        /// <param name="nouns"> Value of the Nouns </param>
        /// <example> http://localhost:54227/api/J3/Similes/easy,soft,smart/rock,pie => easy as rock, easy as pie, soft as rock, soft as pie, smart as rock, smart as pie,</example>
        /// <example> http://localhost:54227/api/J3/Similes/hard,impossible,slippery/stone,ice => hard as stone, hard as ice, impossible as stone, impossible as ice, slippery as stone, slippery as ice, </example>
        /// <returns> All combinations of the values of provided for adjectives and nouns </returns>
        [HttpGet]
        [Route("api/J3/Similes/{adjectives}/{nouns}")]
        public string Similes(string adjectives, string nouns)
        {
        /*Using the split to allow multiple adjectives and nouns input*/
            string[] adjectiveArray = adjectives.Split(',');
            string[] nounArray = nouns.Split(',');
            string result = "";
            //the loop created is to allow all possible combinations to be considered for the adjective and nouns
            for (int i = 0; i< adjectiveArray.Length; i++)
            {
                for(int j =0; j< nounArray.Length; j++)
                {
                    result += adjectiveArray[i] + " as " + nounArray[j] + ", ";
                }
            }
            return result;
        }
    }
}
