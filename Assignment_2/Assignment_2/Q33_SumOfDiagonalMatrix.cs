//Q33. Input a square matrix and find the sum of diagonal elements.

using System;

namespace Assignment_2
{
    internal class Q33_SumOfDiagonalMatrix
    {
        public static void SumOfDiagonalMatrix()
        {
        Matrix:
            int rows, cols;
            int sum = 0;
            Console.WriteLine("\nQ33. Input a square matrix and find the sum of diagonal elements.");
            Console.Write("\nEnter the rows : ");
            rows = int.Parse(Console.ReadLine());
            Console.Write("Enter the columns : ");
            cols = int.Parse(Console.ReadLine());

            if(rows == cols)
            {
                int[,] sqrMatrix = new int[rows, cols];

                Console.WriteLine("Enter the elements in a matrix");
                for(int i = 0; i < rows; i++)
                {
                    for(int j = 0; j < cols; j++)
                    {
                        Console.Write("sqrMatrix[{0},{1}] : ", i, j);
                        sqrMatrix[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                Console.WriteLine("\nMatrix");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write("{0}  ", sqrMatrix[i, j]);
                    }
                    Console.Write("\n");
                }

                Console.Write("\nDiagonal matrix elements : ");
                for (int i = 0; i < rows; i++)
                {
                    for(int j = 0; j < cols; j++)
                    {
                        if(i == j)
                        {
                            Console.Write("{0}  ", sqrMatrix[i, j]);
                            sum += sqrMatrix[i, j];
                        }
                    }
                }

                Console.WriteLine("\nSum of the diagonal matrix : {0}", sum);                
            } else
            {
                Console.WriteLine("\nEnter the square matrix");
                Console.WriteLine("\nPress any key...");
                Console.ReadLine();
                Console.Clear();
                goto Matrix;
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
