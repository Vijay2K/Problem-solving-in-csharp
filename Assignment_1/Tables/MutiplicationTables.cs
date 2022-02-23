//Write a program to find table of given number.

using System;

namespace Tables
{
    class MutiplicationTables
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter the number : ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Multiplication table of {0}", num);
            for(int i = 1; i <= 12; i++)
            {
                int result = i * num;
                Console.WriteLine("{0} X {1} = {2}", i, num, result);
            }
        }
    }
}
