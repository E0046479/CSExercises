 using System;

namespace CSExercises
{
    //Electrifying Electronics Pte Ltd. manufactures 
    //three audio-visual electronic products named 
    //as TV, DVD, and MP3.  The table below gives 
    //the unit price for each of these products:

    //PRODUCT   PRICE
    //TV	    $900
    //DVD	    $500
    //MP3	    $700

    //Retailers make orders for these products. 
    //Each order will have the product code and quantity 
    //(only one product in an order).  The company has a policy 
    //that discount of 10% is given when the order amount exceeds 
    //$5000 and 15% discount when the order amount exceeds $10000.  
    //These discounts apply to TV and DVD only and no discount is provided for MP3.

    //Write a program that would prompt the user successively 
    //the three product codes viz., TV, DVD, MP3 and after each prompt, 
    //the user enters the order quantity for that product.  
    //Then apply the price computations.  (Obviously, if the user does not 
    //wish to order the item prompted he/she would enter a zero for the order quantity).

    public class ExC6
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE - get user input, call the function and return the discounted price
            int tvOrderQty = GetValidNumber("TV");
            int dvdOrderQty = GetValidNumber("DVD");
            int mp3OrderQty = GetValidNumber("MP3");
            double discotedCost = CalculateTotalPrice(tvOrderQty, dvdOrderQty, mp3OrderQty);

            Console.WriteLine("TV\tDVD\tMP3\tDiscounted Price"); // for paper output
            Console.WriteLine("{0}\t{1}\t{2}\t{3}", tvOrderQty, dvdOrderQty, mp3OrderQty, discotedCost);

            //Console.WriteLine(discotedCost); // for test code...
        }

        public static double CalculateTotalPrice(int tvQty, int dvdQty, int mp3Qty)
        {
            double totalPrice = 900 * tvQty + 500 * dvdQty + 700 * mp3Qty;
            double orderAmount = 900 * tvQty + 500 * dvdQty;
            double discountedPrice;
            if (orderAmount > 5000 && orderAmount <= 10000)
            {
                discountedPrice = totalPrice - (orderAmount * 0.1);
            }
            else if (orderAmount > 10000)
            {
                discountedPrice = totalPrice - (orderAmount * 0.15);
            }
            else
            {
                discountedPrice = totalPrice;
            }
            return discountedPrice;
        }

        public static int GetValidNumber(string product)
        {
            int number;
            bool isInt = false;
            do
            {
                Console.WriteLine("Please enter the order number for {0}", product);
                string input = Console.ReadLine();
                isInt = int.TryParse(input, out number);
            } while (!isInt);
            return number;
        }
    }
}