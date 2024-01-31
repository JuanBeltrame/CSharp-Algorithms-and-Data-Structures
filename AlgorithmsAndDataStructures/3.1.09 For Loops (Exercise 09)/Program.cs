/* 
Practica 1 - For loops - Exercise 3.1.9
----------------------------------------------------------------------
English:
The amounts of 200 sales of a bookstore are given as data. We wish to know:
- How many sales had amounts less than $ 10000.
- What is the total amount of the sales whose amount was equal to or greater than $ 10000.

Spanish: 
Se dan como datos los importes de las 200 ventas de una librería. Se desea saber:
• Cuántas ventas tuvieron importes menores que $ 10000.
• Cuál es el monto total de las ventas cuyo importe fue igual o mayor que $ 10000.-
----------------------------------------------------------------------
*/

//--------Programa Principal----------

using System.Diagnostics.Tracing;

Console.Title = "Practica 1 - For loops - Exercise 3.1.9";
Console.ForegroundColor = ConsoleColor.Yellow;

int importe = default;
int contadorDeVentas = default;
decimal sumadorDeVentas = 0;
int cantidadDeVentas = 200;

Random rn = new();

for (int i = 0; i < cantidadDeVentas; i++)
{
    importe = rn.Next(100, 20001);
    if (importe < 10000)
    {
        contadorDeVentas += 1;
    }
    else
    {
        sumadorDeVentas += importe;
    }

}
Console.WriteLine("-----------------------");
Console.WriteLine($"Se realizaron {contadorDeVentas} ventas con un valor menor a $10000");
Console.WriteLine($"Las ventas que superaron los $1000 suman un monto total de: ${sumadorDeVentas}");
Console.WriteLine("-----------------------");