//Bài 2: Async Main + exception

//Tạo Task<int> DivideAsync(int a, int b)

//Nếu b==0 throw

//Bắt exception ở Main bằng try/catch.


namespace Async_AwaitPractice_2
{
    internal class Program
    {
        static async Task<int> DivideAsync(int a, int b)
        {
            await Task.Delay(500);
            return a / b;
        }

        static async Task Main(string[] args)
        {
            try
            {
                int result = await DivideAsync(10, 2);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
