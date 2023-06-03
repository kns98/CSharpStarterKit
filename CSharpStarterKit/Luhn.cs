using CSharpLearn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  
 
The Luhn problem, also known as the Luhn algorithm or the modulus 10 algorithm, 
is a simple algorithm used to validate various identification numbers, such as credit card numbers, 
IMEI numbers, and social security numbers. The algorithm is named after its creator, Hans Peter Luhn.

The Luhn algorithm works by performing the following steps:

1. Starting from the rightmost digit (excluding any check digit), double the value of every second digit. 
If the doubled value exceeds 9, subtract 9 from it.
2. Sum up all the digits obtained in step 1, as well as the unaffected digits (i.e., the digits that were not doubled).
3. If the total sum is divisible by 10 (i.e., the modulo 10 is 0), then the number is valid according to the Luhn algorithm.

The Luhn algorithm is commonly used to quickly detect common errors in typing or transcription of identification numbers. 
It can identify most single-digit errors, as well as many common transpositions of adjacent digits.

Here's an example of how the Luhn algorithm works with a credit card number:

Let's take the credit card number 45320151128336.

1. Starting from the rightmost digit and moving left, double every second digit:
    6, 3, 8, 2, 2, 1, 5, 1, 1, 0, 3, 5, 4

    After doubling:
    6, 6, 8, 4, 2, 1, 10, 1, 2, 0, 6, 5, 8

    If any doubled digit is greater than 9, subtract 9:
    6, 6, 8, 4, 2, 1, 1, 1, 2, 0, 6, 5, 8

2. Sum up all the digits:
    6 + 6 + 8 + 4 + 2 + 1 + 1 + 1 + 2 + 0 + 6 + 5 + 8 = 50

3. Check if the total sum is divisible by 10:
    50 % 10 = 0

Since the modulo 10 of the total sum is 0, the credit card number 45320151128336 passes the Luhn algorithm validation.

The Luhn algorithm is not a foolproof method for verifying the validity of identification numbers, 
as it cannot detect all types of errors. However, it provides a quick and simple check that helps catch many common errors.

*/

namespace CSharpLearn
{
    class LuhnMod
    {
        public static void Luhn(Language language)
        {
            // English: Implementation for the Luhn problem
            // Chinese: Luhn算法问题的实现

            // Define language-specific strings for prompts and messages
            string[] languageStrings = language == Language.English ?
                new string[] { "Enter a credit card number: ", "The credit card number is valid.", "The credit card number is invalid." } :
                new string[] { "输入一个信用卡号码: ", "信用卡号码有效.", "信用卡号码无效." };


            Console.WriteLine("Widely used test credit card numbers:");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Visa:");
            Console.WriteLine("Card Number: 4111 1111 1111 1111");
            Console.WriteLine("CVV: 123");
            Console.WriteLine("Expiration Date: Any future date");
            Console.WriteLine();
            Console.WriteLine("Mastercard:");
            Console.WriteLine("Card Number: 5555 5555 5555 4444");
            Console.WriteLine("CVV: 123");
            Console.WriteLine("Expiration Date: Any future date");
            Console.WriteLine();
            Console.WriteLine("American Express:");
            Console.WriteLine("Card Number: 3782 822463 10005");
            Console.WriteLine("CVV: 1234");
            Console.WriteLine("Expiration Date: Any future date");
            Console.WriteLine();
            Console.WriteLine("Discover:");
            Console.WriteLine("Card Number: 6011 1111 1111 1117");
            Console.WriteLine("CVV: 123");
            Console.WriteLine("Expiration Date: Any future date");
            Console.WriteLine();
            Console.WriteLine("JCB:");
            Console.WriteLine("Card Number: 3530 1113 3330 0000");
            Console.WriteLine("CVV: 123");
            Console.WriteLine("Expiration Date: Any future date");


            // Prompt the user to enter a credit card number
            Console.Write(languageStrings[0]);
            string creditCardNumber = Console.ReadLine();

            // Extract the digits from the credit card number
            int[] digits = creditCardNumber.Where(char.IsDigit).Select(c => int.Parse(c.ToString())).ToArray();
            int sum = 0;
            bool doubleDigit = false;

            // Iterate over the digits in reverse order and calculate the sum
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                int digit = digits[i];

                // Double every other digit starting from the rightmost digit
                if (doubleDigit)
                {
                    digit *= 2;

                    // If the doubled digit is greater than 9, subtract 9
                    if (digit > 9)
                    {
                        digit -= 9;
                    }
                }

                // Add the digit (original or doubled) to the sum
                sum += digit;

                // Toggle the flag to indicate whether the next digit should be doubled or not
                doubleDigit = !doubleDigit;
            }

            // Check if the sum is divisible by 10 to determine the validity of the credit card number
            if (sum % 10 == 0)
            {
                // Display the validation message for a valid credit card number
                Console.WriteLine(languageStrings[1]);
            }
            else
            {
                // Display the validation message for an invalid credit card number
                Console.WriteLine(languageStrings[2]);
            }
        }
    }

}
