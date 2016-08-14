using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that would convert temperature given in Centigrade 
    //scale to Fahrenheit – the number can be integer or real.  Use the formula:
    //	F = 1.8C  + 32

    public class ExB4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Centigrade with interger or real!");
            double centigrade = Convert.ToDouble(Console.ReadLine());
            double result = ConvertToFahrenheit(centigrade);
            Console.WriteLine("The result of {0} Centigrade = {1} Fahrenheit ",centigrade,result);
        }

        public static double ConvertToFahrenheit(double c)
        {
            double fahrenheit = 1.8 * c + 32;
            return fahrenheit;

        }
    }
}
