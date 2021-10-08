using System;

namespace RegexPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RegexPattern pattern = new RegexPattern();
            Console.WriteLine(pattern.ValidatePattern("abc.xyz@bl.co.in"));
            Console.WriteLine(pattern.ValidatePattern("abc-100@yahoo.com"));
            Console.WriteLine(pattern.ValidatePattern("abc..2002@gmail.com"));
            Console.WriteLine(pattern.ValidatePattern("abc()*@gmail.com"));
            Console.WriteLine(pattern.ValidatePattern("abc+100@gmail.com"));
            Console.WriteLine(pattern.ValidatePattern("abc@1.com"));
            Console.WriteLine(pattern.ValidatePattern("abc.100@abc.com.au"));
            Console.WriteLine(pattern.ValidatePattern("abc111@abc.com"));
            Console.WriteLine(pattern.ValidatePattern("abc-100@abc.net"));
            Console.WriteLine(pattern.ValidatePattern("abc@gmail.com.1a"));
            Console.WriteLine(pattern.ValidatePattern("abc@%*.com"));
            Console.WriteLine(pattern.ValidatePattern("abc@abc@gmail.com"));
            Console.ReadKey();
        }
    }
}
