//Write a program to check given number is even or odd.

using System;

namespace EvenOdd
{
    internal class EvenOrOdd
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter the number : ");
            num = int.Parse(Console.ReadLine());
            CheckEvenOrOdd(num);
        }

        private static void CheckEvenOrOdd(int n)
        {
            if(n % 2 == 0)
            {
                Console.WriteLine("\n{0} is an even number.", n);
            } else
            {
                Console.WriteLine("\n{0} is an odd number.", n);
            }
        }
    }
}
