using System.Threading.Tasks;

namespace bai_1
{
    public class Program
    {
        static async Task DeplayPrintAsync()
        {
            await Task.Delay(2000);
            Console.WriteLine("Done");
        }

        static void Main(string[] args)
        {
            DeplayPrintAsync().Wait();
        }
    }
}
