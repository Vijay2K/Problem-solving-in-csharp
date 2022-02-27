//Q39. Input a number from command line argument and check whether it is palindrome or not.

using System;

namespace Assignment_2
{
    internal class Q39_PalindromeUsingCL
    {
        public static void PalindromeUsingCL(string[] args)
        {
            reverse:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nQ39. Input a number from command line argument and check whether it is palindrome or not.");

            Console.Write("\nElements in an array : ");
            for (int i = 0; i < args.Length; i++)
            {
                Console.Write("{0}  ", args[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < args.Length; i++)
            {
                int val = int.Parse(args[i]);
                int init = val;
                int rev = 0;

                while (val > 0)
                {
                    int rem = val % 10;
                    rev = (rev * 10) + rem;
                    val /= 10;
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nReverse number : {0}", rev);

                if (init == rev)
                {
                    Console.WriteLine("{0} is a palindrome", init);
                }
                else
                {
                    Console.WriteLine("{0} is not a palindrome", init);
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
                    goto reverse;
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
