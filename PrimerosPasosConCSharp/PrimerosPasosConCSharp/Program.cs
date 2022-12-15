public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese Nombre: ");
        string nombre = Console.ReadLine();

        Console.WriteLine("Ingrese Ciudad: ");
        string city = Console.ReadLine();

        Console.WriteLine($"Hola {nombre}, Bienvenido a {city}");
    }
}