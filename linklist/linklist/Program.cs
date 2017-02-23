using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linklist
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Node first = new Node { Value=3 };

            Node middle = new Node { Value=4 };

            first.Next = middle;

            Node last = new Node { Value=5 };

            middle.Next = last;

            printList(first);

            Console.Read();
        }

        public static void printList(Node node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
        
    }
}
