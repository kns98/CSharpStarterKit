using CSharpLearn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStarterKit
{
    internal class TriangleMod
    {
        public static void Triangle(Language languageChoice)
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
    }
}
