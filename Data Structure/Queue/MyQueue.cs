using System;

namespace Data_Structure.Queue
{
    class MyQueue
    {
        private int[] arr;
        private int size;

        public MyQueue(int capacity = 5)
        {
            arr = new int[capacity];
        }

        public void Enqueue(int value)
        {
            if (size == arr.Length) return;
            arr[size++] = value;
        }

        public int Dequeue()
        {
            if (size == 0) return -1;

            int val = arr[0];
            for (int i = 1; i < size; i++)
                arr[i - 1] = arr[i];

            size--;
            return val;
        }

        public void Print()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}