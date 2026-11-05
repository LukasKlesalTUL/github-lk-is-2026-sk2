// Program.cs pro program002b (Alternativní řešení přes textový řetězec)
string again = "a";

while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("***********************************");
    Console.WriteLine("**** Ciferný součet a součin ******");
    Console.WriteLine("********* (Přes String) ***********");
    Console.WriteLine("***********************************\n");

    Console.Write("Zadejte celé číslo: ");
    string input = Console.ReadLine() ?? "";
    
    // Odstranění znaménka mínus, pokud tam je (aby nás při čtení znaků nerušilo)
    input = input.Replace("-", "");

    int sum = 0;
    int product = 1;

    // Pokud uživatel zadal nulu, rovnou nastavíme součin na 0
    if (input == "0")
    {
        product = 0;
    }

    // Cyklus projde každý znak v textu zleva doprava
    foreach (char c in input)
    {
        // Převedení znaku (char) zpět na číslo. 
        // Znak '0' odpovídá v ASCII tabulce hodnotě 48. Odečtením '0' získáme čistou číselnou hodnotu.
        int digit = c - '0'; 
        
        sum += digit;
        product *= digit;
        
        Console.WriteLine($"Získána cifra: {digit}");
    }

    Console.WriteLine("\n====================================");
    Console.WriteLine($"Ciferný součet:  {sum}");
    Console.WriteLine($"Ciferný součin:  {product}");
    Console.WriteLine("====================================\n");

    Console.Write("Pro opakování stiskněte 'a' a potvrďte Enter: ");
    again = Console.ReadLine() ?? "";
}