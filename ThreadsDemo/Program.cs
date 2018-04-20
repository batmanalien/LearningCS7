using System;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 50; i++)
            {
                //Manually start the threads at the same time. This can cause system to lag
                Thread thread = new Thread(new ThreadStart(Work));
                thread.Start();

                //Threads can be reused by using tasks, tasks are managed by the thread pool while manual threads give us more control
                //For most devevelopment needs, tasks are the ideal choice
                Task.Run(() =>
                {
                    Console.WriteLine("Thread Task Id: " + Thread.CurrentThread.ManagedThreadId);
                    Thread.Sleep(3000);
                    Console.WriteLine("Thread Task Complete");
                });
            }

            Console.ReadLine();
        }

        private static void Work()
        {
            Console.WriteLine("Thread Id: " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(3000);
            Console.WriteLine("Thread Complete");
        }
    }
}
