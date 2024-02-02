/* 
Practica 1 - For loops - Exercise 3.1.04
----------------------------------------------------------------------
English:
Given 200 integers as data, obtain and display their sum.

Spanish: 
Dados como datos 200 números enteros, obtener y mostrar su suma.
----------------------------------------------------------------------
*/

//--------Programa Principal----------
Console.Title = "Practica 1 - For loops - Exercise 3.1.4";
Console.ForegroundColor = ConsoleColor.Yellow;

int suma = 0;
int limite = 200;
Random random = new();

for (int i = 0; i < limite; i++)
{
    int valorRandom = random.Next(1,11);
    suma = suma + valorRandom;
}

Console.WriteLine($"El valor de la suma de todos los numeros es: {suma}");