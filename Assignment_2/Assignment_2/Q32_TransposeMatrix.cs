//Q32. Input one matrix and print its transpose.

using System;

namespace Assignment_2
{
    internal class Q32_TransposeMatrix
    {
        public static void TransposeMatrix()
        {
            Matrix:
            int rows, cols;
            Console.WriteLine("Q32. Input one matrix and print its transpose.");
            Console.Write("Enter the rows : ");
            rows = int.Parse(Console.ReadLine());
            Console.Write("Enter the columns : ");
            cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];
            int[,] transpose = new int[cols, rows];

            Console.WriteLine("Enter the elements in matrix");
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    Console.Write("matrix[{0},{1}] : ", i, j);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nMatrix");
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    Console.Write("{0}  ", matrix[i, j]);
                }
                Console.Write("\n");
            }

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    transpose[j, i] = matrix[i, j];
                }
                Console.Write("\n");
            }

            Console.WriteLine("Transpose matrix");
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write("{0}  ", transpose[i, j]);
                }
                Console.Write("\n");
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
                    goto Matrix;
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
