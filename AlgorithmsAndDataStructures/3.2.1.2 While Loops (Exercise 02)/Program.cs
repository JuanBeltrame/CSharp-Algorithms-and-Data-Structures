/* 
Practica 1 - While loops - Exercise 3.2.1.2
----------------------------------------------------------------------
English:
We have as data the amounts of all the invoices corresponding to the month that has just ended from a store (we do not know how many there are).
month of a store (it is not known how many there are). You want to know
- how many sales were made
- their average amount
- how many amounts exceed 300 pesos.

Spanish: 
Se tienen como dato los importes de todas las facturas correspondientes al mes que
acaba de finalizar de un comercio (no se sabe cuántas son). Se desea conocer:
• cuántas ventas se realizaron
• importe promedio de las mismas
• cuántos son los importes que superan los 300 pesos
----------------------------------------------------------------------
*/

//--------Programa Principal----------

using System.Security.Cryptography;

Console.Title = "Practica 1 - While loops - Exercise 3.2.1.2";
Console.ForegroundColor = ConsoleColor.Yellow;

int factura = default;
int contadorFacturas = 0;
int contadorImporte = 0;
int importe = default;
double acumulador = 0;
double promedio = default;
Random random = new();

Console.WriteLine("Ingresar N de Factura: ");
factura = random.Next(0, 20);
Console.WriteLine($"Numero de Factura ingresado: {factura}");
while (factura != 0)
{
    contadorFacturas += 1;
    importe = random.Next(0,400);
    acumulador = acumulador + importe;
    Console.WriteLine($"Esta factura posee un importe de: {importe.ToString("F2")}");
    if(importe > 300)
    {
        contadorImporte = contadorImporte + 1;
    }
    Console.WriteLine("Ingresar otro N de Factura - (0 Para Salir)");
    factura = factura = random.Next(0, 20);
    Console.WriteLine();
    Console.WriteLine($"Numero de Factura ingresado: {factura}");
}

promedio = acumulador / contadorFacturas;

Console.WriteLine($"Cantidad de ventas realizadas: {contadorFacturas.ToString("F2")}");
Console.WriteLine($"El promedio en ventas es de: {promedio.ToString("F2")}");
Console.WriteLine($"Importes que superar los 300: {contadorImporte.ToString("F2")}");

