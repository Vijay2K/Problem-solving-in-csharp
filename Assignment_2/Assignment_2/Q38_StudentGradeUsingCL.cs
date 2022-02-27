//38. Input 5 subjects marks from command line argument. Calculate percentage of student and assign appropriate grade.

using System;

namespace Assignment_2
{
    internal class Q38_StudentGradeUsingCL
    {
        public static void StudentGradeCL(string[] args)
        {
            student:
            Console.ForegroundColor = ConsoleColor.White;
            
            Console.WriteLine("\n38. Input 5 subjects marks from command line argument. " +
                "Calculate percentage of student and assign appropriate grade.");
            Console.Write("\nSubject Marks\n");

            int failCount = 0;
            float total = 0, percent;
            string grade;

            for(int i = 0; i < args.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Subject {0} mark : ", i + 1);
                Console.ForegroundColor = ConsoleColor.Yellow;

                float marks = float.Parse(args[i]);
                total += marks;

                Console.Write("{0} ", marks);

                if(marks > 35)
                {
                    Console.Write(" | (Pass) \n");
                } else
                {
                    Console.Write(" | (Fail) \n");
                    failCount++;
                }
            }

            percent = total / args.Length;

            if(percent >= 90 && percent <= 100)
            {
                grade = "A+";
            } else if(percent >= 80 && percent <= 89)
            {
                grade = "A";
            } else if(percent >= 70 && percent <= 79)
            {
                grade = "B+";
            } else if(percent >= 60 && percent <= 69)
            {
                grade = "B";
            } else if(percent >= 50 && percent <= 59)
            {
                grade = "C+";
            } else if(percent >= 40 && percent <= 49)
            {
                grade = "C";
            } else if(percent >= 35 && percent <= 39)
            {
                grade = "D";
            } else
            {
                grade = "F";
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nTotal Marks : {0} / {1}", total, args.Length * 100);
            Console.WriteLine("percentage of total marks : {0}%", percent);
            Console.WriteLine("Grade : {0}", grade);

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
                    goto student;
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
