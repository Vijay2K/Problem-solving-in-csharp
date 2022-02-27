//Q40. Input a number from command line argument and check it is Armstrong or not.

using System;

namespace Assignment_2
{
    internal class Q40_ArmstrongUsingCL
    {
        public static void ArmstrongNumberCL(string[] args)
        {
            armstrong:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nQ40. Input a number from command line argument and check it is Armstrong or not.");

            Console.Write("\nElements in an array : ");
            for(int i = 0; i < args.Length; i++)
            {
                Console.Write("{0}  ", args[i]);
            }
            Console.WriteLine();

            for(int i = 0; i < args.Length; i++)
            {
                int val = int.Parse(args[i]);

                int init = val;
                int temp = val;
                int count = 0;
                double sum = 0;

                while(temp > 0)
                {
                    temp /= 10;
                    count++;
                }

                while(val > 0)
                {
                    int rem = val % 10;
                    sum += Math.Pow(rem, count);
                    val /= 10;
                }

                Console.Write("\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                if(sum == init)
                {
                    Console.WriteLine("{0} is an armstrong number", init);
                } else
                {
                    Console.WriteLine("{0} is not an armstrong number", init);
                }
            }

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
                    goto armstrong;
                case 'n':
                case 'N':
                    Console.Clear();
                    Program.QuestionPartTwo();
                    break;
                default:
                    Console.Write("Invalid Input...");
                    goto choices;
            }
        }
    }
}
