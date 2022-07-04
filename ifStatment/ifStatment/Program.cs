// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//int anyValue = 6;
//string msg = "";

//if (anyValue != 6)
//{
//    msg = "El numero no es 6";
//    Console.WriteLine(msg);
//} else
//{
//    msg = "El número es 6";
//    Console.WriteLine(msg);
//}


class Dispensador {
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

        Dispensador dispensador1 = new Dispensador();

        
        
        int dinero1;
        char n;


        Console.Write("Ingrese Letra: ");
        n = Convert.ToChar(Console.ReadLine());



        Console.Write("Ingrese dinero: ");
        dinero1 = Convert.ToInt32(Console.ReadLine());



        dispensador1.Nevera( n, dinero1);
    }
}