//Q53. Demonstrate the use of sealed keyword.(with class and methods)

using System;

namespace Assignment_2
{
    internal class Q53_SealedKeyword
    {
        sealed class FictionBooks
        {
            private string name;
            private string author;
            private string brief;

            public FictionBooks()
            {
                name = "Harry Potter";
                author = "J.K. Rowling";
                brief = "Harry Potter is a series of seven fantasy novels written by British author J. K. Rowling. " +
                    "\nThe novels chronicle the lives of a young wizard, Harry Potter, and his friends Hermione Granger and Ron Weasley, " +
                    "\nall of whom are students at Hogwarts School of Witchcraft and Wizardry";
            }

            public void DisplayBook()
            {
                Console.WriteLine("\nBook Details (sealed class)\n");
                Console.WriteLine("Name : " + name);
                Console.WriteLine("Author : " + author);
                Console.WriteLine("Brief : " + brief);
            }
        }

        class Books
        {
            protected string name;
            protected string author;
            protected string brief;            
        }

        class AtomicHabits : Books
        {
            public AtomicHabits()
            {
                name = "Atomic Habits";
                author = "James Clear";
                brief = "This breakthrough book from James Clear is the most comprehensive guide on " +
                    "how to change your habits and get 1% better every day.";
            }

            public void DisplayBook()
            {
                Console.WriteLine("\nBook Details\n");
                Console.WriteLine("Name : " + name);
                Console.WriteLine("Author : " + author);
                Console.WriteLine("Brief : " + brief);
            }
        }

        public static void SealedKeyword()
        {
            Books:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nQ53. Demonstrate the use of sealed keyword.(with class and methods)");

            Console.ForegroundColor = ConsoleColor.Yellow;
            FictionBooks fiction = new FictionBooks();
            fiction.DisplayBook();
            AtomicHabits atomicHabit = new AtomicHabits();
            atomicHabit.DisplayBook();

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
                    goto Books;
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
