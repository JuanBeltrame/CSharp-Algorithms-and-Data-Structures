/*
Practica 1 - Sequential - Exercise 1.1.02
----------------------------------------------------------------------
English:
Given two numbers entered via keyboard as data, 
calculate their product and report the result. 
Declare the variables to be used: N1, N2, SUM, all of numerical type.

Spanish: 
Dados como datos (ingresados por teclado) dos números cualesquiera 
calcular su producto e informar el resultado.
Declarar las variables a utilizar N1, N2, SUMA de tipo numérico
----------------------------------------------------------------------
*/

int n1, n2, producto;

Console.WriteLine("Ingresar 2 Numeros");
n1 = int.Parse(Console.ReadLine());
n2 = int.Parse(Console.ReadLine());
producto = n1 * n2;
Console.WriteLine("El resultado de la multiplicacion es:"+ producto);

