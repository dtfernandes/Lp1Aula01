using System;

namespace OlaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nome: ");
            string c = Console.ReadLine();
            Console.WriteLine($"Hello {c}!", c);

            Console.WriteLine($"Bye {c}", c);
        }
    }
}
