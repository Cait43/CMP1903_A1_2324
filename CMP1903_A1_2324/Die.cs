using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        //Property

        public int Value = 0;


        //Method
        public int Roll()          
        {

            Random r = new Random();        // this will generate the random number for my dice 
            Value = r.Next(1, 7);            // this will ensure that the number is 1- 6 
            // next generates random positive numbers 
            return Value;
        }


        
    }
}
