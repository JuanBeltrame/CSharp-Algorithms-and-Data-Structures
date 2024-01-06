/* 
Ejercicio I08 - Dibujando un triángulo rectángulo - UTN Avellaneda
----------------------------------------------------------------------
English:
Write a program that prints by console a triangle like the following:

*
***
*****
*******
*********

The user will indicate the height of the triangle by entering a positive integer. 
For the example above, the height entered was 5.

Spanish: 
Escribir un programa que imprima por consola un triángulo como el siguiente:

*
***
*****
*******
*********

El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo. 
Para el ejemplo anterior, la altura ingresada fue de 5.
----------------------------------------------------------------------
*/

//----Programa Principal------

Console.Title = "Ejercicio I08 - Dibujando un triángulo rectángulo - UTN Avellaneda";
Console.ForegroundColor = ConsoleColor.Yellow;

int row, col, height, lenght = 0;

Console.Write("Enter number: ");

height = int.Parse(Console.ReadLine()!);

for (row = 0; row < height; row++)
{
    for (col = 0; col <= lenght; col++)
    {
        Console.Write('*');
    }
    lenght += 2;
    Console.WriteLine();
}
Console.ReadKey();

