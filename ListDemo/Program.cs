using System;
using System.Collections.Generic;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> customers = new List<string>();

            customers.Add("Mason");
            customers.Add("Shawn");
            customers.Add("Ben");

            Console.WriteLine($"Count = {customers.Count}");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }

            Console.WriteLine($"customer[1] = {customers[1]}");
        }
    }
}
