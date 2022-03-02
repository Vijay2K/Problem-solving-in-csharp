//Q42. Write a program which will demonstrate constructor overloading. Use default, paratermised and copy constructor.

using System;

namespace Assignment_2
{
    internal class Q42_ConstructorOverloading
    {
        class Magnitude
        {
            private float x;
            private float y;
            private float z;
            private double magnitude;

            public Magnitude()
            {
                x = 5.2f;
                y = 10.42f;
                z = 2.6f;
                magnitude = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
            }

            public Magnitude(float x, float y, float z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
                magnitude = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
            }

            public Magnitude(Magnitude mag)
            {
                this.x = mag.x;
                this.y = mag.y;
                this.z = mag.z;
                magnitude = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
            }

            public void DisplayDistance()
            {
                Console.WriteLine("Magnitude (x : {0}, y : {1}, z : {2}) = {3}\n", x, y, z, magnitude);
            }
        }

        public static void ConstructorOverloading()
        {
            constructor:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nQ42. Write a program which will demonstrate constructor overloading. Use default, paratermised and copy constructor.");

            float x;
            float y;
            float z;
            
            Console.WriteLine("\nConstructor overloading");

            Magnitude magnitude = new Magnitude();
            Console.WriteLine("\nDefault constructor");
            Console.ForegroundColor = ConsoleColor.Yellow;
            magnitude.DisplayDistance();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nEnter the value Parameter constructor");

            Console.Write("Enter the x : ");
            x = float.Parse(Console.ReadLine());
            Console.Write("Enter the y : ");
            y = float.Parse(Console.ReadLine());
            Console.Write("Enter the z : ");
            z = float.Parse(Console.ReadLine());

            Magnitude magnitude1 = new Magnitude(x, y, z);
            Console.WriteLine("\nParameter constructor");
            Console.ForegroundColor = ConsoleColor.Yellow;
            magnitude1.DisplayDistance();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nCopy constructor");
            Magnitude magnitude2 = new Magnitude(magnitude1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            magnitude2.DisplayDistance();

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
