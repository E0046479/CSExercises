using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //ABC Taxi Company has the following meter charges 
    //based on the kilometres travelled.
    //
    //Minimum fixed charge:  $2.40
    //In addition the fare would be computed at 40 cents per kilometer.
    //
    //E.g.If the distance traveled is 3.24 km then the total fare is 2.40 + 3.24 * 0.4

    public class ExB7
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
            double fare = 2.4 + (double) (distance * 0.4);
            return fare;
        }
    }
}
