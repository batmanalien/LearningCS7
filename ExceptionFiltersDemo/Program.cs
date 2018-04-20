using System;

namespace ExceptionFiltersDemo
{
    class Program
    {
        class PersonException : Exception
        {
            public PersonException(string name)
            {
                Name = name;
            }

            public string Name { get; private set; }
        }
        static void Main(string[] args)
        {
            try
            {
                throw new PersonException("Bob");
                throw new PersonException("Kim");
            }
            //catch (PersonException ex)
            //{
            //    if (ex.Name == "Kim")
            //        Console.WriteLine("It's from Kim, let's ignore it");
            //    if (ex.Name == "Bob")
            //        Console.WriteLine("It's from Bob, let's do something");
            //}
            //The following catch blocks is equivalent to the catch block above
            catch (PersonException ex) when (ex.Name == "Kim")
            {
                Console.WriteLine("It's from Kim, let's ignore it");
            }
            catch (PersonException ex) when (ex.Name == "Bob")
            {
                Console.WriteLine("It's from Bob, let's do something");
            }
        }
    }
}
