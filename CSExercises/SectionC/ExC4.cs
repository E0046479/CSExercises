using System;

namespace CSExercises
{
    //ABC Taxi Company has the following meter charges based on the kilometres travelled.

    //Minimum charge:  $2.40  (first 0.5 km no additional charges apply)
    //For the next 8.5 kms the rate is 4 cents for every 100 meters
    //After that:   5 cents for evey 100 meters

    //In the above example you should assume that the meter falls every 100 meters.So assume that if the distance travelled(i.e.input) is 12.13 km then it is rounded to 12.20 and the cost would be:

    //$ 2.40 (first 0.5 km) +
    //$ 85 * 0.04 (next 8.5 km) +
    //$ (122 -90) * 0.05 (for distance over 9.0 km)
    //=  $7.40


    public class ExC4
    {
        public static void Main(string[] args)
        {

            double number;
            bool isDouble = false;
            do
            {
                Console.WriteLine("Please enter the distance that you travel with km!");
                string input = Console.ReadLine();
                isDouble = double.TryParse(input, out number);
            } while (!isDouble);
            double fare = CalculateFare(number);
            Console.WriteLine(fare);
        }

        public static double CalculateFare(double distance)
        {
            double fare = 0;
            if (distance <= 0.5)
            {
                fare = 2.4;
            }
            else if (distance > 0.5 && distance <= 9)
            {
                fare = 2.4 + (8.5 * 10 * 0.04);
            }
            else
            {
                fare = 2.4 + (8.5 * 10 * 0.04) + ((distance - 9) * 10 * 0.05);
            }
            return Math.Round(fare, 1);
        }
    }
}