//Write a program to find all factors of given number

using System;

namespace Factors
{
    internal class Factors
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter the number : ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Factors of {0} : ", n);
            for(int i = 1; i <= n; i++)
            {
                if(n % i == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}
