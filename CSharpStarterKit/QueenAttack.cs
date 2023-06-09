﻿/*
 * 

  Conditional Operator: The conditional operator (? :) is used to assign different language-specific strings based 
  on the languageChoice enum value. If languageChoice is Language.English, English strings are assigned; otherwise, Chinese strings are assigned.

  Multidimensional Array: The board variable is declared as a multidimensional array (int[][]) to represent the chessboard.

  Math.Abs(): The Math.Abs() method is used to calculate the absolute value of the difference between two numbers.

  Conditional Statements: The if-else statement is used to check if the queens can attack each other or not based on their positions. 
  The appropriate language-specific string is displayed accordingly.


   Queens attacking diagonally

            A   B   C   D   E   F   G   H  
      +---+---+---+---+---+---+---+---+
    8 |   |   |   |   |   |   |   |   |
      +---+---+---+---+---+---+---+---+
    7 |   |   |   |   |   |   |   |   |
      +---+---+---+---+---+---+---+---+
    6 |   |   |   |   |   | X |   |   |
      +---+---+---+---+---+---+---+---+
    5 |   |   |   |   |   |   |   |   |
      +---+---+---+---+---+---+---+---+
    4 |   |   |   | X |   |   |   |   |
      +---+---+---+---+---+---+---+---+
    3 |   |   |   |   |   |   |   |   |
      +---+---+---+---+---+---+---+---+
    2 |   |   |   |   |   |   |   |   |
      +---+---+---+---+---+---+---+---+
    1 |   |   |   |   |   |   |   |   |
      +---+---+---+---+---+---+---+---+


    Queens not attacking

            A   B   C   D   E   F   G   H  
      +---+---+---+---+---+---+---+---+
    8 |   |   |   |   |   |   |   |   |
      +---+---+---+---+---+---+---+---+
    7 |   |   | X |   |   |   |   |   |
      +---+---+---+---+---+---+---+---+
    6 |   |   |   |   |   | X |   |   |
      +---+---+---+---+---+---+---+---+
    5 |   |   |   |   |   |   |   |   |
      +---+---+---+---+---+---+---+---+
    4 |   |   |   |   |   |   |   |   |
      +---+---+---+---+---+---+---+---+
    3 |   |   |   |   |   |   |   |   |
      +---+---+---+---+---+---+---+---+
    2 |   |   |   |   |   |   |   |   |
      +---+---+---+---+---+---+---+---+
    1 |   |   |   |   |   |   |   |   |
      +---+---+---+---+---+---+---+---+

*
*/


using System;

namespace CSharpLearn
{

    internal static class QueenAttackMod
    {
        public static void QueenAttack(Language languageChoice)
        {
            string[] languageStrings = languageChoice == Language.English ?
                new string[] { "Enter the position of the first queen:", "Row: ", "Column: ", "Enter the position of the second queen:", "The queens can attack each other.", "The queens cannot attack each other." } :
                new string[] { "输入第一个皇后的位置:", "行: ", "列: ", "输入第二个皇后的位置:", "皇后可以互相攻击.", "皇后无法互相攻击." };

            int[][] board = new int[8][];
            for (int i = 0; i < 8; i++)
            {
                board[i] = new int[8];
            }

            int queen1Row, queen1Col, queen2Row, queen2Col;

            Console.WriteLine(languageStrings[0]);
            queen1Row = ConsoleHelper.ReadInteger(languageStrings[1]);
            queen1Col = ConsoleHelper.ReadInteger(languageStrings[2]);

            Console.WriteLine(languageStrings[3]);
            queen2Row = ConsoleHelper.ReadInteger(languageStrings[1]);
            queen2Col = ConsoleHelper.ReadInteger(languageStrings[2]);

            if (queen1Row == queen2Row || queen1Col == queen2Col || Math.Abs(queen1Row - queen2Row) == Math.Abs(queen1Col - queen2Col))
            {
                Console.WriteLine(languageStrings[4]);
            }
            else
            {
                Console.WriteLine(languageStrings[5]);
            }
        }
    }
}
