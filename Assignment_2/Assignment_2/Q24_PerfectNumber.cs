//Q24. Write a C# program to check whether given number is perfect or not.(6, 28, 496, 8128 )

using System;

namespace Assignment_2
{
    internal class Q24_PerfectNumber
    {
        public static void PerfectNumbers()
        {
        perfect:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nQ24. Write a C# program to check whether given number is perfect or not.(6, 28, 496, 8128 )");
            int n;
            Console.Write("\nEnter the value : ");
            n = int.Parse(Console.ReadLine());
            FindPerfectNumber(n);

        choices:
            char ch;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nDo you want to rety (y / n) : ");
            ch = char.Parse(Console.ReadLine());

            switch (ch)
            {
                case 'y':
                case 'Y':
                    Console.Clear();
                    goto perfect;
                case 'n':
                case 'N':
                    Console.Clear();
                    Program.QuestionsPartOne();
                    break;
                default:
                    Console.Write("Invalid Input...");
                    goto choices;
            }
        }

        private static void FindPerfectNumber(int n)
        {
            int sum = 0;
            for(int i = 1; i < n; i++)
            {
                if(n % i == 0)
                {
                    sum += i;
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            if(sum == n)
            {
                Console.WriteLine("{0} is a perfect number.", n);
            } else
            {
                Console.WriteLine("{0} is not a perfect number.", n);
            }
        }
    }
}
