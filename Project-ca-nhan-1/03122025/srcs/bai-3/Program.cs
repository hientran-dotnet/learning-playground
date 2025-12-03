using System.Security.Cryptography;

namespace bai_3
{
    internal class Program
    {
        static CancellationTokenSource source = new CancellationTokenSource();
        static CancellationToken token = source.Token;
        static async Task DownloadAsync()
        {
            for (int i = 0; i < 10; i++)
            {
                token.ThrowIfCancellationRequested();
                Console.WriteLine($"Downloading...{i + 1}/10");
                await Task.Delay(1000);

                if(i > 2)
                {
                    source.Cancel();
                }
            }
        }

        static async Task Main()
        {
            await DownloadAsync();
        }
    }
}
