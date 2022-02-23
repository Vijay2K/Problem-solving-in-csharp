//Write a c# program to convert given number in word. (357546  :  three five seven five four six )
//Update


using System;

namespace NumberToWords
{
    internal class NumToWords
    {
        static void Main(string[] args)
        {
            int n, rem, sum = 0;
            Console.Write("Enter the number : ");
            n = int.Parse(Console.ReadLine());

            while(n > 0)
            {
                rem = n % 10;
                sum = (sum * 10) + rem;
                n /= 10;
            }

            n = sum;

            Console.Write("Number in words : ");
            while(n > 0)
            {
                rem = n % 10;
                switch(rem)
                {
                    case 0:
                        Console.Write("zero ");
                        break;
                    case 1:
                        Console.Write("one ");
                        break;
                    case 2:
                        Console.Write("two ");
                        break;
                    case 3:
                        Console.Write("three ");
                        break;
                    case 4:
                        Console.Write("four ");
                        break;
                    case 5:
                        Console.Write("five ");
                        break;
                    case 6:
                        Console.Write("six ");
                        break;
                    case 7:
                        Console.Write("seven ");
                        break;
                    case 8:
                        Console.Write("eight ");
                        break;
                    case 9:
                        Console.Write("nine ");
                        break;
                    default:
                        Console.Write("Invalid input ");
                        break;
                }

                n /= 10;
            }
        }
    }
}
