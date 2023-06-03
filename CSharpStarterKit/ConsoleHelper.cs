using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
  Console.ReadLine(): The Console.ReadLine() method is used to read input from the console. It reads the user's input for queen positions.
  int.Parse(): The int.Parse() method is used to convert the user's input from string to integer.
*
*/

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
