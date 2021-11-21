// get a name and return a cheers

using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Name");
            print();
            Console.WriteLine("Please, press any Key for finalice");
            System.Console.ReadKey();
        }
        static void print()
        {

            string name = Console.ReadLine();
            Console.WriteLine($"Hello:  {name}");
        }
    }
}
