//Q46. Write a C# program which will demonstrate the single inheritance. Take base class as Bird and child class as parrot. 
//Write and inherit the appropriate methods.

using System;

namespace Assignment_2
{
    internal class Q46_SingleIheritance
    {
        class Bird
        {
            public string Name { get; set; }

            public string Color { get; set; }
        }

        class Parrot : Bird
        {
            public bool CanFly { get; set; }            
        }

        public static void SingleInheritance()
        {
        single:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Q46. Write a C# program which will demonstrate the single inheritance. Take base class as Bird and child class as parrot."+ 
                    "Write and inherit the appropriate methods.");
            Parrot parrot = new Parrot();
            Console.Write("Enter the bird name : ");
            parrot.Name = Console.ReadLine();
            Console.Write("Enter the color : ");
            parrot.Color = Console.ReadLine();
            Console.Write("This bird can fly (y / n) : ");
            retry:
            char c;
            c = char.Parse(Console.ReadLine());
            switch (c)
            {
                case 'y':
                case 'Y':
                    parrot.CanFly = true;
                    break;
                case 'n':
                case 'N':
                    parrot.CanFly = false;
                    break;
                default:
                    Console.WriteLine("\nInvalid Input...");
                    goto retry;
            }

            Console.WriteLine("\nBirds details\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Name : " + parrot.Name);
            Console.WriteLine("Color : " + parrot.Color);
            if(parrot.CanFly)
            {
                Console.WriteLine("Can Fly : yes");

            } else
            {
                Console.WriteLine("Can Fly : No");
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
                    goto single;
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
