//Write a program to enter student marks and calculate percentage and grade.

//Update
using System;

namespace StudentGrade
{
    internal class StudentGrade
    {
        static void Main(string[] args)
        {
            string studentName = "", grade = "";
            int n, sum = 0, percent = 0;
            Console.Write("Enter the student name : ");
            studentName = Console.ReadLine();
            Console.Write("Enter the subjects : ");
            n = int.Parse(Console.ReadLine());

            int[] subs = new int[n];
            Console.WriteLine("Enter all the subject marks : ");
            for(int i = 0; i < n; i++)
            {
                Console.Write("Subject {0} mark : ", i + 1);
                subs[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < n; i++)
            {
                sum += subs[i];
            }

            percent = sum / n;
            if (percent >= 50 && percent < 60)
            {
                grade = "C";
            } else if(percent >= 60 && percent < 70)
            {
                grade = "B+";
            } else if(percent >= 70 && percent < 90)
            {
                grade = "A";
            } else if(percent >= 90 && percent <= 100)
            {
                grade = "A+";
            } else if(percent < 50)
            {
                grade = "E";
            } 

            Console.WriteLine("\nStudent name : " + studentName);
            Console.WriteLine("Total marks out of {0} : {1}", n * 100, sum);
            Console.WriteLine("Percentage : {0}%", percent);
            Console.WriteLine("Grade : " + grade);
        }
    }
}
