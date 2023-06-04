using System;
using System.Collections.Generic;
using System.Linq;

/*
 * A binary search tree (BST) is a hierarchical data structure that allows for efficient searching, 
 * insertion, and deletion of elements. 
 * 
 * It follows this algorithm : for any node in the tree, all values 
 * in its left subtree are less than the node's value, and all values in its right subtree are greater 
 * than the node's value.

   In the provided code, the `BinarySearchTree<T>` class represents a binary search tree. It is a generic 
   class that can store elements of any data type `T`. Each element is wrapped in a `TreeNode<T>` object, 
   which represents a node in the tree.

   The `Add` method is used to insert elements into the binary search tree. It takes a value and recursively 
   traverses the tree to find the correct position for insertion. If the value is less than or equal to the 
   current node's value, it goes to the left subtree; otherwise, it goes to the right subtree. 
   The new node is created and attached as the left or right child of an existing node, depending on the comparison result. 
   This process continues until a suitable leaf node is found for insertion.

   The `Contains` method is used to check if a specific value exists in the binary search tree. 
   It starts the search from the root node and recursively compares the value with nodes in the tree. 
   If a matching node is found, the method returns `true`. If the search reaches a null node (indicating 
   that the value does not exist in the tree) or a matching node is found, the method returns `false`.

*/

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

            Console.Write("Enter the value to search for (strings):");
            string searchValue = Console.ReadLine();

            bool contains = bst.Contains(searchValue);
            Console.WriteLine(contains ? languageStrings[1] : languageStrings[2]);

            bst.DrawTree();
        }

        public void DrawTree()
        {
            if (root == null)
            {
                Console.WriteLine("Tree is empty.");
                return;
            }

            DrawNode(root, "");
        }

        private void DrawNode(TreeNode<T> node, string indent)
        {
            if (node == null)
                return;

            // Print the node's value
            Console.WriteLine(indent + node.Value);

            // Generate the dashes for the branches
            string branchIndent = indent + "├── ";
            string subIndent = indent + "│   ";

            // Recursively draw the left subtree
            DrawNode(node.Left, node.Right != null ? branchIndent : subIndent);

            // Recursively draw the right subtree
            DrawNode(node.Right, subIndent);
        }



    }
}
