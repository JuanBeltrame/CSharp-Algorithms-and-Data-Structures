/* 
Practica 1 - For loops - Exercise 3.1.11
----------------------------------------------------------------------
English:
Generate and report the first N multiples of any integer M.
N and M are two numbers that are entered as data.

Spanish: 
Generar e informar los primeros N múltiplos de un número M entero cualquiera.
N y M son dos números que se ingresan como dato.
----------------------------------------------------------------------
*/

//--------Programa Principal----------

using System.Diagnostics.Tracing;

Console.Title = "Practica 1 - For loops - Exercise 3.1.10";
Console.ForegroundColor = ConsoleColor.Yellow;

Console.Write("Ingresar un numero (M): ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Ingresar la cantidad de multiplos (N) a obtener de (M): ");
int N = int.Parse(Console.ReadLine()!);

int acumulador = 0;

for (int i = 0; i <= N; i++)
{
    acumulador = acumulador + M;
    Console.WriteLine($"los multiplos de {M} son: {acumulador}");
}


b