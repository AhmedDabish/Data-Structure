namespace Data_Structure.LinkedList
{
    public class ListNode
    {
        public Employee Data { get; set; }
        public ListNode Next { get; set; }
        public ListNode Prev { get; set; }

        public ListNode(Employee data)
        {
            Data = data;
        }
    }
}