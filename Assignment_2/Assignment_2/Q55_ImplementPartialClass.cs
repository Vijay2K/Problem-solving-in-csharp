//Q55. Write a program which will implement the partial class concept.

using System;

namespace Assignment_2
{
    partial class Game
    {
        protected string name;
        protected float rating;
    }

    partial class Game
    {
        public void GetData()
        {
            Console.Write("Enter the game name : ");
            name = Console.ReadLine();
            Console.Write("Enter the game rating : ");
            rating = float.Parse(Console.ReadLine());
        }
    }

    partial class Game
    {
        public void DisplayData()
        {
            Console.WriteLine("Game Name : " + name);
            Console.WriteLine("Game Rating : " + rating);
        }
    }

    internal class Q55_ImplementPartialClass
    {
        public static void ImplementPartialClass()
        {
            data:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nQ55. Write a program which will implement the partial class concept.");
            int n;
            Console.Write("\nEnter the number of games : ");
            n = int.Parse(Console.ReadLine());

            Game[] game = new Game[n];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("\nEnter the game {0} details\n", i + 1);
                game[i] = new Game();
                game[i].GetData();
                Console.Write("\n");
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("\nGame {0} details\n", i + 1);
                game[i].DisplayData();
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
