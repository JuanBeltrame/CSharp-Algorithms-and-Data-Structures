/* 
Practica 1 - For loops - Exercise 3.1.12
----------------------------------------------------------------------
English:
Enter a number X, calculate X5

Spanish: 
Ingresado un número X, calcular X5
----------------------------------------------------------------------
*/

//--------Programa Principal----------

using System.Diagnostics.Tracing;

Console.Title = "Practica 1 - For loops - Exercise 3.1.12";
Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine("Ingresar un numero entero: ");
int number = int.Parse(Console.ReadLine()!);

int exponent = number * number * number * number * number;

Console.WriteLine($"El resultado es: {exponent}");



