/* 
Practica 1 - For loops - Exercise 3.1.07
----------------------------------------------------------------------
English:
Calculate and display the sum of the first 100 natural numbers.

Spanish: 
Calcular y exhibir la suma de los primeros 100 números naturales.
----------------------------------------------------------------------
*/

//--------Programa Principal----------

using System.Diagnostics.Tracing;

Console.Title = "Practica 1 - For loops - Exercise 3.1.7";
Console.ForegroundColor = ConsoleColor.Yellow;

int suma = 0;
int contador = 1;

for (int i = 0; i < 100; i++)
{
    suma += contador;
    contador++;
}
Console.WriteLine($"La suma de los primeros 100 numeros naturales es: {suma}");