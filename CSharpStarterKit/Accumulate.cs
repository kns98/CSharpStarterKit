using CSharpLearn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStarterKit
{
    internal class AccumulateMod
    {
        public static void Accumulate(Language languageChoice)
        {
            // English: Implementation for the Accumulate problem
            // Chinese: 累积问题的实现
            string[] languageStrings = languageChoice == Language.English ?
                new string[] { "Enter a series of numbers (separated by spaces): " } :
                new string[] { "输入一系列数字（以空格分隔）: " };

            Console.Write(languageStrings[0]);
            string input = Console.ReadLine();
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

            int[] accumulated = new int[numbers.Length];
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                accumulated[i] = sum;
            }

            Console.WriteLine("Accumulated Result: " + string.Join(" ", accumulated));
        }
    }
}
