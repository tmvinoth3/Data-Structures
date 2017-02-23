using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryTree
{
    public class BinaryTreeNode<T> : IComparable<T>
        where T : IComparable<T>
    {
        public BinaryTreeNode(T value)
        {
            Value = value; 
        }
        public T Value { get; private set; }

        public BinaryTreeNode<T> Left { get; set; }

        public BinaryTreeNode<T> Right { get; set; }

        public int CompareTo(T other)
        {
            return Value.CompareTo(other);
        }
    }
}
