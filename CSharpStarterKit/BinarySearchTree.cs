using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpLearn
{
    public class BinarySearchTree<T>
    {
        public class TreeNode<T>
        {
            public T Value { get; set; }
            public TreeNode<T> Left { get; set; }
            public TreeNode<T> Right { get; set; }

            public TreeNode(T value)
            {
                Value = value;
                Left = null;
                Right = null;
            }
        }

        private readonly IComparer<T> comparer;
        private TreeNode<T> root;

        public BinarySearchTree(IComparer<T> comparer)
        {
            this.comparer = comparer;
            root = null;
        }

        public void Add(T value)
        {
            root = AddNode(root, value);
        }

        private TreeNode<T> AddNode(TreeNode<T> node, T value)
        {
            if (node == null)
            {
                return new TreeNode<T>(value);
            }

            if (comparer.Compare(value, node.Value) <= 0)
            {
                node.Left = AddNode(node.Left, value);
            }
            else
            {
                node.Right = AddNode(node.Right, value);
            }

            return node;
        }

        public bool Contains(T value)
        {
            return SearchNode(root, value) != null;
        }

        private TreeNode<T> SearchNode(TreeNode<T> node, T value)
        {
            if (node == null || comparer.Compare(value, node.Value) == 0)
            {
                return node;
            }

            if (comparer.Compare(value, node.Value) < 0)
            {
                return SearchNode(node.Left, value);
            }

            return SearchNode(node.Right, value);
        }

        public static void BCS(Language languageChoice)
        {
            string[] languageStrings = languageChoice == Language.English ?
                new string[] { "Enter the values to search (space-separated): ", "Found", "Not found" } :
                new string[] { "输入要搜索的值（以空格分隔）: ", "找到了", "未找到" };

            Console.Write(languageStrings[0]);
            string inputValues = Console.ReadLine();

            // Parse input values
            string[] elements = inputValues.Split(' ');

            // Test case
            BinarySearchTree<string> bst = new BinarySearchTree<string>(Comparer<string>.Default);
            foreach (string element in elements)
            {
                bst.Add(element);
            }

            Console.Write("Enter the value to search for:");
            string searchValue = Console.ReadLine();

            bool contains = bst.Contains(searchValue);
            Console.WriteLine(contains ? languageStrings[1] : languageStrings[2]);
        }




    }
}
