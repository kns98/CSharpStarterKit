using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn
{
    static class ConsoleHelper
    {
        public static int ReadInteger(string prompt)
        {
            int value;
            bool isValidInput = false;

            do
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                isValidInput = int.TryParse(input, out value);

                if (!isValidInput)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            } while (!isValidInput);

            return value;
        }
    }
}
