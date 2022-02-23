//Write a program to find greater between given three numbers.

using System;

namespace GreaterNumber
{
    internal class GreaterNumber
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.Write("Enter the num 1 : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the num 2 : ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the num 3 : ");
            num3 = int.Parse(Console.ReadLine());

            int result = GreaterNum(num1, num2, num3);
            Console.WriteLine("Greater number amoung three numbers {0}, {1} and {2} : {3}", num1, num2, num3, result);
        }

        private static int GreaterNum(int a, int b, int c)
        {
            int greater = 0;

            if(a > b && a > c)
            {
                greater = a;
            } else if(b > a && b > c)
            {
                greater = b;
            } else
            {
                greater = c;
            }

            return greater;
        }
    }
}
