using CSharpLearn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStarterKit
{

    /*
     Pascal's rule gives rise to Pascal's triangle.

       0:             1
       1:          1     1
       2:        1     2     1
       3:      1     3     3     1
       4:    1     4     6     4     1
       5:  1     5    10    10    5     1
       6: 1     6    15    20    15    6     1
       7: 1     7    21    35    35    21    7     1
       8: 1     8    28    56    70    56    28    8     1

       e.g. (x + y)^5 = 1x^5 + 5x^4y + 10x^3y^2 + 10x^2y^3 + 5xy^4 + 1y^5.
     */

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
