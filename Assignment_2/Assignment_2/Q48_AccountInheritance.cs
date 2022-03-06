//Q48. Take Account as abstract class. Make saving a/c and current a/c as its child. Make hierarchical inheritance between them. 

using System;

namespace Assignment_2
{
    internal class Q48_AccountInheritance
    {
        abstract class Account
        {
            protected static int balance;
            public abstract void Transactions();
            public void GetChoice(string str)
            {
                enter:
                Console.Write("\nDo you want to {0} amount? (y / n) : ", str);
                char c;
                c = char.Parse(Console.ReadLine());

                switch (c)
                {
                    case 'y':
                    case 'Y':
                        if(str == "deposit")
                        {
                            int amt;
                            Console.Write("Enter the amount to deposit : ");
                            amt = int.Parse(Console.ReadLine());
                            balance += amt;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("current balance : " + balance);
                        }
                        else if(str == "withdraw")
                        {
                            withdraw:
                            int amt;
                            Console.Write("Enter the amount to withdraw : ");
                            amt = int.Parse(Console.ReadLine());
                            
                            if(amt > balance)
                            {
                                Console.WriteLine("\nUnable to withdraw due to insufficient balance");
                                Console.WriteLine("Please try again...\n");
                                goto withdraw;
                            } else
                            {
                                balance -= amt;
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("current balance : " + balance);
                            }
                        }
                        break;
                    case 'n':
                    case 'N':
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Current balance : " + balance);
                        break;
                    default:
                        Console.WriteLine("Invalid input....");
                        goto enter;
                    
                }
            }
        }

        class Saving : Account
        {
            public override void Transactions()
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter the balance : ");
                balance = int.Parse(Console.ReadLine());
                GetChoice("deposit");
            }
        }

        class Current : Account
        {
            public override void Transactions()
            {
                Console.ForegroundColor = ConsoleColor.White;
                GetChoice("withdraw");
            }
        }

        public static void AccountInheritance()
        {
            account:
            Console.WriteLine("\nQ48. Take Account as abstract class. Make saving a/c and current a/c as its child. Make hierarchical inheritance between them.");
            
            Saving saving = new Saving();
            saving.Transactions();
            Current current = new Current();
            current.Transactions();

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
                    goto account;
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
