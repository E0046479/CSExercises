using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company example before, 
    //print the output so that the fare is the 
    //output is printed always rounded to nearest 10 cents 
    //and printed to two decimal places.

    public class ExB8
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the kilometres! that you travel!");
            double distance = Convert.ToDouble(Console.ReadLine());
            double taxiFare = CalculateFare(distance);
            Console.WriteLine(taxiFare);
        }

        public static double CalculateFare(double distance)
        {
            double fare = 2.4 + (double)(distance * 0.4);
            return Math.Round(fare,1, MidpointRounding.AwayFromZero);

        }
    }
}
