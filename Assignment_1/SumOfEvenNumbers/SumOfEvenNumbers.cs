//Write a program to calculate sum of all even numbers up to given number

using System;

namespace SumOfEvenNumbers
{
    internal class SumOfEvenNumbers
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter the number : ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("sum of first {0} even numbers : {1}", n ,SumOfEven(n));
        }

        private static int SumOfEven(int n)
        {
            int sum = 0;

            for(int i = 1; i <= n; i++)
            {
                if(i % 2 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
