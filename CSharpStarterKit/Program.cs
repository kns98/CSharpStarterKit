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
                   GameChoiceUtils.ChooseGameCn(gameChoice, languageChoice);
                }


                if (languageChoice == Language.English)
                {
                    GameChoiceUtils.ChooseGameEng(gameChoice, languageChoice);
                }

                Console.WriteLine("Do you want to continue playing? (y/n)");
                string continueChoice = Console.ReadLine();

                continuePlaying = (continueChoice.ToLower() == "y");
            }
        }

    }
}

  
