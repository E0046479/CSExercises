﻿using System;

namespace CSExercises
{

    //Modify the Prime Number C# program to print out all 
    //the prime numbers from 5 to 10000.


    public class ExE5
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            //Hint: you can call ExE3.IsPrime method (from previous exercise) 
            //to check whether a number is a prime or not.
            for (int i = 1; i < 10000; i++)
            {
                if (ExE3.IsPrime(i))
                {
                    Console.WriteLine("{0} Prime", i);
                }
            }

        }
    }
}
