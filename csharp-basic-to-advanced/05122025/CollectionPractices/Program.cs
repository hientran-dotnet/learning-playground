using System.Collections;
using System.Diagnostics;

namespace CollectionPractices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bài 1:
            List<string> students = new List<string>() { "Alice", "Bob", "Mary", "Peter", "Jack", "Lamvie" };
            students.Add("David");
            Console.WriteLine("List students after add: ");
            Console.WriteLine(string.Join(", ", students));

            // Xóa theo tên
            students.Remove("Bob");
            Console.WriteLine("List students after remove \"Bob\"");
            Console.WriteLine(string.Join(", ", students));

            // Xóa theo index
            students.RemoveAt(2);
            Console.WriteLine("List students after remove value at index 2");
            Console.WriteLine(string.Join(", ", students));

            // Search tên trong list
            string searchName = "Jack";
            if (students.Contains(searchName))
            {
                Console.WriteLine($"{searchName} is exits");
            }
            else
            {
                Console.WriteLine($"{searchName} is not exits");
            }

            Console.WriteLine("\n\n\n\n\n");


            // Bài 2:
            Dictionary<string, int> studentScores = new Dictionary<string, int>()
            {
                { "Hien", 10 },
                { "Huy", 0 },
                { "Hung", 7 },
                { "Phuong", 9 }
            };

            Console.WriteLine("List students have mark greater than 8: ");
            foreach (var student in studentScores)
            {
                if(student.Value > 8)
                {
                    Console.WriteLine($"{student.Key}: {student.Value}");
                }
            }

            // Bài 3:
            const int itemCount = 1000000;
            
            ArrayList arrayList = new ArrayList();

            for(int i = 0; i < itemCount; i++)
            {
                arrayList.Add(i);
            }

            List<int> list = new List<int>();

            for (int i = 0; i < itemCount; i++)
            {
                list.Add(i);
            }

            Stopwatch stopwatch = Stopwatch.StartNew();

            foreach (int item in arrayList)
            {
                int temp = item;
            }
            stopwatch.Stop();
            Console.WriteLine($"Time spend: {stopwatch.ElapsedMilliseconds}");

            stopwatch.Restart();

            foreach (int item in list)
            {
                int temp = item;
            }
            stopwatch.Stop();
            Console.WriteLine($"Time spend: {stopwatch.ElapsedMilliseconds}");
        }
    }
}
