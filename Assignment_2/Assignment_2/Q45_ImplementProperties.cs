//Q45. Write the program which will implement the concept of properties in c#.

using System;

namespace Assignment_2
{
    internal class Q45_ImplementProperties
    {
        class Player
        {
            private int xpPoint;
            private int level;
            public int Health { get; set; }
            
            public int XP
            {
                get
                {
                    return xpPoint;
                } 
                set
                {
                    xpPoint = value;
                }
            }

            public int Level
            {
                get
                {
                    xpPoint += level * 2000;
                    return level;
                } set
                {
                    level = value; 
                }
            }

            public bool IsAlive
            {
                get
                {
                    if (Health > 0)
                    {
                        return true;
                    }

                    return false;
                }
            }

            public void DisplayStatus()
            {
                Console.WriteLine("Player's Health : " + Health);
                Console.WriteLine("Player level : " + Level);
                Console.WriteLine("Player's XpPoints (updated) : " + XP);
                if(IsAlive)
                {
                    Console.WriteLine("Player status : 'alive'");
                } else
                {
                    Console.WriteLine("Player status : 'dead'");
                }
            }
        }

        public static void ImplementProperties()
        {
        Props:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nQ45. Write the program which will implement the concept of properties in c#.");
            Player player = new Player();

            Console.Write("Enter the player health : ");
            player.Health = int.Parse(Console.ReadLine());
            Console.Write("Enter the XP points : ");
            player.XP = int.Parse(Console.ReadLine());
            Console.Write("Enter the level : ");
            player.Level = int.Parse(Console.ReadLine());

            Console.WriteLine("\nplayer details");
            Console.ForegroundColor = ConsoleColor.Yellow;
            player.DisplayStatus();

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
                    goto Props;
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
