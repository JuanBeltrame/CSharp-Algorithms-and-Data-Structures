/* 
Practica 1 - While loops - Exercise 3.2.1.6
----------------------------------------------------------------------
English:
A company has 50 salesmen working for it. 
At the end of the month each of the salesmen reports their number and the amounts of each of the sales made. 
The number of sales made by each of them is not known. 
so a sales value equal to zero indicates that there are no more sales from that salesperson.
You are asked to exhibit, 
for each of the salesmen, the salesman's number and the amount of the highest sale made by that salesman.

Spanish: 
Una empresa tiene 50 viajantes que trabajan en ella. 
A fin de mes cada uno de los viajantes informa su número y los importes de cada una de las ventas realizadas. 
No se sabe la cantidad de ventas que realizó cada uno de ellos 
por lo que un valor de venta igual a cero indica que no hay más ventas de ese vendedor.
Se pide exhibir, 
para cada uno de los viajantes, el Nro. del viajante y el importe de la mayor venta realizada por el mismo.
----------------------------------------------------------------------
*/

//--------Programa Principal----------

using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

Console.Title = "Practica 1 - While loops - Exercise 3.2.1.6";
Console.ForegroundColor = ConsoleColor.Yellow;

int cantidadDeViajantes = 10;
int importe;
int contadorVentas = 0;
int acumuladorDeVentas = 0;
int ventaMaxima = 0;
int pos = default;
int contadorGlobal = 0;
Random rn = new();

Console.WriteLine("--------------");
Console.WriteLine($"La Cantidad de Viajantes que posee la empresa es: {cantidadDeViajantes}");
Console.WriteLine("--------------");
Console.WriteLine();

for (int i = 0; i < cantidadDeViajantes; i++)
{
    Console.WriteLine();
    contadorVentas = 0;
    acumuladorDeVentas = 0;
    ventaMaxima = 0;
    Console.WriteLine($"Numero de Viajante: {i + 1}");

    importe = rn.Next(0, 26);
    Console.WriteLine($"Ingresar importe de la venta [0 para salir]: {importe}");
    while (importe != 0)
    {
        contadorVentas += 1;
        importe = rn.Next(0, 26);
        acumuladorDeVentas = acumuladorDeVentas + importe;
        if (importe > ventaMaxima)
        {
            ventaMaxima = importe;
            pos = i;
        }

        Console.WriteLine($"Ingresar importe de la venta [0 para salir]: {importe}");
    }

    Console.WriteLine("-----------");
    Console.WriteLine($"El vendedor {pos}, realizo {contadorVentas} ventas, y recaudo ${acumuladorDeVentas} en total. su venta maxima fue de: {ventaMaxima}");
    Console.WriteLine("-----------");
}
