﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        ///<summary>
        /// This will roll my 3 dice, then display the rolls and the sum of the rolls 
        ///</summary>
        
        //Methods

        public int  GameRolls()            // this is going to roll the 3 dice then show the results, its also responsible for the sum of dice this will be called later 
        {
            Die die1 = new Die();       // this creates 3 dice 
            Die die2 = new Die();
            Die die3 = new Die();

            die1.Roll();
            Thread.Sleep(1);            // this will add a delay of 1 milliseconds to  the dice roll and allow them to be more random 
            die2.Roll();            // this will asign a number to each of the dice 
            Thread.Sleep(1);
            die3.Roll();

            Console.WriteLine("Rolls: ");            // this is text that will be shown to help users know what the numbers are 
            Console.WriteLine(die1.Value);           // this prints the dice values 
            Console.WriteLine(die2.Value);   
            Console.WriteLine(die3.Value);
            int sumOfDice = die1.Value + die2.Value + die3.Value;        // this adds the values of the dice together to ctreate the sumOfDice
            Console.WriteLine("Sum Total off Rolls: ");            // this will print the sum total of the dice 
            Console.WriteLine(sumOfDice);
            return sumOfDice;
        }


    }
}
