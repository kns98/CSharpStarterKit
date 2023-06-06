using CSharpLearn;
using CSharpStarterKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn
{
    internal class GameChoiceUtils
    {
        private static void BinarySearchTree(Language languageChoice)
        {
            CSharpLearn.BinarySearchTree<object>.BCS(languageChoice);
        }
        public static void ChooseGameCn( int gameChoice, Language languageChoice)
        {
            switch (gameChoice)
            {
                case 1:
                    Console.WriteLine("累加");
                    Console.WriteLine("什么是累加？");
                    Console.WriteLine("描述：对给定的数字列表执行指定的操作（求和、乘积等），并返回结果。");
                    Console.WriteLine("输入：数字列表和要执行的操作。");
                    Console.WriteLine("输出：返回对输入数字进行操作的累积结果。");
                    AccumulateMod.Accumulate(languageChoice);
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
                    ClockMod.Clock(languageChoice);
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
                    LinkedListMod.LinkedList(languageChoice);
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
                    NthPrimeMod.NthPrime(languageChoice);
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
                    PascalsTriangleMod.PascalsTriangle(languageChoice);
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
                    TrinaryMod.Trinary(languageChoice);
                    break;
                case 18:
                    Console.WriteLine("三角形");
                    Console.WriteLine("什么是三角形？");
                    Console.WriteLine("描述：根据三角形的边长确定三角形的类型（等边、等腰、不等边）。");
                    Console.WriteLine("输入：三角形的三条边的长度。");
                    Console.WriteLine("输出：返回一个字符串，指示三角形的类型。");
                    TriangleMod.Triangle(languageChoice);
                    break;
                case 19:
                    Console.WriteLine("单词计数");
                    Console.WriteLine("什么是单词计数？");
                    Console.WriteLine("描述：用于计算给定文本或文档中单词出现次数的实用类。");
                    Console.WriteLine("用法：提供处理输入文本、将其分词为单词并生成每个单词计数的方法。");
                    WordCountMod.WordCount(languageChoice);
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


        public static void ChooseGameEng(int gameChoice, Language languageChoice)
        {
            switch (gameChoice)
            {
                case 1:
                    Console.WriteLine("Accumulate");
                    Console.WriteLine("What is Accumulate?");
                    Console.WriteLine("Description: Performs a specified operation (sum, product, etc.) on a given list of numbers and returns the result.");
                    Console.WriteLine("Input: A list of numbers and the operation to be performed.");
                    Console.WriteLine("Output: Returns the accumulated result of the operation on the input numbers.");
                    AccumulateMod.Accumulate(languageChoice);
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
                    ClockMod.Clock(languageChoice);
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
                    LinkedListMod.LinkedList(languageChoice);
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
                    NthPrimeMod.NthPrime(languageChoice);
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
                    PascalsTriangleMod.PascalsTriangle(languageChoice);
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
                    TrinaryMod.Trinary(languageChoice);
                    break;
                case 18:
                    Console.WriteLine("Triangle");
                    Console.WriteLine("What is Triangle?");
                    Console.WriteLine("Description: Determines the type of triangle (equilateral, isosceles, scalene) based on the lengths of its sides.");
                    Console.WriteLine("Input: The lengths of the triangle's three sides.");
                    Console.WriteLine("Output: Returns a string indicating the type of triangle.");
                    TriangleMod.Triangle(languageChoice);
                    break;
                case 19:
                    Console.WriteLine("Word Count");
                    Console.WriteLine("What is Word Count?");
                    Console.WriteLine("Description: Utility class for counting the occurrences of words in a given text or document.");
                    Console.WriteLine("Usage: Provides methods to process the input text, tokenize it into individual words, and generate a count of each word encountered.");
                    WordCountMod.WordCount(languageChoice);
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
    }
}
