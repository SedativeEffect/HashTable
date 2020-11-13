using System;
using System.Text;

namespace task1
{
    class Solver
    {
        private static void Main(string[] args)
        {
            var N = Convert.ToInt32(Console.ReadLine());
            var tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var table = new HashTable(N);
            foreach (var t in tokens)
            {
                table.Insert(Convert.ToInt32(t));
            }

            for (var i = 0; i < table.Values.Length; i++)
            {
                var elements = GetElementsString(table.Values[i]);
                Console.WriteLine($"{i}: {elements}");
            }
        }

        private static string GetElementsString(ListNode node)
        {
            var sb = new StringBuilder();
            var current = node;
            while (current.Next != null)
            {
                sb.Append($"{current.Value}\t");
                current = current.Next;
            }

            return sb.ToString();
        }
    }
}
