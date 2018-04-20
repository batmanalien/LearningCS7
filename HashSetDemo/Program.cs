using System;
using System.Collections.Generic;

namespace HashSetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //hash s
            HashSet<string> hashSet = new HashSet<string>();
            hashSet.Add("hello");
            hashSet.Add("hello");   //duplicate will not be added to the hashset

            string[] s1 = new string[] {"hello"};
            string[] s2 = new string[] {"world"};
            Console.WriteLine($"hashSet.Count = {hashSet.Count}");

            //determins if the hashset share common elements with another collection
            Console.WriteLine($"hashSet.Overlaps(s1) = {hashSet.Overlaps(s1)}");
            Console.WriteLine($"hashSet.Overlaps(s2) = {hashSet.Overlaps(s2)}");
        }
    }
}
