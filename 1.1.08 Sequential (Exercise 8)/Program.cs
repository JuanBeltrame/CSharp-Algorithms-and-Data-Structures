/*
Practica 1 - Sequential - Exercise 08
----------------------------------------------------------------------
English:
Given a number, show the result of that number raised to the eighth power.

Spanish: 
Dado un número, mostrar el resultado de dicho número elevado a la octava.
----------------------------------------------------------------------
*/

using System.Security.Cryptography.X509Certificates;

int number, raised;

Console.WriteLine("Ingrese un numero");
number = int.Parse(Console.ReadLine());

raised = number * number * number * number * number * number * number * number;
Console.WriteLine("El resultado obtenido es: "+raised);