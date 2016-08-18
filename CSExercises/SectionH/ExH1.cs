using System;

namespace CSExercises
{
    public class ExH1
    {
        public static bool InString(string s1, string s2)
        {
            //bool isFound = false;
            //string smallS1 = s1.ToLower();
            //string smallS2 = s2.ToLower();
            //for (int i = 0; i < smallS1.Length; i++)
            //{
            //    if (smallS2[0] == smallS1[i])
            //    {
            //        string subString = smallS1.Substring(i, smallS2.Length);
            //        if (subString == smallS2)
            //        {
            //            isFound = true;
            //        }
            //    }
            //}
            bool isFound = s1.Contains(s2);
            return isFound;
        }

        public static void Main(string[] args)
        {
            string s1 = "The brown fox";
            string s2 = "fox";

            Console.WriteLine("S1\t\tS2\t\tOutput");
            bool isFound = InString(s1, s2);
            Console.WriteLine("{0}\t{1}\t\t{2}", s1, s2, isFound);
        }
    }
}
