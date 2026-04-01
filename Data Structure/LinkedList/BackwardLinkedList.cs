namespace Data_Structure.LinkedList
{
    public class BackwardLinkedList : ILinkedList
    {
        private ListNode tail;

        public ListNode GetHead()
        {
            return tail;
        }

        public void AddNode(Employee emp)
        {
            ListNode newNode = new ListNode(emp);

            if (tail == null)
                tail = newNode;
            else
            {
                tail.Next = newNode;
                newNode.Prev = tail;
                tail = newNode;
            }
        }
    }
}