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
                if (languageChoice == Language.English)
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
                }
                else
                {
                    Console.WriteLine("选择一个游戏：");
                    Console.WriteLine("1. 累加");
                    Console.WriteLine("2. 字母重排");
                    Console.WriteLine("3. Atbash 密码");
                    Console.WriteLine("4. 啤酒歌");
                    Console.WriteLine("5. 二进制");
                    Console.WriteLine("6. 二叉搜索树");
                    Console.WriteLine("7. 鲍勃");
                    Console.WriteLine("8. 时钟");
                    Console.WriteLine("9. 十六进制");
                    Console.WriteLine("10. 链表");
                    Console.WriteLine("11. Luhn 算法");
                    Console.WriteLine("12. 第 N 个素数");
                    Console.WriteLine("13. 核苷酸计数");
                    Console.WriteLine("14. 回文乘积");
                    Console.WriteLine("15. 帕斯卡三角形");
                    Console.WriteLine("16. 皇后攻击");
                    Console.WriteLine("17. 三进制");
                    Console.WriteLine("18. 三角形");
                    Console.WriteLine("19. 单词计数");
                    Console.WriteLine("20. Wordy 游戏");
                }

                int gameChoice = int.Parse(Console.ReadLine());

                if (languageChoice == Language.Chinese)
                {
                    ChooseGameCn(gameChoice, languageChoice);
                }


                if (languageChoice == Language.English)
                {
                    ChooseGameEng(gameChoice, languageChoice);
                }

                Console.WriteLine("Do you want to continue playing? (y/n)");
                string continueChoice = Console.ReadLine();

                continuePlaying = (continueChoice.ToLower() == "y");
            }
        }

        private static void ChooseGameCn(int gameChoice, Language languageChoice)
        {
            switch (gameChoice)
            {
                case 1:
                    Console.WriteLine("累加");
                    Console.WriteLine("什么是累加？");
                    Console.WriteLine("描述：对给定的数字列表执行指定的操作（求和、乘积等），并返回结果。");
                    Console.WriteLine("输入：数字列表和要执行的操作。");
                    Console.WriteLine("输出：返回对输入数字进行操作的累积结果。");
                    Accumulate();
                    break;
                case 2:
                    Console.WriteLine("字母重排");
                    Console.WriteLine("什么是字母重排？");
                    Console.WriteLine("描述：检查两个输入字符串是否是字母重排（包含相同字符但顺序不同）。");
                    Console.WriteLine("输入：两个字符串。");
                    Console.WriteLine("输出：返回一个布尔值，指示输入的字符串是否是字母重排。");
                    AnagramMod.Anagram(languageChoice);
                    break;
                case 3:
                    Console.WriteLine("Atbash 密码");
                    Console.WriteLine("什么是 Atbash 密码？");
                    Console.WriteLine("描述：实现 Atbash 密码，一种简单的替换密码。");
                    Console.WriteLine("用法：AtbashCipher 类提供使用 Atbash 密码算法加密和解密文本的方法。");
                    new AtbashCipher().Go(languageChoice);
                    break;
                case 4:
                    Console.WriteLine("啤酒歌");
                    Console.WriteLine("什么是啤酒歌？");
                    Console.WriteLine("描述：生成经典的“99 瓶啤酒”歌曲的歌词。");
                    Console.WriteLine("输入：开始的瓶子数量。");
                    Console.WriteLine("输出：返回歌曲的歌词。");
                    BeerSongMod.BeerSong(languageChoice);
                    break;
                case 5:
                    Console.WriteLine("二进制");
                    Console.WriteLine("什么是二进制？");
                    Console.WriteLine("描述：将十进制数转换为二进制表示。");
                    Console.WriteLine("输入：一个十进制数。");
                    Console.WriteLine("输出：返回表示输入数的二进制字符串。");
                    BinaryMod.Binary(languageChoice);
                    break;
                case 6:
                    Console.WriteLine("二叉搜索树");
                    Console.WriteLine("什么是二叉搜索树？");
                    Console.WriteLine("描述：表示一种二叉搜索树，一种层次化的数据结构。");
                    Console.WriteLine("用法：BinarySearchTree 类提供插入、删除和搜索树中元素的方法。");
                    BinarySearchTree(languageChoice);
                    break;
                case 7:
                    Console.WriteLine("鲍勃");
                    Console.WriteLine("什么是鲍勃？");
                    Console.WriteLine("描述：一个对话式聊天机器人，响应用户输入。");
                    Console.WriteLine("用法：Bob 类利用自然语言处理技术理解和与用户交互。");
                    BobRobot.Bob(languageChoice);
                    break;
                case 8:
                    Console.WriteLine("时钟");
                    Console.WriteLine("什么是时钟？");
                    Console.WriteLine("描述：表示一个可以用来跟踪时间的数字时钟。");
                    Console.WriteLine("用法：Clock 类提供设置时间的功能。");
                    Clock();
                    break;
                case 9:
                    Console.WriteLine("十六进制");
                    Console.WriteLine("什么是十六进制？");
                    Console.WriteLine("描述：用于在十进制和十六进制表示之间进行转换的实用类。");
                    Console.WriteLine("用法：提供将十进制数转换为十六进制格式和将十六进制数转换为十进制格式的方法。");
                    HexadecimalMod.Hexadecimal(languageChoice);
                    break;
                case 10:
                    Console.WriteLine("链表");
                    Console.WriteLine("什么是链表？");
                    Console.WriteLine("描述：表示一种线性数据结构，其中元素按顺序存储并使用指针链接。");
                    Console.WriteLine("用法：LinkedList 类提供插入、删除和检索列表中的元素的方法。");
                    LinkedList();
                    break;
                case 11:
                    Console.WriteLine("Luhn");
                    Console.WriteLine("什么是 Luhn？");
                    Console.WriteLine("描述：实现用于验证识别号码的 Luhn 算法。");
                    Console.WriteLine("输入：作为字符串的识别号码。");
                    Console.WriteLine("输出：返回一个布尔值，指示输入号码是否根据 Luhn 算法有效。");
                    LuhnMod.Luhn(languageChoice);
                    break;
                case 12:
                    Console.WriteLine("第 N 个素数");
                    Console.WriteLine("什么是第 N 个素数？");
                    Console.WriteLine("描述：计算第 N 个素数的数学实用类。");
                    Console.WriteLine("用法：提供计算和检索特定索引处的素数的方法。");
                    NthPrime();
                    break;
                case 13:
                    Console.WriteLine("核苷酸计数");
                    Console.WriteLine("什么是核苷酸计数？");
                    Console.WriteLine("描述：计算 DNA 链中核苷酸（A、C、G、T）的出现次数。");
                    Console.WriteLine("输入：作为字符串的 DNA 链。");
                    Console.WriteLine("输出：返回包含每个核苷酸计数的字典或关联数组。");
                    NucleotideCountMod.NucleotideCount(languageChoice);
                    break;
                case 14:
                    Console.WriteLine("回文乘积");
                    Console.WriteLine("什么是回文乘积？");
                    Console.WriteLine("描述：在给定范围内，找到可以由两个数的乘积得到的最大和最小回文数。");
                    Console.WriteLine("输入：一个数字范围。");
                    Console.WriteLine("输出：返回最大和最小回文数，以及生成它们的因子。");
                    PalindromeMod.PalindromeProducts(languageChoice);
                    break;
                case 15:
                    Console.WriteLine("帕斯卡三角形");
                    Console.WriteLine("什么是帕斯卡三角形？");
                    Console.WriteLine("描述：生成帕斯卡三角形，生成指定行数的三角形。");
                    Console.WriteLine("帕斯卡三角形是以法国数学家布莱兹·帕斯卡命名的一个数列。三角形中的每个数是它上方两个数之和。");
                    Console.WriteLine("输入：三角形的行数。");
                    Console.WriteLine("输出：返回表示帕斯卡三角形的二维数组。");
                    PascalsTriangle();
                    break;
                case 16:
                    Console.WriteLine("皇后攻击");
                    Console.WriteLine("什么是皇后攻击？");
                    Console.WriteLine("描述：根据皇后的位置确定两个皇后是否能够互相攻击。");
                    Console.WriteLine("输入：两个皇后的位置。");
                    Console.WriteLine("输出：返回一个消息，指示皇后是否能够互相攻击。");
                    QueenAttackMod.QueenAttack(languageChoice);
                    break;
                case 17:
                    Console.WriteLine("三进制");
                    Console.WriteLine("什么是三进制？");
                    Console.WriteLine("描述：用于处理三进制数（基数为3）的实用类。");
                    Console.WriteLine("用法：提供将三进制数转换为十进制和反之的功能，并对三进制数进行操作。");
                    Trinary();
                    break;
                case 18:
                    Console.WriteLine("三角形");
                    Console.WriteLine("什么是三角形？");
                    Console.WriteLine("描述：根据三角形的边长确定三角形的类型（等边、等腰、不等边）。");
                    Console.WriteLine("输入：三角形的三条边的长度。");
                    Console.WriteLine("输出：返回一个字符串，指示三角形的类型。");
                    Triangle();
                    break;
                case 19:
                    Console.WriteLine("单词计数");
                    Console.WriteLine("什么是单词计数？");
                    Console.WriteLine("描述：用于计算给定文本或文档中单词出现次数的实用类。");
                    Console.WriteLine("用法：提供处理输入文本、将其分词为单词并生成每个单词计数的方法。");
                    WordCount();
                    break;
                case 20:
                    Console.WriteLine("语言处理");
                    Console.WriteLine("什么是语言处理？");
                    Console.WriteLine("描述：用于分析和处理自然语言句子的语言工具。");
                    Console.WriteLine("用法：提供解析句子、识别词性、提取有意义的信息和执行语言操作的方法。");
                    WordyMod.Wordy(languageChoice);
                    break;
                default:
                    Console.WriteLine("无效选择");
                    break;
            }
        }


        private static void ChooseGameEng(int gameChoice, Language languageChoice)
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
                    HexadecimalMod.Hexadecimal(languageChoice);
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
                    PalindromeMod.PalindromeProducts(languageChoice);
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