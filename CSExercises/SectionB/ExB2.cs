﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Slight modification to above: Write a program that 
    //takes a double precision number as input and prints 
    //the square root of the number.  
    //The square root should be rounded to 3 decimal places.
    //Input	    Output
    //0	        0.000
    //25	    5
    //3	        1.732
    //300	    17.321

    public class ExB2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the number!");
            double inputNumber = Convert.ToDouble(Console.ReadLine());
            string resultString = SQRT(inputNumber);
            Console.WriteLine("The square root of the number: {0} is {1}", inputNumber, resultString);
        }

        public static string SQRT(double x)
        {
            //YOUR CODE HERE: return the square root of x and then use String.Format 
            //to format it. The format is similar to WriteLine
            double resultDouble = Math.Sqrt(x);
            string result = String.Format("{0:0.000}",Math.Round(resultDouble,3));
            return result;

        }
    }
}
