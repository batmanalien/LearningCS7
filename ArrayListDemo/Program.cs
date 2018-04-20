using System;
using System.Collections;

namespace ArrayListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList is not generic, deprecated and replaced by generic List
            ArrayList list = new ArrayList();
            list.Add("Hello");  //automatically boxing, converting string into object
            list.Add(1);
            list.Add(true);

            string s = (string)list[0]; //unboxing
            Console.WriteLine($"list[0] = {s}");

            int i = (int)list[1]; //unboxing
            Console.WriteLine($"list[1] = {i}");

            bool b = (bool)list[2]; //unboxing
            Console.WriteLine($"list[2] = {b}");

            foreach (var item in list)
            {
                Console.WriteLine($"item = {item}");    //automatically use object.ToString()
            }
        }
    }
}
