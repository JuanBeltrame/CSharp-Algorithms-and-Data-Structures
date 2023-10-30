/*
Practica 1 - Sequential - Exercise 04
----------------------------------------------------------------------
English:
Given two integer numbers, obtain their sum, difference, multiplication, and division.

Spanish: 
Dados dos números enteros obtener su suma, resta, multiplicación y división.
----------------------------------------------------------------------
*/

int n1, n2, suma, difference, multiplicación, division;

Console.WriteLine("Ingresar 2 numeros enteros");
n1 = int.Parse(Console.ReadLine());
n2 = int.Parse(Console.ReadLine());

suma = n1 + n2;
difference = n1 - n2;
multiplicación = n1 * n2;
division = n1 / n2;

Console.WriteLine("El resultados de la Suma es: {0}", suma);
Console.WriteLine("El resultados de la Resta es: {0}", difference);
Console.WriteLine("El resultados de la multiplicacion es: {0}", multiplicación);
Console.WriteLine("El resultados de la division es: {0}", division);
