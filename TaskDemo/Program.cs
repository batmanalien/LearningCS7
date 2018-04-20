using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begin downloading...\n");
            Download();
            Console.ReadLine(); //Application become responsive and user is able to type in
        }

        static void Download()
        {
            Task.Run(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine("Download Complete\n");
            });
        }
    }
}
