//Write a program to check given character is vowel or consonant.

using System;

namespace VowelOrConsonant
{
    internal class VowelOrConsonant
    {
        static void Main(string[] args)
        {
            char ch;
            Console.Write("Enter the character : ");
            ch = char.Parse(Console.ReadLine());
            CheckVowelOrConsonant(ch);
        }

        private static void CheckVowelOrConsonant(char c)
        {
            bool isVowel = false;
            string vowels = "AEIOUaeiou";
            for(int i = 0; i < vowels.Length; i++)
            {
                if(c == vowels[i])
                {
                    isVowel = true;
                    break;
                }
            }

            if(isVowel)
            {
                Console.WriteLine("{0} is a vowel.", c);
            } else
            {
                Console.WriteLine("{0} is a consonant", c);
            }
        }
    }
}
