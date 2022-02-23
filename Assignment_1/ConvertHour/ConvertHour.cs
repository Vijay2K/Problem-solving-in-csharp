//Write a program to convert 24-hour time format to 12-hour time format with am or pm appropriate.

using System;

namespace ConvertHour
{
    internal class ConvertHour
    {
        static void Main(string[] args)
        {
            int hour;
            Console.Write("Enter the hour in 24hrs format : ");
            hour = int.Parse(Console.ReadLine());

            Console.Write("Time in 12hrs format : ");
            if(hour == 0)
            {
                hour = hour + 12;
                Console.WriteLine(hour + "am");
            }
            else if(hour >= 1 && hour <= 11)
            {
                Console.WriteLine(hour + "am");
            }
            else if(hour == 12)
            {
                Console.WriteLine(hour + "pm");
            }
            else if(hour >= 13 && hour <= 23)
            {
                hour = hour - 12;
                Console.WriteLine(hour + "pm");
            } else
            {
                Console.WriteLine("Invalid Hour...");
            }
        }
    }
}
