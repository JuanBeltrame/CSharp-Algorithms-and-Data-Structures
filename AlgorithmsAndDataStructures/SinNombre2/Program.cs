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
int altura = default;
char symbol = default;

Console.Write("Enter Triange Rectangle height: ");
if (int.TryParse(Console.ReadLine(), out altura))
{
    for (int i = 0; i < altura; i++)
    {
        if (i == 0)
        {
            symbol = 'x';
            Console.WriteLine(symbol);
        }
        else if (i + 1 < altura)



    }
}

