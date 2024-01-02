/* 
Ejercicio I06 - Años bisiestos - UTN Avellaneda
----------------------------------------------------------------------
English:


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
    int.TryParse(Console.ReadLine(), out finRango);
    for (int i = inicioRango; inicioRango <= finRango; inicioRango++)
    {
        if (i % 4 == 0)
        {
            if ()
        }
    }
}
else
{
    Console.WriteLine("La entrada de datos no es correcta");
}