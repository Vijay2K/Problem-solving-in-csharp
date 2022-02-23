//Write a program to find given number is Armstrong or not.

using System;

namespace ArmstrongNumber
{
    internal class ArmstrongNumber
    {
        static void Main(string[] args)
        {
            int n, init, count = 0;
            double sum = 0;
            Console.Write("Enter the number : ");
            n = int.Parse(Console.ReadLine());
            init = n;
            int temp = n;

            while(temp > 0)
            {
                temp /= 10;
                count++;
            }

            while(n > 0)
            {
                int rem = n % 10;
                sum = sum + Math.Pow(rem, count);
                n /= 10;
            }

            if(init == sum)
            {
                Console.WriteLine("{0} is an armstrong number.", init);
            } else
            {
                Console.WriteLine("{0} is not an armstrong number.", init);
            }
        }
    }
}
