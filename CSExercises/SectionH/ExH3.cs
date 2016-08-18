using System;
namespace CSExercises
{
    public class ExH3
    {
        //Write a function (static method) that would take in an integer and 
        //return the hexadecimal.  Print out the Hex of all numbers 1 to 100 and 
        //compare your answer with that of the built in function.
        public static string Hex(int i)
        {
            string hexValue = i.ToString("X");
            return hexValue;






        }

        public static void Main(string[] args)
        {
            int integerValue = 126;
            string hexaValue = Hex(integerValue);
            Console.WriteLine("{0} = {1}", integerValue, hexaValue);
        }
    }
}
