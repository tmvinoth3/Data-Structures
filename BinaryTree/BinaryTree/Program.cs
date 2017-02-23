using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> bt = new BinaryTree<int>();
            bt.Add(4);
            bt.Add(2);
            bt.Add(3);
            bt.Add(1);
            bt.Add(6);
            bt.Add(5);
            bt.Add(8);
            bt.Add(7);
            bt.Add(9);
            bt.Remove(8);
            bt.inorderTraversal();
            WordSort.sort();
            Console.Read();
        }
    }
}
