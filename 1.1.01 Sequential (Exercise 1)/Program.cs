/*
Practica 1 - Sequential - Exercise 01
----------------------------------------------------------------------
English:
Given two numbers entered via keyboard as data, 
calculate their sum and report the result. 
Declare the variables to be used: N1, N2, SUM, all of numerical type.

Spanish: 
Dados como datos (ingresados por teclado) dos números cualesquiera 
calcular su suma e informar el resultado.
Declarar las variables a utilizar N1, N2, SUMA de tipo numérico
----------------------------------------------------------------------
*/

int n1,n2,sum;

Console.WriteLine("Ingresar 2 numeros");
n1 = int.Parse(Console.ReadLine());
n2 = int.Parse(Console.ReadLine());

sum = n1 + n2;
Console.WriteLine("El resultado es:{0}",sum);
