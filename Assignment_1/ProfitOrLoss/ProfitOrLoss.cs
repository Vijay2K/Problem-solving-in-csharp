//Write a program to calculate profit or loss.

using System;

namespace ProfitOrLoss
{
    internal class ProfitOrLoss
    {
        static void Main(string[] args)
        {
            float costPrice, sellingPrice, result = 0;
            Console.Write("Enter the cost price : ");
            costPrice = int.Parse(Console.ReadLine());
            Console.Write("Enter the selling price : ");
            sellingPrice = int.Parse(Console.ReadLine());

            if(costPrice < sellingPrice)
            {
                result = sellingPrice - costPrice;
                Console.WriteLine("Profit : {0}", result);
            } else if(costPrice > sellingPrice)
            {
                result = costPrice - sellingPrice;
                Console.WriteLine("Loss : {0}", result);
            } else
            {
                Console.WriteLine("No profit No loss");
            }

        }
    }
}
