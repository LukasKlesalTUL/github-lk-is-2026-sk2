string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("***** Generátor pseudonáhodných čísel ******");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Načtení vstupů s kontrolou, že uživatel zadal celé číslo
    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte počet znovu: ");
    }

    Console.Write("Zadejte dolní mez (celé číslo): ");
    int dm;
    while (!int.TryParse(Console.ReadLine(), out dm))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
    }

    Console.Write("Zadejte horní mez (celé číslo): ");
    int hm;
    while (!int.TryParse(Console.ReadLine(), out hm))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
    }

    Console.WriteLine();
    Console.WriteLine("============================================");
    Console.WriteLine($"Počet čísel: {n}, dolní mez: {dm}, horní mez: {hm}");
    Console.WriteLine("============================================");

    // Vytvoření pole a generátoru
    int[] myRandNumbs = new int[n];
    Random randomNumber = new Random();

    Console.WriteLine("\nNáhodná čísla:");
    for (int i = 0; i < n; i++)
    {
        myRandNumbs[i] = randomNumber.Next(dm, hm + 1); // hm + 1, aby byla zahrnuta i horní mez
        Console.Write($"{myRandNumbs[i]}; ");
    }

    Console.WriteLine();
    Console.WriteLine("\nPro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();
    
}