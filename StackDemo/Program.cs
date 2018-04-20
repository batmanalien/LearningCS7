using System;
using System.Collections.Generic;

namespace StackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("one");
            stack.Push("two");
            stack.Push("three");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"stack.Pop() = {stack.Pop()}");  //pops the top item from the stop (remove top item)
            Console.WriteLine($"stack.Peek() = {stack.Peek()}");    //peek returns the top item from the stack (not remove top item)
            Console.WriteLine($"stack.Peek() = {stack.Peek()}");
        }
    }
}
