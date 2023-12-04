/*
Practica 3 - Multidimensional Array - Ejercicio 07
----------------------------------------------------------------------
English:
Enter 10 sets of 12 characters each in a two-dimensional array. 
Then enter two integers corresponding to the numbers in two rows of the array,
swap their contents and display the modified array.

Spanish: 
Ingresar 10 conjuntos de 12 caracteres cada uno en un arreglo bidimensional. 
Ingresar luego dos números enteros correspondientes a los números de dos filas del arreglo,
intercambiar sus contenidos y exhibir el arreglo modificado.
----------------------------------------------------------------------
*/

int fila = 4;
int columna = 4;

char[,] matriz = new char[fila, columna];

void InicializarMatriz(char[,] matrix)
{
    for (int i = 0; i < fila; i++)
    {
        for (int j = 0; j < columna; j++)
        {
            matrix[i, j] = ' ';
        }
    }
}

void CargarMatriz(char[,] matrix)
{
    char caracterACargar = ' ';

    for (int i = 0; i < fila; i++)
    {
        for (int j = 0; j < columna; j++)
        {
            char.TryParse(Console.ReadLine(), out caracterACargar);
            while (caracterACargar < 'a' || caracterACargar > 'z')
            {
                Console.Write("Error, debe ser un caracter entre las letras A y Z: ");
                char.TryParse(Console.ReadLine(), out caracterACargar);
            }
            matrix[i, j] = caracterACargar;
        }
    }
}

void MostrarMatrix(char[,] matrix)
{
    for (int i = 0; i < fila; i++)
    {
        for (int j = 0; j < columna; j++)
        {
            Console.Write(matrix[i, j] + "  ");
        }
        Console.WriteLine();
    }
}



//------Programa Principal------
InicializarMatriz(matriz);
Console.WriteLine("Cargar Matriz: ");
CargarMatriz(matriz);
MostrarMatrix(matriz);