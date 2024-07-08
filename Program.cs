using System;

namespace MyConsoleApp
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Sample Data in Console App Jenkins-TEST");

            // Sample data
            var names = new string[] {  "Chandan","Suraj","Pankaj", "Karan" };

            foreach (var name in names)
            {
                Console.WriteLine($"Hello, {name}!");
            }
        }
    }
}
