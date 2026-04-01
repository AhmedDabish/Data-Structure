namespace Data_Structure.LinkedList
{
    public class ForwardLinkedList : ILinkedList
    {
        private ListNode head;

        public ListNode GetHead()
        {
            return head;
        }

        public void AddNode(Employee emp)
        {
            ListNode newNode = new ListNode(emp);

            if (head == null)
                head = newNode;
            else
            {
                ListNode current = head;
                while (current.Next != null)
                    current = current.Next;

                current.Next = newNode;
            }
        }
    }
}