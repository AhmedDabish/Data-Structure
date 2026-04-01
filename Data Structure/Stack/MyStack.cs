using System;

namespace Data_Structure.Stack
{
    class MyStack
    {
        private StackNode top;

        public void Push(int value)
        {
            StackNode newNode = new StackNode(value);
            newNode.Next = top;
            top = newNode;
        }

        public int Pop()
        {
            if (top == null) return -1;

            int value = top.Data;
            top = top.Next;
            return value;
        }

        public int Peek()
        {
            if (top == null) return -1;
            return top.Data;
        }

        public void Print()
        {
            StackNode current = top;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}