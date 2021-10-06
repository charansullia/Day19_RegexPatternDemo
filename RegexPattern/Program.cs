using System;

namespace RegexPattern
{
    class Program
    {
        static void Main(string[] args)
        {
           RegexPattern pattern = new RegexPattern();
            Console.WriteLine(pattern.ValidatePattern("Charan"));
            Console.ReadKey();
        }
    }
}
