using System;

namespace CSExercises
{
    ///Write a C# program that would keep prompting you to enter an integer number over and over again until you enter the number 88. If you enter 88 the computer should say: 
    //	“Lucky you…” 
    //and exit the program.


    public class ExD1
    {
        public static void Main(string[] args)
        {
            int num = 0;
            do
            {
                num = GetValidNumber();
                if (num != 88)
                {
                    Console.WriteLine("Today you are not so lucky! Please Try Again!");
                }
            } while (num != 88);

            Console.WriteLine("Lucky you");

        }

        public static int GetValidNumber()
        {
            int number;
            bool isInt = false;
            bool isValidNumber = false;
            do
            {
                Console.WriteLine("Please enter the number between 0...100!");
                string input = Console.ReadLine();
                isInt = int.TryParse(input, out number);
                if (isInt)
                {
                    isValidNumber = (number > -1 && number < 101) ? true : false;
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
