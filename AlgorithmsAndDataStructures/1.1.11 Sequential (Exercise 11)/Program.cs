﻿/*
Practica 1 - Sequential - Exercise 1.1.11
----------------------------------------------------------------------
English:
Calculate the salary of a worker, 
knowing the number of hours worked in the month and the hourly wage.

Spanish: 
Calcular el sueldo de un operario 
conociendo la cantidad de horas que trabajó en el mes y el jornal horario.
----------------------------------------------------------------------
*/

double precioHora, sueldo;
int horasTrabajadas;

Console.WriteLine("Ingresar el precio del jornal horario: ");
precioHora = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresar las horas trabajadas del operario");
horasTrabajadas = int.Parse(Console.ReadLine());

sueldo = precioHora * horasTrabajadas;
Console.WriteLine("El sueldo del operario es de: "+ sueldo);
