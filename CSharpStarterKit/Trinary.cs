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
            // English: Implementation for the Trinary problem
            // Chinese: 三进制问题的实现
            string[] languageStrings = languageChoice == Language.English ?
                new string[] { "Enter a trinary number: ", "The decimal representation is: " } :
                new string[] { "输入一个三进制数: ", "十进制表示为: " };

            Console.Write(languageStrings[0]);
            string trinaryNumber = Console.ReadLine();

            int decimalNumber = 0;
            int power = 0;

            for (int i = trinaryNumber.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(trinaryNumber[i].ToString());

                if (digit < 0 || digit > 2)
                {
                    Console.WriteLine("Invalid trinary number.");
                    return;
                }

                decimalNumber += digit * (int)Math.Pow(3, power);
                power++;
            }

            Console.WriteLine(languageStrings[1] + decimalNumber);
        }
    }
}
