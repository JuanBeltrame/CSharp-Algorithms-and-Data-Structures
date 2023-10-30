/*
Practica 1 - Sequential - Exercise 06
----------------------------------------------------------------------
English:
Given the measures of two angles of a triangle, 
determine the measure of the third one and report the result.

Spanish: 
Dadas las medidas de dos ángulos de un triángulo determinar la medida del tercero e
informar el resultado.
----------------------------------------------------------------------
*/

double angulo1, angulo2, angulo3;

Console.Write("Ingrese la medida del primer angulo: ");
angulo1 = double.Parse(Console.ReadLine());
Console.Write("Ingrese la medida del segundo angulo: ");
angulo2 = double.Parse(Console.ReadLine());
angulo3 = 180 - angulo1 - angulo2;
Console.Write("Por lo tanto la medida del tercer angulo ha sido: "+ angulo3);