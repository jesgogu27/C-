using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Todo bien");
            string name = "Jesus Gonzalez";
            int age = 38;
            DateTime today = DateTime.Today;

            String msg = $"Mi nombre es {name}  y tengo {age} de edad. {today}";

            Console.Write(msg);
            Console.ReadKey();
        }
    }
}
