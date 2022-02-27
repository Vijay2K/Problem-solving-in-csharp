//Q37. Input 3 numbers from command line argument and find greater between them using ternary operator.

using System;

namespace Assignment_2
{
    internal class Q37_GreaterNumberUsingCL
    {
        public static void CL_GreaterNumber(string[] args) 
        {
            greater:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nQ37. Input 3 numbers from command line argument and find greater between them using ternary operator.");

            float max = float.MinValue;

            Console.Write("\nElements in an array : ");
            for(int i = 0; i < args.Length; i++)
            {
                Console.Write("{0}  ", args[i]);
                float val = float.Parse(args[i]);
                max = (val > max) ? val : max;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nGreater number : {0}", max);

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
                    goto greater;
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
