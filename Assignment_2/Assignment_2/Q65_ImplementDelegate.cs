//Q65. Write a program to implement the concept of delegates.

using System;

namespace Assignment_2
{
    internal class Q65_ImplementDelegate
    {
        delegate void Calculate(float a, float b);

        private static void Add(float a, float b)
        {
            float c = a + b;
            Console.WriteLine("\nAdd : {0}", c);
        }

        private static void Subtract(float a, float b)
        {
            float c = a + b;
            Console.WriteLine("\nSubtract : {0}", c);
        }        
        private static void Multiply(float a, float b)
        {
            float c = a * b;
            Console.WriteLine("\nMultiply : {0}", c);
        }

        private static void Divide(float a, float b)
        {
            float c = a / b;
            Console.WriteLine("\nDivide : {0}", c);
        }

        public static void ImplementDelegate()
        {
        ans:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nQ65. Write a program to implement the concept of delegates.");
            float a, b;

            Console.Write("\nEnter the value for A : ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Enter the value for B : ");
            b = float.Parse(Console.ReadLine());

            Calculate cal = new Calculate(Add);
            Calculate cal1 = new Calculate(Subtract);
            Calculate cal2 = new Calculate(Multiply);
            Calculate cal3 = new Calculate(Divide);

            Console.ForegroundColor = ConsoleColor.Yellow;
            cal(a, b);
            cal1(a, b);
            cal2(a, b);
            cal3(a, b);

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
