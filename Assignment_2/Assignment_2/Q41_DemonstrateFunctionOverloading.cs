//Q41. Write a program which will demonstrate function overloading. Use minimum 3 functions.

using System;

namespace Assignment_2
{
    class Vector
    {
        public float x { get; }
        public float y { get; }
        public float z { get; }

        public Vector() { }

        public Vector(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void PrintVector(Vector vec)
        {
            Console.WriteLine("vector : ({0}, {1}, {2})", vec.x, vec.y, vec.z);
        }

        public void PrintVector(float x, float y)
        {
            Console.WriteLine("2D vector : ({0}, {1})", x, y);
        }

        public void PrintVector(float x, float y, float z)
        {
            Console.WriteLine("vector :  ({0}, {1}, {2})", x, y, z);
        }
    }

    internal class Q41_DemonstrateFunctionOverloading
    {
        public static void FunctionOverloading()
        {
        vector:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nQ41. Write a program which will demonstrate function overloading. Use minimum 3 functions.");
            float x, y, z;
            Console.WriteLine("\nEnter the vector values\n");
            Console.Write("Enter the x : ");
            x = float.Parse(Console.ReadLine());
            Console.Write("Enter the y : ");
            y = float.Parse(Console.ReadLine());
            Console.Write("Enter the z : ");
            z = float.Parse(Console.ReadLine());
            Vector vec = new Vector(x, y, z);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPrinting vector by passing class as a parameter");
            Console.ForegroundColor = ConsoleColor.Yellow;
            vec.PrintVector(vec);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPrinting vector by passing two float parameter");
            Console.ForegroundColor = ConsoleColor.Yellow;
            vec.PrintVector(x, y);
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPrinting vector by passing three float as a parameter");
            Console.ForegroundColor = ConsoleColor.Yellow;
            vec.PrintVector(x, y, z);

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
                    goto vector;
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
