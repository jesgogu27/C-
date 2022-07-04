Random aleatorio =  new Random();
int discountPercentage = 0;
int daysUntilExpiration = 0;

while (Console.ReadKey().Key != ConsoleKey.Enter)
{
    daysUntilExpiration = aleatorio.Next(12);
    Console.WriteLine($"\n{daysUntilExpiration}");

    if (daysUntilExpiration == 0)

    {
        Console.WriteLine("Your subscription has expired.");
    } else if (daysUntilExpiration == 1)
    {
        discountPercentage = 20;
        Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercentage}%!");
    } else if (daysUntilExpiration <= 5)
    {
        discountPercentage = 10;
        Console.WriteLine($"Your subscription expires  in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%");
    } else if (daysUntilExpiration <= 10)
    {
        Console.WriteLine("Your subscription will expire soon. Renew now!");
    }
Console.Write("\nPress <Enter> to exit... ");
}



