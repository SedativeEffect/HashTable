namespace task1
{
    public class ListNode
    {
        public int Value { get; set; }
        public ListNode Next { get; set; }
        private static readonly ListNode _defaultNode = new ListNode();

        public void Insert(int newValue)
        {
            if (Next == null)
            {
                Value = newValue;
                Next = _defaultNode;
            }
            else
            {
                var toAdd = new ListNode
                {
                    Value = newValue,
                    Next = _defaultNode
                };

                var current = this;
                while (current.Next != _defaultNode)
                {
                    current = current.Next;
                }

                current.Next = toAdd;
            }
        }
    }
}