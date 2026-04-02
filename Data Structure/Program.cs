using System;
using Data_Structure.BinarySearch;
using Data_Structure.InsertionSort;
using Data_Structure.LinkedList;
using Data_Structure.Merge_Sort;
using Data_Structure.Queue;
using Data_Structure.Stack;
using Data_Structure.Tree;

namespace Data_Structure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ===== Merge Sort =====
            int[] arr = { 8, 3, 5, 4, 2, 1 };
            Console.WriteLine("Before MergeSort: " + string.Join(", ", arr));
            MergeSort.Sort(arr);
            Console.WriteLine("After MergeSort:  " + string.Join(", ", arr));
            Console.WriteLine();

            // ===== Insertion Sort =====
            int[] arr1 = { 8, 3, 5, 4, 2, 1 };
            Console.WriteLine("Before InsertionSort: " + string.Join(", ", arr1));
            insertionsort.Sort(arr1); 
            Console.WriteLine("After InsertionSort:  " + string.Join(", ", arr1));
            Console.WriteLine();

            // ===== Binary Search =====
            int[] arr3 = { 1, 3, 4, 5, 6, 7, 8 }; // Must be sorted
            int target = 5;

            int index = binarysearch.Search(arr3, target);

            if (index != -1)
                Console.WriteLine($"Element {target} found at index: {index}");
            else
                Console.WriteLine($"Element {target} not found in the array");

            Console.WriteLine();

            // ===== Optional: Test LinkedList / Stack / Queue / Tree =====
            Console.WriteLine("Choose Test:");
            Console.WriteLine("1 - LinkedList");
            Console.WriteLine("2 - Stack");
            Console.WriteLine("3 - Queue");
            Console.WriteLine("4 - Tree");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    TestLinkedList();
                    break;
                case 2:
                    TestStack();
                    break;
                case 3:
                    TestQueue();
                    break;
                case 4:
                    TestTree();
                    break;
            }
        }

        // ===== LinkedList Test =====
        static void TestLinkedList()
        {
            DoublyLinkedList list = new DoublyLinkedList();

            list.Add(new Employee(1, "Ahmed", 5000));
            list.Add(new Employee(2, "Ali", 6000));
            list.Add(new Employee(3, "Mona", 7000));

            Console.WriteLine("Forward:");
            list.PrintForward();

            Console.WriteLine("Backward:");
            list.PrintBackward();
        }

        // ===== Stack Test =====
        static void TestStack()
        {
            MyStack stack = new MyStack();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine("Pop: " + stack.Pop());
            Console.WriteLine("Peek: " + stack.Peek());

            stack.Print();
        }

        // ===== Queue Test =====
        static void TestQueue()
        {
            MyQueue queue = new MyQueue(5);

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine("Dequeue: " + queue.Dequeue());

            queue.Print();
        }

        // ===== Binary Tree Test =====
        static void TestTree()
        {
            BinaryTree tree = new BinaryTree();

            tree.Insert(10);
            tree.Insert(5);
            tree.Insert(15);
            tree.Insert(3);
            tree.Insert(7);

            Console.WriteLine("InOrder:");
            tree.InOrder();
            Console.WriteLine();

            Console.WriteLine("PreOrder:");
            tree.PreOrder();
            Console.WriteLine();

            Console.WriteLine("PostOrder:");
            tree.PostOrder();
            Console.WriteLine();
        }
    }
}