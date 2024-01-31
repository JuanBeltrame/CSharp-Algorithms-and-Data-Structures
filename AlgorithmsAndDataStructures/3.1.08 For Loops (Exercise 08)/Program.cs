/* 
Practica 1 - For loops - Exercise 3.1.8
----------------------------------------------------------------------
English:
Enter two natural numbers.
Check if the first one is smaller than the second one.
If so, display all the numbers between them in ascending sequence, including the extremes.
sequence, including the extremes.

Spanish: 
Ingresar dos números naturales.
Verificar si el primero es menor que el segundo.
En caso afirmativo mostrar todos los números comprendidos entre ellos en secuencia
ascendente, incluyendo los extremos.
----------------------------------------------------------------------
*/

//--------Programa Principal----------

using System.Diagnostics.Tracing;

Console.Title = "Practica 1 - For loops - Exercise 3.1.8";
Console.ForegroundColor = ConsoleColor.Yellow;

int numero01 = default;
int numero02 = default;

Random rn = new();

Console.Write("Ingresar el primer numero: ");
numero01 = int.Parse(Console.ReadLine()!);
Console.Write("Ingresar el segundo numero: ");
numero02 = int.Parse(Console.ReadLine()!);

if(numero01 < numero02)
{
    for (int i = numero01; i <= numero02; i++)
    {
        Console.Write(i + " - ");
        
    }
}