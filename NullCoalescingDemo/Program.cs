using System;

namespace NullCoalescingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello";
            string s2 = s1 ?? "default";
            Console.WriteLine(s2);  //hello

            s1 = null;
            s2 = s1 ?? "default";
            Console.WriteLine(s2);  //defaul

            int? i1 = 1;    //nullable int, ?? cannot be used with non-nullable types
            int i2 = i1 ?? 2;
            Console.WriteLine(i2);  //1

            i1 = null;
            i2 = i1 ?? 2;
            Console.WriteLine(i2);  //2
        }
    }
}
