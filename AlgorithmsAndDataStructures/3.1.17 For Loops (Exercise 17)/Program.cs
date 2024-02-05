/* 
Practica 1 - For loops - Exercise 3.1.17
----------------------------------------------------------------------
English:


Spanish: 
Incorporar al ejercicio anterior la búsqueda del valor mínimo 
y el orden en el que fueron ingresados.
----------------------------------------------------------------------
*/

//--------Programa Principal----------

using Microsoft.Win32.SafeHandles;
using System.Globalization;
using System.Runtime.ExceptionServices;

Console.Title = "Practica 1 - For loops - Exercise 3.1.17";
Console.ForegroundColor = ConsoleColor.Yellow;

int maximo = 0;
int minimo = default;
int numero = default;
int listaDeNumeros = 5;
int posicionIndiceMayor = 0;
int posicionIndiceMenor = default;

for (int i = 0; i < listaDeNumeros; i++)
{
    Console.Write($"{i + 1}. Ingresar un numero: ");
    numero = int.Parse(Console.ReadLine()!);

    if (i == 0)
    {
        minimo = numero;
    }

    if (numero >= maximo)
    {
        maximo = numero;
        posicionIndiceMayor = i;
    }

    if (numero <= minimo)
    {
        minimo = numero;
        posicionIndiceMenor = i;
    }
}

Console.WriteLine($"El valor maximo ingresado fue el: {maximo} en la posicion {posicionIndiceMayor}, el minimo fue el: {minimo}, en al posicion: {posicionIndiceMenor}");