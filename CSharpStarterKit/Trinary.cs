using CSharpLearn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStarterKit
{
    internal class TrinaryMod
    {
        public static void Trinary(Language languageChoice)
        {
            // Define language-specific strings for user prompts and output
            string[] languageStrings = languageChoice == Language.English ?
                new string[] { "Enter a trinary number: ", "The decimal representation is: " } :
                new string[] { "输入一个三进制数: ", "十进制表示为: " };

            // Prompt the user to enter a trinary number
            Console.Write(languageStrings[0]);
            string trinaryNumber = Console.ReadLine();

            int decimalNumber = 0;
            int power = 0;

            // Convert the trinary number to decimal
            for (int i = trinaryNumber.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(trinaryNumber[i].ToString());

                // Check if the digit is valid (between 0 and 2)
                if (digit < 0 || digit > 2)
                {
                    Console.WriteLine("Invalid trinary number.");
                    return;
                }

                decimalNumber += digit * (int)Math.Pow(3, power);
                power++;
            }

            // Output the decimal representation of the trinary number
            Console.WriteLine(languageStrings[1] + decimalNumber);
        }

    }
}
