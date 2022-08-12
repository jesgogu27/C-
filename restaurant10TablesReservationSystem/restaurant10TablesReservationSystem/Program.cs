// See https://aka.ms/new-console-template for more information

using System;

/*
 * 1. validar si el usuario existe o no
 * 2. el programa debe dar bienvenida al uuario existente si eest eexite
 * 3. el programa debe repetirse hasta que se llene 10 peronas
 */

namespace restaurant10TablesReservation
{ 
    class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = new string[10]{"miguel", "", "","","","","","","","" };
            int arraryCurrentIndex = 1;
            bool userType;

            Console.WriteLine("Welcome to the best restaurant in the world!");

            while (true)
            {
                Console.WriteLine("Are you are a register user? Write true, or write false to register ");
                userType =  Convert.ToBoolean(Console.ReadLine());
                
            }
        }
    }
}