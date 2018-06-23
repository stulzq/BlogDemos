using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AsyncConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();
            var result = await client.GetStringAsync("https://www.baidu.com/");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
