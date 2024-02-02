/* 
Practica 1 - For loops - Exercise 3.1.06
----------------------------------------------------------------------
English:
Knowing that a university course has X amount of subjects, enter the grades with which a student passed each of the
the grades with which a student passed each of the subjects during his or her university career and
and finally show the average grade of that student.

Spanish: 
Sabiendo que una carrera universitaria cuenta con X cantidad de materias, ingresar las
notas con que un alumno aprobó cada una de las materias durante su carrera
universitaria y finalmente mostrar la nota promedio de dicho alumno.
----------------------------------------------------------------------
*/

//--------Programa Principal----------

using System.Diagnostics.Tracing;

Console.Title = "Practica 1 - For loops - Exercise 3.1.6";
Console.ForegroundColor = ConsoleColor.Yellow;


int cantidadDeMaterias = 5;
int sumadorNotas = 0;
Random rn = new();

for (int i = 0; i < cantidadDeMaterias; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Ingresar nota para la materia {i + 1} de la carrera: ");
    int notaMateria = rn.Next(1, 11);
    Console.Write($"La nota de la materia {i+1} ingresada fue: {notaMateria}");
    sumadorNotas += notaMateria;
    Console.WriteLine();
}

Console.WriteLine();
decimal promedio = sumadorNotas/cantidadDeMaterias;
Console.WriteLine($"El promedio del alumno es de: {promedio}");
