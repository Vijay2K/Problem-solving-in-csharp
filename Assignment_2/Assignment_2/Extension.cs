using System;
using System.Collections;

namespace Assignment_2
{
    public static class Extension
    {
        public static void Swap(this int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("A : {0}", a);
            Console.WriteLine("B : {0}", b);
        }

        public static int Max_Num(this Int32 num, Int32 a, Int32 b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static System.Random random = new System.Random();
        public static void Shuffle(this ArrayList list)
        {
            int n = list.Count;
            while(n > 0)
            {
                n--;
                int k = random.Next(n + 1);
                object val = list[k];
                list[k] = list[n];
                list[n] = val;
            }
        }
    }
}
