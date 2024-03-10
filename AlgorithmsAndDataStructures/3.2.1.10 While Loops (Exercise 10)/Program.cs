/* 
Practica 1 - While loops - Exercise 3.2.1.08
----------------------------------------------------------------------
English:
For each first-year student at the faculty, the following data is available:
Commission number - Partial exam grade
The number of commissions and the number of students per commission are unknown.
The data is sorted by commission.
To determine, for each commission,
the commission number and the average grade for that partial exam.

Spanish: 
De cada uno de los alumnos de primer año de la facultad se tienen los siguientes datos:
Nro de comisión - Nota del parcial
No se sabe la cantidad de comisiones ni la cantidad de alumnos por comisión. 
Los datos están ordenados por comisión.
Determinar, para cada una de las comisiones, 
el número de comisión y el promedio de las notas de dicho parcial.
----------------------------------------------------------------------
*/

//--------Programa Principal----------

Console.Title = "Practica 1 - While loops - Exercise 3.2.1.08";
Console.ForegroundColor = ConsoleColor.Yellow;

Random rn = new();
Console.WriteLine("Ingresar el numero de Comision: ");
int numComision = rn.Next(11);
while (numComision != 0)
{

}
