using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{

    //Write a program that will print out your detail in the following format:
    //Line 1: Name
    //Line 2: Email

    //Example:
    //John Smith
    //e0011223 @u.nus.edu

    public class ExA1
    {
        public static String myName, myEmail;

        public static void Main(string[] args)
        {
            myName = "Zaw Myo Htet";
            myEmail = "e0046479@u.nus.edu";
            Console.WriteLine(myName + "\n{0}", myEmail);
        }

    }
}
