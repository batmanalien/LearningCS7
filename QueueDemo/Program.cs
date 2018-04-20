using System;
using System.Collections.Generic;

namespace QueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(queue.Dequeue()); //remove 1st item from the queque
            Console.WriteLine(queue.Peek());    //return 1st item from the queque (not remove)
            Console.WriteLine(queue.Peek());    //return 1st item from the queque (not remove)
        }
    }
}
