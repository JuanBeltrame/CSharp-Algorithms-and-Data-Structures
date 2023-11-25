/*
Practica 3 - Multidimensional Array - Ejercicio 04
----------------------------------------------------------------------
English:
The following data are available for each of the first year students of the Faculty:
- Commission number(integer between 1 and 10)
- Age (integer)

These data are entered out of order and the number of students is not known, 
After entering the data of each student, a sign will appear on the screen with the following question: 'Do you continue or not?
question: 'Continue or finish?' 

Upon which the operator will enter a 'C' or 'F' (validate) as appropriate. 

Each time a commission number is entered, validate that it is within the correct range.

For each commission, display a line where it is specified:
Commission N.: Number of students:  Average age: 

At the end show the Commission No. with the highest average age and that average. 
(if there is more than one commission with the highest average, show the last one found).


Spanish: 
Para cada uno de los alumnos de primer año de la Facultad se tienen los siguientes datos:
• Nro.de comisión(entero entre 1 y 10)
• Edad(entero)

Estos datos ingresan desordenados y no se conoce la cantidad de alumnos, 
por lo que luego de introducidos los datos de cada estudiante aparecerá en pantalla un cartel con la
pregunta: '¿Continúa o finaliza?' 

Ante lo cual el operador ingresará una 'C' o una 'F' (validar) según corresponda. 

Cada vez que se ingrese un nro. de comisión validar que esté dentro del rango correcto.

Por cada comisión, mostrar un renglón donde se especifique:
Nro.Comisión:  Cantidad de estudiantes:  Promedio de edad: 

Al final mostrar el Nro. de Comisión con mayor promedio de edad y dicho promedio. 
(si hubiera más de una comisión con promedio máximo mostrar la última encontrada).
----------------------------------------------------------------------
*/

int fila = 10;
int columna = 10;
string alumno = null;
int comision = 0;
int edad = 0;

int[,] matrix = new int[fila, columna];

void InicializarMatrix(int[,] m)
{
    for (int i = 0; i < fila; i++)
    {
        for (int j = 0; j < columna; j++)
        {
            m[i, j] = 0;
        }
    }
}

void MostrarArreglo(int[,] m)
{
    for (int i = 0; i < fila; i++)
    {
        for (int j = 0; j < columna; j++)
        {
            Console.Write(m[i, j]);
        }
        Console.WriteLine();
    }
}







//------------Programa Principal---------------
InicializarMatrix(matrix);
MostrarArreglo(matrix);

Console.Write("Ingresar nombre del Alumno: ");
Console.Write($"Ingresar edad del alumno {alumno} [1 - 10]: ");
edad = int.Parse(Console.ReadLine()!);
Console.Write("Ingresar Comision [1 - 10]: ");
comision = int.Parse(Console.ReadLine()!);
alumno = Console.ReadLine()!;
char continua = 'C';
while (continua == 'C')
{
    do
    {
        Console.Write("Desea ingresar otro alumno: [C] Continuar / [F] Finalizar: ");
        continua = char.ToUpper(char.Parse(Console.ReadLine()!));
    } while (continua != 'C' && continua != 'F');
    if (continua == 'C')
    {
        Console.Write("Ingresar nombre del Alumno: ");
        alumno = Console.ReadLine()!;
    }
    else
    {
        Console.Write("Saliendo del Sistema....");
    }
}