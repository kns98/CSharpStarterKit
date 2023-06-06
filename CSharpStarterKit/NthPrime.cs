using CSharpLearn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStarterKit
{
    internal class NthPrimeMod
    {
        public static void NthPrime(Language languageChoice)
        {
            // English: Implementation for the Nth Prime problem
            // Chinese: 第N个质数问题的实现
            string[] languageStrings = languageChoice == Language.English ?
                new string[] { "Enter the value of N: ", "The Nth prime number is: " } :
                new string[] { "输入N的值: ", "第N个质数为: " };

            Console.Write(languageStrings[0]);
            int n = int.Parse(Console.ReadLine());

            int count = 0;
            int number = 2;

            while (count < n)
            {
                if (IsPrime(number))
                {
                    count++;
                }

                number++;
            }

            Console.WriteLine(languageStrings[1] + (number - 1));
        }

        private static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
