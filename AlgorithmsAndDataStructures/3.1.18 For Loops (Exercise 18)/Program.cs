/* 
Practica 1 - For loops - Exercise 3.1.18
----------------------------------------------------------------------
English:
A school carries out a check on the physical condition of its 304 students. 
It has the file numbers and height (in centimeters) of each one of them.
It needs to know the average height, 
It is required to know the average height, as well as the file numbers of the students with a height of less than 165 cm.


Spanish: 
Una escuela realiza un control sobre el estado físico de sus 304 alumnos. 
Dispone de los números de legajos y estatura (en cms.) de cada uno de ellos.
Se requiere saber el promedio de estatura, 
así como los números de legajos de los alumnos de estatura inferior a 165 cms.
----------------------------------------------------------------------
*/

//--------Programa Principal----------

using Microsoft.Win32.SafeHandles;
using System.Globalization;
using System.Runtime.ExceptionServices;

Console.Title = "Practica 1 - For loops - Exercise 3.1.18";

int cantAlumnos = 10;
double estaturaCentimetros = default;
int numeroLegajo = default;
Double promedioEstatura = default;
double sumaEstatura = 0;

for (int i = 0; i < cantAlumnos; i++)
{
    Random rn = new Random();
    estaturaCentimetros = rn.Next(150,200);
    numeroLegajo = rn.Next(1000, 4001);


    sumaEstatura = sumaEstatura + estaturaCentimetros;
    if (estaturaCentimetros < 165D)
    {
        Console.WriteLine($"Alumno Legajo: {numeroLegajo}, con estatura menor a 165 Centimetros");
    }
}

Console.WriteLine();
promedioEstatura = sumaEstatura / cantAlumnos;
Console.WriteLine($"El promedio de estatura es: {(promedioEstatura.ToString("F2"))}cm");
