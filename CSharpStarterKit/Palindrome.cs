using CSharpLearn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStarterKit
{
    internal class PalindromeMod
    {
        public static bool IsPalindrome(string input)
        {
            return input == new string(input.Reverse().ToArray());
        }

        public static void PalindromeProducts(Language languageChoice)
        {
            // English: Implementation for the Palindrome Products problem
            // Chinese: 回文乘积问题的实现

            // Define language-specific strings based on the selected language
            string[] languageStrings = languageChoice == Language.English ?
                new string[] { "Enter the minimum value: ", "Enter the maximum value: ", "No palindrome products found.", "The largest palindrome product is: " } :
                new string[] { "输入最小值: ", "输入最大值: ", "未找到回文乘积.", "最大回文乘积是: " };

            Console.Write(languageStrings[0]);
            int min = int.Parse(Console.ReadLine());
            Console.Write(languageStrings[1]);
            int max = int.Parse(Console.ReadLine());

            int largestPalindrome = 0;
            List<Tuple<int, int>> largestPalindromeFactors = new List<Tuple<int, int>>();

            // Iterate through all numbers between min and max (inclusive)
            for (int i = min; i <= max; i++)
            {
                for (int j = i; j <= max; j++)
                {
                    // Calculate the product of two numbers
                    int product = i * j;
                    string productString = product.ToString();

                    // Check if the product is a palindrome
                    if (IsPalindrome(productString) && product > largestPalindrome)
                    {
                        // Update the largest palindrome product found so far
                        largestPalindrome = product;
                        largestPalindromeFactors.Clear();
                        largestPalindromeFactors.Add(new Tuple<int, int>(i, j));
                    }
                    else if (product == largestPalindrome)
                    {
                        // Add the current factors to the list of factors for the largest palindrome product
                        largestPalindromeFactors.Add(new Tuple<int, int>(i, j));
                    }
                }
            }

            // Print the result
            if (largestPalindromeFactors.Count == 0)
            {
                Console.WriteLine(languageStrings[2]);
            }
            else
            {
                Console.WriteLine(languageStrings[3] + largestPalindrome);
                foreach (var factors in largestPalindromeFactors)
                {
                    Console.WriteLine($"{factors.Item1} x {factors.Item2}");
                }
            }
        }

    }
}
