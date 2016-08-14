using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company problem above, 
    //calculate the fare so that the fare is always 
    //rounded upwards to the nearest 10 cents. 
    //This is harder than the previous problem 
    //and requires your ingenuity

    public class ExB9
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
            return Math.Ceiling(fare * 10) * 0.1;

        }
    }
}
