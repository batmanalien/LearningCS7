using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begin downloading...\n");
            DownloadAsync();
            Console.ReadLine(); //Application become responsive and user is able to type in
        }

        static async void DownloadAsync()
        {
            HttpClient client = new HttpClient();
            var data = await client.GetStringAsync("http://www.infoworld.com/");
            Thread.Sleep(5000);
            Console.WriteLine(data + "\nDownload Complete\n");
        }
    }
}
