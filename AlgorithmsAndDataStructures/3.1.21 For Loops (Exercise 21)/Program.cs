/* 
Practica 1 - For loops - Exercise 3.1.21
----------------------------------------------------------------------
English:
You have the following data on the N members of a club:
Member number / Age / Gender (F or M) / Dues amount.
You want to know:
a) Number of women and number of men
b) Average age of all members
c) Total dues collected by your club

Spanish: 
Se tienen los siguientes datos de los N socios de un club:
Número de socio / Edad / Sexo (F o M) / Importe de la cuota
Se quiere saber:
a) Cantidad de mujeres y cantidad de hombres
b) Promedio de edad de todos socios
c) Total recaudado por el club en concepto de cuotas
----------------------------------------------------------------------
*/

//--------Programa Principal----------

using Microsoft.Win32.SafeHandles;
using System.Globalization;
using System.Runtime.ExceptionServices;

Console.Title = "Practica 1 - For loops - Exercise 3.1.21";
Console.ForegroundColor = ConsoleColor.Yellow;

int cantMujeres = 0;
int cantHombres = 0;
int acumuladorEdad = 0;
int acumularCuotass = 0;

Console.Write("Ingrese la cantidad de miembros del Club: ");
int nMembers = int.Parse(Console.ReadLine()!);
Random rn = new();
Console.WriteLine();


for (int i = 0; i < nMembers; i++)
{
    int nSocio = rn.Next(1, 1001);
    int edad = rn.Next(1, 100);
    int importeCuota = rn.Next(3000, 6000);
    char letraAletoria = (char)rn.Next('M', 'F' + 1);
    if (letraAletoria == 'M')
    {
        cantMujeres = cantMujeres + 1;
    }
    else
    {
        cantHombres += 1;
    }

    acumuladorEdad = acumuladorEdad + edad;
    acumularCuotass = acumularCuotass + importeCuota;

    Console.WriteLine($"N de Socio: {nSocio}");
    Console.WriteLine($"Edad: {edad}");
    Console.WriteLine($"Sexo (F/M): {letraAletoria}");
    Console.WriteLine($"Importe de la cuota: {importeCuota}");
}

int promedioEdad = acumuladorEdad / nMembers;
Console.WriteLine($"Cantidad de Hombres: {cantHombres}");
Console.WriteLine($"Cantidad de Mujeres: {cantMujeres}");
Console.WriteLine($"Promedio de Edad en el club: {promedioEdad}");
Console.WriteLine($"Total recaudado: {acumularCuotass}");