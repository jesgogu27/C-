string[] idenficator = { "B123", "C243", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach(string i in idenficator)
{
    if (i.StartsWith("B"))
    {
        Console.WriteLine(i);
    }
}