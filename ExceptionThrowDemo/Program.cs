using System;

namespace ExceptionThrowDemo
{
    class Program
    {
        class Person
        {
            private string name;

            public string Name
            {
                get { return name; }
                set
                {
                    try
                    {
                        if (value == null)
                            throw new NullReferenceException("name must have a value"); //throw our own exception with custom message
                        name = value;
                    }
                    catch (Exception)   //This catch will be executed first
                    {
                        Console.WriteLine("name can not be null");
                        throw;  //if this is commented out, only the above catch will be executed. throw will proxy the exception up the chain, then both catches will be executed
                    }

                }
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Person person = new Person();
                person.Name = null;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
