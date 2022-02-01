using System;

namespace HelloGitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie Ihren Nachnamen ein.");

            var name = Console.ReadLine();

            Console.WriteLine("Hallo " + name);
        }
    }
}
