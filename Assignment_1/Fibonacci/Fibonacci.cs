using System;

namespace Fibonacci
{
    internal class Fibonacci
    {
        static void Main(string[] args)
        {
            int n, a = 0, b = 1, c;
            Console.Write("Enter the number : ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Fibonacci Series up to {0} numbers", n);
            Console.Write("{0}  {1}  ", a, b);
            for(int i = 0; i < n; i++)
            {
                c = a + b;

                if(c > n)
                {
                    break;
                }

                a = b;
                b = c;
                Console.Write("{0}  ", c);
            }
        }
    }
}
