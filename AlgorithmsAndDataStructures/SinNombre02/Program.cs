/* 
Ejercicio I06 - Años bisiestos - UTN Avellaneda
----------------------------------------------------------------------
English:
Write a program that determines if a year is a leap year.
A year is a leap year if it is a multiple of 4.
Years that are multiples of 100 are not leap years, unless they are also multiples of 400. For example, the year 2000 is a leap year, but 1900 is not.
Ask the user for a start year and an end year, and display all the leap years in that range."

Spanish: 
Escribir un programa que determine si un año es bisiesto.
Un año es bisiesto si es múltiplo de 4. 
Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
----------------------------------------------------------------------
*/

//----Programa Principal-----
Console.Title = "Ejercicio I06 - Años bisiestos - UTN Avellaneda";

int inicioRango;
int finRango;

Console.WriteLine("Ingresar el año de Comienzo");
if (int.TryParse(Console.ReadLine(), out inicioRango))
{
    Console.WriteLine("Ingresar el año de final: ");
    if(int.TryParse(Console.ReadLine(), out finRango))
    for (int i = inicioRango; i <= finRango; i++)
    {
        if ((i % 4 == 0 && i % 100 != 0) || (i % 400 == 0))
        {
            Console.WriteLine($"{i}, SI es biciesto");
        }
        else
        {
            Console.WriteLine($"{i}, NO es biciesto");
        }
    }
}
else
{
    Console.WriteLine("La entrada de datos no es correcta");
}