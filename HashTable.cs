namespace task1
{
    public class HashTable
    {
        private readonly int _n;

        public ListNode[] Values;

        public void Insert(int newValue)
        {
            var hash = newValue % _n;
            Values[hash].Insert(newValue);
        }

        public HashTable(int n)
        {
            _n = n;

            Values = new ListNode[n];
            for (var i = 0; i < n; i++)
            {
                Values[i] = new ListNode();
            }
        }
    }
}