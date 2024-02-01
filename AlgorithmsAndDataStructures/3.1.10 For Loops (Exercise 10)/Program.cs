/* 
Practica 1 - For loops - Exercise 3.1.10
----------------------------------------------------------------------
English:
Obtain the sum of the N natural numbers after the number 300 inclusive.

Spanish: 
Obtener la suma de los N números naturales posteriores al número 300 inclusive.
----------------------------------------------------------------------
*/

//--------Programa Principal----------

using System.Diagnostics.Tracing;

Console.Title = "Practica 1 - For loops - Exercise 3.1.10";
Console.ForegroundColor = ConsoleColor.Yellow;

Console.Write("Ingresar la cantidad de numeros que se desean sumar: ");
int cantidad = int.Parse(Console.ReadLine()!);
int acumulador = 0;

for (int i = 300; i <= 300 + cantidad; i++)
{
    acumulador += i;
}

Console.WriteLine($"La suma obtenida es: {acumulador} ");