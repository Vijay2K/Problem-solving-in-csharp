//Q54. Demonstrate the difference between var, object and dynamic data types with suitable example.

using System;

namespace Assignment_2
{
    internal class Q54_VarDynamicKeyword
    {

        public static void VarDynamicKeyword()
        {
            data:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nQ54. Demonstrate the difference between var, object and dynamic data types with suitable example.");
            VarKeyword();
            ObjectKeyword();
            DynamicKeyword();
            
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

        private static void VarKeyword()
        {
            int n;
            var num = 100;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nUsing 'var' keyword\n");
            Console.Write("Enter the value for n (integer): ");
            n = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("(Before adding) Num value : " + num);
            num += n;
            Console.WriteLine("(After adding) Num value : " + num);
        }


        private static void ObjectKeyword()
        {
            string str;            
            object a = 100;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nUsing 'object' keyword\n");
            Console.Write("Enter the string : ");
            str = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Initial value of 'a' (int) : " + a);
            a = str;
            Console.WriteLine("setting the value of 'a' to string from int : " + a);
        }

        private static void DynamicKeyword()
        {
            string str;
            int n, result;
            dynamic a = 100;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nUsing 'dynamic' keyword\n");
            
            Console.Write("Enter the string : ");
            str = Console.ReadLine();
            
            Console.Write("Enter the number : ");
            n = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Initial value of 'a' (int) : " + a);

            result = a + n;
            Console.WriteLine("Adding with the integer : " + result);
            
            a += str;
            Console.WriteLine("concat with string : " + a);

        }

    }
}
