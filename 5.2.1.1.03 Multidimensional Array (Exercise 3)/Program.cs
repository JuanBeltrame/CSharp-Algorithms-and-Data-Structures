using System.Diagnostics.Metrics;

/*
Practica 3 - Multidimensional Array - Ejercicio 03
----------------------------------------------------------------------
English:
Enter integers into a two-dimensional array A of 10 rows by 5 columns;
then enter integers into another array B of equal dimension. 
Obtain an array C, where C = A + B. 
(each element of C is obtained as the sum of the counterpart elements of A and B).

- Show A, B and C, one array below the other.
- Show A, B and C, one array next to the other.

Spanish:
Ingresar números enteros en un arreglo bidimensional A de 10 filas por 5 columnas;
luego ingresar números enteros en otro arreglo B de igual dimensión. 
Obtener un arreglo C, siendo C = A + B. 
(cada elemento de C se obtiene como la suma de los elementos homólogos de A y B).

• Mostrar A, B y C, un arreglo debajo del otro
• Mostrar A, B y C, un arreglo al lado del otro
----------------------------------------------------------------------
*/

int tamanioFila = 3;
int tamanioColumna = 3;

int[,] matrixA = new int[tamanioFila, tamanioColumna];
int[,] matrixB = new int[tamanioFila, tamanioColumna];
int[,] matrixC = new int[tamanioFila, tamanioColumna];

void InicializarMatrix(int[,] m)
{
    for (int i = 0; i < tamanioFila; i++)
    {
        for (int j = 0; j < tamanioColumna; j++)
        {
            m[i, j] = 0;
        }
    }
}

void MostrarMatrix(int[,] m)
{
    for (int i = 0; i < tamanioFila; i++)
    {
        for (int j = 0; j < tamanioColumna; j++)
        {
            Console.Write(m[i, j]);
        }
        Console.WriteLine();
    }
}

void CargarMatrix(int[,] m)
{
    for (int i = 0; i < tamanioFila; i++)
    {
        Console.WriteLine($"Fila {i + 1}: ");
        for (int j = 0; j < tamanioColumna; j++)
        {
            Console.Write($"     Columna {j + 1}: ");
            m[i, j] = int.Parse(Console.ReadLine()!);
        }
    }
}


int[,] AddMatrices(int[,] mA, int[,] mB)
{
    int[,] mC = new int[tamanioFila, tamanioColumna];

    for (int i = 0; i < tamanioFila; i++)
    {
        for (int j = 0; j < tamanioColumna; j++)
        {
            mC[i, j] = mA[i, j] + mB[i, j];
        }
    }
    return mC;
}

//-----Programa Principal-------
InicializarMatrix(matrixA);
InicializarMatrix(matrixB);
InicializarMatrix(matrixC);
Console.WriteLine("Matriz A:");
MostrarMatrix(matrixA);
Console.WriteLine();

Console.WriteLine("Matriz B:");
MostrarMatrix(matrixB);
Console.WriteLine();

Console.WriteLine("Matriz C:");
MostrarMatrix(matrixC);
Console.WriteLine();

Console.WriteLine("Cargar Matriz A:");
CargarMatrix(matrixA);
Console.WriteLine();

Console.WriteLine("Cargar Matriz B:");
CargarMatrix(matrixB);
Console.WriteLine();

Console.WriteLine("Obtener Matriz C sumando MatrixA + MatrixB:");
matrixC = AddMatrices(matrixA, matrixB);
MostrarMatrix(matrixC);
Console.WriteLine();