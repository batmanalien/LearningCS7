using System;

namespace StringInterpolationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new { x = 1.1234, y = 2.5678};

            Console.WriteLine("x: " + point.x + " y: " + point.y);
            Console.WriteLine("x: {0}, y: {1}", point.x, point.y);
            //string formatters 10 spaces after the number and limit to 1 decimal
            Console.WriteLine($"x: {point.x}, y: {point.y,10:N1}");
        }
    }
}
