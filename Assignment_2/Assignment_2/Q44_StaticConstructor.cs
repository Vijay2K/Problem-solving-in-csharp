//Q44. Write a program to demonstrate static constructor with proper example.

using System;

namespace Assignment_2
{
    internal class Q44_StaticConstructor
    {
        class Greater
        {
            private static int num1; 
            private int num2, num3, greater;

            //static constructor
            static Greater()
            {
                num1 = 56;
                Console.WriteLine("Static constructor initialized the value for 'num1 =  56'");
            }

            public Greater(int a, int b)
            {
                num2 = a;
                num3 = b;
                
                Console.WriteLine("\nParamter constructor called");
                if (num1 > num2 && num1 > num3)
                {
                    greater = num1;
                }
                else if (num2 > num1 && num2 > num3)
                {
                    greater = num2;
                }
                else
                {
                    greater = num3;
                }
            }

            public void Display()
            {
                Console.WriteLine("Greater number between three numbers ({0}, {1}, {2}) : {3}", num1, num2, num3, greater);
            }
        }

        public static void StaticConstructor()
        {
        constructor:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nQ44. Write a program to demonstrate static constructor with proper example.");

            int a, b;
            Console.WriteLine("\nEnter the value of num2 and num3 for paratemter constructor : ");
            Console.ForegroundColor = ConsoleColor.White;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Greater greater = new Greater(a, b);
            greater.Display();

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
                    goto constructor;
                case 'n':
                case 'N':
                    Console.Clear();
                    Program.QuestionPartThree();
                    break;
                default:
                    Console.Write("Invalid Input...");
                    goto choices;
            }
        }
    }
}
