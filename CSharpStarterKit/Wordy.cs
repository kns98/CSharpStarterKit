using CSharpLearn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStarterKit
{
    using System;
    using System.Collections.Generic;

    public class WordyMod
    {

        static Dictionary<string, Func<int, int, int>> operators = new Dictionary<string, Func<int, int, int>>
        {
            { "plus", (a, b) => a + b },
            { "minus", (a, b) => a - b },
            { "times", (a, b) => a * b },
            { "multiplied", (a, b) => a * b },
            { "divided", (a, b) => a / b },
            { "加", (a, b) => a + b },
            { "减", (a, b) => a - b },
            { "乘以", (a, b) => a * b },
            { "除以", (a, b) => a / b }
        };

        public static void Wordy(Language languageChoice)
        {
            // Define sample inputs
            string[] sampleInputs = new string[]
            {
                "2 plus 3 multiplied 4 minus 5",
                "10 乘以 5 加 3",
                "8 divided 2 plus 6 minus 4"
            };

            // Display sample inputs
            Console.WriteLine("Sample Inputs:");
            foreach (string input in sampleInputs)
            {
                Console.WriteLine(input);
            }

            Console.WriteLine();

            // Get user input and process it
            Console.Write("Enter an input: ");
            string userInput = Console.ReadLine();
            ProcessInput(userInput);
        }

        static void ProcessInput(string input)
        {
            Queue<string> numberQueue = new Queue<string>();
            Queue<string> operatorQueue = new Queue<string>();
            Queue<string> otherQueue = new Queue<string>();

            CategorizeValues(input, numberQueue, operatorQueue, otherQueue);
            EvaluateValues(numberQueue, operatorQueue);

            Console.WriteLine("Number:");
            PrintQueueValues(numberQueue);

            Console.WriteLine("\nOperator:");
            PrintQueueValues(operatorQueue);

            Console.WriteLine("\nOther:");
            PrintQueueValues(otherQueue);
        }


        static void CategorizeValues(string input, Queue<string> numberQueue, Queue<string> operatorQueue, Queue<string> otherQueue)
        {
            string[] values = input.Split(' ');

            foreach (string value in values)
            {
                if (int.TryParse(value, out _))
                {
                    numberQueue.Enqueue(value);

                    if (numberQueue.Count == 2 && operatorQueue.Count > 0)
                    {
                        EvaluateValues(numberQueue, operatorQueue);
                    }
                }
                else if (operators.ContainsKey(value))
                {
                    operatorQueue.Enqueue(value);
                }
                else
                {
                    otherQueue.Enqueue(value);
                }
            }
        }

        static void EvaluateValues(Queue<string> numberQueue, Queue<string> operatorQueue)
        {
            if (numberQueue.Count >= 2 && operatorQueue.Count > 0)
            {
                int a = int.Parse(numberQueue.Dequeue());
                int b = int.Parse(numberQueue.Dequeue());
                string op = operatorQueue.Dequeue();

                if (operators.TryGetValue(op, out Func<int, int, int> operation))
                {
                    int result = operation(a, b);
                    numberQueue.Enqueue(result.ToString());
                }
            }
        }

        static void PrintQueueValues(Queue<string> queue)
        {
            foreach (string value in queue)
            {
                Console.WriteLine(value);
            }
        }
    }

}


