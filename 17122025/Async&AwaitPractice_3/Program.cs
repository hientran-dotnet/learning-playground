//Download nhiều URL

//Input: danh sách 10 URL

//Output: độ dài HTML mỗi trang

//Yêu cầu:

//bản 1: tuần tự

//bản 2: song song WhenAll

//in thời gian chạy



using System.Diagnostics;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Async_AwaitPractice_3
{
    internal class Program
    {
        static async Task<double> GetWebAsync(string url)
        {
            Stopwatch sw = Stopwatch.StartNew();
            HttpClient client = new HttpClient();
            HttpResponseMessage rs = await client.GetAsync(url);
            string content = await rs.Content.ReadAsStringAsync();
            //Console.WriteLine(content);
            sw.Stop();

            return content.Length;
        }

        static async Task Main(string[] args)
        {
            List<string> url = new List<string>()
            {
                "https://www.google.com/",
                "https://www.youtube.com/",
                "https://www.facebook.com/",
                "https://www.instagram.com/",
                "https://chatgpt.com/"
            };

            Stopwatch sw = new Stopwatch();
            List<double> time = new List<double>();
            List<double> lenghtOfHtml = new List<double>();

            sw.Start();
            foreach (var item in url)
            {
                
                double lenght = await GetWebAsync(item);
                lenghtOfHtml.Add(lenght);
            }
            sw.Stop();

            Console.WriteLine($"TIME TAKEN OF ASYNC: {sw.ElapsedMilliseconds}");
            sw.Reset();

            foreach(var items in lenghtOfHtml)
            {
                Console.WriteLine("Lenght of HTML");
                Console.WriteLine(items);
            }

            List<Task<double>> t = new List<Task<double>>();

            sw.Start();

            foreach (var item in url)
            {
                t.Add(GetWebAsync(item));
            }

            double[] arr_lenght = await Task.WhenAll(t);

            sw.Stop();

            Console.WriteLine($"TIME TAKEN OF CONCURRENT: {sw.ElapsedMilliseconds}");

            Console.WriteLine("Lenght of HTML");
            foreach(var i in arr_lenght)
            {
                Console.WriteLine(i);
            }
        }
    }
}
