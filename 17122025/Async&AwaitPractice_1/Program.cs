//Bài 1: Delay + đo thời gian

//Viết Task WaitAndPrintAsync(int ms)

//In “Start”, await delay, in “Done”

//Gọi 3 lần:

//tuần tự

//concurrent bằng Task.WhenAll

//So sánh tổng thời gian chạy.


using System.Diagnostics;
using System.Text;

namespace Async_AwaitPractice_1
{
    internal class Program
    {
        static async Task WaitAndPrintAsync(int seconds, string msg, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"{msg, 10} ... Start");
            Console.ResetColor();

            for(int i = 0; i < seconds; i++)
            {
                Console.ForegroundColor = color;
                Console.WriteLine($"{msg, 10} {i, 2}");
                Console.ResetColor();
                await Task.Delay(seconds);
            }

        }
        static async Task Main(string[] args)
        {
            Stopwatch sw_t1 = new Stopwatch();
            Stopwatch sw_t2 = new Stopwatch();

            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("==== Chạy tuần tự giữa các task ====");
            Console.ResetColor();

            sw_t1.Start();

            // Chạy tuần tự giữa các task
            await WaitAndPrintAsync(10, "T1", ConsoleColor.Green);
            await WaitAndPrintAsync(5, "T2", ConsoleColor.Magenta);
            await WaitAndPrintAsync(23, "T3", ConsoleColor.Yellow);

            sw_t1.Stop();


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("==== Chạy song song giữa các task ====");
            Console.ResetColor();
            // Chạy song song giữa các task

            sw_t2.Start();

            Task t1 = WaitAndPrintAsync(10, "T1", ConsoleColor.Green);
            Task t2 = WaitAndPrintAsync(5, "T2", ConsoleColor.Magenta);
            Task t3 = WaitAndPrintAsync(23, "T3", ConsoleColor.Yellow);

            await Task.WhenAll(t1, t2, t3);

            sw_t2.Stop();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Tổng thời gian chạy của cả 2 task:");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Task 1: {sw_t1.ElapsedMilliseconds}ms");
            Console.WriteLine($"Task 2: {sw_t2.ElapsedMilliseconds}ms");
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
