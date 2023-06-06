using CSharpLearn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStarterKit
{
    internal class HexadecimalMod
    {

        public static void Hexadecimal(Language languageChoice)
        {
            // English: Implementation for the Hexadecimal problem
            // Chinese: 十六进制问题的实现
            string[] languageStrings = languageChoice == Language.English ?
                new string[] { "Enter a decimal number: ", "The hexadecimal representation is: " } :
                new string[] { "输入一个十进制数: ", "十六进制表示为: " };

            Console.Write(languageStrings[0]);
            int decimalNumber = int.Parse(Console.ReadLine());

            int index = 0;

            char[] hexadecimal = new char[32];
            // Convert decimal to hexadecimal
            while (decimalNumber != 0)
            {
                int remainder = decimalNumber % 16;

                if (remainder < 10)
                {
                    hexadecimal[index] = (char)(remainder + '0');
                }
                else
                {
                    hexadecimal[index] = (char)(remainder - 10 + 'A');
                }

                decimalNumber /= 16;
                index++;
            }

            // Add null terminator to the end of the hexadecimal array
            hexadecimal[index] = '\0';

            Console.WriteLine(languageStrings[1] + string.Join("", hexadecimal.Reverse<char>()));
        }
    }
}
