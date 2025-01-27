﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        ///<summary>
        /// This runs the game and checks the value of the dice and sum of dice to make sure there in bounds 
        ///</summary>
        
        //Method
        public void RunningTest()       // void stops it from returning a value 
        {
            Game g = new Game();                // this will allow me to use the game class and call GameRoll()

            int trial = g.GameRolls();           // this is going to check the values of the dice / total 
            Console.WriteLine("testing the game");  // this will tell the user what step they are up to 
            Die trialDie = new Die();
            trialDie.Roll();                    // his calls the function from Die class 
            Console.WriteLine("testing the dice");
            // this will check if the dice is within the bounds needed 

            Debug.Assert(trialDie.Roll() > 0);
            Debug.Assert(trialDie.Roll() < 7);

            Debug.Assert(trial > 2 );          // this will check that the total of all the dice added is still within bounds 
            Debug.Assert(trial < 19);

        }

        
    }
}
