/* 
Practica 1 - For loops - Exercise 3.1.16
----------------------------------------------------------------------
English:
Given a list of 93 numbers, 
determine and report the maximum value 
and the order in which it was entered.

Spanish: 
Dada una lista de 93 números, 
determinar e informar el valor máximo 
y el orden en el que fue ingresado.
----------------------------------------------------------------------
*/

//--------Programa Principal----------

using System.Globalization;

Console.Title = "Practica 1 - For loops - Exercise 3.1.16";
Console.ForegroundColor = ConsoleColor.Yellow;

int listaDeNumeros = 5;

int numero = default;
int valorMaximo = 0;
int posicionIndice = default;

for (int i = 0; i < listaDeNumeros; i++)
{
    Console.Write($"{i+1}. Ingresar un numero: ");
    numero = int.Parse(Console.ReadLine()!);

    if (numero >= valorMaximo)
    {
        valorMaximo = numero;
        posicionIndice = i +1;
    }
}

Console.WriteLine($"El numero de mayor valor ingresado fue el: {valorMaximo}, en la posicion: {posicionIndice}");
