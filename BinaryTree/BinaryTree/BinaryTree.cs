using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryTree
{
    class BinaryTree<T> 
        where T : IComparable<T>
    {
        private BinaryTreeNode<T> head;
        private int count;

        public void Add(T value)
        {
            if (head == null)
            {
                head = new BinaryTreeNode<T>(value);
            }
            else
            {
                AddTo(head, value);
            }
            count++;
        }

        private void AddTo(BinaryTreeNode<T> node, T value)
        {
            if (value.CompareTo(node.Value) < 0)
            {
                if (node.Left == null)
                {
                    node.Left = new BinaryTreeNode<T>(value);
                }
                else
                {
                    AddTo(node.Left, value);
                }

            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new BinaryTreeNode<T>(value);
                }
                else
                {
                    AddTo(node.Right, value);
                }
            }
        }

        private bool Contains(T value)
        {
            BinaryTreeNode<T> parent;
            return FindWithParent(value, out parent) != null;
        }

        private BinaryTreeNode<T> FindWithParent(T value, out BinaryTreeNode<T> parent)
        {
            BinaryTreeNode<T> current = head;
            parent = null;
            while (current != null)
            {
                int res = current.CompareTo(value);


                if (res > 0)
                {
                    parent = current;
                    current = current.Left;
                }
                else if (res < 0)
                {
                    parent = current;
                    current = current.Right;
                }
                else
                {
                    break;
                }

            }
            return current;
        }

        public bool Remove(T value)
        {
            BinaryTreeNode<T> current, parent;

            current = FindWithParent(value, out parent);

            if (current == null)
            {
                return false;
            }
            count--;
            //case 1 current has no right node
            if (current.Right == null)
            {
                if (parent == null)
                {
                    head = current.Left;
                }
                else
                {
                    int res = current.CompareTo(value);

                    if (res > 0)
                    {
                        parent.Left = current.Left;
                    }
                    else
                    {
                        parent.Right = current.Left;
                    }
                }
            }
            //case 2 current has right and right has no left child
            //lmp -left most parent
            //lm - left most
            else if (current.Right.Left == null)
            {
                current.Right.Left = current.Left;

                if (parent == null)
                {
                    head = current.Right;
                }
                else
                {
                    int res = current.CompareTo(value);

                    if (res > 0)
                    {
                        parent.Left = current.Right;
                    }
                    else
                    {
                        parent.Right = current.Right;
                    }
                }
            }
            //case 3 current has right and right has left child
            else
            {
                BinaryTreeNode<T> lmp = current.Right;
                BinaryTreeNode<T> lm = current.Right.Left;

                while (lm.Left != null)
                {
                    lmp = lm;
                    lm = lm.Left;
                }

                lmp.Left = lm.Right;

                lm.Left = current.Left;
                lm.Right = current.Right;

                if (parent == null)
                {
                    head = lm;
                }
                else
                {
                    int res = current.CompareTo(value);

                    if (res > 0)
                    {
                        parent.Left = lm;
                    }
                    else
                    {
                        parent.Right = lm;
                    }
                }
            }
            return true;
        }


        public void inorderTraversal()
        {
            inorderTraversal(head);
        }

        public void inorderTraversal(BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                inorderTraversal(node.Left);
                Console.WriteLine(node.Value+"\t");
                inorderTraversal(node.Right);
            }
        }

        public void clear()
        {
            head = null;
        }
    }
}
