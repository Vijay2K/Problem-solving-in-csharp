//Write a program to find sum of all digits in given number.

using System;

namespace SumOfDigits
{
    internal class SumOfDigits
    {
        static void Main(string[] args)
        {
            int num, sum = 0;
            Console.Write("Enter the number : ");
            num = int.Parse(Console.ReadLine());
            while(num > 0)
            {
                int rem = num % 10;
                sum = sum + rem;
                num /= 10;
            }

            Console.WriteLine("Sum of all digits : {0}", sum);
        }
    }
}
