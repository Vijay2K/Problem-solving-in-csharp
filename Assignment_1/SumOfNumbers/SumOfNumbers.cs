//Write a program to find sum of 1 to n numbers using goto statement.

using System;

namespace SumOfNumbers
{
    internal class SumOfNumbers
    {
        static void Main(string[] args)
        {
            int n, i = 1, sum = 0;
            Console.WriteLine("Enter the n : ");
            n = int.Parse(Console.ReadLine());
            SUM:
            if(i <= n)
            {
                sum += i;
                i++;

                goto SUM;
            }

            Console.WriteLine("Sum of {0} numbers : {1}", n, sum);
        }
    }
}
