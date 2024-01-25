/* 
Practica 1 - If Conditional - Exercise 2.1.11
----------------------------------------------------------------------
English:
Six different positive numbers are entered. 
At the end display a message saying: 
"The largest number entered was xxx."


Spanish: 
Se ingresan seis números positivos diferentes. 
Al final mostrar un cartel que diga: 
“El mayor número ingresado fue el xxx”
----------------------------------------------------------------------
*/

//------------Programa Principal------------------

Console.Title = "Practica 1 - If Conditional - Exercise 2.1.11";
Console.ForegroundColor = ConsoleColor.Yellow;

int max = 0;
int numero = default;

for (int i = 0; i < 6; i++)
{
    Console.WriteLine("Ingresar numero: ");
    if (int.TryParse(Console.ReadLine(), out numero))
    {
        if (numero > max)
        {
            max = numero;
        }
    }
    else
    {
        Console.WriteLine("El valor ingresado no es un numero");
        
    }
}

Console.WriteLine($"El numero mas grande ingresado es: {max}");