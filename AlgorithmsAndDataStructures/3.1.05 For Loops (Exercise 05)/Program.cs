/* 
Practica 1 - For loops - Exercise 3.1.5
----------------------------------------------------------------------
English:
For 1,000 residential electricity users there are pairs of values that indicate, for each meter
for each meter, the Kilowatt consumption at the end of the previous month and the Kilowatt consumption at the end of the current month.
Kilowatt consumption at the end of the current month. In addition, there is the price per Kilowatt.
Display, for each user, the price per Kilowatt, the consumption for the month and the amount to be paid.
to be paid.

Spanish: 
Para 1000 usuarios residenciales de energía eléctrica se cuenta con pares de valores
que indican, para cada medidor, el consumo de Kilowatios al final del mes anterior y el
consumo de Kilowatios al final del mes actual. Además, se tiene el precio por Kilowatio.
Exhibir, para cada usuario, el precio del Kilowatio, el consumo del mes y el importe a
abonar.
----------------------------------------------------------------------
*/

//--------Programa Principal----------
Console.Title = "Practica 1 - For loops - Exercise 3.1.5";
Console.ForegroundColor = ConsoleColor.Yellow;

Random rn = new();
for (int i = 0; i < 5; i++)
{
    decimal precioKw = rn.Next(1, 101);
    int finalMesAnterior = rn.Next(1, 1001);
    int finalMesActual = rn.Next(1001, 2001);
    int consumoActual = finalMesActual - finalMesAnterior;
    decimal deuda = consumoActual * precioKw;
    Console.WriteLine($"Para el cliente: {i+1}, el precio del kilowatio es: {precioKw}, ");
    Console.WriteLine($"Con un gasto actual de {consumoActual} Kilowatts durante el transcurso de este mes");
    Console.WriteLine($"El saldo a pagar es de: {deuda}");
}
