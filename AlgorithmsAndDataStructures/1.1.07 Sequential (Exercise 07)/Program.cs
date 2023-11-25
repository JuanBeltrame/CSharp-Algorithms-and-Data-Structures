/*
Practica 1 - Sequential - Exercise 07
----------------------------------------------------------------------
English:
Given the value of the side of a square, 
calculate its perimeter and its area, 
and report them with explanatory signs.

Spanish: 
Dado el valor del lado de un cuadrado calcular su perímetro y su superficie, e informar
los mismos con carteles aclaratorios.
----------------------------------------------------------------------
*/
int lado;
double perimetro, area;
Console.Write("Ingrese el lado de un cuadrado: ");
lado = int.Parse(Console.ReadLine());

perimetro = 4 * lado;
Console.WriteLine("El perimetro del cuadrado es: " + perimetro);
area = lado * lado;
Console.WriteLine("El area del cuadrado es:" + area);
