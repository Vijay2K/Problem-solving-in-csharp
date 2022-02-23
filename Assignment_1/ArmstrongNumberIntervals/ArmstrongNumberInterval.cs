//Write a program to print all Armstrong numbers between given two intervals.

using System;

namespace ArmstrongNumberIntervals
{
    internal class ArmstrongNumberInterval
    {
        static void Main(string[] args)
        {
            int start, end;
            Console.Write("Enter the starting range : ");
            start = int.Parse(Console.ReadLine());
            Console.Write("Enter the ending range : ");
            end = int.Parse(Console.ReadLine());

            Console.WriteLine("Armstrong numbers between {0} and {1} : ", start, end);
            for(int i = start; i < end; i++)
            {
                double sum = 0;
                int num = i;
                int count = 0;

                while(num > 0)
                {
                    num /= 10;
                    count++;
                }

                num = i;

                while(num > 0)
                {
                    int rem = num % 10;
                    sum = sum + Math.Pow(rem, count);
                    num /= 10;
                }

                if(sum == i)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}
