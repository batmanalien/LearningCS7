using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;

namespace ConcurrentDictionaryDemo
{
    class Program
    {
        static Dictionary<int, int> itemsThreadNotSafe = new Dictionary<int, int>();
        static ConcurrentDictionary<int, int> itemsThreadSafe = new ConcurrentDictionary<int, int>();

        static void Main(string[] args)
        {
            ThreadSafeExecute();
            ThreadNotSafeExecute(); //This will throw an exception saying a key already exisits
        }

        private static void ThreadSafeExecute()
        {
            Thread thread1 = new Thread(new ThreadStart(AddItemThreadSafe));
            Thread thread2 = new Thread(new ThreadStart(AddItemThreadSafe));

            thread1.Start();
            thread2.Start();

            Console.WriteLine($"Count = {itemsThreadSafe.Count}");
        }

        static void AddItemThreadSafe()
        {
            itemsThreadSafe.TryAdd(1, 1);
        }

        private static void ThreadNotSafeExecute()
        {
            Thread thread1 = new Thread(new ThreadStart(AddItemThreadNotSafe));
            Thread thread2 = new Thread(new ThreadStart(AddItemThreadNotSafe));

            thread1.Start();
            thread2.Start();

            Console.WriteLine($"Count = {itemsThreadNotSafe.Count}");
        }

        static void AddItemThreadNotSafe()
        {
            itemsThreadNotSafe.Add(1, 1);
        }
    }
}
