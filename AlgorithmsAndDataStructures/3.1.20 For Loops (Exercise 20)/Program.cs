/* 
Practica 1 - For loops - Exercise 3.1.20
----------------------------------------------------------------------
English:
A committee has 55 students, 
Each one of them has the grades of the 6 mid-term exams they have taken. 
Obtain the average of the grades of each of the students.

Spanish: 
Una comisión tiene 55 alumnos, 
de cada uno de los cuales se tienen las notas de los 6 parciales que han rendido. 
Obtener el promedio de las notas de cada uno de los alumnos.
----------------------------------------------------------------------
*/

//--------Programa Principal----------

using Microsoft.Win32.SafeHandles;
using System.Globalization;
using System.Runtime.ExceptionServices;

Console.Title = "Practica 1 - For loops - Exercise 3.1.20";
Console.ForegroundColor = ConsoleColor.Yellow;

int cantidadAlumnos = 55;

for (int i = 0; i < cantidadAlumnos; i++)
{
    int cantidadDeParciales = 6;
    int acumuladorNotas = 0;
    for (int j = 0; j < cantidadDeParciales; i++)
    {
        int nota = default;
        Random rn = new();
        nota = rn.Next(1, 11);
        acumuladorNotas = acumuladorNotas + nota;
    }
    Console.WriteLine($"Alumno: {i+1}, con un promedio de: {acumuladorNotas}");
}

