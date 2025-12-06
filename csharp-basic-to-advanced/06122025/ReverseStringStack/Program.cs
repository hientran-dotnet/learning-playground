namespace ReverseStringStack
{
    internal class Program
    {
        static string ReverseString(string value)
        {
            // h, e, l, l, o
            Stack<char> chars = new Stack<char>();
            foreach (char c in value)
            {
                chars.Push(c);
            }

            string reverse = string.Empty;
            while (chars.Count > 0)
            {
                reverse += chars.Pop();
            }
            return reverse;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input string:");
            string input = Console.ReadLine();
            string result = ReverseString(input);
            Console.WriteLine(result);
        }
    }
}
