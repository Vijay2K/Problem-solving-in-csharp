using System;
using System.Threading;

namespace Assignment_2
{
    internal class Program
    {
        static string[] strs;
        static void Main(string[] args)
        {
            strs = new string[args.Length];
            for(int i = 0; i < args.Length; i++)
            {
                strs[i] = args[i];
            }

            Choices();
        }

        private static void Choices()
        {
            byte choice;

        CHOICE:
            Console.WriteLine("\tAssignment - 2\n");
            Console.WriteLine("  1. Question from 21 to 30");
            Console.WriteLine("  2. Question from 31 to 40");
            Console.WriteLine("\n\tAssignment - 3\n");
            Console.WriteLine("  3. Question from 41 to 50");
            Console.WriteLine("\n  Press 0 to exit\n");

            Console.Write("  Enter the Choice : ");
            choice = byte.Parse(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    Console.Clear();
                    QuestionsPartOne();
                    break;
                case 2:
                    Console.Clear();
                    QuestionPartTwo();
                    break;
                case 3:
                    Console.Clear();
                    QuestionPartThree();
                    break;
                default:
                    Console.WriteLine("Invalid Choice...");
                    Thread.Sleep(500);
                    Console.Clear();
                    goto CHOICE;
            }
        }

        public static void QuestionsPartOne()
        {
            byte choice;

            Questions:
            Console.WriteLine("1. Write a c# program to convert given number in word form. (147 : one hundred forty seven)");
            Console.WriteLine("2. Find the greater between given 3 numbers using ternary operator.");
            Console.WriteLine("3. Write a C# program to convert decimal number to binary.");
            Console.WriteLine("4. Write a C# program to check whether given number is perfect or not.(6, 28, 496, 8128 )");
            Console.WriteLine("5. Write a C# program to print all perfect numbers within given range.");
            Console.WriteLine("6. Write down a menu driven program using switch to convert various distance from one unit to other.");
            Console.WriteLine("7. Write a program in C# to read n number of values in an array and display it in reverse order.");
            Console.WriteLine("8. Write a program in C# to find the sum and average of all elements of the array.");
            Console.WriteLine("9. Write a program in C# to find maximum and minimum element in an array.");
            Console.WriteLine("10. Write a program in C# to sort the given array in descending order.");
            Console.WriteLine("\nPress 0 to Go Back");

            Console.Write("\nEnter your choice : ");
            choice = byte.Parse(Console.ReadLine());

            switch(choice)
            {
                case 0:
                    Console.Clear();
                    Choices();
                    break;
                case 1:
                    Console.Clear();
                    Q21_NumberToWords.NumberToWords();
                    break;
                case 2:
                    Console.Clear();
                    Q22_GreaterNumberTernary.GreaterNumber();
                    break;
                case 3:
                    Console.Clear();
                    Q23_DecimalToBinary.DecimalToBinary();
                    break;
                case 4:
                    Console.Clear();
                    Q24_PerfectNumber.PerfectNumbers();
                    break;
                case 5:
                    Console.Clear();
                    Q25_PerfectNumbersInRange.PerfectNumberInRange();
                    break;
                case 6:
                    Console.Clear();
                    Q26_DistanceConversion.DistanceConversion();
                    break;
                case 7:
                    Console.Clear();
                    Q27_ReverseArray.ReverseArray();
                    break;
                case 8:
                    Console.Clear();
                    Q28_ArraySumAverage.ArraySumAverage();
                    break;
                case 9:
                    Console.Clear();
                    Q29_MinMaxElements.MinMaxElements();
                    break;
                case 10:
                    Console.Clear();
                    Q30_DecendingSort.SortingInDecending();
                    break;
                default:
                    Console.WriteLine("Invalid Input...");
                    Thread.Sleep(500);
                    Console.Clear();
                    goto Questions;
            }
        }

        public static void QuestionPartTwo()
        {
            byte choice;

        Questions:
            Console.WriteLine("1. Write a program in C# to search given element in array.");
            Console.WriteLine("2. Input one matrix and print its transpose.");
            Console.WriteLine("3. Input a square matrix and find the sum of diagonal elements.");
            Console.WriteLine("4. Write a C# program to store the information of one student using structure.");
            Console.WriteLine("5. Write a C# program to store the information of 5 employees using structure and array.");
            Console.WriteLine("6. Demonstrate the use of all access specifiers with suitable example.");
            Console.WriteLine("7. Input 3 numbers from command line argument and find greater between them using ternary operator.");
            Console.WriteLine("8. Input 5 subjects marks from command line argument. Calculate percentage of student and assign appropriate grade.");
            Console.WriteLine("9. Input a number from command line argument and check whether it is palindrome or not.");
            Console.WriteLine("10. Input a number from command line argument and check it is Armstrong or not.");
            Console.WriteLine("\nPress 0 to Go Back");

            Console.Write("\nEnter your choice : ");
            choice = byte.Parse(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Console.Clear();
                    Choices();
                    break;
                case 1:
                    Console.Clear();
                    Q31_SearchElement.SearchElements();                    
                    break;
                case 2:
                    Console.Clear();
                    Q32_TransposeMatrix.TransposeMatrix();
                    break;
                case 3:
                    Console.Clear();
                    Q33_SumOfDiagonalMatrix.SumOfDiagonalMatrix();
                    break;
                case 4:
                    Console.Clear();
                    Q34_StudentInfo.StudentDetails();
                    break;
                case 5:
                    Console.Clear();
                    Q35_EmployeeInfo.EmployeeInfo();
                    break;
                case 6:
                    Console.Clear();
                    Q36_AccessSpecifiers.AccessSpecifiers();
                    break;
                case 7:
                    Console.Clear();
                    Q37_GreaterNumberUsingCL.CL_GreaterNumber(strs);
                    break;
                case 8:
                    Console.Clear();
                    Q38_StudentGradeUsingCL.StudentGradeCL(strs);
                    break;
                case 9:
                    Console.Clear();
                    Q39_PalindromeUsingCL.PalindromeUsingCL(strs);
                    break;
                case 10:
                    Console.Clear();
                    Q40_ArmstrongUsingCL.ArmstrongNumberCL(strs);
                    break;
                default:
                    Console.WriteLine("Invalid Input...");
                    Thread.Sleep(500);
                    Console.Clear();
                    goto Questions;
            }
        }

        public static void QuestionPartThree()
        {
            byte choice;

            Questions:
            Console.WriteLine("1. Write a program which will demonstrate function overloading. Use minimum 3 functions.");
            Console.WriteLine("2. Write a program which will demonstrate constructor overloading. Use default, paratermised and copy constructor.");
            Console.WriteLine("3. Write a program which will demonstrate the use of static keyword with variables, methods, and constructor.");
            Console.WriteLine("4. Write a program to demonstrate static constructor with proper example.");
            Console.WriteLine("5. Write the program which will implement the concept of properties in c#.");
            Console.WriteLine("6. Write a C# program which will demonstrate the single inheritance. Take base class as Bird and child class as parrot\n"+ 
                                "  Write and inherit the appropriate methods.");
            Console.WriteLine("7. Write a C# program to demonstrate multilevel inheritance. Base class – bird, middle class – flying birds, child class – any bird.\n" + 
                                "  Use appropriate methods in related class.");
            Console.WriteLine("8. Take Account as abstract class. Make saving a/c and current a/c as its child. Make hierarchical inheritance between them.");
            Console.WriteLine("9. Demonstrate multiple inheritance with the use of interface with suitable example.");
            Console.WriteLine("10. Declare a class name ‘A’ with some methods and one parameterised constructor. Derive another class ‘B’ from ‘class A’.\n" +
                    "  In class B have some methods and constructor.Demonstrate how base class parameterised constructor gets\n" +
                    "  call from child class constructor.");
            Console.WriteLine("\nPress 0 to Go Back");

            Console.Write("\nEnter your choice : ");
            choice = byte.Parse(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Console.Clear();
                    Choices();
                    break;
                case 1:
                    Console.Clear();
                    Q41_DemonstrateFunctionOverloading.FunctionOverloading();
                    break;
                case 2:
                    Console.Clear();
                    Q42_ConstructorOverloading.ConstructorOverloading();
                    break;
                case 3:
                    Console.Clear();
                    Q43_DemonstrateStaticKeyword.DemonstateStaticKeyword();
                    break;
                case 4:
                    Console.Clear();
                    Q44_StaticConstructor.StaticConstructor();
                    break;
                case 5:
                    Console.Clear();
                    Q45_ImplementProperties.ImplementProperties();
                    break;
                case 6:
                    Console.Clear();
                    Q36_AccessSpecifiers.AccessSpecifiers();
                    break;
                case 7:
                    Console.Clear();
                    Q37_GreaterNumberUsingCL.CL_GreaterNumber(strs);
                    break;
                case 8:
                    Console.Clear();
                    Q38_StudentGradeUsingCL.StudentGradeCL(strs);
                    break;
                case 9:
                    Console.Clear();
                    Q39_PalindromeUsingCL.PalindromeUsingCL(strs);
                    break;
                case 10:
                    Console.Clear();
                    Q40_ArmstrongUsingCL.ArmstrongNumberCL(strs);
                    break;
                default:
                    Console.WriteLine("Invalid Input...");
                    Thread.Sleep(500);
                    Console.Clear();
                    goto Questions;
            }
        }
    }
}
