using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BinaryTree;

namespace BinaryTree
{
    static class WordSort
    {
        public static void sort()
        {
            BinaryTree<string> bt = new BinaryTree<string>();

            string input = string.Empty;

            while (!input.Equals("quit", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("> ");
                input = Console.ReadLine();

                string[] arr = input.Split(' ');

                foreach (var item in arr)
                {
                    bt.Add(item);
                }

                bt.inorderTraversal();

                bt.clear();

            }
        }
    }
}
