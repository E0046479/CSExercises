using System;

namespace CSExercises
{
    //Use Euclid's Algorithm given below to determine 
    //the LCM and HCF for given two integer numbers.

    //- Take in as input two numbers A and B.

    //-	Subtract the smaller of the two numbers from 
    //  the Larger Number and assign the answer to the larger number.

    //-	The above process is repeated until both the numbers are equal, say X.
    //-	Apparently the residual number (X) that we have obtained is the HCF.

    //-	LCM could then be computed using the formula(A* B)/HCF

    //-	Print out your answers.


    public class ExD2
    {
        public static void Main(string[] args)
        {
            int a = GetValidNumber("A");
            int b = GetValidNumber("B");
            int hcf = 0;
            int lcm = 0;

            CalculateHCFAndLCM(a, b, ref hcf, ref lcm);

            Console.WriteLine("HCF:" + hcf);
            Console.WriteLine("LCM:" + lcm);
        }

        public static void CalculateHCFAndLCM(int a, int b, ref int hcf, ref int lcm)
        {
            //YOUR CODE HERE
            //Don't worry about the use of "ref" keyword here. 
            //At the end of the method, assign the HCF value to the hcf parameter
            //and LCM to the lcm parameter. hcf = <some value>; lcm=<some value>;
            int max = Math.Max(a, b);
            int min = Math.Min(a, b);
            do
            {
                max = max - min;
                if (max < min)
                {
                    int temp = min;
                    min = max;
                    max = temp;
                }
                    
            } while (max != min);

            hcf = max;
            lcm = (a * b) / hcf;
        }

        public static int GetValidNumber(string n)
        {
            int number;
            bool isInt = false;
            do
            {
                Console.WriteLine("Enter {0}", n);
                string input = Console.ReadLine();
                isInt = int.TryParse(input, out number);
            } while (!isInt);
            return number;
        }
    }
}
