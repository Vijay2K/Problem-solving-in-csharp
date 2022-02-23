//Write a program to print all prime numbers between given two intervals.

using System;

namespace PrimeNumbers
{
    internal class PrimeNumbers
    {
        static void Main(string[] args)
        {
            int start, end;
            bool isPrime = false;
            Console.Write("Enter the starting range : ");
            start = int.Parse(Console.ReadLine());
            Console.Write("Enter the ending range : ");
            end = int.Parse(Console.ReadLine());

            Console.WriteLine("Prime numbers between {0} and {1}", start, end);
            for(int i = start + 1; i < end; i++)
            {
                isPrime = false;
                for(int j = 2; j <= i / 2; j++)
                {
                    if(i % j == 0)
                    {
                        isPrime = true;
                        break;
                    }
                }

                if(!isPrime)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}
