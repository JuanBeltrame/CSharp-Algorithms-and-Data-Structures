/*
Practica 1 - Sequential - Exercise 1.1.14
----------------------------------------------------------------------
English:
Calculate how many pesos a bank has in coins:
if it has N1 coins of 10 pesos,
N2 of half the value of N1 pesos,
N3 of a quarter of N1 peso,
and N4 of 1 peso.
(N1, N2, N3, and N4 are quantities)

Spanish: 
Calcular cuántos pesos tiene un banco en monedas:
si dispone de N1 monedas de 10 pesos, 
N2 de la mitad de pesos de N1, 
N3 de un cuarto peso de N1, 
y N4 de 1 peso. 
(N1, N2, N3 y N4 son cantidades)
----------------------------------------------------------------------
*/

int N1, N2, N3, N4;

double cantidadDeMonedas;

Console.Write("Ingrese la cantidad de monedas de 10 pesos: ");
N1 = int.Parse(Console.ReadLine());
Console.Write("Ingrese la cantidad de monedas de 5 pesos: ");
N2 = int.Parse(Console.ReadLine());
Console.Write("Ingrese la cantidad de monedas de 2,5 pesos: ");
N3 = int.Parse(Console.ReadLine());
Console.Write("Ingrese la cantidad de monedas de 1 pesos: ");
N4 = int.Parse(Console.ReadLine());
cantidadDeMonedas = (N1 * 10) + (N2 * 5) + (N3 * 2.5) + (N4);
Console.Write("La cantidad de pesos que hay en el banco son: " + cantidadDeMonedas);