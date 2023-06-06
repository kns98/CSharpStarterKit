using CSharpLearn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStarterKit
{
    internal class WordCountMod
    {
        public static void WordCount(Language languageChoice)
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
    }
}
