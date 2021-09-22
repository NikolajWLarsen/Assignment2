using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new ImmutableStudent(1234);
            
            Console.WriteLine(s.ToString());
        }
    }
}
