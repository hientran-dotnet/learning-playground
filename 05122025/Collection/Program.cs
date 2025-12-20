using System.Collections;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Collection - List<T>
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6};

            Console.WriteLine(string.Join(", ", numbers));

            // Dictionary<TKey, TValue>
            Dictionary<string, int> studentScores = new Dictionary<string, int>()
            {
                {"Alice", 90},
                {"Bob", 85},
                {"Charlie", 92  }
            };
            Console.WriteLine($"Student Scores: {studentScores["Alice"]}");

            // ArrayList
            ArrayList list = new ArrayList() { 1, "hello", true };
            list.Add(3.14);
            Console.WriteLine(string.Join(", ", list.Cast<object>()));

            // Hashtable
            Hashtable hashtable = new Hashtable()
            {
                {"Alice", 80},
                {"Bob", 75},
                {"Charlie", 88}
            };
            Console.WriteLine($"Hashtable - Bob's score: {hashtable["Bob"]}");
        }
    }
}
