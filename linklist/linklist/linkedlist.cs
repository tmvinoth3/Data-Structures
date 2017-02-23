using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linklist
{
   public class linkedlist<T> 
    {
        public int Count { get; private set; }

        public linkedlistNode<T> Head { get; private set; }

        public linkedlistNode<T> Tail { get; private set; }
        
         public void addFirst(T value)
        {
            addFirst(new linkedlistNode<T>(value));
        }
        public void addFirst(linkedlistNode<T> node)
        {
            linkedlistNode<T> temp = Head;

            Head = node;

            Head.Next = temp;

            Count++;

            if (Count == 1)
            {
                Tail = Head;
            }

        }

        public void InsertPosition(int position,T value)
        {
            InsertPosition(position,new linkedlistNode<T>(value));
        }

        public void InsertPosition(int position, linkedlistNode<T> node)
        {
            int count = 1;
            if (position <= Count)
            {
                linkedlistNode<T> temp = Head;
                while (temp != null)
                {

                    if (count == position)
                    {
                        node.Next = temp.Next;
                        temp.Next = node;
                        break;
                    }
                    temp = temp.Next;
                    count++;
                }
            }
            else
            {
                Console.WriteLine("OutOFBound");
            }

        }

        public void DeletePosition(int position)
        {
            int count = 1;
            if (position <= Count)
            {
                linkedlistNode<T> temp = Head;
                linkedlistNode<T> hold;
                while (temp != null)
                {

                    if (count == position)
                    {
                        hold = temp.Next;
                        temp.Next = temp.Next.Next;
                        hold = null;
                        break;
                    }
                    temp = temp.Next;
                    count++;
                }
            }
            else
            {
                Console.WriteLine("OutOFBound");
            }

        }

        public void addLast(T value)
        {
            addLast(new linkedlistNode<T>(value));
        }

        public void addLast(linkedlistNode<T> node)
        {

            if (Count == 0)
            {
                Head = node;
            }

            else
            {
                Tail.Next = node;
            }

            Tail = node;
            Count++;

        }

        public void removeFirst()
        {
            if (Count != 0)
            {
                Head = Head.Next;
                Count--;

                if (Count == 0)
                {
                    Tail = null;
                }
            }
        }

        public void printList()
        {
            linkedlistNode<T> node = Head;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }

        public void removeLast()
        {
            
            if (Count != 0)
            {
                
                if (Count == 1)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    linkedlistNode<T> current = Head; 
                    while (current.Next != Tail)
                    {
                        current = current.Next;
                    }
                    current.Next = null;
                    Count--;
                    Tail = current;
                    
                }
            }
        }





    

    }

   class linkedlist
   {
       static void Main(string[] args)
       {
           linkedlist<int> l = new linkedlist<int>();
           l.addFirst(5);
           l.addFirst(10);
           l.addLast(15);
           //l.removeFirst();
           //l.removeLast();
           l.InsertPosition(2,8);
           l.DeletePosition(3);
           l.printList();
           Console.Read();
       }
   }


}
