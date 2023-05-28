using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Choose a language:");
        Console.WriteLine("1. English");
        Console.WriteLine("2. Chinese");
        int languageChoice = int.Parse(Console.ReadLine());

        Console.WriteLine("Hello, World!");

        QueenAttack(languageChoice);
        Anagram(languageChoice);
        BeerSong(languageChoice);
        Binary(languageChoice);
        Luhn(languageChoice);
        NucleotideCount(languageChoice);
        PalindromeProducts(languageChoice);
        PascalsTriangle(languageChoice);
        Triangle(languageChoice);
        Accumulate(languageChoice);
        Clock(languageChoice);
        Hexadecimal(languageChoice);
        LinkedList(languageChoice);
        Trinary(languageChoice);
        WordCount(languageChoice);
        NthPrime(languageChoice);
        Wordy(languageChoice);
        AtbashCipher(languageChoice);
        BinarySearchTree(languageChoice);
        Bob(languageChoice);
    }

    public static void QueenAttack(int languageChoice)
    {
        // English: Implementation for the Queen Attack problem
        // Chinese: 皇后攻击问题的实现
        string[] languageStrings = languageChoice == 1 ?
            new string[] { "Enter the position of the first queen:", "Row: ", "Column: ", "Enter the position of the second queen:", "The queens can attack each other.", "The queens cannot attack each other." } :
            new string[] { "输入第一个皇后的位置:", "行: ", "列: ", "输入第二个皇后的位置:", "皇后可以互相攻击.", "皇后无法互相攻击." };

        int[][] board = new int[8][];
        for (int i = 0; i < 8; i++)
        {
            board[i] = new int[8];
        }
        int queen1Row, queen1Col, queen2Row, queen2Col;

        Console.WriteLine(languageStrings[0]);
        Console.Write(languageStrings[1]);
        queen1Row = int.Parse(Console.ReadLine());
        Console.Write(languageStrings[2]);
        queen1Col = int.Parse(Console.ReadLine());

        Console.WriteLine(languageStrings[3]);
        Console.Write(languageStrings[1]);
        queen2Row = int.Parse(Console.ReadLine());
        Console.Write(languageStrings[2]);
        queen2Col = int.Parse(Console.ReadLine());

        if (queen1Row == queen2Row || queen1Col == queen2Col || Math.Abs(queen1Row - queen2Row) == Math.Abs(queen1Col - queen2Col))
        {
            Console.WriteLine(languageStrings[4]);
        }
        else
        {
            Console.WriteLine(languageStrings[5]);
        }
    }

    public static void Anagram(int languageChoice)
    {
        // English: Implementation for the Anagram problem
        // Chinese: 字谜问题的实现
        string[] languageStrings = languageChoice == 1 ?
            new string[] { "Enter the first word: ", "Enter the second word: ", "The words are anagrams.", "The words are not anagrams." } :
            new string[] { "输入第一个单词: ", "输入第二个单词: ", "这两个单词是字谜.", "这两个单词不是字谜." };

        Console.Write(languageStrings[0]);
        string word1 = Console.ReadLine();
        Console.Write(languageStrings[1]);
        string word2 = Console.ReadLine();

        char[] chars1 = word1.ToLower().ToCharArray();
        char[] chars2 = word2.ToLower().ToCharArray();

        Array.Sort(chars1);
        Array.Sort(chars2);

        string sortedWord1 = new string(chars1);
        string sortedWord2 = new string(chars2);

        if (sortedWord1 == sortedWord2)
        {
            Console.WriteLine(languageStrings[2]);
        }
        else
        {
            Console.WriteLine(languageStrings[3]);
        }
    }

    public static void BeerSong(int languageChoice)
    {
        // English: Implementation for the Beer Song problem
        // Chinese: 啤酒歌问题的实现
        string[] languageStrings = languageChoice == 1 ?
            new string[] { " bottles", " bottle", " of beer on the wall,", " of beer.", "Take one down and pass it around,", "No more bottles of beer on the wall, no more bottles of beer.", "Go to the store and buy some more,", " bottles of beer on the wall." } :
            new string[] { " 瓶", " 瓶", " 的啤酒在墙上,", " 的啤酒.", "拿掉一瓶传来传去,", "没有啤酒在墙上, 没有啤酒.", "去商店买一些,", " 瓶的啤酒在墙上." };

        for (int i = 99; i > 0; i--)
        {
            Console.WriteLine($"{i}{(i == 1 ? languageStrings[1] : languageStrings[0])}{languageStrings[2]} {i}{(i == 1 ? languageStrings[1] : languageStrings[0])}{languageStrings[3]}");
            Console.WriteLine(languageStrings[4]);
            Console.WriteLine($"{i - 1}{((i - 1) == 1 ? languageStrings[1] : languageStrings[0])}{languageStrings[6]}\n");
        }

        Console.WriteLine(languageStrings[5]);
        Console.WriteLine(languageStrings[6]);
        Console.WriteLine($"99{languageStrings[0]}{languageStrings[7]}\n");
    }

    public static void Binary(int languageChoice)
    {
        // English: Implementation for the Binary problem
        // Chinese: 二进制问题的实现
        string[] languageStrings = languageChoice == 1 ?
            new string[] { "Enter a decimal number: ", "The binary representation is: " } :
            new string[] { "输入一个十进制数: ", "二进制表示为: " };

        Console.Write(languageStrings[0]);
        int decimalNumber = int.Parse(Console.ReadLine());

        string binaryString = Convert.ToString(decimalNumber, 2);
        Console.WriteLine(languageStrings[1] + binaryString);
    }

    public static void Luhn(int languageChoice)
    {
        // English: Implementation for the Luhn problem
        // Chinese: Luhn算法问题的实现
        string[] languageStrings = languageChoice == 1 ?
            new string[] { "Enter a credit card number: ", "The credit card number is valid.", "The credit card number is invalid." } :
            new string[] { "输入一个信用卡号码: ", "信用卡号码有效.", "信用卡号码无效." };

        Console.Write(languageStrings[0]);
        string creditCardNumber = Console.ReadLine();

        int[] digits = creditCardNumber.Where(char.IsDigit).Select(c => int.Parse(c.ToString())).ToArray();
        int sum = 0;
        bool doubleDigit = false;

        for (int i = digits.Length - 1; i >= 0; i--)
        {
            int digit = digits[i];

            if (doubleDigit)
            {
                digit *= 2;
                if (digit > 9)
                {
                    digit -= 9;
                }
            }

            sum += digit;
            doubleDigit = !doubleDigit;
        }

        if (sum % 10 == 0)
        {
            Console.WriteLine(languageStrings[1]);
        }
        else
        {
            Console.WriteLine(languageStrings[2]);
        }
    }

    public static void NucleotideCount(int languageChoice)
    {
        // English: Implementation for the Nucleotide Count problem
        // Chinese: 核苷酸计数问题的实现
        string[] languageStrings = languageChoice == 1 ?
            new string[] { "Enter a DNA sequence: ", "A:", "C:", "G:", "T:" } :
            new string[] { "输入一个DNA序列: ", "A:", "C:", "G:", "T:" };

        Console.Write(languageStrings[0]);
        string sequence = Console.ReadLine().ToUpper();

        Dictionary<char, int> nucleotideCount = new Dictionary<char, int>
        {
            { 'A', 0 },
            { 'C', 0 },
            { 'G', 0 },
            { 'T', 0 }
        };

        foreach (char nucleotide in sequence)
        {
            if (nucleotideCount.ContainsKey(nucleotide))
            {
                nucleotideCount[nucleotide]++;
            }
        }

        Console.WriteLine(languageStrings[1] + nucleotideCount['A']);
        Console.WriteLine(languageStrings[2] + nucleotideCount['C']);
        Console.WriteLine(languageStrings[3] + nucleotideCount['G']);
        Console.WriteLine(languageStrings[4] + nucleotideCount['T']);
    }

    public static void PalindromeProducts(int languageChoice)
    {
        // English: Implementation for the Palindrome Products problem
        // Chinese: 回文乘积问题的实现
        string[] languageStrings = languageChoice == 1 ?
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

    public static void PascalsTriangle(int languageChoice)
    {
        // English: Implementation for the Pascal's Triangle problem
        // Chinese: 帕斯卡三角形问题的实现
        string[] languageStrings = languageChoice == 1 ?
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

    public static void Triangle(int languageChoice)
    {
        // English: Implementation for the Triangle problem
        // Chinese: 三角形问题的实现
        string[] languageStrings = languageChoice == 1 ?
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

    public static void Accumulate(int languageChoice)
    {
        // English: Implementation for the Accumulate problem
        // Chinese: 累积问题的实现
        string[] languageStrings = languageChoice == 1 ?
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

    public static void Clock(int languageChoice)
    {
        // English: Implementation for the Clock problem
        // Chinese: 时钟问题的实现
        string[] languageStrings = languageChoice == 1 ?
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

    public static void Hexadecimal(int languageChoice)
    {
        // English: Implementation for the Hexadecimal problem
        // Chinese: 十六进制问题的实现
        string[] languageStrings = languageChoice == 1 ?
            new string[] { "Enter a decimal number: ", "The hexadecimal representation is: " } :
            new string[] { "输入一个十进制数: ", "十六进制表示为: " };

        Console.Write(languageStrings[0]);
        int decimalNumber = int.Parse(Console.ReadLine());

        string hexadecimalString = decimalNumber.ToString("X");
        Console.WriteLine(languageStrings[1] + hexadecimalString);
    }

    public static void LinkedList(int languageChoice)
    {
        // English: Implementation for the Linked List problem
        // Chinese: 链表问题的实现
        string[] languageStrings = languageChoice == 1 ?
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

    public static void Trinary(int languageChoice)
    {
        // English: Implementation for the Trinary problem
        // Chinese: 三进制问题的实现
        string[] languageStrings = languageChoice == 1 ?
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

    public static void WordCount(int languageChoice)
    {
        // English: Implementation for the Word Count problem
        // Chinese: 单词计数问题的实现
        string[] languageStrings = languageChoice == 1 ?
            new string[] { "Enter a sentence: ", "The word count is: " } :
            new string[] { "输入一个句子: ", "单词数量为: " };

        Console.Write(languageStrings[0]);
        string sentence = Console.ReadLine();

        string[] words = sentence.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        int wordCount = words.Length;

        Console.WriteLine(languageStrings[1] + wordCount);
    }

    public static void NthPrime(int languageChoice)
    {
        // English: Implementation for the Nth Prime problem
        // Chinese: 第N个质数问题的实现
        string[] languageStrings = languageChoice == 1 ?
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

    public static void Wordy(int languageChoice)
    {
        // English: Implementation for the Wordy problem
        // Chinese: Wordy问题的实现
        string[] languageStrings = languageChoice == 1 ?
            new string[] { "Enter a word problem: ", "Invalid question.", "The answer is: " } :
            new string[] { "输入一个单词问题: ", "无效的问题.", "答案是: " };

        Console.Write(languageStrings[0]);
        string problem = Console.ReadLine().ToLower();

        string[] words = problem.Split(' ');
        int length = words.Length;

        if (length < 3 || length % 2 == 0 || !words[0].Equals("what") || !words[length - 1].Equals("equal"))
        {
            Console.WriteLine(languageStrings[1]);
            return;
        }

        int result = int.Parse(words[2]);

        for (int i = 3; i < length - 2; i += 2)
        {
            string operatorWord = words[i];

            if (operatorWord.Equals("plus"))
            {
                result += int.Parse(words[i + 1]);
            }
            else if (operatorWord.Equals("minus"))
            {
                result -= int.Parse(words[i + 1]);
            }
            else if (operatorWord.Equals("multiplied"))
            {
                result *= int.Parse(words[i + 2]);
                i++;
            }
            else if (operatorWord.Equals("divided"))
            {
                result /= int.Parse(words[i + 2]);
                i++;
            }
            else
            {
                Console.WriteLine(languageStrings[1]);
                return;
            }
        }

        Console.WriteLine(languageStrings[2] + result);
    }

    public static void AtbashCipher(int languageChoice)
    {
        // English: Implementation for the Atbash Cipher problem
        // Chinese: Atbash密码问题的实现
        string[] languageStrings = languageChoice == 1 ?
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

    public static void BinarySearchTree(int languageChoice)
    {
        // English: Implementation for the Binary Search Tree problem
        // Chinese: 二叉搜索树问题的实现
        string[] languageStrings = languageChoice == 1 ?
            new string[] { "Enter the elements of the binary search tree (separated by spaces): ", "Enter the element to search: ", "The binary search tree is valid.", "The binary search tree is invalid." } :
            new string[] { "输入二叉搜索树的元素（以空格分隔）: ", "输入要搜索的元素: ", "二叉搜索树有效.", "二叉搜索树无效." };

        Console.Write(languageStrings[0]);
        string input = Console.ReadLine();
        int[] elements = input.Split(' ').Select(int.Parse).ToArray();

        TreeNode root = BuildBinarySearchTree(elements);

        Console.Write(languageStrings[1]);
        int searchElement = int.Parse(Console.ReadLine());

        bool isValid = ValidateBinarySearchTree(root);
        Console.WriteLine(isValid ? languageStrings[2] : languageStrings[3]);

        TreeNode searchResult = SearchBinarySearchTree(root, searchElement);
        Console.WriteLine("Search Result: " + (searchResult != null ? searchResult.Value.ToString() : "Not found"));
    }

    private static TreeNode BuildBinarySearchTree(int[] elements)
    {
        if (elements.Length == 0)
        {
            return null;
        }

        TreeNode root = new TreeNode(elements[0]);

        for (int i = 1; i < elements.Length; i++)
        {
            InsertIntoBinarySearchTree(root, elements[i]);
        }

        return root;
    }

    private static void InsertIntoBinarySearchTree(TreeNode node, int value)
    {
        if (value <= node.Value)
        {
            if (node.Left == null)
            {
                node.Left = new TreeNode(value);
            }
            else
            {
                InsertIntoBinarySearchTree(node.Left, value);
            }
        }
        else
        {
            if (node.Right == null)
            {
                node.Right = new TreeNode(value);
            }
            else
            {
                InsertIntoBinarySearchTree(node.Right, value);
            }
        }
    }

    private static bool ValidateBinarySearchTree(TreeNode node)
    {
        return ValidateBinarySearchTree(node, int.MinValue, int.MaxValue);
    }

    private static bool ValidateBinarySearchTree(TreeNode node, int minValue, int maxValue)
    {
        if (node == null)
        {
            return true;
        }

        if (node.Value < minValue || node.Value > maxValue)
        {
            return false;
        }

        return ValidateBinarySearchTree(node.Left, minValue, node.Value - 1)
            && ValidateBinarySearchTree(node.Right, node.Value + 1, maxValue);
    }

    private static TreeNode SearchBinarySearchTree(TreeNode node, int value)
    {
        if (node == null || node.Value == value)
        {
            return node;
        }

        if (value < node.Value)
        {
            return SearchBinarySearchTree(node.Left, value);
        }

        return SearchBinarySearchTree(node.Right, value);
    }

    public static void Bob(int languageChoice)
    {
        // English: Implementation for the Bob problem
        // Chinese: Bob问题的实现
        string[] languageStrings = languageChoice == 1 ?
            new string[] { "Enter a phrase to Bob: ", "Bob's response: " } :
            new string[] { "输入要与Bob交流的短语: ", "Bob的回应: " };

        Console.Write(languageStrings[0]);
        string phrase = Console.ReadLine();

        string response = BobResponse(phrase);
        Console.WriteLine(languageStrings[1] + response);
    }

    private static string BobResponse(string phrase)
    {
        if (string.IsNullOrWhiteSpace(phrase))
        {
            return "Fine. Be that way!";
        }

        bool isQuestion = phrase.EndsWith("?");
        bool isYelling = phrase.ToUpper() == phrase;

        if (isQuestion && isYelling)
        {
            return "Calm down, I know what I'm doing!";
        }
        else if (isQuestion)
        {
            return "Sure.";
        }
        else if (isYelling)
        {
            return "Whoa, chill out!";
        }
        else
        {
            return "Whatever.";
        }
    }
}

public class TreeNode
{
    public int Value { get; set; }
    public TreeNode Left { get; set; }
    public TreeNode Right { get; set; }

    public TreeNode(int value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}
