/* 
Practica 1 - While loops - Exercise 3.2.1.4
----------------------------------------------------------------------
English:
OK

Spanish: 
Se cuenta con la información brindada por un conjunto de vendedores. Por cada uno de
ellos se ingresa su código (un carácter distinto de *) y el importe total de sus ventas.
Determinar el código del vendedor con mayor importe vendido y dicho importe.
----------------------------------------------------------------------
*/

//--------Programa Principal----------

using System.Security.Cryptography;

Console.Title = "Practica 1 - While loops - Exercise 3.2.1.4";
Console.ForegroundColor = ConsoleColor.Yellow;

char codVendedor = default;
int importeTotal;
int maximo = 0;
char pos = default;
Random rn = new();

Console.Write("Ingresar un codigo de Venderdor: ");
codVendedor = char.Parse(Console.ReadLine()!);
Console.Write($"Codigo de Vendedor Ingresado es: {codVendedor}");
Console.WriteLine();

while (codVendedor != '*')
{
    Console.WriteLine();
    importeTotal = rn.Next(1, 1001);
    Console.WriteLine($"El importe total del vendedor: {codVendedor}, es de ${importeTotal}");

    if (importeTotal > maximo)
    {
        maximo = importeTotal;
        pos = codVendedor;
    }
    Console.Write("Ingresar un codigo de Venderdor [* Para Salir ]: ");
    codVendedor = char.Parse(Console.ReadLine()!);

}
Console.WriteLine($"El vendedor com mayor importe en ventas fue el vendedor: {pos}, con un importe de {maximo}");