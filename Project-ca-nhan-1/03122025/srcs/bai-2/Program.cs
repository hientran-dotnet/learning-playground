namespace bai_2
{
    internal class Program
    {
        static async Task<int> SumAsync(int[] nums)
        {
            return await Task.Run(() => nums.Sum());
        }

        static async Task Main(string[] args)
        {
            int[] arr = [2, 4, 5];
            var result = await SumAsync(arr);

            Console.WriteLine(result);
        }
    }
}
