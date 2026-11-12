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
            Console.WriteLine("********************************");
            Console.WriteLine("***** Vykreslení obdélníku *****");
            Console.WriteLine("********************************");
            Console.WriteLine("********* Tomáš Žižka **********");
            Console.WriteLine("********************************");
            Console.WriteLine();

            // 1. Bezpečné načtení šířky s kontrolou na kladnou hodnotu
            Console.Write("Zadejte šířku obrazce (přirozené číslo): ");
            int width;
            while (!int.TryParse(Console.ReadLine(), out width) || width <= 0)
            {
                Console.Write("Šířka musí být celé kladné číslo větší než 0. Zadejte znovu: ");
            }

            // 2. Bezpečné načtení výšky s kontrolou na kladnou hodnotu
            Console.Write("Zadejte výšku obrazce (přirozené číslo): ");
            int height;
            while (!int.TryParse(Console.ReadLine(), out height) || height <= 0)
            {
                Console.Write("Výška musí být celé kladné číslo větší než 0. Zadejte znovu: ");
            }

            Console.WriteLine();
            Console.WriteLine($"Vykresluji obrazec o rozměrech {width} × {height}:");
            Console.WriteLine();

            // 3. Jádro algoritmu: Vnořený cyklus pro 2D rastr
            // Vnější cyklus počítá řádky (shora dolů)
            for (int i = 1; i <= height; i++)
            {
                // BARVY: Zjištění sudého/lichého řádku pomocí zbytku po dělení dvěma
                if (i % 2 != 0) 
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;   // Liché řádky (1, 3, 5...)
                }
                else 
                {
                    Console.ForegroundColor = ConsoleColor.Yellow; // Sudé řádky (2, 4, 6...)
                }

                // Vnitřní cyklus sází sloupce v aktuálním řádku (zleva doprava)
                for (int j = 1; j <= width; j++)
                {
                    Console.Write("* ");
                    Thread.Sleep(TimeSpan.FromMilliseconds(100)); // Efekt animace vykreslování
                }

                // ZLATÉ PRAVIDLO: Okamžitý návrat do výchozího stavu konzole před odřádkováním
                Console.ResetColor();

                // Konec řádku -> přesun kurzoru na nový řádek
                Console.WriteLine();
            }

            // 4. Dotaz na opakování
            Console.WriteLine();
            Console.Write("Pro opakování programu stiskněte 'a' a potvrďte Enterem: ");
            again = Console.ReadLine() ?? "";
        }
    }
}