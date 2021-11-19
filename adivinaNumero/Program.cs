//permite al usuario adivinar el número

using System;

namespace adivinaNumero
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hola Advinina el número que estoy pensado!!! \n");
            PideNumero();

        }

        static void PideNumero()
        {
            int n = 0, cont=0;

            Random num = new Random();
            int aleatorio = num.Next(1, 100);
            
            Console.WriteLine("Ingrese Número: ");
           
            while (n != aleatorio)
            {
                cont++;
                n = int.Parse(Console.ReadLine());
                if (n > aleatorio) Console.WriteLine("Ingresa un número menor");
                if (n < aleatorio) Console.WriteLine("Ingrese un número mayor");
            }
            Console.WriteLine($"Lo intentaste {cont} veces, y lo has logrado" );
        }
    }
}