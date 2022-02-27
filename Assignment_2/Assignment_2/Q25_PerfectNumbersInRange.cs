//Q25. Write a C# program to print all perfect numbers within given range.

using System;

namespace Assignment_2
{
    internal class Q25_PerfectNumbersInRange
    {
        public static void PerfectNumberInRange()
        {
        perfect:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n25. Write a C# program to print all perfect numbers within given range.");
            int start, end;
            Console.Write("\nEnter the starting range : ");
            start = int.Parse(Console.ReadLine());
            Console.Write("Enter the ending range : ");
            end = int.Parse(Console.ReadLine());
            FindPerfectNumberInRange(start, end);

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

        private static void FindPerfectNumberInRange(int start, int end)
        {
            Console.Write("\nPerfect numbers within the range {0} and {1} : ", start, end);
            int perfectCount = 0;
            for(int i = start; i <= end; i++)
            {
                int sum = 0;
                int n = 1;

                while(n < i)
                {
                    if(i % n == 0)
                    {
                        sum += n;
                    }
                    n++;
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                if(sum == i)
                {
                    Console.Write("{0}  ", i);
                    perfectCount++;
                }
            }

            if(perfectCount == 0)
            {
                Console.Write("NULL");
                Console.WriteLine("\nThere is no perfect number within the range {0} and {1}", start, end);
            }

        }
    }
}
