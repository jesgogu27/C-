using System;

namespace ConsoleApp1
{
    internal class Program
    {
        public void Nevera(string codigo, int dinero)
        {
            switch (codigo)
            {
                case "1":
                    Console.WriteLine("Su Coca-Cola está servida. \n");
                    int vuelto = dinero - 2000;
                    Console.WriteLine("Cambio: " + vuelto);
                    break;
            }


        }
        static void Main()
        {

            Program dispensador1 = new Program();



            int dinero1;
            String n;


            Console.Write("Ingrese Letra: ");
            n = Console.ReadLine();



            Console.Write("Ingrese dinero: ");
            dinero1 = Convert.ToInt32(Console.ReadLine());



            dispensador1.Nevera(n, dinero1);
        }
    }
}

