/* 
Practica 1 - If Conditional - Exercise 2.1.13
----------------------------------------------------------------------
English:
Any two integer values are given. 
If the first is greater than the second, subtract 20% from the first, 
but if the second is greater, subtract 15% from the second. 
With these new values, if the first is greater than 100 and the second greater than 150, they are considered correct values.
considered correct values, 
otherwise it is a risk interval.

Spanish: 
Se dan dos valores cualesquiera enteros. 
Si el primero es mayor que el segundo, restarle al primero un 20%, 
pero si el segundo es el mayor restarle al segundo un 15%. 
Con estos nuevos valores, si el primero quedo mayor a 100 y el segundo mayor a 150, se lo
consideran valores correctos, 
de lo contrario es un intervalo de riesgo.
----------------------------------------------------------------------
*/

//---Programa Principal----
Console.Title = "Practica 1 - If Conditional - Exercise 2.1.13";
Console.ForegroundColor = ConsoleColor.Yellow;

int valor01 = default;
int valor02 = default;

Console.Write("Ingresar el primer numero: ");
int.TryParse(Console.ReadLine(), out valor01);
Console.Write("Ingresar el primer numero: ");
int.TryParse(Console.ReadLine(), out valor02);


if (valor01 > valor02)
{
    decimal valorAdescontar = 0.2M * valor01;
    valor01 = valor01 - (int)valorAdescontar;
}
else
{
    decimal valorADescontar = 0.15M * valor02;
    valor02 = valor02 - (int)valorADescontar;
}

if (valor01 > 100 && valor02 > 150)
{
    Console.WriteLine("Los valores ingresados estan en el rango correcto");
}
else
{
    Console.WriteLine("Los valores ingresados pertenecen al rando de riesgo");
}
