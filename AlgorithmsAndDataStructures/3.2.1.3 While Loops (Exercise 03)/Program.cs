/* 
Practica 1 - While loops - Exercise 3.2.1.3
----------------------------------------------------------------------
English:
Enter non-zero numbers, except for the last value. Determine their sum.

Spanish: 
Se van ingresando números distintos de cero, salvo el último valor. Determinar su suma.
----------------------------------------------------------------------
*/

//--------Programa Principal----------

using System;
using System.Security.Cryptography;

Console.Title = "Practica 1 - While loops - Exercise 3.2.1.3";
Console.ForegroundColor = ConsoleColor.Yellow;


int numero = default;
int sumador = 0;
Random rn = new();

Console.WriteLine("Ingresar un numero: ");
numero = rn.Next(0, 20);
Console.WriteLine($"Se ingreso el numero: {numero}");
while (numero != 0)
{

    sumador += numero;

    Console.WriteLine("Ingresar otro numero: ");
    numero = rn.Next(0, 20);
    Console.WriteLine($"Se ingreso el numero: {numero}");
    Console.WriteLine();
}

Console.WriteLine($"La suma de los valores ingresados es de: {sumador}");