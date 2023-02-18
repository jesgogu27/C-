/*
 *provando la clase Directory  y sus metodos principales
 */
internal class Program
{
    private static void Main(string[] args)
    {
        //Directory into a specific Directory
        string pathDirectory = @"C:\stores\201";
        IEnumerable<string> listOfDirectories = Directory.EnumerateDirectories(pathDirectory);

        foreach (string directory in listOfDirectories)
        {
            Console.WriteLine(directory);
        }

        Console.WriteLine("\n");

        //files into a specific directory
        IEnumerable<string> listOfFiles = Directory.EnumerateFiles(pathDirectory);
        Console.WriteLine("Debe imprimir los files");
        foreach (string file in listOfFiles)
        {
            Console.WriteLine(file);
        }

        Console.WriteLine("\n");

        IEnumerable<string> allFilesInAFolders = Directory.EnumerateFiles(pathDirectory, "sales.json",SearchOption.AllDirectories);
        foreach (string file in allFilesInAFolders)
        {
            Console.WriteLine(file);
        }
    }
}