/*
Practica 1 - Sequential - Exercise 03
----------------------------------------------------------------------
English:
Given five numbers, 
calculate their average 
and report the result

Spanish: 
Dados como datos cinco números 
obtener el promedio de los mismos 
e informar el resultado.
----------------------------------------------------------------------
*/

int n1,n2,n3,n4,n5,cantidadNumeros,acumulador;
float average;

cantidadNumeros = 0;
acumulador = 0;
Console.WriteLine("Ingresar numeros");

n1 = int.Parse(Console.ReadLine());
cantidadNumeros +=1;
acumulador += n1;
n2 = int.Parse(Console.ReadLine());
cantidadNumeros +=1;
acumulador += n2;
n3 = int.Parse(Console.ReadLine());
cantidadNumeros +=1;
acumulador += n3;
n4 = int.Parse(Console.ReadLine());
cantidadNumeros +=1;
acumulador += n4;
n5 = int.Parse(Console.ReadLine());
cantidadNumeros +=1;
acumulador += n5;

average = acumulador/cantidadNumeros;
Console.WriteLine("El promedio de los mismos es:{0}",average);
