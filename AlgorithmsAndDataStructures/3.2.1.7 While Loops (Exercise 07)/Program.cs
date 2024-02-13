/* 
Practica 1 - While loops - Exercise 3.2.1.7
----------------------------------------------------------------------
English:
At the end of each day, 
The salespeople in a store report their sales to the owner to calculate the commission they will receive. 
There are 8 salespeople, coded 'A' to 'H', and it is not known how many sales each one made.
The data is sorted and grouped by salesperson. 
For each salesman each of the amounts of his sales are entered. 
To indicate the end of each one of them, a sales value equal to 0 is entered. 
It is requested to show for each of the salesmen:
his code and the commission he will charge, which is 2.5% of the sum of his sales.

Spanish: 
Al finalizar cada día, 
Los vendedores de un comercio rinden al dueño sus ventas para calcular la comisión que cobrarán. 
Los vendedores son 8, codificados de la ‘A’ a la ‘H’, y no se sabe cuántas ventas realizó cada uno.
Los datos vienen ordenados y agrupados por vendedor. 
Por cada vendedor se ingresan cada uno de los importes de sus ventas. 
Para indicar el fin de cada uno de ellos se ingresa un valor de venta igual a 0. 
Se solicita mostrar para cada uno de los vendedores:
su código y la comisión que cobrará, que es el 2,5 % de la suma de sus ventas.
----------------------------------------------------------------------
*/

//--------Programa Principal----------

using System.Runtime.InteropServices;

Console.Title = "Practica 1 - While loops - Exercise 3.2.1.7";
Console.ForegroundColor = ConsoleColor.Yellow;

char cantidadDeVendedores = 'H';
int importe = default;
Random rn = new();

for (char i = 'A'; i < cantidadDeVendedores; i++)
{
    importe = rn.Next(0, 51);
    Console.WriteLine($"Importe del vendedor {i}: {importe}");
    while (importe != 0)
    {
        importe = rn.Next(0, 51);
        Console.WriteLine($"Importe del vendedor {i}: {importe}");
    }


    Console.WriteLine($"El importe del vendedor {i}, es de {importe}");
}
