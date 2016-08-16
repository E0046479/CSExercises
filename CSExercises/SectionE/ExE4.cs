using System;

namespace CSExercises
{
    //Given an integer as input write a C# program to determine 
    //whether the number is a Perfect Number or not.

    //A perfect number is one for which the sum of its factors
    //    (including number one) add up to the number itself.For example 
    //        number six is a perfect number because,
    //		6 = 1 + 2 + 3.


    public class ExE4
    {
        public static void Main(string[] args)
        {
            //Console.Write("Please enter an integer: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //if (IsPerfectNumber(n))
            //{
            //    Console.WriteLine("Perfect Number");
            //}
            //else
            //{
            //    Console.WriteLine("Not Perfect Number");
            //}
            for (int i = 1; i < 1000; i++)
            {
                if (IsPerfectNumber(i))
                {
                    Console.WriteLine(i + " Perfect Number");
                }
            }
               
        }

        public static bool IsPerfectNumber(int n)
        {
            // ( 1 + 2 + 3 + 6 ) / 2 = 6.
            bool isPerfect = false;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            if (sum % n == 0)
            {
                isPerfect = true;
            }
            return isPerfect;
        }
    }
}
