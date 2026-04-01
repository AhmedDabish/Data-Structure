using System;

namespace Data_Structure.LinkedList
{
    public class DoublyLinkedList
    {
        private ListNode head;

        public void Add(Employee emp)
        {
            ListNode newNode = new ListNode(emp);

            if (head == null)
            {
                head = newNode;
                return;
            }

            ListNode temp = head;
            while (temp.Next != null)
                temp = temp.Next;

            temp.Next = newNode;
            newNode.Prev = temp;
        }

        public void PrintForward()
        {
            ListNode temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.Data.Name);
                temp = temp.Next;
            }
        }

        public void PrintBackward()
        {
            ListNode temp = head;
            if (temp == null) return;

            while (temp.Next != null)
                temp = temp.Next;

            while (temp != null)
            {
                Console.WriteLine(temp.Data.Name);
                temp = temp.Prev;
            }
        }
    }
}