using CSharpLearn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStarterKit
{
    internal class LinkedListMod
    {
        public static void LinkedList(Language languageChoice)
        {
            // English: Implementation for the Linked List problem
            // Chinese: 链表问题的实现
            string[] languageStrings = languageChoice == Language.English ?
                new string[] { "Enter the elements (numbers) of the linked list (separated by spaces): ", "The linked list: ", "The reversed linked list: " } :
                new string[] { "输入链表元素（数字）（用空格分隔。）: ", "链表: ", "反转后的链表: " };

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

            Console.Write(languageStrings[2]);
            foreach (int element in linkedList.Reverse())
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
