using CSharpLearn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn
{
    internal class BinaryMod
    {
        public static void Binary(Language languageChoice)
        {
            // English: Implementation for the Binary problem
            // Chinese: 二进制问题的实现
            string[] languageStrings = languageChoice == Language.English ?
                new string[] { "Enter a decimal number: ", "The binary representation is: " } :
                new string[] { "输入一个十进制数: ", "二进制表示为: " };

            Console.Write(languageStrings[0]);
            int decimalNumber = int.Parse(Console.ReadLine());

            string binaryString = Convert.ToString(decimalNumber, 2);
            Console.WriteLine(languageStrings[1] + binaryString);
        }
    }
}
