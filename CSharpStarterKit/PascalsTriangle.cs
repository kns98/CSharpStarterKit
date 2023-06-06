using CSharpLearn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStarterKit
{
    internal class PascalsTriangleMod
    {
        public static void PascalsTriangle(Language languageChoice)
        {
            // English: Implementation for the Pascal's Triangle problem
            // Chinese: 帕斯卡三角形问题的实现
            string[] languageStrings = languageChoice == Language.English ?
                new string[] { "Enter the number of rows: " } :
                new string[] { "输入行数: " };

            int numRows = ConsoleHelper.ReadInteger(languageStrings[0]);

            int[][] triangle = new int[numRows][];

            // Construct Pascal's Triangle
            for (int line = 0; line < numRows; line++)
            {
                triangle[line] = new int[line + 1];
                int C = 1;

                for (int i = 0; i <= line; i++)
                {
                    triangle[line][i] = C;
                    C = C * (line - i) / (i + 1);
                }
            }

            // Print Pascal's Triangle
            for (int line = 0; line < numRows; line++)
            {
                for (int i = 0; i <= line; i++)
                {
                    Console.Write(triangle[line][i] + " ");
                }
                Console.Write("\n");
            }
        }
    }
}
