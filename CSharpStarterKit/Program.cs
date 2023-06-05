/*

NB: Mei to write Chinese version

/*
   Notes:

1. Class: In C#, a class is a blueprint for creating objects that encapsulate data and functionality. 
   The `Program` class is defined to encapsulate the program's functionality. It serves as the entry point 
   for the program and contains the `Main` method.

2. Method: A method is a block of code that performs a specific task. The `Main` method is the entry 
   point of the program. It is where the execution starts when the program is run. The `Main` method is 
   declared with the `static` keyword, allowing it to be called without creating an instance of the `Program` class.

3. Console Input/Output: The `Console` class provides methods for reading input from the console (`Console.ReadLine`) 
   and displaying output on the console (`Console.WriteLine`). In the given code, `Console.WriteLine` 
   is used to display messages to the user, and `Console.ReadLine` is used to read input from the user.

4. Conditional Statements: Conditional statements allow the program to make decisions based on certain conditions. 
   The `if-else` statement is used in the `QueenAttack` method to check if two queens can attack each other based on 
   their positions. It evaluates a condition and executes different code blocks depending on whether the condition is 
   true or false.

5. Looping: Loops are used to repeatedly execute a block of code until a specific condition is met. The `for` loop 
   is used in the `BeerSong` method to iterate over a range of numbers and print the lyrics of the beer song. 
   It consists of an initialization, a condition, an iterator, and a loop body.

6. Arrays: Arrays are used to store a fixed-size sequence of elements of the same type. The `board` array is defined
   as a two-dimensional array in the `QueenAttack` method. It represents the chessboard and stores the positions of 
   queens. It allows easy access and manipulation of elements using indices.

7. String Manipulation: C# provides various string manipulation methods to perform operations like concatenation, 
   sorting, reversing, and checking equality. In the given code, string manipulation is used to concatenate strings 
   (`+` operator), check equality (`==` operator), get the length of a string (`string.Length`), and convert strings to 
   integers (`int.Parse`).

8. Variable Declaration/Assignment: Variables are declared using a specific type and can hold values of that type. 
   They can be assigned values using the assignment operator (`=`). Throughout the code, variables like 
   `languageChoice`, `queen1Row`, `queen1Col`, etc., are declared and assigned values.

9. Integer Operations: Integer operations are performed using arithmetic operators such as addition (`+`), 
   subtraction (`-`), multiplication (`*`), and modulo (`%`). These operations manipulate integer values and produce 
   results of type `int`.

10. User-defined Methods: User-defined methods are custom-defined blocks of code that encapsulate a specific 
    functionality or task. In the given code, methods like `QueenAttack`, `Anagram`, `BeerSong`, etc., are 
   defined to solve specific problems. They help organize the code and promote reusability.

11. Object-Oriented Programming: Object-oriented programming (OOP) is a programming paradigm that organizes 
    code into objects that contain both data and methods. The code in C# is organized using classes, which are 
    fundamental to OOP. Classes enable encapsulation, inheritance, and polymorphism.

12. Collections: C# provides various collection classes to store and manipulate groups of related objects. 
   The code uses a `Dictionary<char, int>` in the `NucleotideCount` method to store and count nucleotides. 
   The `Dictionary` class allows mapping keys to values, making it efficient to access and manipulate elements.

13. Namespace: Namespaces are used to organize and group related classes and types. They help prevent naming conflicts 
    and provide better code organization. The given code includes various namespaces like `System`, 
    `System.Collections.Generic`, `System.Linq`, and `System.Text`, which provide access to different types and functionalities.

14. Type Conversion: Type conversion is used to convert values from one type to another. In the given code, 
    type conversion is performed using methods like `int.Parse` to convert strings to integers and `ToString` 
    to convert integers to strings. These methods allow working with different data types.

15. Mathematical Operations: The `Math` class in C# provides various mathematical operations and functions. 
    In the given code, the `Math.Abs` method is used to find the absolute value of a number. Additionally, 
    the `string.Length` property is used to calculate the length of a string, which can be considered a mathematical 
    operation on the string's data.

16. Exception Handling: Exception handling is used to catch and handle runtime errors or exceptional conditions 
    that may occur during program execution. The `try-catch` block is used in the given code to catch potential 
    exceptions and handle errors gracefully. It allows the program to recover from errors and continue executing.

17. Inheritance: Inheritance is a mechanism in object-oriented programming that allows creating new classes 
    based on existing classes. In the given code, all classes implicitly inherit from the `Object` class, 
    which is the base class for all classes in C#. Inheritance enables code reuse and the creation of class hierarchies.

18. Polymorphism: Polymorphism allows objects of different types to be treated as objects of a common base type. 
    In the given code, polymorphism is achieved through method overriding. The `ToString` method is overridden to 
    provide a custom string representation of an object. Polymorphism enables code flexibility and extensibility.

19. Encapsulation: Encapsulation is the bundling of data and methods together within a class. It allows hiding 
    internal implementation details and providing a clean interface for interacting with the class. The given 
    code demonstrates encapsulation by encapsulating the program's functionality within the `Program` class and 
    using access modifiers like `public` and `private`.

20. Static Members: Static members belong to the class itself rather than instances of the class. 
    The `Main` method in the given code is declared as static. It can be invoked without creating an instance of the `Program` class. Static members are shared among all instances of the class.


*/



using CSharpStarterKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpLearn
{

    public class Program
    {
        static Language languageChoice = Language.English;
        
        public static void Main(string[] args)
        {
            bool continuePlaying = true;
            Console.WriteLine("Choose a language:");
            Console.WriteLine("1. English");
            Console.WriteLine("2. Chinese");

            Language languageChoice = (Language)int.Parse(Console.ReadLine());

            while (continuePlaying)
            {
                Console.WriteLine("Choose a game:");
                Console.WriteLine("1. Accumulate");
                Console.WriteLine("2. Anagram");
                Console.WriteLine("3. Atbash Cipher");
                Console.WriteLine("4. Beer Song");
                Console.WriteLine("5. Binary");
                Console.WriteLine("6. Binary Search Tree");
                Console.WriteLine("7. Bob");
                Console.WriteLine("8. Clock");
                Console.WriteLine("9. Hexadecimal");
                Console.WriteLine("10. Linked List");
                Console.WriteLine("11. Luhn");
                Console.WriteLine("12. Nth Prime");
                Console.WriteLine("13. Nucleotide Count");
                Console.WriteLine("14. Palindrome Products");
                Console.WriteLine("15. Pascal's Triangle");
                Console.WriteLine("16. Queen Attack");
                Console.WriteLine("17. Trinary");
                Console.WriteLine("18. Triangle");
                Console.WriteLine("19. Word Count");
                Console.WriteLine("20. Wordy");

                int gameChoice = int.Parse(Console.ReadLine());
                ChooseGame(gameChoice, languageChoice);

                Console.WriteLine("Do you want to continue playing? (y/n)");
                string continueChoice = Console.ReadLine();

                continuePlaying = (continueChoice.ToLower() == "y");
            }
        }

        private static void ChooseGame(int gameChoice, Language languageChoice)
        {
            switch (gameChoice)
            {
                case 1:
                    Console.WriteLine("Accumulate");
                    Console.WriteLine("What is Accumulate?");
                    Console.WriteLine("Description: Performs a specified operation (sum, product, etc.) on a given list of numbers and returns the result.");
                    Console.WriteLine("Input: A list of numbers and the operation to be performed.");
                    Console.WriteLine("Output: Returns the accumulated result of the operation on the input numbers.");
                    Accumulate();
                    break;
                case 2:
                    Console.WriteLine("Anagram");
                    Console.WriteLine("What is Anagram?");
                    Console.WriteLine("Description: Checks if two input strings are anagrams (contain the same characters in a different order).");
                    Console.WriteLine("Input: Two strings.");
                    Console.WriteLine("Output: Returns a boolean value indicating whether the input strings are anagrams or not.");
                    AnagramMod.Anagram(languageChoice);
                    break;
                case 3:
                    Console.WriteLine("Atbash Cipher");
                    Console.WriteLine("What is Atbash Cipher?");
                    Console.WriteLine("Description: Implements the Atbash cipher, a simple substitution cipher.");
                    Console.WriteLine("Usage: The AtbashCipher class provides methods to encrypt and decrypt text using the Atbash cipher algorithm.");
                    new AtbashCipher().Go(languageChoice);
                    break;
                case 4:
                    Console.WriteLine("Beer Song");
                    Console.WriteLine("What is Beer Song?");
                    Console.WriteLine("Description: Generates the lyrics of the classic '99 Bottles of Beer' song.");
                    Console.WriteLine("Input: The number of bottles to start with.");
                    Console.WriteLine("Output: Returns the lyrics of the song.");
                    BeerSongMod.BeerSong(languageChoice);
                    break;
                case 5:
                    Console.WriteLine("Binary");
                    Console.WriteLine("What is Binary?");
                    Console.WriteLine("Description: Converts a decimal number into its binary representation.");
                    Console.WriteLine("Input: A decimal number.");
                    Console.WriteLine("Output: Returns a string representing the binary equivalent of the input number.");
                    BinaryMod.Binary(languageChoice);
                    break;
                case 6:
                    Console.WriteLine("Binary Search Tree");
                    Console.WriteLine("What is Binary Search Tree?");
                    Console.WriteLine("Description: Represents a binary search tree, a hierarchical data structure.");
                    Console.WriteLine("Usage: The BinarySearchTree class offers methods to insert, delete, and search for elements within the tree.");
                    BinarySearchTree(languageChoice);
                    break;
                case 7:
                    Console.WriteLine("Bob");
                    Console.WriteLine("What is Bob?");
                    Console.WriteLine("Description: A conversational chatbot that responds to user input.");
                    Console.WriteLine("Usage: The Bob class utilizes natural language processing techniques to understand and interact with users.");
                    BobRobot.Bob(languageChoice);
                    break;
                case 8:
                    Console.WriteLine("Clock");
                    Console.WriteLine("What is Clock?");
                    Console.WriteLine("Description: Represents a digital clock that can be used to track time.");
                    Console.WriteLine("Usage: The Clock class provides functionalities to set the time.");
                    Clock();
                    break;
                case 9:
                    Console.WriteLine("Hexadecimal");
                    Console.WriteLine("What is Hexadecimal?");
                    Console.WriteLine("Description: Utility class for converting between decimal and hexadecimal representations of numbers.");
                    Console.WriteLine("Usage: Provides methods to convert decimal numbers to hexadecimal format and vice versa.");
                    Hexadecimal();
                    break;
                case 10:
                    Console.WriteLine("Linked List");
                    Console.WriteLine("What is Linked List?");
                    Console.WriteLine("Description: Represents a linear data structure where elements are stored in a sequence and linked using pointers.");
                    Console.WriteLine("Usage: The LinkedList class provides methods to insert, delete, and retrieve elements within the list.");
                    LinkedList();
                    break;
                case 11:
                    Console.WriteLine("Luhn");
                    Console.WriteLine("What is Luhn?");
                    Console.WriteLine("Description: Implements the Luhn algorithm for validating identification numbers.");
                    Console.WriteLine("Input: An identification number as a string.");
                    Console.WriteLine("Output: Returns a boolean value indicating whether the input number is valid according to the Luhn algorithm.");
                    LuhnMod.Luhn(languageChoice);
                    break;
                case 12:
                    Console.WriteLine("Nth Prime");
                    Console.WriteLine("What is Nth Prime?");
                    Console.WriteLine("Description: Mathematical utility class that computes the nth prime number.");
                    Console.WriteLine("Usage: Provides methods to calculate and retrieve the prime number at a specific index.");
                    NthPrime();
                    break;
                case 13:
                    Console.WriteLine("Nucleotide Count");
                    Console.WriteLine("What is Nucleotide Count?");
                    Console.WriteLine("Description: Counts the occurrences of nucleotides (A, C, G, T) in a DNA strand.");
                    Console.WriteLine("Input: A DNA strand as a string.");
                    Console.WriteLine("Output: Returns a dictionary or an associative array with the counts of each nucleotide.");
                    NucleotideCountMod.NucleotideCount(languageChoice);
                    break;
                case 14:
                    Console.WriteLine("Palindrome Products");
                    Console.WriteLine("What is Palindrome Products?");
                    Console.WriteLine("Description: Finds the largest and smallest palindrome numbers that can be obtained as the product of two numbers within a given range.");
                    Console.WriteLine("Input: A range of numbers.");
                    Console.WriteLine("Output: Returns the largest and smallest palindrome numbers, along with the factors that produce them.");
                    PalindromeProducts();
                    break;
                case 15:
                    Console.WriteLine("Pascal's Triangle");
                    Console.WriteLine("What is Pascal's Triangle?");
                    Console.WriteLine("Description: Generates Pascal's Triangle up to a given number of rows.");
                    Console.WriteLine("Pascal's Triangle is a triangular array of numbers named after the French mathematician Blaise Pascal. Each number in the triangle is the sum of the two numbers directly above it.");
                    Console.WriteLine("Input: The number of rows for the triangle.");
                    Console.WriteLine("Output: Returns a two-dimensional array representing Pascal's Triangle.");
                    PascalsTriangle();
                    break;
                case 16:
                    Console.WriteLine("Queen Attack");
                    Console.WriteLine("What is Queen Attack?");
                    Console.WriteLine("Description: Determines whether two queens on a chessboard can attack each other based on their positions.");
                    Console.WriteLine("Input: The positions of the two queens.");
                    Console.WriteLine("Output: Returns a message indicating whether the queens can attack each other or not.");
                    QueenAttackMod.QueenAttack(languageChoice);
                    break;
                case 17:
                    Console.WriteLine("Trinary");
                    Console.WriteLine("What is Trinary?");
                    Console.WriteLine("Description: Utility class for working with numbers represented in the trinary numeral system (base-3).");
                    Console.WriteLine("Usage: Provides functionalities to convert trinary numbers to decimal and vice versa, and perform operations on trinary numbers.");
                    Trinary();
                    break;
                case 18:
                    Console.WriteLine("Triangle");
                    Console.WriteLine("What is Triangle?");
                    Console.WriteLine("Description: Determines the type of triangle (equilateral, isosceles, scalene) based on the lengths of its sides.");
                    Console.WriteLine("Input: The lengths of the triangle's three sides.");
                    Console.WriteLine("Output: Returns a string indicating the type of triangle.");
                    Triangle();
                    break;
                case 19:
                    Console.WriteLine("Word Count");
                    Console.WriteLine("What is Word Count?");
                    Console.WriteLine("Description: Utility class for counting the occurrences of words in a given text or document.");
                    Console.WriteLine("Usage: Provides methods to process the input text, tokenize it into individual words, and generate a count of each word encountered.");
                    WordCount();
                    break;
                case 20:
                    Console.WriteLine("Wordy");
                    Console.WriteLine("What is Wordy?");
                    Console.WriteLine("Description: Linguistic tool for analyzing and processing natural language sentences.");
                    Console.WriteLine("Usage: Provides methods to parse sentences, identify parts of speech, extract meaningful information, and perform linguistic operations.");
                    WordyMod.Wordy(languageChoice);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        private static void BinarySearchTree(Language languageChoice)
        {
            CSharpLearn.BinarySearchTree<object>.BCS(languageChoice);
        }

        public static void PalindromeProducts()
        {
            // English: Implementation for the Palindrome Products problem
            // Chinese: 回文乘积问题的实现
            string[] languageStrings = languageChoice == Language.English ?
                new string[] { "Enter the minimum value: ", "Enter the maximum value: ", "No palindrome products found.", "The largest palindrome product is: " } :
                new string[] { "输入最小值: ", "输入最大值: ", "未找到回文乘积.", "最大回文乘积是: " };

            Console.Write(languageStrings[0]);
            int min = int.Parse(Console.ReadLine());
            Console.Write(languageStrings[1]);
            int max = int.Parse(Console.ReadLine());

            int largestPalindrome = 0;
            List<Tuple<int, int>> largestPalindromeFactors = new List<Tuple<int, int>>();

            for (int i = min; i <= max; i++)
            {
                for (int j = i; j <= max; j++)
                {
                    int product = i * j;
                    string productString = product.ToString();

                    if (productString == new string(productString.Reverse().ToArray()) && product > largestPalindrome)
                    {
                        largestPalindrome = product;
                        largestPalindromeFactors.Clear();
                        largestPalindromeFactors.Add(new Tuple<int, int>(i, j));
                    }
                    else if (product == largestPalindrome)
                    {
                        largestPalindromeFactors.Add(new Tuple<int, int>(i, j));
                    }
                }
            }

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

        public static void PascalsTriangle()
        {
            // English: Implementation for the Pascal's Triangle problem
            // Chinese: 帕斯卡三角形问题的实现
            string[] languageStrings = languageChoice == Language.English ?
                new string[] { "Enter the number of rows: " } :
                new string[] { "输入行数: " };

            Console.Write(languageStrings[0]);
            int numRows = int.Parse(Console.ReadLine());

            List<List<int>> triangle = new List<List<int>>();

            for (int i = 0; i < numRows; i++)
            {
                List<int> row = new List<int>();

                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        row.Add(1);
                    }
                    else
                    {
                        int left = triangle[i - 1][j - 1];
                        int right = triangle[i - 1][j];
                        row.Add(left + right);
                    }
                }

                triangle.Add(row);
            }

            foreach (List<int> row in triangle)
            {
                string rowString = string.Join(" ", row);
                Console.WriteLine(rowString);
            }
        }

        public static void Triangle()
        {
            // English: Implementation for the Triangle problem
            // Chinese: 三角形问题的实现
            string[] languageStrings = languageChoice == Language.English ?
                new string[] { "Enter the number of rows: " } :
                new string[] { "输入行数: " };

            Console.Write(languageStrings[0]);
            int numRows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numRows; i++)
            {
                string row = new string('*', i);
                Console.WriteLine(row);
            }
        }

        public static void Accumulate()
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

        public static void Clock()
        {
            // English: Implementation for the Clock problem
            // Chinese: 时钟问题的实现
            string[] languageStrings = languageChoice == Language.English ?
                new string[] { "Enter the hours: ", "Enter the minutes: ", "Invalid time." } :
                new string[] { "输入小时: ", "输入分钟: ", "无效的时间." };

            Console.Write(languageStrings[0]);
            int hours = int.Parse(Console.ReadLine());
            Console.Write(languageStrings[1]);
            int minutes = int.Parse(Console.ReadLine());

            if (hours < 0 || hours >= 24 || minutes < 0 || minutes >= 60)
            {
                Console.WriteLine(languageStrings[2]);
            }
            else
            {
                int totalMinutes = hours * 60 + minutes;

                int newHours = (totalMinutes / 60) % 24;
                int newMinutes = totalMinutes % 60;

                Console.WriteLine($"The time is: {newHours.ToString("D2")}:{newMinutes.ToString("D2")}");
            }
        }

        public static void Hexadecimal()
        {
            // English: Implementation for the Hexadecimal problem
            // Chinese: 十六进制问题的实现
            string[] languageStrings = languageChoice == Language.English ?
                new string[] { "Enter a decimal number: ", "The hexadecimal representation is: " } :
                new string[] { "输入一个十进制数: ", "十六进制表示为: " };

            Console.Write(languageStrings[0]);
            int decimalNumber = int.Parse(Console.ReadLine());

            string hexadecimalString = decimalNumber.ToString("X");
            Console.WriteLine(languageStrings[1] + hexadecimalString);
        }

        public static void LinkedList()
        {
            // English: Implementation for the Linked List problem
            // Chinese: 链表问题的实现
            string[] languageStrings = languageChoice == Language.English ?
                new string[] { "Enter the elements of the linked list (separated by spaces): ", "The linked list: ", "The reversed linked list: " } :
                new string[] { "输入链表元素（以空格分隔）: ", "链表: ", "反转后的链表: " };

            Console.Write(languageStrings[0]);
            string input = Console.ReadLine();
            int[] elements = input.Split(' ').Select(int.Parse).ToArray();

            LinkedList<int> linkedList = new LinkedList<int>(elements);

            Console.Write(languageStrings[1]);
            foreach (int element in linkedList)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            linkedList.Reverse();

            Console.Write(languageStrings[2]);
            foreach (int element in linkedList)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        public static void Trinary()
        {
            // English: Implementation for the Trinary problem
            // Chinese: 三进制问题的实现
            string[] languageStrings = languageChoice == Language.English ?
                new string[] { "Enter a trinary number: ", "The decimal representation is: " } :
                new string[] { "输入一个三进制数: ", "十进制表示为: " };

            Console.Write(languageStrings[0]);
            string trinaryNumber = Console.ReadLine();

            int decimalNumber = 0;
            int power = 0;

            for (int i = trinaryNumber.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(trinaryNumber[i].ToString());

                if (digit < 0 || digit > 2)
                {
                    Console.WriteLine("Invalid trinary number.");
                    return;
                }

                decimalNumber += digit * (int)Math.Pow(3, power);
                power++;
            }

            Console.WriteLine(languageStrings[1] + decimalNumber);
        }

        public static void WordCount()
        {
            // English: Implementation for the Word Count problem
            // Chinese: 单词计数问题的实现
            string[] languageStrings = languageChoice == Language.English ?
                new string[] { "Enter a sentence: ", "The word count is: " } :
                new string[] { "输入一个句子: ", "单词数量为: " };

            Console.Write(languageStrings[0]);
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;

            Console.WriteLine(languageStrings[1] + wordCount);
        }

        public static void NthPrime()
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

      

      

        public static void AtbashCipher()
        {
            // English: Implementation for the Atbash Cipher problem
            // Chinese: Atbash密码问题的实现
            string[] languageStrings = languageChoice == Language.English ?
                new string[] { "Enter a message: ", "The encoded message is: " } :
                new string[] { "输入一条消息: ", "编码后的消息为: " };

            Console.Write(languageStrings[0]);
            string message = Console.ReadLine().ToLower();

            StringBuilder encodedMessage = new StringBuilder();

            foreach (char c in message)
            {
                if (char.IsLetter(c))
                {
                    char encodedChar = (char)('a' + ('z' - c));
                    encodedMessage.Append(encodedChar);
                }
                else
                {
                    encodedMessage.Append(c);
                }
            }

            Console.WriteLine(languageStrings[1] + encodedMessage);
        }




    }

  
}