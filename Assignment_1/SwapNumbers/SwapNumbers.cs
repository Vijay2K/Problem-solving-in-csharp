//Write a program to swap given two numbers.

using System;

namespace SwapNumbers
{
    class SwapNumbers
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Enter the num 1 : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter the num 2 : ");
            b = int.Parse(Console.ReadLine());

            SwapNumber(a, b);        
        }

        private static void SwapNumber(int a, int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("\nAfter Swapping : ");
            Console.WriteLine("num 1 : {0}", a);
            Console.WriteLine("num 2 : {0}", b);
        }
    }
}
