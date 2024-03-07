/*
Practica 1 - While Loops - Pre-Conditional - Exercise 01/08
----------------------------------------------------------------------
English: 
We want to know the total sales for each of the sellers in a company. 
To this end, we have the following data: the seller's code and the amount of each sale.

A seller may have made more than one sale. 
We don't know the number of sellers the company has or the number of sales made by each seller 
(a seller code equal to zero marks the end of data). 
THIS DATA IS SORTED BY SELLER CODE. 
Display each seller's code and their corresponding total, 
and finally, the seller code with the highest total sales and that total amount."

Spanish: 
Se desea saber el total de ventas de cada uno de los vendedores de una empresa. 
A tal fin se tienen como datos: el código de vendedor y el importe de cada una de las ventas;

Un vendedor puede haber realizado más de una venta. 
No se sabe la cantidad de vendedores que tiene la empresa ni la cantidad de ventas hechas por cada vendedor 
(un código de vendedor igual a cero es fin de datos). 
ESTOS DATOS ESTAN ORDENADOS POR CODIGO DE VENDEDOR. 
Exhibir cada código de vendedor y su total correspondiente 
y al final, el código de vendedor con mayor importe vendido y dicho importe.
----------------------------------------------------------------------
*/

//--------Programa Principal----------

using System.Runtime.InteropServices;

Console.Title = "Practica 1 - While loops - Exercise 3.2.1.8";
Console.ForegroundColor = ConsoleColor.Yellow;


int codVendedor = default;
int mayorImporteGlobal = 0;
int vendedorMax = default;

Console.Write($"Ingresar codigo de Vendedor (0 para finalizar): ");
int codigoVendedor = int.Parse(Console.ReadLine()!);

while (codigoVendedor != 0)
{
    int acumuladorTotalxVendedor = 0;
    int vendedorAnterior = codigoVendedor;
    while (codigoVendedor == vendedorAnterior)
    {
        Console.Write($"Ingresar Importe de la venta realizada por el vendedor {codigoVendedor}: ");
        int importe = int.Parse(Console.ReadLine()!);
        acumuladorTotalxVendedor = acumuladorTotalxVendedor + importe;
        if (acumuladorTotalxVendedor > mayorImporteGlobal)
        {
            vendedorMax = codigoVendedor;
            mayorImporteGlobal = acumuladorTotalxVendedor;
        }

        Console.Write($"Ingresar codigo de Vendedor (0 para finalizar): ");
        codigoVendedor = int.Parse(Console.ReadLine()!);
    }
    Console.WriteLine($"El importe total del vendedor: {vendedorAnterior}, es de: {acumuladorTotalxVendedor}");
}
Console.WriteLine($"El vendedor con el mayor importe vendido es: {vendedorMax}, con un monto de: {mayorImporteGlobal}");





