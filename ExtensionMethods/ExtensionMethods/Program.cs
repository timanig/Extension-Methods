using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = "Hello World";

            Console.WriteLine($"If {x} is two words print " +
                $"true else print false: {x.IsTwoWords()} ");
        }
    }
}
