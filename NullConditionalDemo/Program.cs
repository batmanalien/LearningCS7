using System;

namespace NullConditionalDemo
{
    class Program
    {
        class Person
        {
            public string Name { get; set; }
        }
        static void Main(string[] args)
        {
            Person person1 = new Person() { Name = "Mason" };
            Console.WriteLine("person1.Name: " + person1.Name);

            //Person person2 = null;
            //Console.WriteLine(person2.Name);  //This will crash

            Person person2 = null;
            if (person2 != null)
                Console.WriteLine("person2.Name: " + person2.Name);

            //same as person2 above
            Person person3 = null;
            Console.WriteLine("person3.Name: " + person3?.Name);

            //nested null conditial operator
            Person person4 = new Person() { Name = "Mason" }; ;
            Console.WriteLine("person4.Name.Length: " + person4?.Name.Length);

            //nested null conditial operator
            //Person person5 = new Person();
            //Console.WriteLine("person5.Name.Length: " + person5?.Name.Length);  //This will crash

            //nested null conditial operator
            Person person6 = new Person();
            Console.WriteLine("person6.Name.Length: " + person6?.Name?.Length);

            //combine null conditial and coalesc operator
            Person person7 = new Person();
            Console.WriteLine("person7.Name.: " + (person7?.Name ?? "Unknown"));
        }
    }
}
