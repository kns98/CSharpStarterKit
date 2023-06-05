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
            string inputPrompt = languageChoice == Language.English ? "Enter a decimal number: " : "输入一个十进制数: ";
            string outputMessage = languageChoice == Language.English ? "The binary representation is: " : "二进制表示为: ";

            int decimalNumber = ConsoleHelper.ReadInteger(inputPrompt);

            string binaryString = Convert.ToString(decimalNumber, 2);
            Console.WriteLine(outputMessage + binaryString);
        }


    }
}