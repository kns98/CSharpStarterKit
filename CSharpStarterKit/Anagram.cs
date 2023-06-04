using CSharpLearn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn
{
    class AnagramMod
    {
        public static void Anagram(Language languageChoice)
        {
            // English: Implementation for the Anagram problem
            // Chinese: 字谜问题的实现
            string promptWord1 = languageChoice == Language.English ? "Enter the first word: " : "输入第一个单词: ";
            string promptWord2 = languageChoice == Language.English ? "Enter the second word: " : "输入第二个单词: ";
            string messageAnagram = languageChoice == Language.English ? "The words are anagrams." : "这两个单词是字谜.";
            string messageNotAnagram = languageChoice == Language.English ? "The words are not anagrams." : "这两个单词不是字谜.";

            string word1 = ConsoleHelper.ReadString(promptWord1);
            string word2 = ConsoleHelper.ReadString(promptWord2);

            char[] chars1 = word1.ToLower().ToCharArray();
            char[] chars2 = word2.ToLower().ToCharArray();

            Array.Sort(chars1);
            Array.Sort(chars2);

            string sortedWord1 = new string(chars1);
            string sortedWord2 = new string(chars2);

            if (sortedWord1 == sortedWord2)
            {
                Console.WriteLine(messageAnagram);
            }
            else
            {
                Console.WriteLine(messageNotAnagram);
            }
        }
    }
}
