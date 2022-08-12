// See https://aka.ms/new-console-template for more information
using ReverseString;
using System;


namespace MyNewApp
{
    class Program : Utilities
    {
        static void Main(string[] args)
        {

            string value = "Microsoft learn";
            string reversedValue = Reverse(value);
            Console.WriteLine($"The Secret Message \n {reversedValue}");
        }

    }
}
