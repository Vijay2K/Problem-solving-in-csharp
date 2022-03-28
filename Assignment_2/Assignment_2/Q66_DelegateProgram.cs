//Q66. Write a delegate which will take one integer argument. 
//And write functions for factorial, Fibonacci, Factors of number, Table of Number and call the functions through delegate.

using System;

namespace Assignment_2
{
    internal class Q66_DelegateProgram
    {
        private delegate void Cal(int n);

        private static void Fibonacci(int n)
        {
            int a = 0, b = 1;
            int c;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nFibonacci series of first {0} numbers : ", n);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("{0}  {1}  ", a, b);

            for(int i = 2; i < n; i++)
            {
                c = a + b;

                a = b;
                b = c;

                Console.Write("{0}  ", c);
            }
        }

        private static void Factorial(int n)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\nFactorial of the {0} : ", n);
            int factorial = 1;
            for(int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("{0}", factorial);
        }

        private static void Factors(int n)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\nFactors of {0} : ", n);
            for(int i = 1; i <= n; i++)
            {
                if(n % i == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("{0}  ", i);
                }
            }
        }

        private static void Tables(int n)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\nMultiplication table of {0}", n);
            for(int i = 1; i <= 10; i++)
            {
                int result = i * n;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("{0} X {1} = {2}", i, n, result);
            }
        }

        public static void DelegateProgram()
        {
            ans:
            Console.WriteLine("\nQ66. Write a delegate which will take one integer argument." +
            "And write functions for factorial, Fibonacci, Factors of number, Table of Number and call the functions through delegate.");

            int n;
            Console.Write("\nEnter the number : ");
            n = int.Parse(Console.ReadLine());

            Cal cal = new Cal(Fibonacci);
            cal += Factors;
            cal += Factorial;
            cal += Tables;

            cal.Invoke(n);

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
                    goto ans;
                case 'n':
                case 'N':
                    Console.Clear();
                    Program.QuestionPartFive();
                    break;
                default:
                    Console.Write("Invalid Input...");
                    goto choices;
            }
        }
    }
}
