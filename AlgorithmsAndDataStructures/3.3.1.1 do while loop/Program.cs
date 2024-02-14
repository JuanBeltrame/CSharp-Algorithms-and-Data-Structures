/* 
Practica 1 - While loops - Exercise 3.3.1.1
----------------------------------------------------------------------
English:


Spanish: 
Determinar cuántos caracteres tiene un conjunto de elementos, sabiendo que el último
carácter perteneciente al conjunto es una “S”, y que ésta letra aparece sólo una vez.
----------------------------------------------------------------------
*/

//--------Programa Principal----------

using System.Runtime.InteropServices;

Console.Title = "Practica 1 - While loops - Exercise 3.3.1.1";
Console.ForegroundColor = ConsoleColor.Yellow;

char elemento = default ;
int contElementos = 0;

do
{
    Console.WriteLine("Ingresar un elemento: ");
    elemento = char.Parse(Console.ReadLine()!);
    contElementos += 1;

} while (char.ToUpper(elemento) != 'S');

Console.WriteLine($"El conjunto de caracteres ingresados tuvo: {contElementos} elementos");
