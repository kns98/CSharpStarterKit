using CSharpLearn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn
{
    /*

     Decimal Number: 10

     Binary Representation: 1-0-1-0

     Explanation:
     10 in decimal is represented as 1-0-1-0 in binary. 
     Each digit in the binary representation represents a power of 2, starting from the rightmost digit. 

     In this example, the leftmost digit is 1, representing 2^3 (8).
     The second digit is 0, representing 2^2 (4). 
     The third digit is 1, representing 2^1 (2). 
     The rightmost digit is 0, representing 2^0 (1).

     -----------------------------------------------------------------------------------------

     十进制数：10

     二进制表示：1-0-1-0

     解释：
     十进制数10在二进制中表示为1-0-1-0。
     二进制表示中的每个数字表示2的幂，从最右边的数字开始。

     在这个例子中，最左边的数字是1，表示2的3次幂（8）。
     第二个数字是0，表示2的2次幂（4）。
     第三个数字是1，表示2的1次幂（2）。
     最右边的数字是0，表示2的0次幂（1）。

    */

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