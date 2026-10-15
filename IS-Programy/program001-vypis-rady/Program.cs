// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Data;

Console.WriteLine("NAZDAR. mám hlad");



//Příklad:
//first = 1
//last = 10
//step = 2

//1
//3
//5
//7
//9

/*Toto
je víceřádkový komentář*/

//jako první si připravíme smyčku pro opakování programu 

string again = "a";
// .ToLower() převede vstup na malá písmena, tak že program bude pokračovat při zadávání, jak malého "a" tak i velkého "A" 
while (again.ToLower() == "a")
{
    //hlavička programu
    Console.Clear();
    Console.WriteLine("****************************************************");
    Console.WriteLine("********************Vypis řady**********************");
    Console.WriteLine("****************************************************");
    Console.WriteLine("*******************Lukáš Klesal*********************");
    Console.WriteLine("****************************************************");
    Console.WriteLine("****************************************************");

    // Vstup počáteční hodnoty - špatné řešení 
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    //Vstup počáteční hodnoty správné řešení 
    Console.Write("Zadejte poslední číslo řady (celé číslo): ");
    int last;
    while (!int.TryParse(Console.ReadLine(), out last))
    {
        Console.Write("Nezadali jste celé číslo řady! Zadejte poslední číslo řady znovu (Celé číslo): ");
    }
    //vstup diference s kontrolou kladné hodnoty 
    Console.Write("zadejte diferenci (kladné celé číslo): ");
    int step;
    while (!int.TryParse(Console.ReadLine(), out step) || step <= 0)
    {
        Console.Write("Diference musí být kladné číslo! Zadejte diferenci znovu (kladné celé číslo): ");
    }




    // Dotaz na opakování 
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a. Následně potvrďtě klávesou En");
    Console.WriteLine("Jakkoukoli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.WriteLine("Chcete program opakovat?");
    again = Console.ReadLine() ?? "";
}