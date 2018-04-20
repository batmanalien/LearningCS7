using System;
using System.Collections.Generic;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> config = new Dictionary<string, string>();

            config.Add("resolution", "1920x1080");
            config.Add("title", "MyWebSite");
            //key must be unique, adding the following line will throw an exception
            //config.Add("title", "MyWebSite");

            Console.WriteLine($"config[\"title\"] = {config["title"]}");

            foreach (var setting in config)
            {
                Console.WriteLine($"setting.Key = {setting.Key}, setting.Value = {setting.Value}");
            }
        }
    }
}
