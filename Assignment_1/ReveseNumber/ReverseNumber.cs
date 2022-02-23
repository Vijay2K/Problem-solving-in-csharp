//Write a program to reverse the given number.

using System;

namespace ReveseNumber
{
    internal class ReverseNumber
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter the number : ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Revese Number : {0}", ReverseNum(number));
        }

        private static int ReverseNum(int num)
        {
            int rev = 0;

            while(num > 0)
            {
                int rem = num % 10;
                rev = (rev * 10) + rem;
                num /= 10;
            }

            return rev;
        }
    }
}
