using System;

namespace RegexPattern
{
    class Program
    {
        static void Main(string[] args)
        {
           RegexPattern pattern = new RegexPattern();
            Console.WriteLine(pattern.ValidatePattern("Bridgelabz@1234"));
            Console.ReadKey();
        }
    }
}
