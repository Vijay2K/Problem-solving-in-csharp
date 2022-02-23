/*
    Write a program to input electricity unit charge and calculate the total electricity bill according to the given condition:
	For first 50 units Rs. 0.50/unit
	For next 100 units Rs. 0.75/unit
	For next 100 units Rs. 1.20/unit
	For unit above 250 Rs. 1.50/unit
	An additional surcharge of 20% is added to the bill.
 */

using System;

namespace ElectricityBill
{
    internal class ElectricityBill
    {
        static void Main(string[] args)
        {
            float unit;
            float total, val, surCharge;

            Console.Write("Enter the units : ");
            unit = float.Parse(Console.ReadLine());

            if(unit <= 50)
            {
                val = unit * 0.5f;
            } else if(unit <= 150)
            {
                val = 25 + ((unit - 50) * 0.75f);
            } else if(unit <= 250)
            {
                val = 100 + ((unit - 150) * 1.2f);
            } else
            {
                val = 220 + ((unit - 250) * 1.5f);
            }

            surCharge = val * 0.2f;
            total = val + surCharge;

            Console.WriteLine("Electricity bills : {0}", total);
        }
    }
}
