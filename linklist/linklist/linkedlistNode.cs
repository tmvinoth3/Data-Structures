using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linklist
{
    public class linkedlistNode<T>
    {
        public linkedlistNode(T value)
        {
            Value = value;
        }

        public linkedlistNode()
        {
            // TODO: Complete member initialization
        }

        public T Value { get; set; }

        public linkedlistNode<T> Next { get; set; }
    }
}
