// Program.cs pro program002a
string again = "a";

while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("***********************************");
    Console.WriteLine("**** Ciferný součet a součin ******");
    Console.WriteLine("***********************************");
    Console.WriteLine();

    Console.Write("Zadejte celé číslo: ");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte ho znovu: ");
    }

    int numberBackup = number; 
    int sum = 0;               // Neutrální prvek pro sčítání
    int product = 1;           // Neutrální prvek pro násobení
    int digit;                 

    if (number < 0)
    {
        number = -number; // Převod na kladné číslo
    }

    if (number == 0)
    {
        sum = 0;
        product = 0; // Pokud je číslo 0, součin je 0
    }
    else
    {
        Console.WriteLine("\nPrůběh rozkladu čísla na cifry:");
        while (number > 0)
        {
            digit = number % 10;            
            sum = sum + digit;              
            product = product * digit; // Přidáno: násobení cifer

            Console.WriteLine($"Získána cifra: {digit}");

            number = number / 10;           
        }
    }

    Console.WriteLine("\n====================================");
    Console.WriteLine($"Původní číslo:   {numberBackup}");
    Console.WriteLine($"Ciferný součet:  {sum}");
    Console.WriteLine($"Ciferný součin:  {product}");
    Console.WriteLine("====================================\n");

    Console.Write("Pro opakování stiskněte 'a' a potvrďte Enter: ");
    again = Console.ReadLine() ?? "";
}