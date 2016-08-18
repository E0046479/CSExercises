using System;

namespace CSExercises
{
    //Write a static method:  Substitute(string s, char c1, char c2) that would 
    //return a string. The method should find all occurrences of the character c1 
    //in the string s and substitute c1 with character c2.  The new word so formed would 
    //be the return value of this method. 
    public class ExH4
    {
        public static string Substitute(string s, char c1, char c2)
        {
            s = s.Replace(c1, c2);
            return s;
        }

        //public static void Main(string[] args)
        //{
        //    string s1 = "The brown";
        //    char c1 = 'o';
        //    char c2 = 'z';

        //    Console.WriteLine("S1\t\tc1\t\tc2\t\tOutput");
        //    string newString = Substitute(s1, c1, c2);
        //    Console.WriteLine("{0}\t{1}\t\t{2}\t{3}", s1, c1, c2,newString);
        //}
    }
}
