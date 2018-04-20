using System;
using System.Threading;
using System.Threading.Tasks;

namespace CallBackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begin downloading...\n");
            Download((message) => Console.WriteLine("\nDownload complete " + message));
            Console.ReadLine(); //Application become responsive and user is able to type in
        }

        static void Download(Action<string> callback)
        {
            Task.Run(() =>
            {
                Thread.Sleep(5000);
                callback("yay!");
            });
        }
    }
}
