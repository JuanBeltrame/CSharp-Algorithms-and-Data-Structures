/* 
Practica 1 - While loops - Exercise 3.2.1.1
----------------------------------------------------------------------
English:
Given a set of integers, 
determine how many of them are greater than or equal to 100. 
A number equal to zero indicates end of data.

Spanish: 
Dado un conjunto de números enteros, 
determinar cuántos de ellos son mayores o iguales que 100. 
Un número igual a cero indica fin de datos.
----------------------------------------------------------------------
*/

//--------Programa Principal----------

Console.Title = "Practica 1 - While loops - Exercise 3.2.1.1";
Console.ForegroundColor = ConsoleColor.Yellow;

int numero = default;
int contador = 0;

Console.WriteLine("Ingresar un numero: ");
numero = int.Parse(Console.ReadLine()!);
while ( numero != 0)
{
    if (numero >= 100)
    {
        contador += 1;
    }

    Console.WriteLine("Ingresar nuevamente un numero: ");
    numero = int.Parse(Console.ReadLine()!);
}

Console.WriteLine();
Console.WriteLine($"Se ingresaron {contador} de numeros mayores o iguales a 100");