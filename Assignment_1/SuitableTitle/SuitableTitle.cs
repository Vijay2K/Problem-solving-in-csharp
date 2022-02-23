//Write a program to assign suitable title (Miss, Mrs, Mr) to person. Take input one’s gender and material status if required
//Update
using System;

namespace SuitableTitle
{
    internal class SuitableTitle
    {
        static void Main(string[] args)
        {
            string name, gender = "";
            byte _gender;
            char materialStatus;
            bool isMarried = false;

            Console.Write("Enter the name : ");
            name = Console.ReadLine();
            Console.Write("Enter the gender (1. male / 2. female / 3. transgender) : ");
            _gender = byte.Parse(Console.ReadLine());
            
            Console.Write("Enter the material status (y / n) : ");
            materialStatus = char.Parse(Console.ReadLine());

            switch (_gender)
            {
                case 1:
                    gender = "male";
                    break;
                case 2:
                    gender = "female";
                    break;
                case 3:
                    gender = "transgender";
                    break;
                default:
                    Console.WriteLine("Gender Invalid Input...");
                    break;
            }

            if (materialStatus == 'y')
            {
                isMarried = true;
            } else if(materialStatus == 'n')
            {
                isMarried = false;
            } else
            {
                Console.WriteLine("material status Invalid input...");
            }

            Console.WriteLine("Suitable Title");
            if(gender == "male" && isMarried || gender == "male" && !isMarried)
            {
                Console.WriteLine("Mr. " + name);
            } else if(isMarried && gender == "female" || gender == "transgender")
            {
                Console.WriteLine("Mrs. " + name);
            } else if(!isMarried && gender == "female" || gender == "transgender")
            {
                Console.WriteLine("Miss. " + name);
            } else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
