/* 
Practica 1 - While loops - Exercise 3.2.1.5
----------------------------------------------------------------------
English:


Spanish: 
Se dispone de una serie de importes 
y para cada uno es necesario saber si se aplica o no un descuento. 
En caso afirmativo, calcular el importe del mismo. 

El criterio es el siguiente: 
Para importes menores o iguales que 85, no se hace descuento 
y para importes mayores, se hace el 5 % de descuento. 
Informar cada importe (nunca cero) con su correspondiente descuento y, al final, el porcentaje que representa la cantidad de
importes que tuvieron descuento, con respecto a la cantidad total de importes.
----------------------------------------------------------------------
*/

//--------Programa Principal----------

using System.Collections.Concurrent;
using System.Security.Cryptography;

Console.Title = "Practica 1 - While loops - Exercise 3.2.1.5";
Console.ForegroundColor = ConsoleColor.Yellow;

Random rn = new();
int importe;
decimal porcentaje1;
decimal descuento;
int contadorDescuento = 0;
int contadorImporte = 0;
decimal porcentaje2;

Console.Write("Ingresar un importe: ");
Console.WriteLine(importe = rn.Next(0,201));
Console.WriteLine();

while (importe != 0)
{
    contadorImporte += 1;

    if (importe <= 85)
    {
        Console.WriteLine($"A este importe de: {importe.ToString("F1")} no se le realiza descuento");
    }
    else
    {
        contadorDescuento += 1;
        Console.WriteLine($"Es importe de: {importe.ToString("F1")}, clasifica para recibir el 5% de descuento");
        porcentaje1 = (decimal)0.05 * importe;
        descuento = importe - porcentaje1;
        Console.WriteLine($"Su el precio final es de: {descuento.ToString("F1")}");
    }

    Console.Write("Ingresar un importe: ");
    Console.WriteLine(importe = rn.Next(0, 201));
    Console.WriteLine();
}
porcentaje2 = (100 * contadorDescuento) / contadorImporte;
Console.WriteLine($"El porcentaje que representa la cantidad de importes que tuvieron descuento, con respecto a la cantidad total de importes es: {porcentaje2.ToString("F1")}%");
