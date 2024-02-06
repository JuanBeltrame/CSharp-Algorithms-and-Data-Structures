/* 
Practica 1 - For loops - Exercise 3.1.23
----------------------------------------------------------------------
English:
A company is divided into 10 sections. 
For each of them we have the following data:
- Section no.
- Number of employees working in it
for each employee we have the following data:
- Number of hours worked
- Working shift ('M': morning; 'T': afternoon)

You want to know:
- The average number of hours worked in each section
- The total number of hours worked in each shift in the company.

Spanish: 
Una empresa está dividida en 10 secciones. 
Para cada una de ellas se tienen como datos:
• Nro. de sección
• Cantidad de empleados que trabajan en ella
para cada empleado se tiene como dato:
• Cantidad de horas trabajadas
• Turno de trabajo (‘M’: mañana; ‘T’: tarde)

Se desea saber:
• El promedio de horas trabajadas en cada sección
• La cantidad total de horas trabajadas en cada turno en la empresa
----------------------------------------------------------------------
*/

//--------Programa Principal----------

using Microsoft.Win32.SafeHandles;
using System.Globalization;
using System.Runtime.ExceptionServices;

Console.Title = "Practica 1 - For loops - Exercise 3.1.23";
Console.ForegroundColor = ConsoleColor.Yellow;

int cantidadSecciones = 10;
int cantidadEmpleados;
Random rn = new();

int acumuladorHorasTMGlobal = 0;
int acumuladorHorasTTGlobal = 0;

for (int i = 0; i < cantidadSecciones; i++)
{
    int promedio = 0;
    int cantidadHorasTrabajadas;
    int turno;
    int acumuladorHoras = 0;
    int acumuladorHorasTM = 0;
    int acumuladorHorasTT = 0;

    Console.WriteLine($"Numero de Seccio: {i+1}");
    cantidadEmpleados = rn.Next(1, 21);
    Console.WriteLine($"Actualmente trabajan {cantidadEmpleados}");
    for (int j = 0; j < cantidadEmpleados; j++)
    {
        cantidadHorasTrabajadas = rn.Next(20, 41);
        acumuladorHoras = acumuladorHoras + cantidadHorasTrabajadas;
        Console.WriteLine($"El empleado: {j}, trabajo: {cantidadHorasTrabajadas} horas.");
        turno = rn.Next(0, 2);
        if ( turno == 0)
        {
            acumuladorHorasTM = acumuladorHorasTM + cantidadHorasTrabajadas;
            acumuladorHorasTMGlobal += cantidadHorasTrabajadas;
        }
        else
        {
            acumuladorHorasTT = acumuladorHorasTT + cantidadHorasTrabajadas;
            acumuladorHorasTTGlobal += cantidadHorasTrabajadas;
        }
    }

    promedio = acumuladorHoras / cantidadEmpleados;
    Console.WriteLine($"El promedio de horas trabajadas en la seccion {i+1}, es de: {promedio}");
    Console.WriteLine($"En la seccion {i +1} se trabajaron: {acumuladorHorasTM} horas a la manaana y {acumuladorHorasTT} a la tarde");
}

Console.WriteLine($"En toda la empresa se trabajaron {acumuladorHorasTMGlobal} horas en el turno manana");
Console.WriteLine($"En toda la empresa se trabajaron {acumuladorHorasTTGlobal} horas en el turno tarde");