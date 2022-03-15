//Q56. Create a file which includes only data members, another file which contains all constructors of the class, 
//another file which will include all functions related. Use the concept of partial class.

using System;

namespace Assignment_2
{
    partial class Cal
    {
        private float a, b, result;
    }

    partial class Cal
    {
        public Cal(float a, float b)
        {
            this.a = a;
            this.b = b;
            result = 0;
        }
    }

    partial class Cal
    {
        public void Sum()
        {
            result = a + b;
            Console.WriteLine("\nSum of {0} and {1} : {2}", a, b, result);
        }

        public void Sub()
        {
            result = a - b;
            Console.WriteLine("\nDifference between {0} and {1} : {2}", a, b, result);
        }

        public void Multiply()
        {
            result = a * b;
            Console.WriteLine("\nMultiplication of {0} and {1} : {2}", a, b, result);
        }

        public void Divide()
        {
            result = a / b;
            Console.WriteLine("\nDivision of {0} and {1} : {2}", a, b, result);
        }
    }

    internal class Q56_PartialClass
    {
        public static void PartialClass()
        {
            data:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nQ56. Create a file which includes only data members, another file which contains all constructors of the class," + 
            " another file which will include all functions related.Use the concept of partial class.");

            float a, b;
            Console.Write("\nEnter the value for a : ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Enter the value for b : ");
            b = float.Parse(Console.ReadLine());

            Cal cal = new Cal(a, b);
            Console.ForegroundColor = ConsoleColor.Yellow;
            cal.Sum();
            cal.Sub();
            cal.Multiply();
            cal.Divide();

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
                    goto data;
                case 'n':
                case 'N':
                    Console.Clear();
                    Program.QuestionPartFour();
                    break;
                default:
                    Console.Write("Invalid Input...");
                    goto choices;
            }
        }
    }
}
