//Q26. Write down a menu driven program using switch to convert various distance from one unit to other.

using System;

namespace Assignment_2
{
    internal class Q26_DistanceConversion
    {
        public static void DistanceConversion()
        {
            distance:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nQ26. Write down a menu driven program using switch to convert various distance from one unit to other.");
            char c;
            Console.WriteLine("\n1. Converting millimeter(mm) to centimeter(cm).");
            Console.WriteLine("2. Converting centimeter(cm) to meter(m).");
            Console.WriteLine("3. Converting meter(m) to kilometer(km).");
            Console.WriteLine("4. Converting centimeter(cm) to inches(in).");

            Console.Write("\nEnter your choice : ");
            c = char.Parse(Console.ReadLine());
            switch(c)
            {
                case '1':
                    MillimeterToCentimeter();
                    break;
                case '2':
                    CentimeterToMeter();
                    break;
                case '3':
                    MeterToKilometer();
                    break;
                case '4':
                    CentimeterToInches();
                    break;
                default:
                    Console.WriteLine("\nInvalid choice...");
                    Console.WriteLine("\nPress any key and try again...");
                    Console.ReadLine();
                    Console.Clear();
                    goto distance;
            }

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
                    goto distance;
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

        private static void MillimeterToCentimeter()
        {
            float value, result = 0;
            Console.WriteLine("\nConverting Millimeter to centimeter\n");
            Console.Write("Enter the length value : ");
            value = float.Parse(Console.ReadLine());
            result = value / 10;
            Console.WriteLine("\nMillimeter to centimeter");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0} mm = {1} cm", value, result);
        }

        private static void CentimeterToMeter()
        {
            float value, result = 0;

            Console.WriteLine("\nConverting centimeter to meter\n");
            Console.Write("Enter the length value : ");
            value = float.Parse(Console.ReadLine());
            result = value / 100;

            Console.WriteLine("\nCentimeter to Meter");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0} cm = {1} m", value, result);
        }

        private static void MeterToKilometer()
        {
            float value, result = 0;

            Console.WriteLine("\nConverting meter to kilometer\n");
            Console.Write("Enter the length value : ");
            value = float.Parse(Console.ReadLine());
            result = value / 1000;

            Console.WriteLine("\nMeter to Kilometer");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0} m = {1} km", value, result);
        }

        private static void CentimeterToInches()
        {
            float value, result = 0;

            Console.WriteLine("\nConverting Centimeter to Inches\n");
            Console.Write("Enter the length value : ");
            value = float.Parse(Console.ReadLine());
            result = value / 2.54f;

            Console.WriteLine("\nCentimeter to Inches");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0} cm = {1} in", value, result);
        }
    }
}
