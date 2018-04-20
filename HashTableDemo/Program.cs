using System;
using System.Collections;

namespace HashTableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hashtable is not generic, deprecated and replaced by generic Dictionary
            Hashtable table = new Hashtable();
            table.Add("title", "MyWebSite");

            string s = (string)table["title"];
            Console.WriteLine($"table[\"title\"] = {s}");
        }
    }
}
