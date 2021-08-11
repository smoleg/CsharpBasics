using System;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace lesson5_10._08._21
{
    class Program
    {
        static void Main()
        {
            string[] urls =
            {
                @"https://vk.com",
                @"https://ya.ru",
                @"https://google.com"
            };

            HttpClient client = new HttpClient();

            foreach (var url in urls)
            {
                var req = client.GetStringAsync(url).Result;

                int posStart = req.IndexOf("<title>") + "<title>".Length;
                int posEnd = req.IndexOf("</title>");
                int lenght = posEnd - posStart;

                var res = req.Substring(posStart, lenght);
                Console.WriteLine(res);
            }
            Console.ReadKey();
        }
    }
}
