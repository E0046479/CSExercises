using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that takes a double precision number 
    //as input and prints the square root of the number.

    public class ExB1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the number!");
            double inputNumber = Convert.ToDouble(Console.ReadLine());
            double result = SQRT(inputNumber);
            Console.WriteLine("The square root of the number: {0} is {1:0.000}",inputNumber,result);
        }

        public static double SQRT(double x)
        {
            double result = Math.Sqrt(x);
            return result;
        }
    }
}
