using System;
using System.IO;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Hello {args[0]}!");
            string[] files = Directory.GetFiles("./", "*.json", SearchOption.AllDirectories);
            foreach (var file in files) {
                Console.WriteLine(file);
            }
        }
    }
}
