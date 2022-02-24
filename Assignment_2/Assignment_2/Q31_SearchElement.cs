//Q31. Write a program in C# to search given element in array.

using System;

namespace Assignment_2
{
    internal class Q31_SearchElement
    {
        public static void SearchElements()
        {
            Search:
            int n, searchElement;
            bool hasFound = false;
            Console.WriteLine("\nQ31. Write a program in C# to search given element in array.");
            Console.Write("\nEnter the size of an array : ");
            n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Enter the elements");
            for(int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] : ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the search element : ");
            searchElement = int.Parse(Console.ReadLine());

            int elementIndex = 0;
            for(int i = 0; i < n; i++)
            {
                elementIndex = i;
                if(searchElement == arr[i])
                {
                    hasFound = true;
                    break;
                }
            }

            if(hasFound)
            {
                Console.WriteLine("\n'{0}' element found at {1} index and {2} position", searchElement, elementIndex, elementIndex + 1);
            } else
            {
                Console.WriteLine("\n{0} haven't found in this array.", searchElement);
            }

        choices:
            char ch;
            Console.Write("\nDo you want to rety (y / n) : ");
            ch = char.Parse(Console.ReadLine());

            switch (ch)
            {
                case 'y':
                case 'Y':
                    Console.Clear();
                    goto Search;
                case 'n':
                case 'N':
                    Console.Clear();
                    Program.QuestionPartTwo();
                    break;
                default:
                    Console.Write("Invalid Input...");
                    goto choices;
            }
        }
    }
}
