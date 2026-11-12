using System;
using System.Threading;

class Program
{
    static void Main()
    {
        string again = "a";
        while (again.ToLower() == "a")
        {
            Console.Clear();
            Console.WriteLine("******************************************");
            Console.WriteLine("** Vykreslení pravoúhlého trojúhelníku  **");
            Console.WriteLine("******************************************");
            Console.WriteLine("************* Tomáš Žižka ****************");
            Console.WriteLine("******************************************");
            Console.WriteLine();

            // Rozhodnutí o vstupu podle zadání: Stačí nám jeden rozměr (výška = šířka)
            Console.Write("Zadejte velikost trojúhelníku (přirozené číslo): ");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.Write("Velikost musí být celé kladné číslo větší než 0. Zadejte znovu: ");
            }

            Console.WriteLine();
            Console.WriteLine($"Vykresluji pravoúhlý trojúhelník o velikosti {size}:");
            Console.WriteLine();

            // Jádro algoritmu
            // Vnější cyklus počítá řádky shora dolů
            for (int i = 1; i <= size; i++)
            {
                // Vnitřní cyklus sází hvězdičky vedle sebe
                // Hlavní změna oproti obdélníku: kreslíme jen tolik hvězdiček, kolikátý je to řádek (j <= i)
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                    Thread.Sleep(TimeSpan.FromMilliseconds(100)); // Efekt animace vykreslování
                }

                // Konec řádku -> odřádkování
                Console.WriteLine();
            }

            // Dotaz na opakování
            Console.WriteLine();
            Console.Write("Pro opakování programu stiskněte 'a' a potvrďte Enterem: ");
            again = Console.ReadLine() ?? "";
        }
    }
}