//Q49. Demonstrate multiple inheritance with the use of interface with suitable example.

using System;

namespace Assignment_2
{
    internal class Q49_MultipleInheritance
    {
        interface IVector
        {
            public void Calculate(float x, float y, float z);
        }

        class VectorBase
        {
            public static float magnitude;
        }

        class Magnitude : VectorBase, IVector
        {
            public void Calculate(float x, float y, float z)
            {
                magnitude = (float)Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
                Console.WriteLine("\nMagnitude : {0}", magnitude);
            }
        }

        class Normals : VectorBase, IVector
        {
            public void Calculate(float x, float y, float z)
            {
                float _x = (x / magnitude);
                float _y = (y / magnitude);
                float _z = (z / magnitude);

                Console.WriteLine("Normal vector : ({0}, {1}, {2})", _x, _y, _z);
            }
        }

        public static void MultipleInheritance()
        {
            multiple:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Q49. Demonstrate multiple inheritance with the use of interface with suitable example.");
            Console.WriteLine("\nEnter the values for vector");
            float x, y, z;

            Console.Write("Enter the x : ");
            x = float.Parse(Console.ReadLine());
            Console.Write("Enter the y : ");
            y = float.Parse(Console.ReadLine());
            Console.Write("Enter the z : ");
            z = float.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Magnitude mag = new Magnitude();
            mag.Calculate(x, y, z);
            Normals normal = new Normals();
            normal.Calculate(x, y, z);

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
                    goto multiple;
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
