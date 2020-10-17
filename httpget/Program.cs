using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClientEx
{
    class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient req = new HttpClient();
            //req.
            var content = await req.GetAsync("https://httpbin.org/get");
            Console.WriteLine(await content.Content.ReadAsStringAsync());
            Console.WriteLine(content.StatusCode);

        }
    }
}