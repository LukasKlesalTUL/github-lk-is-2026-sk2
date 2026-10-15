// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

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


    // Dotaz na opakování 
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a. Následně potvrďtě klávesou En");
    Console.WriteLine("Jakkoukoli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.WriteLine("Chcete program opakovat?");
    again = Console.ReadLine() ?? "";
}