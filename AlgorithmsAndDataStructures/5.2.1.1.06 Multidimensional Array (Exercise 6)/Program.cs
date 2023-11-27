/*
Practica 3 - Multidimensional Array - Ejercicio 06
----------------------------------------------------------------------
English:



Spanish: 

----------------------------------------------------------------------
*/

int fila = 30;
int columna = 7;
int[,] matrizEnteros = new int[fila, columna];

int tamArray = 6;
decimal[] arrayReales = new decimal[tamArray];

void InicializarMatriz(int[,] m, int f, int c)
{
    for (int i = 0; i < f; i++)
    {
        for (int j = 0; j < c; j++)
        {
            m[i, j] = 0;
        }
    }
}

void InicializarArray(decimal[] arr, int tam)
{
    for (int i = 0; i < tam; i++)
    {
        arr[i] = 0;
    }
}


void CargarMatriz(int[,] m, int f, int c)
{
    for (int i = 0; i < f; i++)
    {
        for (int j = 0; j < c; j++)
        {

        }
    }
}

void CargarArrayPrecios(decimal[] arr, int tam)
{
    for (int i = 0; i < tam; i++)
    {
        Console.WriteLine("Cargar Precio del articulo", i + 1);
        arr[i] = decimal.Parse(Console.ReadLine()!); 
    }
}


InicializarMatriz(matrizEnteros, fila, columna);
InicializarArray(arrayReales, tamArray);
CargarArrayPrecios(arrayReales, tamArray);

