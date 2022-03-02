//Q43. Write a program which will demonstrate the use of static keyword with variables, methods, and constructor.

using System;

namespace Assignment_2
{
    internal class Q43_DemonstrateStaticKeyword
    {
        class Car
        {
            public static string name;
            public static string modelName;
            public static string color;
            public static int milage;

            static Car()
            {
                Console.WriteLine("\nEnter the Car Details (static constructor)");
            }

            public static void GetData()
            {
                Console.Write("\nEnter the car name : ");
                name = Console.ReadLine();
                Console.Write("Enter the model name : ");
                modelName = Console.ReadLine();
                Console.Write("Enter the color : ");
                color = Console.ReadLine();
                Console.Write("Enter the milage : ");
                milage = int.Parse(Console.ReadLine());
            }
        }

        public static void DemonstateStaticKeyword()
        {
            d_static:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nQ43. Write a program which will demonstrate the use of static keyword with variables, methods, and constructor.");

            Car.GetData();
            Console.WriteLine("\nCar details");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Name : {0}", Car.name);
            Console.WriteLine("Model Name : {0}", Car.modelName);
            Console.WriteLine("Color : {0}", Car.color);
            Console.WriteLine("Milage : {0}", Car.milage);

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
                    goto d_static;
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
