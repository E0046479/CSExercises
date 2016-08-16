using System;

namespace CSExercises
{
    public class ExE3
    {
        //Given an integer as input determine whether the number 
        //is a prime number or not.  Your program should output “Prime” 
        //    or “Not Prime” as the case may be.

        //A Prime Number is one which is only divisible by one and itself.

        //Consider how the efficiency of the program can be improved. 
        //Normally the order of complexity is proportional to the number of 
        //    times a loop is executed.A more formal definition of 
        //    “Analysis of Algorithms” will be dealt in a later course.

        public static void Main(string[] args)
        {
            Console.Write("Please enter an integer: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (IsPrime(n))
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }

            //for (int i = 1; i < 100; i++)
            //{
            //    if (IsPrime(i))
            //    {
            //        Console.WriteLine("{0} Prime", i);
            //    }
            //}

        }

        public static bool IsPrime(int n)
        {
            //is a natural number greater than 1 that has no positive divisors other than 1 and itself.
            // n > 1 && n % i != 0 && n != i
            bool isPrime = true;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                }

            }
            if (n == 1)
            {
                isPrime = false;
            }
            return isPrime;

        }
    }
}
