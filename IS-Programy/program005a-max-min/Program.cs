Console.Clear();
string again = "a";
// .ToLower() převede vstup na malá písmena, takže program bude pokračovat při zadávání "a" tak i "A"
while (again.ToLower() == "a")
{
    Console.WriteLine();
    Console.Clear();
    Console.WriteLine("******************************************");
    Console.WriteLine("**** Maximum, minimum a přesýpací hodiny **");
    Console.WriteLine("******************************************");
    Console.WriteLine("************** Lukáš Klesal ***************");
    Console.WriteLine("******************************************");
    Console.WriteLine("******************************************");

    // Vstup pro počet generovaných čísel
    Console.Write("Zadejte počet generovaných (kladné celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
    {
        Console.Write("Nezadali jste celé kladné celé číslo! Zadejte počet čísel znovu: ");
    }

    // Vstup pro dolní mez
    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;
    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte dolní mez znovu: ");
    }

    // Vstup pro horní mez
    Console.Write("Zadejte horní mez (celé číslo větší nebo rovno hodnotě pro dolní mez): ");
    int upperBound;
    while (!int.TryParse(Console.ReadLine(), out upperBound) || upperBound < lowerBound)
    {
        Console.Write("Nezadali jste celé číslo nebo je horní mez menší než dolní mez! Zadejte horní mez znovu: ");
    }

    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("==================================");
    Console.WriteLine($"Počet generovaných čísel: {n}; Dolní mez: {lowerBound}; Horní mez: {upperBound}");
    Console.WriteLine("==================================");
    Console.WriteLine();

    // Jádro konkrétního algoritmu
    int[] myRandNumbs = new int[n];
    Random randomNumber = new Random();

    Console.WriteLine("Náhodná čísla:");
    for (int i = 0; i < n; i++)
    {
        myRandNumbs[i] = randomNumber.Next(lowerBound, upperBound + 1);
        Console.Write($"{myRandNumbs[i]}; ");
    }

    // Hledání maxima, minima a jejich prvních pozic
    int max = myRandNumbs[0];
    int posMax = 0;
    int min = myRandNumbs[0];
    int posMin = 0;

    for (int i = 1; i < n; i++)
    {
        if (myRandNumbs[i] > max)
        {
            max = myRandNumbs[i];
            posMax = i;
        }

        if (myRandNumbs[i] < min)
        {
            min = myRandNumbs[i];
            posMin = i;
        }
    }

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"Maximum: {max}");
    Console.WriteLine($"Pozice prvního maxima: {posMax}");
    Console.WriteLine($"Minimum: {min}");
    Console.WriteLine($"Pozice prvního minima: {posMin}");
    Console.WriteLine();

    // Vykreslení barevných přesýpacích hodin (jen když je max >= 3)
    if (max >= 3)
    {
        for (int i = 0; i < max; i++)
        {
            int spaces = Math.Min(i, max - 1 - i);
            int stars = max - 2 * spaces;

            for (int j = 0; j < spaces; j++)
            {
                Console.Write("  ");
            }

            for (int k = 0; k < stars; k++)
            {
                if (i == 0 || i == max - 1 || k == 0 || k == stars - 1)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

                Console.Write("* ");
            }

            Console.WriteLine();
        }

        Console.ResetColor();
    }
    else
    {
        Console.WriteLine("Maximum je menší než 3, obrazec přesýpacích hodin nelze vykreslit.");
    }
    // Konec jádra konkrétního algoritmu

    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakokouli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";
}