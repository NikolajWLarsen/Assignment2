using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new ImutableStudent(1234);
            
            Console.WriteLine(s.ToString());
        }
    }
}
