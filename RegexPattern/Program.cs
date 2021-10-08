using System;

namespace RegexPattern
{
    class Program
    {
        static void Main(string[] args)
        {
           RegexPattern pattern = new RegexPattern();
            Console.WriteLine(pattern.ValidatePattern("91 9876543200"));
            Console.ReadKey();
        }
    }
}
