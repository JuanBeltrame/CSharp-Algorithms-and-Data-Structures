/* 
Practica 1 - While loops - Exercise 3.2.1.11
----------------------------------------------------------------------
English:
From the employee clocking system of a company, the following data is available:
day, ID number (DNI), and number of hours worked.

The following information is desired:
For each day, who worked the most hours and the average number of hours worked.
The total number of hours worked.
The data is sorted by day, and data entry ends when entering day 0.

Spanish: 
Del reloj de marcación del personal de una empresa se tienen los siguientes datos:
día, DNI y cantidad de horas trabajadas

Se desea conocer:
Por día, quien trabajó la mayor cantidad de horas y el promedio de horas trabajadas
La cantidad total de horas trabajadas.
Los datos vienen ordenados por día y la carga de datos termina al ingresar el día en 0.
----------------------------------------------------------------------
*/

//--------Programa Principal----------

using System.Transactions;

Console.Title = "Practica 1 - While loops - Exercise 3.2.1.11";
Console.ForegroundColor = ConsoleColor.Yellow;


Random rn = new Random();
int dia;
int diaAnterior;

int dni;
int dniAnterior;

dia = rn.Next(0, 31);
Console.WriteLine();
Console.WriteLine($"Ingresar dia: {dia}");
while (dia != 0)
{
    int cantDNIs = 0;
    int cantHsTrabajadas;
    int acumHoras = 0;
    decimal promedioHoras;
    int horasMax = 0;
    int maxDni = 0;

    diaAnterior = dia;
    while (dia == diaAnterior)
    {
        dni = rn.Next(30, 40);
        Console.WriteLine($"Ingresar un DNI: {dni}");
        cantDNIs += 1;

        cantHsTrabajadas = rn.Next(1, 9);
        Console.WriteLine($"Ingresar cantidad de Horas trabajadas del empleado con DNI {dni}: {cantHsTrabajadas}");
        acumHoras += cantHsTrabajadas;

        if (cantHsTrabajadas > horasMax)
        {
            horasMax = cantHsTrabajadas;
            maxDni = dni;
        }

        dia = rn.Next(0, 31);
        Console.WriteLine();
        Console.WriteLine($"Ingresar nuevamente el dia: {dia}");
    }
    promedioHoras = acumHoras / cantDNIs;
    Console.WriteLine($"En el dia {diaAnterior} se trabajaron {acumHoras}hs en total, con un promedio de {promedioHoras}hs trabajadas, y el DNI que mas trabajo fu el: {maxDni} ");
    Console.WriteLine(  );
}




