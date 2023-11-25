/*
Practica 3 - Multidimensional Array - Ejercicio 02
----------------------------------------------------------------------
English:
Enter 20 sets of 20 integer elements each into a two-dimensional array. 
Calculate and display the sum of their main diagonal and the sum of their secondary diagonal.

Spanish:
Ingresar 20 conjuntos de 20 elementos enteros cada uno en un arreglo bidimensional.
Calcular y exhibir la suma de su diagonal principal y la de su diagonal secundaria.
----------------------------------------------------------------------
*/



int fila = 2;
int columna = 3;

int diagonalPrincipal = 0;
int diagonalSecundaria = 0;

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

void MostrarMatrix(int[,] m)
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

void CargarMatrix(int[,] m)
{
    for (int i = 0; i < fila; i++)
    {
        Console.WriteLine($"Fila: {i + 1} ");
        for (int j = 0; j < columna; j++)
        {
            Console.Write($"Columna: {j + 1} ");
            m[i, j] = int.Parse(Console.ReadLine()!);
        }
    }
}

int SumarDiagonalPrincipal(ref int dp, int[,] m)
{
    for (int i = 0; i < fila; i++)
    {
        dp = m[i, i] + dp;
    }

    return dp;
}

int SumarDiagonalSecundaria(ref int ds, int[,] m)
{

    for (int j = fila - 1; j >= 0; j--)
    {
        ds = m[j, j] + ds;
    }
    return ds;
}


//------ Programa Principal ----
InicializarMatrix(matrix);
Console.WriteLine("Aca la matrix inicializada");
MostrarMatrix(matrix);
Console.WriteLine();
Console.Write("Cargar la matriz: ");
CargarMatrix(matrix);

Console.Write("Suma de la diagonal Principal: ");
int sumaPrimaria = SumarDiagonalPrincipal(ref diagonalPrincipal, matrix);
Console.Write(sumaPrimaria);
int sumaSecundaria = SumarDiagonalSecundaria(ref diagonalSecundaria, matrix);
Console.WriteLine();
Console.Write("Suma de la diagonal Secundaria: ");
Console.Write(sumaSecundaria);
Console.WriteLine();