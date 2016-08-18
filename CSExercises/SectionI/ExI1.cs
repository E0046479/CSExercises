using System;

namespace CSExercises
{
    //You are required to take as input an amount (dollar.cents).  
    //Assume that the amount is between 5 cents (inputted as 0.05) and 
    //3 dollars 50 cents (inputted as 3.50).  Further assume that we would 
    //always input nearest to 5 cents (i.e., values like 2.23 are not keyed in).  
    //The duty of your program is to dispense this amount (accurately!) using a combination of 
    //a denomination can be used.  
    //Yeah I know what you are thinking – simply issue all five cent coins; right?  
    //Cannot!- easy but no challenge.  
    //We are requesting the program to use the “minimum number of coins” principle.  
    //For example, if a request were made for 1.95 then the computer would issue one 100-cent coin, 
    //one 50-cent coin, two 20-cent coins and one 5-cent coin.  

    //The trick is to always start with the largest denomination and slowly go down.  
    //Try your luck – but don’t loose money!  

    public class ExI1
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the amount between  5 cents (inputted as 0.05) and 3 dollars 50 cents (inputted as 3.50) : ");
            double amount = Convert.ToDouble(Console.ReadLine());

            int totalCent = (int) (Math.Round(amount,2) * 100);
            int hundredCent, fiftyCent,tweentyCent,tenCent,fiveCent, remaider;

            if (totalCent >= 100)
            {
                hundredCent = (totalCent / 100) * 100;
                remaider = totalCent - hundredCent;
                if (totalCent != hundredCent && remaider >= 50)
                {
                    fiftyCent = (remaider / 50) * 50;
                    remaider = remaider - fiftyCent;
                    if (remaider != fiftyCent && remaider >= 20)
                    {

                    }
                }

            }
            else if (totalCent >= 50)
            {

            }
            else if (totalCent >= 20)
            {

            }
            else if (totalCent >= 10)
            {

            }
            else if (totalCent >= 5)
            {

            }

             


        }
    }
}
