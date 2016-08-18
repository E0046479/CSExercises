using System;

namespace CSExercises
{
    public class ExH2
    {
        //Write a static method: FindWord(string s1, string s2) that would return an integer.  
        //The method should find if the string s2 occurs in s1 and return an integer that would 
        //indicate the starting position of the word s2 in s1.  If the word does not occur 
        //the return value should be –1.

        public static int FindWord(string s1, string s2)
        {
            //int isFound = 0;
            //string smallS1 = s1.ToLower();
            //string smallS2 = s2.ToLower();
            //for (int i = 0; i < smallS1.Length; i++)
            //{
            //    if (smallS2[0] == smallS1[i])
            //    {
            //        string subString = smallS1.Substring(i, smallS2.Length);
            //        if (subString == smallS2)
            //        {
            //            isFound = i;
            //        }
            //    }
            //}
            int isFound = s1.IndexOf(s2);
            return isFound;
        }

        //public static void Main(string[] args)
        //{
        //    string s1 = "The brown fox";
        //    string s2 = "fox";

        //    Console.WriteLine("S1\t\tS2\t\tOutput");
        //    int isFound = FindWord(s1, s2);
        //    Console.WriteLine("{0}\t{1}\t\t{2}", s1, s2, isFound);
        //}
    }
}

