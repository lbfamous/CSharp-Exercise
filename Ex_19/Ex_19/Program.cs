//using System;


namespace Ex_19
{
    using System;
    public class Stack
    {
        private Node first = null;
        private int count = 0;
        public bool Empty
        {
            get
            {
                return (first == null);
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public object Pop()
        {
            if(first == null)
            {
                throw new InvalidOperationException("Can pop from an empty stack");
            }
            else
            {
                object temp = first.Value;
                first = first.Next;
                count--;
                return temp;
            }
        }

        public void Push(object o)
        {
            first = new Node(o, first);
            count++;
        }

        class Node
        {
            public Node Next;
            public object Value;

            public Node(object value) : this(value, null) { }

            public Node(object value,Node next)
            {
                Next = next;
                Value = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            if (s.Empty)
                Console.WriteLine("Stack is Empty");
            else
                Console.WriteLine("Stack is Not Empty");

            for(int i = 0;i <5;++i)
            {
                s.Push(i);
            }

            Console.WriteLine("Stack Pushed {0} Element", s.Count);

            for(int i = 0; i <5;i++)
            {
                Console.WriteLine("Stack pop The {0} Element,Left {1} Element", (int)s.Pop() + 1, s.Count);
            }
            s = null;

            Console.ReadLine();
        }
    }
}
