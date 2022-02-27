//Q21. Write a c# program to convert given number in word form. (147 : one hundred forty seven)

using System;

namespace Assignment_2
{
    internal class Q21_NumberToWords
    {
        static string[] one =
        {
            "", "one ", "two ", "three ", "four ", "five ", "six ", "seven ", "eight ", "nine ", "ten ", "eleven ",
            "twelve ", "thirteen ", "fourteen ", "fifteen ", "sixteen ", "seventeen ", "eighteen ", "nineteen "
        };

        static string[] ten =
        {
            "", "", "twenty ", "thirty ", "forty ", "fifty ", "sixty ", "seventy ", "eighty ", "ninety "
        };

        public static void NumberToWords()
        {
        word:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nQ21. Write a c# program to convert given number in word form. (147 : one hundred forty seven)");
            int num;
            string result = "";
            Console.Write("\nEnter the number : ");
            num = int.Parse(Console.ReadLine());
            Console.Write("\nNumber '{0}' in words : ",num);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(ConvertToWords(num, result));

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
                    goto word;
                case 'n':
                case 'N':
                    Console.Clear();
                    Program.QuestionsPartOne();
                    break;
                default:
                    Console.Write("Invalid Input...");
                    goto choices;
            }
        }

        private static string NumberToWords(int n, string s, string str, int length)
        {
            if(n > 19)
            {
                str += ten[n / 10];
                str += one[n % 10];
            } else
            {
                str += one[n];
            }

            if(n != 0)
            {
                str += s;
            }

            return str;
        }

        private static string ConvertToWords(int n, string str)
        {
            string st = "";
            str += NumberToWords((n / 10000000), "crore ", st, 20);
            str += NumberToWords((n / 100000) % 100, "lakh ", st, 20);
            str += NumberToWords((n / 1000) % 100, "thousand ", st, 20);
            str += NumberToWords((n / 100) % 10, "hundred ", st, 20);

            str += NumberToWords((n % 100), "", st, 20);
            return str;
        } 
    }
}
