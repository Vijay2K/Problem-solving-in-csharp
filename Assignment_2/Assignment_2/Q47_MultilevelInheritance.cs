//Q47. Write a C# program to demonstrate multilevel inheritance. Base class – bird, middle class – flying birds, child class – any bird. 
//Use appropriate methods in related class.

using System;

namespace Assignment_2
{
    internal class Q47_MultilevelInheritance
    {
        class Bird
        {
            public virtual void BirdProp()
            {
                Console.WriteLine("I am bird class (base)");
            }

            public void Props()
            {
                Console.WriteLine("Birds can lay egg");
            }
        }

        class FlyingBirds : Bird
        {
            public override void BirdProp()
            {
                Console.WriteLine("Birds can fly");
            }

            public void Flying()
            {
                Console.WriteLine("We can fly across the country");
            }
        }

        class Peacock : FlyingBirds
        {
            public override void BirdProp()
            {
                Console.WriteLine("I am pecock I am the beautiful bird");
            }

            public void PeacockProps()
            {
                Console.WriteLine("I am in blue and green color");
            }
        }

        public static void MultilevelInheritance()
        {
            multilevel:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nQ47. Write a C# program to demonstrate multilevel inheritance. Base class – bird, middle class – flying birds, child class – any bird."+
                "Use appropriate methods in related class.");

            Peacock peacock = new Peacock();
            Console.WriteLine("\nCalled from the 'Peacock class'\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            peacock.BirdProp();
            peacock.Props();
            peacock.Flying();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nCalled from the 'Flying bird class'\n");
            FlyingBirds flyingBird = new FlyingBirds();
            Console.ForegroundColor = ConsoleColor.Yellow;
            flyingBird.BirdProp();
            flyingBird.BirdProp();
            flyingBird.Flying();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nCalled from the 'base bird class'\n");
            Bird bird = new Bird();
            Console.ForegroundColor = ConsoleColor.Yellow;
            bird.BirdProp();
            bird.Props();
            
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
                    goto multilevel;
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
