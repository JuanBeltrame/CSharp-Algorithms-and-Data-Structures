/*
Practica 3 - Multidimensional Array - Ejercicio 08
----------------------------------------------------------------------
English:
We have the information of the last tennis tournament of a club, in which 40 players participated. 
For each of them we have the following set of integer numerical data:

- Player number.
- Number of matches won
- Number of matches lost

As these data are entered, the total score of each player must be calculated, 
knowing that for each match won 3 points are assigned and for each match lost, zero points are assigned.
We wish to obtain a list, sorted in descending order according to total score, as follows:

Player's number - Matches won - Matches lost - Total score


Spanish: 
Se cuenta con la información del último torneo de tenis de un club, en el que participaron 40 jugadores. 
Por cada uno de ellos se tiene el siguiente juego de datos numéricos enteros:

- Nro de jugador
- Cantidad de partidos ganados
- Cantidad de partidos perdidos

A medida que se ingresan dichos datos, se debe ir calculando el puntaje total de cada jugador
sabiendo que, por cada partido ganado, se le asigna 3 puntos y por cada partido perdido cero puntos.
Se desea obtener un listado, ordenado en forma decreciente según puntaje total, de la siguiente forma:

Nro. de jugador - Partidos ganados - Partidos perdidos - Puntaje total
----------------------------------------------------------------------
*/
using System.Runtime.Serialization.Formatters;

int fila = 4;
int columna = 4;

int[,] matriz = new int[fila, columna];



void inicializarMatriz(int[,] matrix)
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
    int datoACargar = 0;

    for (int i = 0; i < fila; i++)
    {
        for (int j = 0; j < columna - 1; j++)
        {

            do
            {
                Console.Write($"Fila {i + 1}, Columna {j + 1}: ");
                datoACargar = int.Parse(Console.ReadLine()!);
            } while (datoACargar <= 0 || datoACargar >= 100);
            matrix[i, j] = datoACargar;
        }
        matrix[i, 3] = matrix[i, 1] * 3;
    }
}

void MostrarMatriz(int[,] matrix)
{
    
}

static void ProcesosDeConsola(string mensaje)
{
    Console.WriteLine();
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(mensaje);
    Console.ForegroundColor = ConsoleColor.Gray;
}






//---------Programa Principal
inicializarMatriz(matriz);
ProcesosDeConsola("Cargar Matriz: ");
CargarMatriz(matriz);
