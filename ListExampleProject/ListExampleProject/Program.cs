// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<string> tacoShoppingList = new List<string>();

tacoShoppingList.Add("Cinco  Tacos de Suadero");
tacoShoppingList.Add("Cuatro Tacos de Tripa");
tacoShoppingList.Add("Cinco  Tacos de Pastor");
tacoShoppingList.Add("Cuatro Coca-Cola's");

for (int i = 0; i < tacoShoppingList.Count; i++)
{
    Console.WriteLine(tacoShoppingList[i]);
}

tacoShoppingList.Remove("Cinco  Tacos de Suadero");
tacoShoppingList.RemoveAt(0);

Console.WriteLine("\n");


for (int i = 0; i < tacoShoppingList.Count; i++)
{
    Console.WriteLine(tacoShoppingList[i]);
}