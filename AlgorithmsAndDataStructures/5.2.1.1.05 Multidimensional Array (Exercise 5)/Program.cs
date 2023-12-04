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

int fila = 4;
int columna = 3;
int numeroAlumno;

int[,] matriz = new int[fila, columna];

bool validarRangoEnteros(int nro, int desde, int hasta)
{
    if (nro < desde || nro > hasta)
    {
        return true;
    }
    else
    {
        return false;
    }
}

void InicializarMatriz(int[,] matrix)
{
    for (int i = 0; i < fila; i++)
    {
        for (int j = 0; j < columna; j++)
        {
            matrix[i, j] = 0;
        }
    }
}

void CargarMatriz(int[,] matrix)
{
    int nroAlumno;
    string? nombreAlumno = null;
    int notaAlumnoo;

    for (int i = 0; i < fila; i++)
    {
        for (int j = 0; j < columna; j++)
        {
            if (j == 0)
            {
                Console.Write("Ingresar Nombre del alumno: ");
                nombreAlumno = Console.ReadLine()!;
                while (string.IsNullOrWhiteSpace(nombreAlumno) || nombreAlumno.Length >= 10)
                {
                    Console.WriteLine("Error, ingrese un nombre menor a 10 caracteres");
                    Console.Write("Ingresar Nombre del alumno: ");
                    nombreAlumno = Console.ReadLine()!;
                }
                Console.Write("Ingresar numero del Alumno: [ID] ");
                while (int.TryParse(Console.ReadLine(), out nroAlumno) && (nroAlumno < 1 || nroAlumno > 12000))
                {
                    Console.Write("Error, ingrese un numero entre 1 y 12000: ");
                }
                matrix[i, j] = nroAlumno;
                Console.Write("Dato guardado de manera exitosa!");
                Console.WriteLine();
            }
            else if (j > 0)
            {
                Console.WriteLine();
                Console.Write($"Ingresar la nota {j} del alumno {nombreAlumno}: ");
                while (int.TryParse(Console.ReadLine(), out notaAlumnoo) && (validarRangoEnteros(notaAlumnoo, 0, 10)))
                {
                    Console.Write($" Error, Ingresar nuevamente la nota{j} del alumno {nombreAlumno}: ");
                }
                Console.Write("Dato guardado de manera Correcta!");
                Console.WriteLine();
                matrix[i, j] = notaAlumnoo;
            }

        }
    }
}

void MostrarMatriz(int[,] matrix)
{
    for (int i = 0; i < fila; i++)
    {
        for (int j = 0; j < columna; j++)
        {
            Console.Write(matrix[i, j] + " ");

        }
        Console.WriteLine();
    }

}

void BubbleSort(int[,] matrix, int numColumna)
{
    for (int i = 0; i < fila - 1; i++)
    {
        for (int j = i + 1; j < fila; j++)
        {
            if (matrix[i, numColumna] > matrix[j, numColumna])
            {
                for (int k = 0; k < columna; k++)
                {
                    int auxiliar = matrix[i, k];
                    matrix[i, k] = matrix[j, k];
                    matrix[j, k] = auxiliar;
                }
            }
        }
    }
}

static void ProcesosDeConsola(string mensaje)
{
    Console.WriteLine();
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(mensaje);
    Console.ForegroundColor = ConsoleColor.Gray;
}

int BinarySearch(int[,] matrix, int number)
{
    int inferior = 0;
    int superior = columna;
    int medio = (int)((inferior + superior) / 2);
    while ((matrix[medio, 0] != number) && (inferior <= superior))
    {
        if (matrix[medio, 0] > numeroAlumno)
            superior = medio - 1;
        else
            inferior = medio + 1;
        medio = (int)((inferior + superior) / 2);
    }
    if (matrix[medio, 0] == numeroAlumno)
        return medio;
    else
        return -1;
}

//---------Programa Principal----------
InicializarMatriz(matriz);
ProcesosDeConsola("-------Cargar Matriz------");
CargarMatriz(matriz);
ProcesosDeConsola("-------Mostrar Matriz------");
MostrarMatriz(matriz);
BubbleSort(matriz, 0);
ProcesosDeConsola("-------Matriz Ordenada------");
MostrarMatriz(matriz);
ProcesosDeConsola("------Buscar por Numero de Alumno------");
Console.Write("Ingresar numero de Alumno a buscar: ");
while (int.TryParse(Console.ReadLine(), out numeroAlumno) && numeroAlumno != 0)
{
    int pos = BinarySearch(matriz, numeroAlumno);
    if (pos != -1)
    {
        Console.WriteLine($"Aca los datos de la Fila {pos}");
        for (int j = 0; j < columna; j++)
        {
            Console.Write(matriz[pos, j] + " ");
            
        }
        Console.WriteLine();
        Console.Write("Ingresar numero de Alumno a buscar: ");
    }
    else
    {
        Console.WriteLine("El dato no se encontro");
        Console.Write("Ingresar numero de Alumno a buscar: ");
    }
}

