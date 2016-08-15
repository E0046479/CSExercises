using System;

namespace CSExercises
{
    //Given a three-digit integer as input write a C# program 
    //to determine whether the number is an Armstrong number.
    //
    //An Armstrong number is one for which the sum of each digit 
    //raised to the power of number of digits results in the number itself.
    //
    //For a three digit number 153 =  1^3 + 5^3 + 3^3  
    //
    //Confine the input to 3 digit examples only ie., number values 100…999.


    public class ExC5
    {
        public static void Main(string[] args)
        {
            int number = GetValidNumber();
            Console.WriteLine(IsArmstrongNumber(number)); // for paper output
            /*
             * For testing code
            if (IsArmstrongNumber(number))
            {
                Console.WriteLine("Armstrong Number");
            }
            else
            {
                Console.WriteLine("Not Armstrong Number");
            }
             */
        }


        public static bool IsArmstrongNumber(int n)
        {
            bool isArmstrongNumber = false;
            int digit1 = n / 100;
            int digit2 = (n % 100) / 10;
            int digit3 = (n % 100) % 10;
            int sum = Convert.ToInt32(Math.Pow(digit1, 3)) + Convert.ToInt32(Math.Pow(digit2, 3)) + Convert.ToInt32(Math.Pow(digit3, 3));
            isArmstrongNumber = (sum == n) ? true : false;
            return isArmstrongNumber;
        }

        public static int GetValidNumber()
        {
            int number;
            bool isInt = false;
            bool isValidNumber = false;
            do
            {
                Console.WriteLine("Please enter the number between 100...999!");
                string input = Console.ReadLine();
                isInt = int.TryParse(input, out number);
                if (isInt)
                {
                    isValidNumber = (number > 99 && number < 1000) ? true : false;
                }
                else
                {
                    Console.WriteLine("Please enter Number!!!! not character !!!");
                }
            } while (!isValidNumber);
            return number;
        }
    }
}