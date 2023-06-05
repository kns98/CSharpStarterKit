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
            decToBinary(decimalNumber);
        }

        // function to convert decimal to binary
        static void decToBinary(int n)
        {
            // array to store binary number
            int[] binaryNum = new int[32];

            // counter for binary array
            int i = 0;
            while (n > 0)
            {

                // storing remainder in binary array
                binaryNum[i] = n % 2;
                n = n / 2;
                i++;
            }

            // printing binary array in reverse order
            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write(binaryNum[j]);
            }
            Console.WriteLine();
        }
    }
}