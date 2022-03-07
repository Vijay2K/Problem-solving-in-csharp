/*Q50. Declare a class name ‘A’ with some methods and one parameterised constructor. Derive another class ‘B’ from ‘class A’. 
	In class B have some methods and constructor. Demonstrate how base class parameterised constructor gets 
	call from child class constructor. 
 */

using System;

namespace Assignment_2
{
    internal class Q50_parameterisedconstructor
    {
        class A
        {
            private int a, b;
            private int greater;

            public A(int a, int b)
            {
                this.a = a;
                this.b = b;
            }

            public void GreaterNum()
            {
                if(a > b)
                {
                    greater = a;
                } else
                {
                    greater = b;
                }

                Console.WriteLine("\nGreater number : {0}", greater);
            }

        }

        class B : A
        {
            public B(int a, int b) : base(a, b)
            {
                Console.WriteLine("\nValue initialized");
            }
        }

        public static void ParametrisedConstructor()
        {
            greater:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nQ50. Declare a class name ‘A’ with some methods and one parameterised constructor. Derive another class ‘B’ from ‘class A’." + 
                    "In class B have some methods and constructor.Demonstrate how base class parameterised constructor gets" +
                    "call from child class constructor.");
            int a, b;
            Console.Write("\nEnter the value for A : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter the value for B : ");
            b = int.Parse(Console.ReadLine());

            B val = new B(a, b);
            Console.ForegroundColor = ConsoleColor.Yellow;
            val.GreaterNum();

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
                    Program.QuestionPartThree();
                    break;
                default:
                    Console.Write("Invalid Input...");
                    goto choices;
            }
        }
    }
}
