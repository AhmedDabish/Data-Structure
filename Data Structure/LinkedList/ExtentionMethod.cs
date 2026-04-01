using System;

namespace Data_Structure.LinkedList
{
    public static class ExtensionMethods
    {
        public static void PrintList(this ILinkedList list)
        {
            ListNode current = list.GetHead();

            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }

        public static int CountNode(this ILinkedList list)
        {
            int count = 0;
            ListNode current = list.GetHead();

            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }
    }
}