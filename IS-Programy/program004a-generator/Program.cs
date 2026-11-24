string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("***** Generátor pseudonáhodných čísel ******");
    Console.WriteLine("********************************************");
    Console.WriteLine();

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

    // Proměnné pro počítání
    int kladna = 0;
    int zaporna = 0;
    int nulova = 0;
    int suda = 0;
    int licha = 0;

    Console.WriteLine("\nNáhodná čísla:");
    for (int i = 0; i < n; i++)
    {
        myRandNumbs[i] = randomNumber.Next(dm, hm + 1);
        Console.Write($"{myRandNumbs[i]}; ");

        // Zjištění kladných, záporných a nulových čísel
        if (myRandNumbs[i] > 0)
        {
            kladna++;
        }
        else if (myRandNumbs[i] < 0)
        {
            zaporna++;
        }
        else
        {
            nulova++;
        }

        // Zjištění sudých a lichých čísel
        if (myRandNumbs[i] % 2 == 0)
        {
            suda++;
        }
        else
        {
            licha++;
        }
    }

    Console.WriteLine("\n");
    Console.WriteLine("============================================");
    Console.WriteLine($"Počet kladných čísel:  {kladna}");
    Console.WriteLine($"Počet záporných čísel: {zaporna}");
    Console.WriteLine($"Počet nulových čísel:  {nulova}");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine($"Počet sudých čísel:    {suda}");
    Console.WriteLine($"Počet lichých čísel:   {licha}");
    Console.WriteLine("============================================");

    Console.WriteLine("\nPro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();
}