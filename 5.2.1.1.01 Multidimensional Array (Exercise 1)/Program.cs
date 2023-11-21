/*
Practica 3 - Multidimensional Array - Exercise 01
----------------------------------------------------------------------
English:
Enter real elements into a two-dimensional array of 30 rows by 12 columns. 
Then enter an integer data corresponding to a row number (validate its consistency). 
The objective is to calculate and display the sum of all elements in that row.

Spanish:
Ingresar elementos reales en un arreglo bidimensional de 30 filas por 12 columnas. 
Luego ingresar un dato entero que corresponde al número de una fila (validar que sea consistente).
Se desea obtener y exhibir la suma de todos los elementos de dicha fila.
----------------------------------------------------------------------
*/
using System.ComponentModel.DataAnnotations.Schema;

int fila = 5;
int columna = 5;
decimal acumulador = 0;

decimal[,] matrix = new decimal[fila, columna];

void InicializarMatrix(decimal[,] matriz)
{
    for (int i = 0; i < fila; i++)
    {
        for (int j = 0; j < columna; j++)
        {
            matriz[i, j] = 0;
        }
    }
}

void CargarMatrix(decimal[,] matriz)
{
    for (int i = 0; i < fila; i++)
    {
        Console.WriteLine($"Fila: {i+1} ");
        for (int j = 0; j < columna; j++)
        {
            Console.Write($"Columna: {j+1} ");
            matriz[i, j] = int.Parse(Console.ReadLine()!);
        }
    }
}

decimal SumarFila(decimal[,] matriz, int filaASumar, ref decimal acum)
{
    for (int j = 0; j < columna; j++)
    {
        acum = acum + matriz[filaASumar, j];
    }

    return acum;
}

void MostrarFilaSumada(decimal valor)
{
    Console.Write(valor);
}

void MostrarMatrix(decimal[,] matriz)
{
    for (int i = 0; i < fila; i++)
    {
        for (int j = 0; j < columna; j++)
        {
            Console.Write(matriz[i, j]);
        }
        Console.WriteLine();
    }
}

//-------------------------Programa Principal----------------------------------------------
InicializarMatrix(matrix);
Console.WriteLine("Matrix Inicializada: ");
MostrarMatrix(matrix);

Console.WriteLine("Cargar Matriz");
CargarMatrix(matrix);

Console.WriteLine("Matrix con los valores cargados");
MostrarMatrix(matrix);

Console.Write($"Seleccionar fila de la cual obtener su suma [Entre 0 y {fila}]: ");
int datoABuscar = int.Parse(Console.ReadLine()!);
while (datoABuscar >= fila)
{
    Console.Write($"Seleccionar fila de la cual obtener su suma [Entre 0 y {fila}]: ");
    datoABuscar = int.Parse(Console.ReadLine()!);
}

Console.WriteLine("El resultado de la fila seleccionada es: ");
decimal suma = SumarFila(matrix, datoABuscar, ref acumulador);
MostrarFilaSumada(suma);


