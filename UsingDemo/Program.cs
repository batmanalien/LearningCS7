using System;

namespace UsingDemo
{
    class Program
    {
        //implment the IDisposalbe interface to make the resource disposable
        class MyResource : IDisposable
        {
            public void Dispose()
            {
                Console.WriteLine("Disposing our resource");
            }
        }

        static void Main(string[] args)
        {
            using (MyResource resource = new MyResource())
            {
                Console.WriteLine("Using my resource");
            }
            Console.WriteLine("Finished");
        }
    }
}
