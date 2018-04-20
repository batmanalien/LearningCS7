using System;

namespace TupleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //use constructor to create a tuple
            var tuple1 = new Tuple<int, string, bool>(1, "Hello", true);
            Console.WriteLine($"item1 = {tuple1.Item1}");
            Console.WriteLine($"item2 = {tuple1.Item2}");
            Console.WriteLine($"item3 = {tuple1.Item3}");

            //Use static method create to create a tuple
            var tuple2 = Tuple.Create(1, "Hello", true);
            Console.WriteLine($"item1 = {tuple2.Item1}");
            Console.WriteLine($"item2 = {tuple2.Item2}");
            Console.WriteLine($"item3 = {tuple2.Item3}");
        }
    }
}
