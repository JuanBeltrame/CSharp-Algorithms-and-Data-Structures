/*
Practica 3 - Multidimensional Array - Ejercicio 05
----------------------------------------------------------------------
English:
The grades of 4 exams taken by 30 students are available and sorted in ascending order by STUDENT NUMBER. 
The student number is an integer value between 1 and 12000. 
It is desired to input a STUDENT NUMBER and search for it using binary search within the array. 
If found, report the student number along with the grades for the 4 exams; 
otherwise, display a clarifying message.


Spanish: 
Se tiene las notas de 4 parciales tomados a 30 alumnos ordenados en forma creciente, por NRO DE ALUMNO.
El número de alumno es un valor entero entre 1 y 12000.
Se desea ingresar un NRO DE ALUMNO y buscarlo por medio de la búsqueda dicotómica dentro del arreglo. 
Si se encuentra, informar el nro de alumno junto con las notas de los 4 parciales; 
sino exhibir cartel aclaratorio.
----------------------------------------------------------------------
*/

int fila = 3;
int columna = 5;


decimal[,] matrix = new decimal[fila, columna];

void InicializarMatrix(decimal[,] m)
{
    for (int i = 0; i < fila; i++)
    {
        for (int j = 0; j < columna; j++)
        {
            m[i, j] = 0.00M;
        }
    }
}

void CargarMatrix(decimal[,] m)
{
    for (int i = 0; i < fila; i++)
    {
        for (int j = 0; j < columna; j++)
        {
            //do
            //{
            //    Console.Write("Ingresar Nombre del alumno: ");
            //    string nombreAlumno = Console.ReadLine()!;
            //    nroAlumno = int.Parse(Console.ReadLine()!);
            //} while (!validarRangoEnteros(nroAlumno, 1, 50));
            m[i, j] = decimal.Parse(Console.ReadLine()!);

        }
    }
}

bool validarRangoEnteros(int nro, int desde, int hasta)
{
    if (nro >= desde && nro <= hasta)
    {
        return true;
    }
    else
    {
        return false;
    }
}


//---------Programa Principal----------

InicializarMatrix(matrix);
CargarMatrix(matrix);
